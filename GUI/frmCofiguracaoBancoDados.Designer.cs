namespace Formulario
{
    partial class frmCofiguracaoBancoDados
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.txtBanco = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btTestar = new System.Windows.Forms.Button();
            this.btlbFechar = new System.Windows.Forms.Label();
            this.lbConfigBancoDandos = new System.Windows.Forms.Label();
            this.pnBarraTitulo = new System.Windows.Forms.Panel();
            this.pnBarraTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "SERVIDOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(12, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "BANCO DE DADOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(12, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "USUÁRIO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(12, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "SENHA";
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(12, 104);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(760, 20);
            this.txtServidor.TabIndex = 4;
            // 
            // txtBanco
            // 
            this.txtBanco.Location = new System.Drawing.Point(12, 163);
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(760, 20);
            this.txtBanco.TabIndex = 5;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(12, 222);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(760, 20);
            this.txtUsuario.TabIndex = 6;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(12, 281);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(760, 20);
            this.txtSenha.TabIndex = 7;
            // 
            // btSalvar
            // 
            this.btSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvar.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btSalvar.Location = new System.Drawing.Point(418, 323);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(142, 27);
            this.btSalvar.TabIndex = 8;
            this.btSalvar.Text = "SALVAR";
            this.btSalvar.UseVisualStyleBackColor = false;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btTestar
            // 
            this.btTestar.BackColor = System.Drawing.Color.Transparent;
            this.btTestar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTestar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTestar.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTestar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btTestar.Location = new System.Drawing.Point(225, 323);
            this.btTestar.Name = "btTestar";
            this.btTestar.Size = new System.Drawing.Size(142, 27);
            this.btTestar.TabIndex = 9;
            this.btTestar.Text = "TESTAR CONEXÃO";
            this.btTestar.UseVisualStyleBackColor = false;
            this.btTestar.Click += new System.EventHandler(this.btTestar_Click);
            // 
            // btlbFechar
            // 
            this.btlbFechar.AutoSize = true;
            this.btlbFechar.BackColor = System.Drawing.Color.Transparent;
            this.btlbFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btlbFechar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlbFechar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btlbFechar.Location = new System.Drawing.Point(748, 8);
            this.btlbFechar.Name = "btlbFechar";
            this.btlbFechar.Size = new System.Drawing.Size(20, 19);
            this.btlbFechar.TabIndex = 5;
            this.btlbFechar.Text = "X";
            this.btlbFechar.Click += new System.EventHandler(this.btlbFechar_Click);
            // 
            // lbConfigBancoDandos
            // 
            this.lbConfigBancoDandos.AutoSize = true;
            this.lbConfigBancoDandos.BackColor = System.Drawing.Color.Transparent;
            this.lbConfigBancoDandos.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfigBancoDandos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbConfigBancoDandos.Location = new System.Drawing.Point(135, 8);
            this.lbConfigBancoDandos.Name = "lbConfigBancoDandos";
            this.lbConfigBancoDandos.Size = new System.Drawing.Size(506, 38);
            this.lbConfigBancoDandos.TabIndex = 4;
            this.lbConfigBancoDandos.Text = "ALTERAÇÃO DO BANCO DE DADOS";
            this.lbConfigBancoDandos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbConfigBancoDandos_MouseDown);
            // 
            // pnBarraTitulo
            // 
            this.pnBarraTitulo.BackColor = System.Drawing.Color.Transparent;
            this.pnBarraTitulo.Controls.Add(this.btlbFechar);
            this.pnBarraTitulo.Controls.Add(this.lbConfigBancoDandos);
            this.pnBarraTitulo.Location = new System.Drawing.Point(4, 7);
            this.pnBarraTitulo.Name = "pnBarraTitulo";
            this.pnBarraTitulo.Size = new System.Drawing.Size(776, 57);
            this.pnBarraTitulo.TabIndex = 14;
            this.pnBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnBarraTitulo_MouseDown);
            // 
            // frmCofiguracaoBancoDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(784, 360);
            this.Controls.Add(this.pnBarraTitulo);
            this.Controls.Add(this.btTestar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtBanco);
            this.Controls.Add(this.txtServidor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCofiguracaoBancoDados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONFIGURAÇÃO DO BANCO DE DADOS";
            this.Load += new System.EventHandler(this.frmCofiguracaoBancoDados_Load);
            this.pnBarraTitulo.ResumeLayout(false);
            this.pnBarraTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.TextBox txtBanco;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btTestar;
        private System.Windows.Forms.Label btlbFechar;
        private System.Windows.Forms.Label lbConfigBancoDandos;
        private System.Windows.Forms.Panel pnBarraTitulo;
    }
}