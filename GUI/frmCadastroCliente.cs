using BLL;
using DAL;
using Ferramentas;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace Formulario
{
    public partial class frmCadastroCliente : Formulario.frmModeloDeFormularioDeCadastro
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
                    if(txtTexto.Text.Length == 3)
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
        
        public frmCadastroCliente()
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
            txtCPFCNPJ.Clear();
            txtRGIE.Clear();
            txtRua.Clear();
            txtNumero.Clear();
            txtCep.Clear();
            txtEstado.Clear();
            txtCidade.Clear();
            txtBairro.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            txtCelular.Clear();
            rbFisica.Checked = true;

            this.foto = "";
            pbFoto.Image = null;
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {                
             frmConsultaCliente f = new frmConsultaCliente();
            f.ShowDialog();

            if (f.codigo != 0) 
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao); 
                BLLCliente bll = new BLLCliente(cx);
                ModeloCliente modelo = bll.CarregaModeloCliente(f.codigo);

                txtCodigo.Text = modelo.CliCod.ToString();
                if (modelo.CliTipo == "PF")
                {
                    rbFisica.Checked = true;
                }
                else
                {
                    rbJuridica.Checked = true;
                    //este código também serve basta comentar o de cima e 
                    //retirar o comentario do abaixo
                   
                    //rbFisica.Checked = false;

                }
                txtNome.Text = modelo.CliNome;
                txtRSocial.Text = modelo.CliRSocial;
                txtCPFCNPJ.Text = modelo.CliCpfCnpj;
                txtRGIE.Text = modelo.CliRgIe;
                txtCep.Text = modelo.CliCep;
                txtRua.Text = modelo.CliEndereco;
                txtNumero.Text = modelo.CliNumeroEnd;
                txtBairro.Text = modelo.CliBairro;
                txtCidade.Text = modelo.CliCidade;
                txtEstado.Text = modelo.CliEstado;
                txtTelefone.Text = modelo.CliTelefone;
                txtCelular.Text = modelo.CliCelular;
                txtEmail.Text = modelo.CliEmail;

                //foto
                try
                {
                    MemoryStream ms = new MemoryStream(modelo.CliFoto);
                    pbFoto.Image = Image.FromStream(ms);
                    this.foto = "Foto Original";
                }
                catch { }

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
                    BLLCliente bll = new BLLCliente(cx);
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
                ModeloCliente modelo = new ModeloCliente();
                modelo.CliNome = txtNome.Text;
                modelo.CliRSocial = txtRSocial.Text;
                modelo.CliCpfCnpj = txtCPFCNPJ.Text;
                modelo.CliRgIe = txtRGIE.Text;
                modelo.CliCep = txtCep.Text;
                modelo.CliCidade = txtCidade.Text;
                modelo.CliEstado = txtEstado.Text;
                modelo.CliEndereco = txtRua.Text;
                modelo.CliNumeroEnd = txtNumero.Text;
                modelo.CliBairro = txtBairro.Text;
                modelo.CliEmail = txtEmail.Text;
                modelo.CliTelefone = txtTelefone.Text;
                modelo.CliCelular = txtCelular.Text;

                // cli_tipo = PF-> pessoa fisica
                // cli_tipo = PJ -> pessoa juridica

                if (rbFisica.Checked == true)
                {
                    modelo.CliTipo = "PF"; // pessoa fisica
                    modelo.CliRSocial = "";
                }
                else
                {
                    modelo.CliTipo = "PJ"; // pessoa juridica
                }

                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);

              
                    if (this.operacao == "inserir")
                {
                    modelo.CarregaImagem(this.foto); // foto
                    bll.Incluir(modelo);
                    MessageBox.Show("Cliente Cadastrado: Código " + modelo.CliCod.ToString());
                }
                else
                {
                    modelo.CliCod = Convert.ToInt32(txtCodigo.Text);

                    if (this.foto == "Foto Original") //foto

                    {
                        ModeloCliente mt = bll.CarregaModeloCliente(modelo.CliCod);
                        modelo.CliFoto = mt.CliFoto;
                    }

                    else
                    {
                        modelo.CarregaImagem(this.foto); //foto
                    }


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

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
        }
      
       

        private void rbFisica_CheckedChanged(object sender, EventArgs e)
        {
            if(rbFisica.Checked == true)
            {
                lbRSocial.Visible = false;
                txtRSocial.Visible = false;
                lbCPFCNPJ.Text = "CPF";
                lbRGIE.Text = "RG";
            }
            else
            {
                lbRSocial.Visible = true;
                txtRSocial.Visible = true;
                lbCPFCNPJ.Text = "CNPJ";
                lbRGIE.Text = "INSCRIÇÃO ESTADUAL (IE)";
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

        private void txtCPFCNPJ_Leave(object sender, EventArgs e)
        {
            lbValorIncorreto.Visible = false;
            if (rbFisica.Checked == true)
            {
                //cpf
                if(Validacao.IsCpf(txtCPFCNPJ.Text) == false)
                {
                    lbValorIncorreto.Visible = true;
                }
            }
            else
            {
                //cnpj
                lbValorIncorreto.Visible = false;
                if (Validacao.IsCnpj(txtCPFCNPJ.Text) == false)
                {
                    lbValorIncorreto.Visible = true;
                }
            }
        }

        private void lbCadastroCliente_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)8)
            {
                Campo edit = Campo.CEP;               
                Formatar(edit, txtCep);
            }
        }

        
        private void txtCPFCNPJ_KeyPress(object sender, KeyPressEventArgs e)
         {
             if (e.KeyChar != (char)8)
             {            
                 Campo edit = Campo.CPF;
                 if (rbFisica.Checked == false) edit = Campo.CNPJ;
                 Formatar(edit, txtCPFCNPJ);
             }
         }

        public string foto = "";       

        private void btcFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.ShowDialog();
            if (!string.IsNullOrEmpty(od.FileName))
            {
                this.foto = od.FileName;
                pbFoto.Load(this.foto);
            }
        }

        private void btrFoto_Click(object sender, EventArgs e)
        {
            this.foto = "";
            pbFoto.Image = null;
        }
    }
}
