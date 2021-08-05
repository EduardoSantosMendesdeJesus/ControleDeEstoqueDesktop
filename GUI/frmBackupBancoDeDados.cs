using DAL;
using Ferramentas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Formulario
{
    public partial class frmBackupBancoDeDados : Form
    {
        public frmBackupBancoDeDados()
        {
            InitializeComponent();
        }

        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btBackup_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog d = new SaveFileDialog();
                d.Filter = "Backup Files|*.bak";
                d.ShowDialog();

                if (d.FileName != "")
                {
                    string nomeBanco = DadosDaConexao.banco;
                    String localBackup = d.FileName;

                    // Faz o backup do banco de dados e salva no banco master do sql

                    // banco de dados que não utiliza usuario e senha, com autenticação do windows, se não for utilizar este backup basta comentar
                    String conexao = @"Data Source=" + DadosDaConexao.servidor + "; Initial Catalog =  master; Integrated Security=True";

                    // banco de dados com usuário e senha, para utilizar basta retirar o comentario

                    /*String conexao = @"Data Source =" + DadosDaConexao.servidor + "Initial Catalog = master; User=" +
                            DadosDaConexao.usuario + "; Password=" + DadosDaConexao.senha; */

                    SQLServerBackup.BackupDataBase(conexao, nomeBanco, d.FileName);
                    MessageBox.Show("Backup realizado");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btRestaurar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog d = new OpenFileDialog();
                d.Filter = "Backup Files|*.bak";
                d.ShowDialog();

                if (d.FileName != "")
                {
                    string nomeBanco = DadosDaConexao.banco;
                    String localBackup = d.FileName;

                    //Restaura o banco de dados

                    // banco sem usuario e senha, autenticação do windows, se não for utilizar basta comentar
                    String conexao = @"Data Source=" + DadosDaConexao.servidor + "; Initial Catalog =  master; Integrated Security=True";

                    // banco com usuário e senha, para utilizar basta retirar o comentario

                    /*String conexao = @"Data Source =" + DadosDaConexao.servidor + "Initial Catalog = master; User=" +
                            DadosDaConexao.usuario + "; Password=" + DadosDaConexao.senha; */

                    SQLServerBackup.RestauraDatabase(conexao, nomeBanco, d.FileName);                    
                    MessageBox.Show("Backup restaurado");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void pnBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btlbFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbBRB_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
