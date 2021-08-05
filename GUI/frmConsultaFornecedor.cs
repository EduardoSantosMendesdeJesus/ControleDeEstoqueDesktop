using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class frmConsultaFornecedor : Form
    {
        public int codigo = 0;
        public frmConsultaFornecedor()
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
            BLLFornecedor bll = new BLLFornecedor(cx);

            if (rbNome.Checked == true)
            {
                dgvDados.DataSource = bll.LocalizarPorNome(txtValor.Text);
            }
            else
            {
                dgvDados.DataSource = bll.LocalizarPorCNPJ(txtValor.Text);
            }
        }

        private void frmConsultaFornecedor_Load(object sender, EventArgs e)
        {
            btLocalizar_Click(sender, e);
            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[0].Width = 47;
            dgvDados.Columns[1].HeaderText = "Nome";
            dgvDados.Columns[1].Width = 210;
            dgvDados.Columns[2].HeaderText = "Razão Social";
            dgvDados.Columns[2].Width = 100;
            dgvDados.Columns[3].HeaderText = "IE";
            dgvDados.Columns[3].Width = 90;
            dgvDados.Columns[4].HeaderText = "CNPJ";
            dgvDados.Columns[4].Width = 130;           
            dgvDados.Columns[5].HeaderText = "CEP";
            dgvDados.Columns[5].Width = 80;
            dgvDados.Columns[6].HeaderText = "Logradouro";
            dgvDados.Columns[6].Width = 200;
            dgvDados.Columns[7].HeaderText = "Número";
            dgvDados.Columns[7].Width = 50;
            dgvDados.Columns[8].HeaderText = "Bairro";
            dgvDados.Columns[8].Width = 100;
            dgvDados.Columns[9].HeaderText = "Cidade";
            dgvDados.Columns[9].Width = 110;
            dgvDados.Columns[10].HeaderText = "UF";
            dgvDados.Columns[10].Width = 50;
            dgvDados.Columns[11].HeaderText = "Telefone";
            dgvDados.Columns[11].Width = 105;
            dgvDados.Columns[12].HeaderText = "Celular";
            dgvDados.Columns[12].Width = 110;
            dgvDados.Columns[13].HeaderText = "E-mail";
            dgvDados.Columns[13].Width = 170;

        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
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

        private void lbConsultaFornecedor_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}

