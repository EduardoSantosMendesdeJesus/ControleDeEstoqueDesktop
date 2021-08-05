namespace Formulario
{
    partial class frmCadastroProduto
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.txtValorPago = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValorVenda = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbUND = new System.Windows.Forms.ComboBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.cbSubCategoria = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btLoFoto = new System.Windows.Forms.Button();
            this.btRmFoto = new System.Windows.Forms.Button();
            this.btAddCategoria = new System.Windows.Forms.Button();
            this.btAddSubCategoria = new System.Windows.Forms.Button();
            this.btAddUnidadeMedida = new System.Windows.Forms.Button();
            this.lbCadastroProduto = new System.Windows.Forms.Label();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnDados.Controls.Add(this.btAddUnidadeMedida);
            this.pnDados.Controls.Add(this.btAddSubCategoria);
            this.pnDados.Controls.Add(this.btAddCategoria);
            this.pnDados.Controls.Add(this.btRmFoto);
            this.pnDados.Controls.Add(this.btLoFoto);
            this.pnDados.Controls.Add(this.label10);
            this.pnDados.Controls.Add(this.panel1);
            this.pnDados.Controls.Add(this.cbSubCategoria);
            this.pnDados.Controls.Add(this.cbCategoria);
            this.pnDados.Controls.Add(this.cbUND);
            this.pnDados.Controls.Add(this.label9);
            this.pnDados.Controls.Add(this.label8);
            this.pnDados.Controls.Add(this.label7);
            this.pnDados.Controls.Add(this.txtValorVenda);
            this.pnDados.Controls.Add(this.label6);
            this.pnDados.Controls.Add(this.txtValorPago);
            this.pnDados.Controls.Add(this.txtQtde);
            this.pnDados.Controls.Add(this.label5);
            this.pnDados.Controls.Add(this.label4);
            this.pnDados.Controls.Add(this.txtDescricao);
            this.pnDados.Controls.Add(this.label3);
            this.pnDados.Controls.Add(this.txtNome);
            this.pnDados.Controls.Add(this.txtCodigo);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.label1);
            this.pnDados.Location = new System.Drawing.Point(7, 97);
            this.pnDados.Size = new System.Drawing.Size(788, 502);
            // 
            // pnBotoes
            // 
            this.pnBotoes.Location = new System.Drawing.Point(7, 605);
            this.pnBotoes.Size = new System.Drawing.Size(788, 66);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(666, 22);
            this.btCancelar.Size = new System.Drawing.Size(107, 32);
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(547, 22);
            this.btSalvar.Size = new System.Drawing.Size(107, 32);
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(412, 22);
            this.btExcluir.Size = new System.Drawing.Size(107, 32);
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(277, 22);
            this.btAlterar.Size = new System.Drawing.Size(107, 32);
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btLocalizar
            // 
            this.btLocalizar.Location = new System.Drawing.Point(142, 22);
            this.btLocalizar.Size = new System.Drawing.Size(107, 32);
            this.btLocalizar.Click += new System.EventHandler(this.btLocalizar_Click);
            // 
            // btInserir
            // 
            this.btInserir.Location = new System.Drawing.Point(7, 22);
            this.btInserir.Size = new System.Drawing.Size(107, 32);
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(10, 9);
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
            this.label2.Location = new System.Drawing.Point(10, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOME";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(10, 34);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(10, 88);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(355, 20);
            this.txtNome.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(10, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "DESCRIÇÃO";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(10, 146);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(355, 153);
            this.txtDescricao.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(10, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "QUANTIDADE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(10, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "VALOR PAGO";
            // 
            // txtQtde
            // 
            this.txtQtde.Location = new System.Drawing.Point(10, 411);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(157, 20);
            this.txtQtde.TabIndex = 12;
            this.txtQtde.Text = "00";
            this.txtQtde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtde_KeyPress);
            this.txtQtde.Leave += new System.EventHandler(this.txtQtde_Leave);
            // 
            // txtValorPago
            // 
            this.txtValorPago.Location = new System.Drawing.Point(10, 347);
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.Size = new System.Drawing.Size(157, 20);
            this.txtValorPago.TabIndex = 9;
            this.txtValorPago.Text = "0.00";
            this.txtValorPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorPago_KeyPress);
            this.txtValorPago.Leave += new System.EventHandler(this.txtValorPago_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(203, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "VALOR DE VENDA";
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.Location = new System.Drawing.Point(207, 347);
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(157, 20);
            this.txtValorVenda.TabIndex = 11;
            this.txtValorVenda.Text = "0.00";
            this.txtValorVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorVenda_KeyPress);
            this.txtValorVenda.Leave += new System.EventHandler(this.txtValorVenda_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label7.Location = new System.Drawing.Point(203, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "MEDIDA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label8.Location = new System.Drawing.Point(10, 440);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "CATEGORIA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label9.Location = new System.Drawing.Point(204, 440);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 19);
            this.label9.TabIndex = 14;
            this.label9.Text = "SUB-CATEGORIA";
            // 
            // cbUND
            // 
            this.cbUND.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbUND.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbUND.FormattingEnabled = true;
            this.cbUND.Location = new System.Drawing.Point(206, 410);
            this.cbUND.Name = "cbUND";
            this.cbUND.Size = new System.Drawing.Size(157, 21);
            this.cbUND.TabIndex = 15;            
            // 
            // cbCategoria
            // 
            this.cbCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(10, 466);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(157, 21);
            this.cbCategoria.TabIndex = 16;
            this.cbCategoria.SelectedIndexChanged += new System.EventHandler(this.cbCategoria_SelectedIndexChanged);
            // 
            // cbSubCategoria
            // 
            this.cbSubCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbSubCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSubCategoria.FormattingEnabled = true;
            this.cbSubCategoria.Location = new System.Drawing.Point(203, 466);
            this.cbSubCategoria.Name = "cbSubCategoria";
            this.cbSubCategoria.Size = new System.Drawing.Size(157, 21);
            this.cbSubCategoria.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbFoto);
            this.panel1.Location = new System.Drawing.Point(412, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 397);
            this.panel1.TabIndex = 18;
            // 
            // pbFoto
            // 
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFoto.Location = new System.Drawing.Point(0, 0);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(361, 397);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto.TabIndex = 0;
            this.pbFoto.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label10.Location = new System.Drawing.Point(411, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 19);
            this.label10.TabIndex = 19;
            this.label10.Text = "FOTO";
            // 
            // btLoFoto
            // 
            this.btLoFoto.BackColor = System.Drawing.Color.Transparent;
            this.btLoFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLoFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLoFoto.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLoFoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btLoFoto.Location = new System.Drawing.Point(412, 455);
            this.btLoFoto.Name = "btLoFoto";
            this.btLoFoto.Size = new System.Drawing.Size(164, 34);
            this.btLoFoto.TabIndex = 20;
            this.btLoFoto.Text = "CARREGAR FOTO";
            this.btLoFoto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btLoFoto.UseVisualStyleBackColor = false;
            this.btLoFoto.Click += new System.EventHandler(this.btLoFoto_Click);
            // 
            // btRmFoto
            // 
            this.btRmFoto.BackColor = System.Drawing.Color.Transparent;
            this.btRmFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRmFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRmFoto.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRmFoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btRmFoto.Location = new System.Drawing.Point(609, 453);
            this.btRmFoto.Name = "btRmFoto";
            this.btRmFoto.Size = new System.Drawing.Size(164, 34);
            this.btRmFoto.TabIndex = 21;
            this.btRmFoto.Text = "REMOVER FOTO";
            this.btRmFoto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btRmFoto.UseVisualStyleBackColor = false;
            this.btRmFoto.Click += new System.EventHandler(this.btRmFoto_Click);
            // 
            // btAddCategoria
            // 
            this.btAddCategoria.BackColor = System.Drawing.Color.Transparent;
            this.btAddCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAddCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddCategoria.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btAddCategoria.Location = new System.Drawing.Point(172, 466);
            this.btAddCategoria.Name = "btAddCategoria";
            this.btAddCategoria.Size = new System.Drawing.Size(21, 21);
            this.btAddCategoria.TabIndex = 22;
            this.btAddCategoria.Text = "+";
            this.btAddCategoria.UseVisualStyleBackColor = false;
            this.btAddCategoria.Click += new System.EventHandler(this.btAddCategoria_Click);
            // 
            // btAddSubCategoria
            // 
            this.btAddSubCategoria.BackColor = System.Drawing.Color.Transparent;
            this.btAddSubCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAddSubCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddSubCategoria.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddSubCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btAddSubCategoria.Location = new System.Drawing.Point(370, 466);
            this.btAddSubCategoria.Name = "btAddSubCategoria";
            this.btAddSubCategoria.Size = new System.Drawing.Size(21, 21);
            this.btAddSubCategoria.TabIndex = 23;
            this.btAddSubCategoria.Text = "+";
            this.btAddSubCategoria.UseVisualStyleBackColor = false;
            this.btAddSubCategoria.Click += new System.EventHandler(this.btAddSubCategoria_Click);
            // 
            // btAddUnidadeMedida
            // 
            this.btAddUnidadeMedida.BackColor = System.Drawing.Color.Transparent;
            this.btAddUnidadeMedida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAddUnidadeMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddUnidadeMedida.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddUnidadeMedida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btAddUnidadeMedida.Location = new System.Drawing.Point(370, 410);
            this.btAddUnidadeMedida.Name = "btAddUnidadeMedida";
            this.btAddUnidadeMedida.Size = new System.Drawing.Size(21, 21);
            this.btAddUnidadeMedida.TabIndex = 24;
            this.btAddUnidadeMedida.Text = "+";
            this.btAddUnidadeMedida.UseVisualStyleBackColor = false;
            this.btAddUnidadeMedida.Click += new System.EventHandler(this.btAddUnidadeMedida_Click);
            // 
            // lbCadastroProduto
            // 
            this.lbCadastroProduto.AutoSize = true;
            this.lbCadastroProduto.BackColor = System.Drawing.Color.Transparent;
            this.lbCadastroProduto.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadastroProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbCadastroProduto.Location = new System.Drawing.Point(220, 26);
            this.lbCadastroProduto.Name = "lbCadastroProduto";
            this.lbCadastroProduto.Size = new System.Drawing.Size(363, 38);
            this.lbCadastroProduto.TabIndex = 25;
            this.lbCadastroProduto.Text = "CADASTRO DE PRODUTO";
            this.lbCadastroProduto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbCadastroProduto.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbCadastroProduto_MouseDown);
            // 
            // frmCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(802, 678);
            this.Controls.Add(this.lbCadastroProduto);
            this.Name = "frmCadastroProduto";
            this.Text = "CADASTRO DE PRODUTO";
            this.Load += new System.EventHandler(this.frmCadastroProduto_Load);
            this.Controls.SetChildIndex(this.pnDados, 0);
            this.Controls.SetChildIndex(this.pnBotoes, 0);
            this.Controls.SetChildIndex(this.lbCadastroProduto, 0);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRmFoto;
        private System.Windows.Forms.Button btLoFoto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.ComboBox cbSubCategoria;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.ComboBox cbUND;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtValorVenda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValorPago;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAddUnidadeMedida;
        private System.Windows.Forms.Button btAddSubCategoria;
        private System.Windows.Forms.Button btAddCategoria;
        private System.Windows.Forms.Label lbCadastroProduto;
    }
}
