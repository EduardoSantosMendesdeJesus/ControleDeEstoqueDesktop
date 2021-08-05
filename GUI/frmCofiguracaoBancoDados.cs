using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Formulario
{
    public partial class frmCofiguracaoBancoDados : Form
    {
        public frmCofiguracaoBancoDados()
        {
            InitializeComponent();
        }

        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                // Objeto para trabalhar com arquivos seja pra criar ou abrir um
                StreamWriter arquivo = new StreamWriter("ConfiguracaoBanco.txt", false);
                
                // Manda escrever linhas no arquivo referente aos comandos pedidos 
                arquivo.WriteLine(txtServidor.Text);
                arquivo.WriteLine(txtBanco.Text);
                arquivo.WriteLine(txtUsuario.Text);
                arquivo.WriteLine(txtSenha.Text);
                arquivo.Close();
                MessageBox.Show("Arquivo atualizado");
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void frmCofiguracaoBancoDados_Load(object sender, EventArgs e)
        {
            try
            {                   
                StreamReader arquivo = new StreamReader("ConfiguracaoBanco.txt");
                // Executa a leitura das linhas
                txtServidor.Text = arquivo.ReadLine();
                txtBanco.Text = arquivo.ReadLine();
                txtUsuario.Text = arquivo.ReadLine();
                txtSenha.Text = arquivo.ReadLine();
                arquivo.Close();                
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btTestar_Click(object sender, EventArgs e)
        {
            try
            {
                
                DadosDaConexao.servidor = txtServidor.Text;
                DadosDaConexao.banco = txtBanco.Text;
                DadosDaConexao.usuario = txtUsuario.Text;
                DadosDaConexao.senha = txtSenha.Text;
                
                // Testa a conexão
                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = DadosDaConexao.StringDeConexao;
                conexao.Open();
                conexao.Close();
                MessageBox.Show("Conectado com sucesso");
            }
            catch (SqlException errob)
            {
                MessageBox.Show("Erro ao tentar se conectar ao banco de dados \n" +
                "Verifique os dados informados");
            }
            catch (Exception erros)
            {
                MessageBox.Show(erros.Message);
            }
        }

        private void btlbFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lbConfigBancoDandos_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
