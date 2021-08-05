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
    public partial class frmConsultaProduto : Form
    {
        public int codigo = 0;
        public frmConsultaProduto()
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
            BLLProduto bll = new BLLProduto(cx);
            dgvDados.DataSource = bll.Localizar(txtValor.Text);
        }

        private void frmConsultaProduto_Load(object sender, EventArgs e)
        {
            btLocalizar_Click(sender, e);
            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[0].Width = 50;
            dgvDados.Columns[1].HeaderText = "Produto";
            dgvDados.Columns[1].Width = 150;
            dgvDados.Columns[2].HeaderText = "Descrição";
            dgvDados.Columns[2].Width = 150;
            dgvDados.Columns[3].HeaderText = "Foto"; // está oculta
            dgvDados.Columns[3].Width = 40;
            dgvDados.Columns[4].HeaderText = "Valor Pago"; // está oculta
            dgvDados.Columns[4].Width = 90;
            dgvDados.Columns[5].HeaderText = "Valor de Venda";
            dgvDados.Columns[5].Width = 110;
            dgvDados.Columns[6].HeaderText = "Quantidade";
            dgvDados.Columns[6].Width = 80;
            dgvDados.Columns[7].HeaderText = "Unidade de Medida"; // está oculta
            dgvDados.Columns[7].Width = 125;
            dgvDados.Columns[8].HeaderText = "Categoria"; // está oculta
            dgvDados.Columns[8].Width = 60;
            dgvDados.Columns[9].HeaderText = "Sub Categoria"; // está oculta
            dgvDados.Columns[9].Width = 100;
            dgvDados.Columns[10].HeaderText = "Unidade de Medida"; // nome da unidade de medida
            dgvDados.Columns[10].Width = 125;
            dgvDados.Columns[11].HeaderText = "Categoria"; // nome da categoria
            dgvDados.Columns[11].Width = 145;
            dgvDados.Columns[12].HeaderText = "Sub Categoria"; // nome da subcategoria
            dgvDados.Columns[12].Width = 145;

            // oculta colunas
            // para exibir essas colunas basta comenta-las
           // dgvDados.Columns["pro_foto"].Visible = false;
            dgvDados.Columns["pro_valorpago"].Visible = false;
            dgvDados.Columns["cat_cod"].Visible = false;
            dgvDados.Columns["scat_cod"].Visible = false;
            dgvDados.Columns["umed_cod"].Visible = false;
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

        private void lbConsultaProduto_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
