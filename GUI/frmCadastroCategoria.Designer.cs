namespace Formulario
{
    partial class frmCadastroCategoria
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbCadastroCategoria = new System.Windows.Forms.Label();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.txtNome);
            this.pnDados.Controls.Add(this.txtCodigo);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.label1);
            this.pnDados.ForeColor = System.Drawing.Color.Black;
            this.pnDados.Location = new System.Drawing.Point(5, 97);
            this.pnDados.Size = new System.Drawing.Size(780, 137);
            // 
            // pnBotoes
            // 
            this.pnBotoes.Location = new System.Drawing.Point(5, 240);
            this.pnBotoes.Size = new System.Drawing.Size(780, 60);
            // 
            // btCancelar
            // 
            this.btCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btCancelar.Location = new System.Drawing.Point(656, 15);
            this.btCancelar.Size = new System.Drawing.Size(114, 30);
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btSalvar.Location = new System.Drawing.Point(527, 15);
            this.btSalvar.Size = new System.Drawing.Size(114, 30);
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btExcluir.Location = new System.Drawing.Point(398, 15);
            this.btExcluir.Size = new System.Drawing.Size(114, 30);
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btAlterar.Location = new System.Drawing.Point(269, 15);
            this.btAlterar.Size = new System.Drawing.Size(114, 30);
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btLocalizar
            // 
            this.btLocalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btLocalizar.Location = new System.Drawing.Point(140, 15);
            this.btLocalizar.Size = new System.Drawing.Size(114, 30);
            this.btLocalizar.Click += new System.EventHandler(this.btLocalizar_Click);
            // 
            // btInserir
            // 
            this.btInserir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btInserir.Location = new System.Drawing.Point(11, 15);
            this.btInserir.Size = new System.Drawing.Size(114, 30);
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "CÓDIGO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(7, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOME DA CATEGORIA";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(9, 39);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(9, 101);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(761, 20);
            this.txtNome.TabIndex = 3;
            // 
            // lbCadastroCategoria
            // 
            this.lbCadastroCategoria.AutoSize = true;
            this.lbCadastroCategoria.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadastroCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbCadastroCategoria.Location = new System.Drawing.Point(215, 28);
            this.lbCadastroCategoria.Name = "lbCadastroCategoria";
            this.lbCadastroCategoria.Size = new System.Drawing.Size(395, 38);
            this.lbCadastroCategoria.TabIndex = 0;
            this.lbCadastroCategoria.Text = "CADASTRO DE CATEGORIA";
            this.lbCadastroCategoria.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbCadastroCategoria_MouseDown);
            // 
            // frmCadastroCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(804, 310);
            this.Controls.Add(this.lbCadastroCategoria);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmCadastroCategoria";
            this.Text = "CADASTRO DE CATEGORIA";
            this.Load += new System.EventHandler(this.frmCadastroCategoria_Load);
            this.Controls.SetChildIndex(this.lbCadastroCategoria, 0);
            this.Controls.SetChildIndex(this.pnDados, 0);
            this.Controls.SetChildIndex(this.pnBotoes, 0);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCadastroCategoria;
    }
}
