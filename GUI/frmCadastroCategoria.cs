using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Modelo;
using DAL;
using BLL;
using System.Runtime.InteropServices;

namespace Formulario
{
    public partial class frmCadastroCategoria : Formulario.frmModeloDeFormularioDeCadastro
    {
        public frmCadastroCategoria()
        {
            InitializeComponent();
        }

       [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
       private extern static void ReleaseCapture();

       [DllImport("user32.Dll", EntryPoint = "SendMessage")]
       private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
      

        public void LimpaTela()
        {
            txtCodigo.Clear();
            txtNome.Clear();
        }

        private void frmCadastroCategoria_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.alteraBotoes(1);
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                // Faz a leiturara dos dados
                ModeloCategoria modelo = new ModeloCategoria();
                modelo.CatNome = txtNome.Text;

                //Gera a conexão com o banco e grava os dados no banco
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCategoria bll = new BLLCategoria(cx);

                if (this.operacao == "inserir")
                {
                    //Cadastra uma categoria
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro Efetuado: Código "+modelo.CatCod.ToString());
                }
                else
                {
                    //Altera uma categoria
                    modelo.CatCod = Convert.ToInt32(txtCodigo.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro Alterado");
                }
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alteraBotoes(2);
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLCategoria bll = new BLLCategoria(cx);
                    bll.Excluir(Convert.ToInt32(txtCodigo.Text));
                    this.LimpaTela();
                    this.alteraBotoes(1);
                }
            }
            catch
            {
                MessageBox.Show("Não é possivel excluir o registro. \n O registro esta aberto.");
                this.alteraBotoes(3);
            }
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaCategoria f = new frmConsultaCategoria(); // criação do formulário de consulta da categoria
            f.ShowDialog(); // Mostra o formulário na tela

            if (f.codigo != 0) 
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao); // Cria a conexão
                BLLCategoria bll = new BLLCategoria(cx);
                ModeloCategoria modelo = bll.CarregaModeloCategoria(f.codigo); // Carrega o modelo, e informa o código que o usuario selecionou
                txtCodigo.Text = modelo.CatCod.ToString(); 
                txtNome.Text = modelo.CatNome;
                alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose(); // Encerra a consulta destruindo o formulário
        }

        private void lbCadastroCategoria_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
