using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Formulario;
using Modelo;
using System.IO;
using System.Runtime.InteropServices;

namespace Formulario
{
    public partial class frmCadastroProduto : Formulario.frmModeloDeFormularioDeCadastro
    {
        public string foto = "";
        public frmCadastroProduto()
        {            
            InitializeComponent();
        }

        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void lbCadastroProduto_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void LimpaTela()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtDescricao.Clear();
            txtQtde.Clear();
            txtValorPago.Clear();
            txtValorVenda.Clear();
            this.foto = "";
            pbFoto.Image = null;
        }


        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);            
        }        

        private void frmCadastroProduto_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);

            // combo box da categoria
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCategoria bll = new BLLCategoria(cx);
            cbCategoria.DataSource = bll.Localizar("");
            cbCategoria.DisplayMember = "cat_nome";
            cbCategoria.ValueMember = "cat_cod";
            //cbCategoria.AutoCompleteMode = AutoCompleteMode.Suggest;
            //cbCategoria.AutoCompleteSource = AutoCompleteSource.ListItems;

            try
            {
                //combo box da subcategoria            
                BLLSubCategoria sbll = new BLLSubCategoria(cx);
                cbSubCategoria.DataSource = sbll.LocalizarPorCategoria((int)cbCategoria.SelectedValue);                
                cbSubCategoria.DisplayMember = "scat_nome";
                cbSubCategoria.ValueMember = "scat_cod";

            }
            catch
            {
               // MessageBox.Show("Cadastre uma categoria");
            }

            //combo box unidade de medida
            BLLUnidadeDeMedida ubll = new BLLUnidadeDeMedida(cx);
            cbUND.DataSource = ubll.Localizar("");
            cbUND.DisplayMember = "umed_nome";
            cbUND.ValueMember = "umed_cod";
        }

        private void txtValorVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar !=',' && e.KeyChar !='.')
            {
                e.Handled = true;
            }
            if(e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtValorVenda.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }
        }
        private void txtValorVenda_Leave(object sender, EventArgs e)
        {
            if (txtValorVenda.Text.Contains(",") == false)
            {
                txtValorVenda.Text += ",00";
            }
            else
            {
                if (txtValorVenda.Text.IndexOf(",") == txtValorVenda.Text.Length - 1)
                {
                    txtValorVenda.Text += "00";
                }
            }
            try
            {
                Double d = Convert.ToDouble(txtValorVenda.Text);
            }
            catch
            {
                txtValorVenda.Text = "0,00";
            }
        }

        private void txtValorPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtValorPago.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }
        }

        private void txtValorPago_Leave(object sender, EventArgs e)
        {
            if (txtValorPago.Text.Contains(",") == false)
            {
                txtValorPago.Text += ",00";
            }
            else
            {
                if (txtValorPago.Text.IndexOf(",") == txtValorPago.Text.Length - 1)
                {
                    txtValorPago.Text += "00";
                }
            }
            try
            {
                Double d = Convert.ToDouble(txtValorPago.Text);
            }
            catch
            {
                txtValorPago.Text = "0,00";                
            }
        }

        private void txtQtde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) // para quantidades inteiras
            {
                e.Handled = true;
            }

            /*-----------------------------------------------------------------------------------------------------
            Caso for utilizar quantidade fracionada (ou seja com . ou ,) comentar o comando "if" que está ha cima 
            e retirar o comentario do comando"if" que está ha baixo.
            ----------------------------------------------------------------------------------------------------*/
            
           /* if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }            
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtQtde.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }  */           
        }

        private void txtQtde_Leave(object sender, EventArgs e)
        {
            //Se for utilizar quantidade fracionada comente a proxima linha "if ..." 
            if (txtQtde.Text.Contains("") == false)

            // e retire o comentario desta linha "if..."abaixo e do comando "try" 
            /*if (txtQtde.Text.Contains(",") == false)*/
            {
                txtQtde.Text += ",00";
             }
             else
             {
                 if (txtQtde.Text.IndexOf(",") == txtQtde.Text.Length - 1)
                 {
                     txtQtde.Text += "00";
                 }
            }/*
             try
             {
                 Double d = Convert.ToDouble(txtQtde.Text);
             }
             catch
             {
                 txtQtde.Text = "0,00";
             }   */
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alteraBotoes(2);
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            // combo box da categoria
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);

            try
            {
                cbCategoria.Text = "";
                //combo box da subcategoria            
                BLLSubCategoria sbll = new BLLSubCategoria(cx);
                cbSubCategoria.DataSource = sbll.LocalizarPorCategoria((int)cbCategoria.SelectedValue);
                cbSubCategoria.DisplayMember = "scat_nome";
                cbSubCategoria.ValueMember = "scat_cod";
            }
            catch
            {
                // MessageBox.Show("Cadastre uma categoria");
            }

            //combo box unidade de medida
            BLLUnidadeDeMedida ubll = new BLLUnidadeDeMedida(cx);
            cbUND.DataSource = ubll.Localizar("");
            cbUND.DisplayMember = "umed_nome";
            cbUND.ValueMember = "umed_cod";
        }

        private void btLoFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.ShowDialog();
            if (!string.IsNullOrEmpty(od.FileName))
            {
                this.foto = od.FileName;
                pbFoto.Load(this.foto);
            }
        }

        private void btRmFoto_Click(object sender, EventArgs e)
        {
            this.foto = "";
            pbFoto.Image = null;
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
                ModeloProduto modelo = new ModeloProduto();
                modelo.ProNome = txtNome.Text;
                modelo.ProDescricao = txtDescricao.Text;
                modelo.ProValorPago = Convert.ToDouble(txtValorPago.Text);
                modelo.ProValorVenda = Convert.ToDouble(txtValorVenda.Text);
                modelo.ProQtde = Convert.ToDouble(txtQtde.Text);
                modelo.UmedCod = Convert.ToInt32(cbUND.SelectedValue);
                modelo.CatCod = Convert.ToInt32(cbCategoria.SelectedValue);
                modelo.ScatCod = Convert.ToInt32(cbSubCategoria.SelectedValue);                            

                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);

                if (this.operacao == "inserir")
                {
                    modelo.CarregaImagem(this.foto);
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro Efetuado: Código " + modelo.ProCod.ToString());
                }

                else
                {                    
                    modelo.ProCod = Convert.ToInt32(txtCodigo.Text);
                    
                    if ( this.foto == "Foto Original")
                    {
                        ModeloProduto mt = bll.CarregaModeloProduto(modelo.ProCod);
                        modelo.ProFoto = mt.ProFoto;
                    }

                    else
                    {
                        modelo.CarregaImagem(this.foto);
                    }

                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro Efetuado");
                }
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {             
            frmConsultaProduto f = new frmConsultaProduto();
            f.ShowDialog();

            if (f.codigo != 0) 
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                ModeloProduto modelo = bll.CarregaModeloProduto(f.codigo);
                txtCodigo.Text = modelo.CatCod.ToString(); 
                txtCodigo.Text = modelo.ProCod.ToString();
                txtDescricao.Text = modelo.ProDescricao; //.ToString();
                txtNome.Text = modelo.ProNome; //.ToString();
                txtQtde.Text = modelo.ProQtde.ToString();
                txtValorPago.Text = modelo.ProValorPago.ToString();
                txtValorVenda.Text = modelo.ProValorVenda.ToString();
                cbCategoria.SelectedValue = modelo.CatCod;
                cbSubCategoria.SelectedValue = modelo.ScatCod;
                cbUND.SelectedValue = modelo.UmedCod;
                try
                {
                    MemoryStream ms = new MemoryStream(modelo.ProFoto);
                    pbFoto.Image = Image.FromStream(ms);
                    this.foto = "Foto Original";
                }
                catch {}

                txtQtde_Leave(sender,e);
                txtValorPago_Leave(sender, e);
                txtValorVenda_Leave(sender, e);
                alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose();            
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLProduto bll = new BLLProduto(cx);
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

        private void btAddCategoria_Click(object sender, EventArgs e)
        {
            frmCadastroCategoria f = new frmCadastroCategoria();
            f.ShowDialog();
            f.Dispose();

            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCategoria bll = new BLLCategoria(cx);
            cbCategoria.DataSource = bll.Localizar("");
            cbCategoria.DisplayMember = "cat_nome";
            cbCategoria.ValueMember = "cat_cod";

            try
            {
                //combo box da subcategoria            
                BLLSubCategoria sbll = new BLLSubCategoria(cx);
                cbSubCategoria.DataSource = sbll.LocalizarPorCategoria((int)cbCategoria.SelectedValue);
                cbSubCategoria.DisplayMember = "scat_nome";
                cbSubCategoria.ValueMember = "scat_cod";
            }
            catch
            {
                // MessageBox.Show("Cadastre uma categoria");
            }
        }

        private void btAddSubCategoria_Click(object sender, EventArgs e)
        {
            frmCadastroSubCategoria f = new frmCadastroSubCategoria();
            f.ShowDialog();
            f.Dispose();

            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
           
            try
            {
                //combo box da subcategoria            
                BLLSubCategoria sbll = new BLLSubCategoria(cx);
                cbSubCategoria.DataSource = sbll.LocalizarPorCategoria((int)cbCategoria.SelectedValue);
                cbSubCategoria.DisplayMember = "scat_nome";
                cbSubCategoria.ValueMember = "scat_cod";
            }
            catch
            {
                // MessageBox.Show("Cadastre uma subcategoria");
            }
        }

        private void btAddUnidadeMedida_Click(object sender, EventArgs e)
        {
            frmCadastroUnidadeDeMedida f = new frmCadastroUnidadeDeMedida();
            f.ShowDialog();
            f.Dispose();

            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);

            BLLUnidadeDeMedida ubll = new BLLUnidadeDeMedida(cx);
            cbCategoria.DataSource = ubll.Localizar("");
            cbCategoria.DisplayMember = "umed_nome";
            cbCategoria.ValueMember = "umed_cod";
        }
       
    }    
}
