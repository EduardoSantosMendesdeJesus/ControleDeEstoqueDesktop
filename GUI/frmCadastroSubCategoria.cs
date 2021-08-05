using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BLL;
using DAL;
using Modelo;
using System.Runtime.InteropServices;

namespace Formulario
{
    public partial class frmCadastroSubCategoria : Formulario.frmModeloDeFormularioDeCadastro
    {
        public frmCadastroSubCategoria()
        {
            InitializeComponent();
        }

        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public void LimpaTela()
        {
            txtNome.Clear();
            txtScatCod.Clear();
        }

        private void frmCadastroSubCategoria_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCategoria bll = new BLLCategoria(cx);
            cbCatCod.DataSource = bll.Localizar("");
            cbCatCod.DisplayMember = "cat_nome";
            cbCatCod.ValueMember = "cat_cod";
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(2);
            this.operacao = "inserir";
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            this.LimpaTela();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                // Faz a leiturara dos dados
                ModeloSubCategoria modelo = new ModeloSubCategoria();
                modelo.ScatNome = txtNome.Text;
                modelo.CatCod = Convert.ToInt32(cbCatCod.SelectedValue);

                //Gera a conexão com o banco e grava os dados no banco 
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLSubCategoria bll = new BLLSubCategoria(cx);

                if (this.operacao == "inserir")
                {
                    //Cadastra uma categoria
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro Efetuado: Código " + modelo.ScatCod.ToString());
                }
                else
                {
                    //Altera uma categoria
                    modelo.ScatCod = Convert.ToInt32(txtScatCod.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro Alterado");
                }
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLSubCategoria bll = new BLLSubCategoria(cx);
                    bll.Excluir(Convert.ToInt32(txtScatCod.Text));
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

        private void btAlterar_Click(object sender, EventArgs e)
        {
            alteraBotoes(2);
            this.operacao = "alterar";
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
              
            frmConsultaSubCategoria f = new frmConsultaSubCategoria(); // criação do formulário de consulta da categoria
            f.ShowDialog(); // Mostra o formulário na tela

            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao); // Cria a conexão
                BLLSubCategoria bll = new BLLSubCategoria(cx);
                ModeloSubCategoria modelo = bll.CarregaModeloSubCategoria(f.codigo); // Carrega o modelo, e informa o código que o usuario selecionou
                txtScatCod.Text = modelo.ScatCod.ToString();
                txtNome.Text = modelo.ScatNome;
                cbCatCod.SelectedValue = modelo.CatCod;
                alteraBotoes(3);
                
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose();
            
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            frmCadastroCategoria f = new frmCadastroCategoria();
            f.ShowDialog();
            f.Dispose();
            this.alteraBotoes(1);
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCategoria bll = new BLLCategoria(cx);
            cbCatCod.DataSource = bll.Localizar("");
            cbCatCod.DisplayMember = "cat_nome";
            cbCatCod.ValueMember = "cat_cod";
        }

        private void lbCadstroSubCat_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
