namespace Formulario
{
    partial class frmBackupBancoDeDados
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
            this.btBackup = new System.Windows.Forms.Button();
            this.btRestaurar = new System.Windows.Forms.Button();
            this.pnBarraTitulo = new System.Windows.Forms.Panel();
            this.lbBRB = new System.Windows.Forms.Label();
            this.btlbFechar = new System.Windows.Forms.Label();
            this.pnBarraTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btBackup
            // 
            this.btBackup.BackColor = System.Drawing.Color.Black;
            this.btBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBackup.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBackup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btBackup.Location = new System.Drawing.Point(94, 69);
            this.btBackup.Name = "btBackup";
            this.btBackup.Size = new System.Drawing.Size(251, 45);
            this.btBackup.TabIndex = 1;
            this.btBackup.Text = "BACKUP DO BANCO DE DADOS";
            this.btBackup.UseVisualStyleBackColor = false;
            this.btBackup.Click += new System.EventHandler(this.btBackup_Click);
            // 
            // btRestaurar
            // 
            this.btRestaurar.BackColor = System.Drawing.Color.Black;
            this.btRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRestaurar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRestaurar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btRestaurar.Location = new System.Drawing.Point(389, 69);
            this.btRestaurar.Name = "btRestaurar";
            this.btRestaurar.Size = new System.Drawing.Size(251, 45);
            this.btRestaurar.TabIndex = 3;
            this.btRestaurar.Text = "RESTAURAR O BANCO DE DADOS";
            this.btRestaurar.UseVisualStyleBackColor = false;
            this.btRestaurar.Click += new System.EventHandler(this.btRestaurar_Click);
            // 
            // pnBarraTitulo
            // 
            this.pnBarraTitulo.Controls.Add(this.lbBRB);
            this.pnBarraTitulo.Location = new System.Drawing.Point(9, 12);
            this.pnBarraTitulo.Name = "pnBarraTitulo";
            this.pnBarraTitulo.Size = new System.Drawing.Size(697, 51);
            this.pnBarraTitulo.TabIndex = 4;
            this.pnBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnBarraTitulo_MouseDown);
            // 
            // lbBRB
            // 
            this.lbBRB.AutoSize = true;
            this.lbBRB.BackColor = System.Drawing.Color.Transparent;
            this.lbBRB.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBRB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbBRB.Location = new System.Drawing.Point(6, 17);
            this.lbBRB.Name = "lbBRB";
            this.lbBRB.Size = new System.Drawing.Size(685, 32);
            this.lbBRB.TabIndex = 0;
            this.lbBRB.Text = "BACKUP E RESTAURAÇÃO DO BANCO DE DADOS";
            this.lbBRB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbBRB_MouseDown);
            // 
            // btlbFechar
            // 
            this.btlbFechar.AutoSize = true;
            this.btlbFechar.BackColor = System.Drawing.Color.Transparent;
            this.btlbFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btlbFechar.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlbFechar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btlbFechar.Location = new System.Drawing.Point(712, 12);
            this.btlbFechar.Name = "btlbFechar";
            this.btlbFechar.Size = new System.Drawing.Size(18, 17);
            this.btlbFechar.TabIndex = 1;
            this.btlbFechar.Text = "X";
            this.btlbFechar.Click += new System.EventHandler(this.btlbFechar_Click);
            // 
            // frmBackupBancoDeDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(735, 128);
            this.Controls.Add(this.btlbFechar);
            this.Controls.Add(this.pnBarraTitulo);
            this.Controls.Add(this.btRestaurar);
            this.Controls.Add(this.btBackup);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBackupBancoDeDados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BACKUP DO BANCO DE DADOS";
            this.pnBarraTitulo.ResumeLayout(false);
            this.pnBarraTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBackup;
        private System.Windows.Forms.Button btRestaurar;
        private System.Windows.Forms.Panel pnBarraTitulo;
        private System.Windows.Forms.Label btlbFechar;
        private System.Windows.Forms.Label lbBRB;
    }
}