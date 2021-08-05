using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using DAL;
using BLL;
using Modelo;

namespace Formulario
{
    public partial class frmMovimentacaoDeCompra : Formulario.frmModeloDeFormularioDeCadastro
    {
        public frmMovimentacaoDeCompra()
        {
            InitializeComponent();
        }

        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void lbCadastroCategoria_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        public void LimpaTela()
        {
            txtComCod.Clear();
            txtForCod.Clear();
            lbFornecedor.Text = "Click em localizar ou informe o código do Fornecedor";
            txtNFiscal.Clear();
            txtProCod.Clear();
            lbProduto.Text = "Click em localizar ou informe o código do Produto";
            txtQtde.Clear();
            txtValor.Clear();
            txtTotalCompra.Clear();
            dgvItens.Rows.Clear();
        }

        public double totalCompra = 0;

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.totalCompra = 0;
            this.alteraBotoes(2);
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            /*
             
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

             */
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alteraBotoes(2);
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            /*
            
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

            */
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            /*
              
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
              
             */
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.alteraBotoes(1);
            this.totalCompra = 0;
        }

        private void btLocFor_Click(object sender, EventArgs e)
        {
            frmConsultaFornecedor f = new frmConsultaFornecedor();
            f.ShowDialog();

            if (f.codigo != 0)
            {
                txtForCod.Text = f.codigo.ToString();
                TxtForCod_Leave(sender, e);                
            }
        }

        private void TxtForCod_Leave(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);
                ModeloFornecedor modelo = bll.CarregaModeloFornecedor(Convert.ToInt32(txtForCod.Text));
                lbFornecedor.Text = modelo.ForNome;
            }
            catch
            {
                txtForCod.Clear();
                lbFornecedor.Text = "Click em localizar ou informe o código do Fornecedor";
            }
        }

        private void BtLocProd_Click(object sender, EventArgs e)
        {
            frmConsultaProduto f = new frmConsultaProduto();
            f.ShowDialog();

            if (f.codigo != 0)
            {
                txtProCod.Text = f.codigo.ToString();
                TxtProCod_Leave(sender, e);
            }
        }

        private void TxtProCod_Leave(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                ModeloProduto modelo = bll.CarregaModeloProduto(Convert.ToInt32(txtProCod.Text));
                lbProduto.Text = modelo.ProNome;
                txtQtde.Text = "1";
                txtValor.Text = modelo.ProValorPago.ToString();
            }
            catch
            {
                txtProCod.Clear();
                lbProduto.Text = "Click em localizar ou informe o código do Produto";
            }
        }

        private void btAddProd_Click(object sender, EventArgs e)
        {
            if ((txtProCod.Text !="") && (txtQtde.Text != "") && (txtValor.Text != ""))
            {
                Double TotalLocal = Convert.ToDouble(txtQtde.Text) * Convert.ToDouble(txtValor.Text);
                this.totalCompra = this.totalCompra + TotalLocal; //metodo para somar o total da compra
                String[] i = new string[] { txtProCod.Text, lbProduto.Text, txtQtde.Text, txtValor.Text, TotalLocal.ToString() };
                this.dgvItens.Rows.Add(i); //adiciona o string dentro  da datagrid 

                txtProCod.Clear();
                lbProduto.Text = "Click em localizar ou informe o código do Produto";
                txtQtde.Clear();
                txtValor.Clear();                

                txtTotalCompra.Text = this.totalCompra.ToString(); //atualiza o valor da compra
            }
        }

        private void frmMovimentacaoDeCompra_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLTipoPagamento bll = new BLLTipoPagamento(cx);
            cbTPagamento.DataSource = bll.Localizar("");
            cbTPagamento.DisplayMember = "tpa_nome";
            cbTPagamento.ValueMember = "tpa_cod";
        }

        private void dgvItens_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtProCod.Text = dgvItens.Rows[e.RowIndex].Cells[0].Value.ToString();
                lbProduto.Text = dgvItens.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtQtde.Text = dgvItens.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtValor.Text = dgvItens.Rows[e.RowIndex].Cells[3].Value.ToString();
                Double valor = Convert.ToDouble(dgvItens.Rows[e.RowIndex].Cells[4].Value);
                this.totalCompra = this.totalCompra - valor;
                dgvItens.Rows.RemoveAt(e.RowIndex);
                txtTotalCompra.Text = this.totalCompra.ToString();
            }
        }
    }
}
