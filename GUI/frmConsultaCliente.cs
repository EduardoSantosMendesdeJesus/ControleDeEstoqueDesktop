using DAL;
using BLL;
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
    public partial class frmConsultaCliente : Form
    {
        public int codigo = 0;
        public frmConsultaCliente()
        {
            InitializeComponent();
        }

        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCliente bll = new BLLCliente(cx);

            if (rbNome.Checked == true)
            {
                dgvDados.DataSource = bll.LocalizarPorNome(txtValor.Text);
            }
            else
            {
                dgvDados.DataSource = bll.LocalizarPorCPFCNPJ(txtValor.Text);
            }
        }

        private void frmConsultaCliente_Load(object sender, EventArgs e)
        {
            btLocalizar_Click(sender, e);
            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[0].Width = 43;
            dgvDados.Columns[1].HeaderText = "Nome";
            dgvDados.Columns[1].Width = 160;
            dgvDados.Columns[2].HeaderText = "CPF/CNPJ";
            dgvDados.Columns[2].Width = 80;
            dgvDados.Columns[3].HeaderText = "RG/IE";
            dgvDados.Columns[3].Width = 90;
            dgvDados.Columns[4].HeaderText = "Razão Social";
            dgvDados.Columns[4].Width = 130;
            dgvDados.Columns[5].HeaderText = "Tipo";
            dgvDados.Columns[5].Width = 30;
            dgvDados.Columns[6].HeaderText = "CEP";
            dgvDados.Columns[6].Width = 80;
            dgvDados.Columns[7].HeaderText = "Logradouro";
            dgvDados.Columns[7].Width = 200;
            dgvDados.Columns[8].HeaderText = "Número";
            dgvDados.Columns[8].Width = 50;
            dgvDados.Columns[9].HeaderText = "Bairro";
            dgvDados.Columns[9].Width = 100;
            dgvDados.Columns[10].HeaderText = "Cidade";
            dgvDados.Columns[10].Width = 80;
            dgvDados.Columns[11].HeaderText = "UF";
            dgvDados.Columns[11].Width = 30;
            dgvDados.Columns[12].HeaderText = "Telefone";
            dgvDados.Columns[12].Width = 90;
            dgvDados.Columns[13].HeaderText = "Celular";
            dgvDados.Columns[13].Width = 90;
            dgvDados.Columns[14].HeaderText = "E-mail";
            dgvDados.Columns[14].Width = 130;
            dgvDados.Columns[15].HeaderText = "Foto"; // está oculta
            dgvDados.Columns[15].Width = 50;

            // oculta colunas
            // para exibir a coluna fotos basta comenta, ou colocar true no lugar de false
            dgvDados.Columns["cli_foto"].Visible = false;

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

        private void lbConsultaCliente_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
    }
}
