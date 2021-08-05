using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace Formulario
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCategoria f = new frmCadastroCategoria();
            f.ShowDialog(); // Manda mostrar o formulário
            f.Dispose();
        }

        private void categoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaCategoria f = new frmConsultaCategoria();
            f.ShowDialog();
            f.Dispose();
        }

        private void subCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroSubCategoria f = new frmCadastroSubCategoria();
            f.ShowDialog();
            f.Dispose();
        }

        private void subCategoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaSubCategoria f = new frmConsultaSubCategoria();
            f.ShowDialog();
            f.Dispose();
        }

        private void unidadeDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroUnidadeDeMedida f = new frmCadastroUnidadeDeMedida();
            f.ShowDialog();
            f.Dispose();
        }

        private void unidadeDeMedidaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaUnidadeDMedida f = new frmConsultaUnidadeDMedida();
            f.ShowDialog();
            f.Dispose();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroProduto f = new frmCadastroProduto();
            f.ShowDialog();
            f.Dispose();
        }

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaProduto f = new frmConsultaProduto();
            f.ShowDialog();
            f.Dispose();
        }

        private void configuraçãoDoBancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCofiguracaoBancoDados f = new frmCofiguracaoBancoDados();
            f.ShowDialog();
            f.Dispose();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void explorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer");
        }

        private void blocoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad");
        }

        private void exelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void powerPointToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("powerpnt");
        }

        private void outlookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("outlook");
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // Verifica a conexão do banco
            try
            {
                StreamReader arquivo = new StreamReader("ConfiguracaoBanco.txt");
                DadosDaConexao.servidor = arquivo.ReadLine();
                DadosDaConexao.banco = arquivo.ReadLine();
                DadosDaConexao.usuario = arquivo.ReadLine();
                DadosDaConexao.senha = arquivo.ReadLine();
                arquivo.Close();

                // Testa a conexão
                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = DadosDaConexao.StringDeConexao;
                conexao.Open();
                conexao.Close();
            }
            catch(SqlException errob)
            {
                MessageBox.Show("Erro ao tentar se conectar ao banco de dados \n" +
                "Acesse as configurações do banco de dados e informe os parâmetros de conexão");
            }
            catch (Exception erros)
            {
                MessageBox.Show(erros.Message);
            }
         }

        private void backupDoBancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBackupBancoDeDados f = new frmBackupBancoDeDados();
            f.ShowDialog();
            f.Dispose();
        }

        private void tipoDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmCadastroTipoPagamento f = new frmCadastroTipoPagamento();
            f.ShowDialog();
            f.Dispose();
        }

        private void tipoDePagamentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaTipoPagamento f = new frmConsultaTipoPagamento();
            f.ShowDialog();
            f.Dispose();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCliente f = new frmCadastroCliente();
            f.ShowDialog();
            f.Dispose();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaCliente f = new frmConsultaCliente();
            f.ShowDialog();
            f.Dispose();
        }

        private void pbFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbMaximizar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            //pbReasturarAbaixo.Visible = true;
            //pbMaximizar.Visible = false;
        }

        private void pbReasturarAbaixo_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
            //pbReasturarAbaixo.Visible = false;
            //pbMaximizar.Visible = true;
        }

        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroFornecedor f = new frmCadastroFornecedor();
            f.ShowDialog();
            f.Dispose();
        }

        private void fornecedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaFornecedor f = new frmConsultaFornecedor();
            f.ShowDialog();
            f.Dispose();
        }

        private void frmPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMovimentacaoDeCompra f = new frmMovimentacaoDeCompra();
            f.ShowDialog();
            f.Dispose();
        }
    }
}
