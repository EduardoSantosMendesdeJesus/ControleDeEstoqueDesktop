namespace Formulario
{
    partial class frmConsultaSubCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaSubCategoria));
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.btLocalizar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btlbFechar = new System.Windows.Forms.Label();
            this.lbConsultaSubCat = new System.Windows.Forms.Label();
            this.pnBarraTitulo = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.pnBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
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
            this.dgvDados.TabIndex = 7;
            this.dgvDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellDoubleClick);
            // 
            // btLocalizar
            // 
            this.btLocalizar.BackColor = System.Drawing.Color.Transparent;
            this.btLocalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLocalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLocalizar.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLocalizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btLocalizar.Location = new System.Drawing.Point(895, 139);
            this.btLocalizar.Name = "btLocalizar";
            this.btLocalizar.Size = new System.Drawing.Size(117, 29);
            this.btLocalizar.TabIndex = 6;
            this.btLocalizar.Text = "LOCALIZAR";
            this.btLocalizar.UseVisualStyleBackColor = false;
            this.btLocalizar.Click += new System.EventHandler(this.btLocalizar_Click);
            // 
            // txtValor
            // 
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(12, 139);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(871, 29);
            this.txtValor.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(12, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "SUB-CATEGORIA";
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
            // lbConsultaSubCat
            // 
            this.lbConsultaSubCat.AutoSize = true;
            this.lbConsultaSubCat.BackColor = System.Drawing.Color.Transparent;
            this.lbConsultaSubCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbConsultaSubCat.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsultaSubCat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbConsultaSubCat.Location = new System.Drawing.Point(289, 8);
            this.lbConsultaSubCat.Name = "lbConsultaSubCat";
            this.lbConsultaSubCat.Size = new System.Drawing.Size(420, 38);
            this.lbConsultaSubCat.TabIndex = 4;
            this.lbConsultaSubCat.Text = "CONSULTA SUB-CATEGORIA";
            this.lbConsultaSubCat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbConsultaSubCat_MouseDown);
            // 
            // pnBarraTitulo
            // 
            this.pnBarraTitulo.BackColor = System.Drawing.Color.Transparent;
            this.pnBarraTitulo.Controls.Add(this.pbLogo);
            this.pnBarraTitulo.Controls.Add(this.btlbFechar);
            this.pnBarraTitulo.Controls.Add(this.lbConsultaSubCat);
            this.pnBarraTitulo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pnBarraTitulo.Location = new System.Drawing.Point(12, 6);
            this.pnBarraTitulo.Name = "pnBarraTitulo";
            this.pnBarraTitulo.Size = new System.Drawing.Size(1000, 89);
            this.pnBarraTitulo.TabIndex = 11;
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
            this.pbLogo.TabIndex = 8;
            this.pbLogo.TabStop = false;
            // 
            // frmConsultaSubCategoria
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
            this.Name = "frmConsultaSubCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSULTA SUBCATEGORIA";
            this.Load += new System.EventHandler(this.frmConsultaSubCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.pnBarraTitulo.ResumeLayout(false);
            this.pnBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Button btLocalizar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label btlbFechar;
        private System.Windows.Forms.Label lbConsultaSubCat;
        private System.Windows.Forms.Panel pnBarraTitulo;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}