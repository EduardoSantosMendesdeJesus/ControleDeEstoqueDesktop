using BLL;
using DAL;
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
    public partial class frmConsultaSubCategoria : Form
    {
        public int codigo = 0;
        public frmConsultaSubCategoria()
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
            BLLSubCategoria bll = new BLLSubCategoria(cx);
            dgvDados.DataSource = bll.Localizar(txtValor.Text);
        }

        private void frmConsultaSubCategoria_Load(object sender, EventArgs e)
        {
            btLocalizar_Click(sender, e);
            dgvDados.Columns[0].HeaderText = "Código da SubCategoria";
            dgvDados.Columns[0].Width = 77;
            dgvDados.Columns[1].HeaderText = "SubCategoria";
            dgvDados.Columns[1].Width = 400;
            dgvDados.Columns[2].HeaderText = "Código da Categoria";
            dgvDados.Columns[2].Width = 77;
            dgvDados.Columns[3].HeaderText = "Categoria";
            dgvDados.Columns[3].Width = 400;
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verifica se alinha clicada por + que 1 vez é maior ou igual a 0
            {
                this.codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value); // Armazena o código
                this.Close(); // Fecha a consulta
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

        private void lbConsultaSubCat_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
