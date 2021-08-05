using BLL;
using DAL;
using Ferramentas;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Formulario
{
    public partial class frmCadastroFornecedor : Formulario.frmModeloDeFormularioDeCadastro
    {
        public enum Campo
        {
            CPF = 1,
            CNPJ = 2,
            CEP = 3,
        }
        public void Formatar(Campo Valor, TextBox txtTexto)
        {
            switch (Valor)
            {
                
                case Campo.CPF:
                    txtTexto.MaxLength = 14;
                    if (txtTexto.Text.Length == 3)
                    {
                        txtTexto.Text = txtTexto + ".";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 7)
                    {
                        txtTexto.Text = txtTexto.Text + ".";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 11)
                    {
                        txtTexto.Text = txtTexto.Text + "-";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    break;
                    

                case Campo.CNPJ:
                    txtTexto.MaxLength = 18;
                    if (txtTexto.Text.Length == 2 || txtTexto.Text.Length == 6)
                    {
                        txtTexto.Text = txtTexto.Text + ".";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 10)
                    {
                        txtTexto.Text = txtTexto.Text + "/";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 15)
                    {
                        txtTexto.Text = txtTexto.Text + "-";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    break;

                  case Campo.CEP:
                    txtTexto.MaxLength = 9;
                    if (txtTexto.Text.Length == 5)
                    {
                        txtTexto.Text = txtTexto.Text + "-";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    break;                    
            }
        }

        public frmCadastroFornecedor()
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
            txtRSocial.Clear();
            txtCNPJ.Clear();
            txtIE.Clear();
            txtRua.Clear();
            txtNumero.Clear();
            txtCep.Clear();
            txtEstado.Clear();
            txtCidade.Clear();
            txtBairro.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            txtCelular.Clear();
        }

            private void lbCadastroFornecedor_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            
            frmConsultaFornecedor f = new frmConsultaFornecedor();
            f.ShowDialog();

            if (f.codigo != 0) 
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao); 
                BLLFornecedor bll = new BLLFornecedor(cx);
                ModeloFornecedor modelo = bll.CarregaModeloFornecedor(f.codigo);

                txtCodigo.Text = modelo.ForCod.ToString();
                txtNome.Text = modelo.ForNome;
                txtRSocial.Text = modelo.ForRSocial;
                txtCNPJ.Text = modelo.ForCnpj;
                txtIE.Text = modelo.ForIe;
                txtCep.Text = modelo.ForCep;
                txtRua.Text = modelo.ForEndereco;
                txtNumero.Text = modelo.ForNumeroEnd;
                txtBairro.Text = modelo.ForBairro;
                txtCidade.Text = modelo.ForCidade;
                txtEstado.Text = modelo.ForEstado;
                txtTelefone.Text = modelo.ForTelefone;
                txtCelular.Text = modelo.ForCelular;
                txtEmail.Text = modelo.ForEmail;              

                alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose();                        
             
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
                    BLLFornecedor bll = new BLLFornecedor(cx);
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

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloFornecedor modelo = new ModeloFornecedor();
                modelo.ForNome = txtNome.Text;
                modelo.ForRSocial = txtRSocial.Text;
                modelo.ForCnpj = txtCNPJ.Text;
                modelo.ForIe = txtIE.Text;
                modelo.ForCep = txtCep.Text;
                modelo.ForCidade = txtCidade.Text;
                modelo.ForEstado = txtEstado.Text;
                modelo.ForEndereco = txtRua.Text;
                modelo.ForNumeroEnd = txtNumero.Text;
                modelo.ForBairro = txtBairro.Text;
                modelo.ForEmail = txtEmail.Text;
                modelo.ForTelefone = txtTelefone.Text;
                modelo.ForCelular = txtCelular.Text;
                
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);

                if (this.operacao == "inserir")
                {                    
                    bll.Incluir(modelo);
                    MessageBox.Show("Fornecedor Cadastrado: Código " + modelo.ForCod.ToString());
                }
                else
                {
                    modelo.ForCod = Convert.ToInt32(txtCodigo.Text);
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

        private void txtCNPJ_Leave(object sender, EventArgs e)
        {
            //cnpj
            lbValorIncorreto.Visible = false;
            if (Validacao.IsCnpj(txtCNPJ.Text) == false)
            {
                lbValorIncorreto.Visible = true;
            }
        }

        private void txtCNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)18)
            {
                Campo edit = Campo.CNPJ;               
                Formatar(edit, txtCNPJ);
            }

        }

        private void txtCep_Leave(object sender, EventArgs e)
        {
            if (Validacao.ValidaCep(txtCep.Text) == false)
            {
                MessageBox.Show("CEP Inválido");
                txtBairro.Clear();
                txtEstado.Clear();
                txtCidade.Clear();
                txtRua.Clear();
            }
            else
            {
                if (BuscaEndereco.verificaCEP(txtCep.Text) == true)
                {
                    txtBairro.Text = BuscaEndereco.bairro;
                    txtEstado.Text = BuscaEndereco.estado;
                    txtCidade.Text = BuscaEndereco.cidade;
                    txtRua.Text = BuscaEndereco.endereco;
                }
            }
        }

        private void txtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)9)
            {
                Campo edit = Campo.CEP;
                Formatar(edit, txtCep);
            }
        }
    }
}
