namespace Formulario
{
    partial class frmCadastroSubCategoria
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
            this.cbCatCod = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtScatCod = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.lbCadstroSubCat = new System.Windows.Forms.Label();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.btAdd);
            this.pnDados.Controls.Add(this.txtNome);
            this.pnDados.Controls.Add(this.txtScatCod);
            this.pnDados.Controls.Add(this.label3);
            this.pnDados.Controls.Add(this.cbCatCod);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.label1);
            this.pnDados.Location = new System.Drawing.Point(5, 96);
            this.pnDados.Size = new System.Drawing.Size(787, 194);
            // 
            // pnBotoes
            // 
            this.pnBotoes.Location = new System.Drawing.Point(5, 297);
            this.pnBotoes.Size = new System.Drawing.Size(787, 61);
            // 
            // btCancelar
            // 
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btLocalizar
            // 
            this.btLocalizar.Click += new System.EventHandler(this.btLocalizar_Click);
            // 
            // btInserir
            // 
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(10, 17);
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
            this.label2.Location = new System.Drawing.Point(10, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOME DA SUB-CATEGORIA";
            // 
            // cbCatCod
            // 
            this.cbCatCod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbCatCod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCatCod.FormattingEnabled = true;
            this.cbCatCod.Location = new System.Drawing.Point(10, 163);
            this.cbCatCod.Name = "cbCatCod";
            this.cbCatCod.Size = new System.Drawing.Size(356, 21);
            this.cbCatCod.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(10, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "NOME DA CATEGORIA";
            // 
            // txtScatCod
            // 
            this.txtScatCod.Enabled = false;
            this.txtScatCod.Location = new System.Drawing.Point(10, 45);
            this.txtScatCod.Name = "txtScatCod";
            this.txtScatCod.Size = new System.Drawing.Size(100, 20);
            this.txtScatCod.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(10, 103);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(757, 20);
            this.txtNome.TabIndex = 5;
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.Transparent;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btAdd.Location = new System.Drawing.Point(372, 163);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(21, 21);
            this.btAdd.TabIndex = 6;
            this.btAdd.Text = "+";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // lbCadstroSubCat
            // 
            this.lbCadstroSubCat.AutoSize = true;
            this.lbCadstroSubCat.BackColor = System.Drawing.Color.Transparent;
            this.lbCadstroSubCat.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadstroSubCat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbCadstroSubCat.Location = new System.Drawing.Point(217, 26);
            this.lbCadstroSubCat.Name = "lbCadstroSubCat";
            this.lbCadstroSubCat.Size = new System.Drawing.Size(467, 38);
            this.lbCadstroSubCat.TabIndex = 7;
            this.lbCadstroSubCat.Text = "CADASTRO DE SUB-CATEGORIA";
            this.lbCadstroSubCat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbCadstroSubCat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbCadstroSubCat_MouseDown);
            // 
            // frmCadastroSubCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(804, 363);
            this.Controls.Add(this.lbCadstroSubCat);
            this.Name = "frmCadastroSubCategoria";
            this.Text = "CADASTRO DE SUBCATEGORIA";
            this.Load += new System.EventHandler(this.frmCadastroSubCategoria_Load);
            this.Controls.SetChildIndex(this.pnDados, 0);
            this.Controls.SetChildIndex(this.pnBotoes, 0);
            this.Controls.SetChildIndex(this.lbCadstroSubCat, 0);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtScatCod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCatCod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label lbCadstroSubCat;
    }
}
