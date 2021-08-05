using BLL;
using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Formulario
{
    public partial class frmCadastroUnidadeDeMedida : Formulario.frmModeloDeFormularioDeCadastro
    {
        public frmCadastroUnidadeDeMedida()
        {
            InitializeComponent();
        }

        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alteraBotoes(2);
        }
        public void LimpaTela()
        {
            txtCod.Clear();
            txtUnidadeMedida.Clear();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLUnidadeDeMedida bll = new BLLUnidadeDeMedida(cx);
                    bll.Excluir(Convert.ToInt32(txtCod.Text));
                    this.LimpaTela();
                    this.alteraBotoes(1);
                }
            }
            catch
            {
                MessageBox.Show("Não é possivel excluir o registro. \n O registro esta sendo utilizado.");
                this.alteraBotoes(3);
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {                
                ModeloUnidadeDeMedida modelo = new ModeloUnidadeDeMedida();
                modelo.UmedNome = txtUnidadeMedida.Text;
                                
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUnidadeDeMedida bll = new BLLUnidadeDeMedida(cx);

                if (this.operacao == "inserir")
                {                   
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro Efetuado: Código " + modelo.UmedCod.ToString());
                }
                else
                {                    
                    modelo.UmedCod = Convert.ToInt32(txtCod.Text);
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

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.alteraBotoes(1);
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            
            frmConsultaUnidadeDMedida f = new frmConsultaUnidadeDMedida();
            f.ShowDialog();

            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUnidadeDeMedida bll = new BLLUnidadeDeMedida(cx);
                ModeloUnidadeDeMedida modelo = bll.CarregaModeloUnidadeDeMedida(f.codigo);
                txtCod.Text = modelo.UmedCod.ToString();
                txtUnidadeMedida.Text = modelo.UmedNome;
                alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose();            
        }

        private void txtUnidadeMedida_Leave(object sender, EventArgs e)
        {
            if(this.operacao == "inserir")
            {
                int r = 0;
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUnidadeDeMedida bll = new BLLUnidadeDeMedida(cx);
                r = bll.VerificaUnidadeDeMedida(txtUnidadeMedida.Text);

                if (r > 0)
                {
                    DialogResult d = MessageBox.Show("Existe um registro com esse valor. Deseja altera-lo?", "Aviso", MessageBoxButtons.YesNo);
                    if (d.ToString() == "Yes")
                    {
                        this.operacao = "alterar";                        
                        ModeloUnidadeDeMedida modelo = bll.CarregaModeloUnidadeDeMedida(r);
                        txtCod.Text = modelo.UmedCod.ToString();
                        txtUnidadeMedida.Text = modelo.UmedNome;
                        //alteraBotoes(3);
                    }
                }
            }
        }

        private void lbUnidadeMedida_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
