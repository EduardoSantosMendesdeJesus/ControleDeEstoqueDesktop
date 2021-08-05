namespace Formulario
{
    partial class frmConsultaCategoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaCategoria));
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btLocalizar = new System.Windows.Forms.Button();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.lbConsultaCat = new System.Windows.Forms.Label();
            this.pnBarraTitulo = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btlbFechar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.pnBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(12, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "CATEGORIA";
            // 
            // txtValor
            // 
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(12, 139);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(871, 29);
            this.txtValor.TabIndex = 1;
            // 
            // btLocalizar
            // 
            this.btLocalizar.BackColor = System.Drawing.Color.Transparent;
            this.btLocalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLocalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLocalizar.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLocalizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btLocalizar.Location = new System.Drawing.Point(889, 139);
            this.btLocalizar.Name = "btLocalizar";
            this.btLocalizar.Size = new System.Drawing.Size(123, 29);
            this.btLocalizar.TabIndex = 2;
            this.btLocalizar.Text = "LOCALIZAR";
            this.btLocalizar.UseVisualStyleBackColor = false;
            this.btLocalizar.Click += new System.EventHandler(this.btLocalizar_Click);
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.BackgroundColor = System.Drawing.Color.White;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.GridColor = System.Drawing.Color.Silver;
            this.dgvDados.Location = new System.Drawing.Point(12, 179);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(1000, 500);
            this.dgvDados.TabIndex = 3;
            this.dgvDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellDoubleClick);
            // 
            // lbConsultaCat
            // 
            this.lbConsultaCat.AutoSize = true;
            this.lbConsultaCat.BackColor = System.Drawing.Color.Transparent;
            this.lbConsultaCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbConsultaCat.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsultaCat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbConsultaCat.Location = new System.Drawing.Point(326, 25);
            this.lbConsultaCat.Name = "lbConsultaCat";
            this.lbConsultaCat.Size = new System.Drawing.Size(348, 38);
            this.lbConsultaCat.TabIndex = 4;
            this.lbConsultaCat.Text = "CONSULTA CATEGORIA";
            this.lbConsultaCat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbConsultaCat_MouseDown);
            // 
            // pnBarraTitulo
            // 
            this.pnBarraTitulo.BackColor = System.Drawing.Color.Transparent;
            this.pnBarraTitulo.Controls.Add(this.pbLogo);
            this.pnBarraTitulo.Controls.Add(this.btlbFechar);
            this.pnBarraTitulo.Controls.Add(this.lbConsultaCat);
            this.pnBarraTitulo.Location = new System.Drawing.Point(12, 6);
            this.pnBarraTitulo.Name = "pnBarraTitulo";
            this.pnBarraTitulo.Size = new System.Drawing.Size(1000, 89);
            this.pnBarraTitulo.TabIndex = 5;
            this.pnBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnBarraTitulo_MouseDown);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(3, 7);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(196, 74);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 7;
            this.pbLogo.TabStop = false;
            // 
            // btlbFechar
            // 
            this.btlbFechar.AutoSize = true;
            this.btlbFechar.BackColor = System.Drawing.Color.Transparent;
            this.btlbFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btlbFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btlbFechar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlbFechar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btlbFechar.Location = new System.Drawing.Point(971, 8);
            this.btlbFechar.Name = "btlbFechar";
            this.btlbFechar.Size = new System.Drawing.Size(20, 19);
            this.btlbFechar.TabIndex = 5;
            this.btlbFechar.Text = "X";
            this.btlbFechar.Click += new System.EventHandler(this.btlbFechar_Click);
            // 
            // frmConsultaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1024, 700);
            this.Controls.Add(this.pnBarraTitulo);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.btLocalizar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultaCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSULTA CATEGORIA";
            this.Load += new System.EventHandler(this.frmConsultaCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.pnBarraTitulo.ResumeLayout(false);
            this.pnBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btLocalizar;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Label lbConsultaCat;
        private System.Windows.Forms.Panel pnBarraTitulo;
        private System.Windows.Forms.Label btlbFechar;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}