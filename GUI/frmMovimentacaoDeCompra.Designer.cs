namespace Formulario
{
    partial class frmMovimentacaoDeCompra
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
            this.lbCadastroCategoria = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtComCod = new System.Windows.Forms.TextBox();
            this.txtNFiscal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtDataCompra = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbNParcelas = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalCompra = new System.Windows.Forms.TextBox();
            this.cbTPagamento = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtDataIni = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.proCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forQtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provund = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtForCod = new System.Windows.Forms.TextBox();
            this.btLocFor = new System.Windows.Forms.Button();
            this.lbFornecedor = new System.Windows.Forms.Label();
            this.txtProCod = new System.Windows.Forms.TextBox();
            this.btLocProd = new System.Windows.Forms.Button();
            this.lbProduto = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btAddProd = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.label14);
            this.pnDados.Controls.Add(this.label13);
            this.pnDados.Controls.Add(this.label10);
            this.pnDados.Controls.Add(this.btAddProd);
            this.pnDados.Controls.Add(this.txtValor);
            this.pnDados.Controls.Add(this.label12);
            this.pnDados.Controls.Add(this.txtQtde);
            this.pnDados.Controls.Add(this.label11);
            this.pnDados.Controls.Add(this.lbProduto);
            this.pnDados.Controls.Add(this.btLocProd);
            this.pnDados.Controls.Add(this.txtProCod);
            this.pnDados.Controls.Add(this.lbFornecedor);
            this.pnDados.Controls.Add(this.btLocFor);
            this.pnDados.Controls.Add(this.txtForCod);
            this.pnDados.Controls.Add(this.label9);
            this.pnDados.Controls.Add(this.label8);
            this.pnDados.Controls.Add(this.dgvItens);
            this.pnDados.Controls.Add(this.label7);
            this.pnDados.Controls.Add(this.dtDataIni);
            this.pnDados.Controls.Add(this.label6);
            this.pnDados.Controls.Add(this.cbTPagamento);
            this.pnDados.Controls.Add(this.txtTotalCompra);
            this.pnDados.Controls.Add(this.label5);
            this.pnDados.Controls.Add(this.label4);
            this.pnDados.Controls.Add(this.cbNParcelas);
            this.pnDados.Controls.Add(this.label3);
            this.pnDados.Controls.Add(this.dtDataCompra);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.txtNFiscal);
            this.pnDados.Controls.Add(this.txtComCod);
            this.pnDados.Controls.Add(this.label1);
            this.pnDados.Location = new System.Drawing.Point(4, 99);
            this.pnDados.Size = new System.Drawing.Size(795, 420);
            // 
            // pnBotoes
            // 
            this.pnBotoes.Location = new System.Drawing.Point(4, 523);
            this.pnBotoes.Size = new System.Drawing.Size(795, 54);
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
            // lbCadastroCategoria
            // 
            this.lbCadastroCategoria.AutoSize = true;
            this.lbCadastroCategoria.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadastroCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbCadastroCategoria.Location = new System.Drawing.Point(241, 28);
            this.lbCadastroCategoria.Name = "lbCadastroCategoria";
            this.lbCadastroCategoria.Size = new System.Drawing.Size(431, 38);
            this.lbCadastroCategoria.TabIndex = 1;
            this.lbCadastroCategoria.Text = "MOVIMENTAÇÃO DE COMPRA";
            this.lbCadastroCategoria.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbCadastroCategoria_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "CÓDIGO";
            // 
            // txtComCod
            // 
            this.txtComCod.BackColor = System.Drawing.Color.White;
            this.txtComCod.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtComCod.Enabled = false;
            this.txtComCod.Location = new System.Drawing.Point(10, 41);
            this.txtComCod.Name = "txtComCod";
            this.txtComCod.Size = new System.Drawing.Size(100, 20);
            this.txtComCod.TabIndex = 1;
            // 
            // txtNFiscal
            // 
            this.txtNFiscal.BackColor = System.Drawing.Color.White;
            this.txtNFiscal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNFiscal.Location = new System.Drawing.Point(10, 99);
            this.txtNFiscal.Name = "txtNFiscal";
            this.txtNFiscal.Size = new System.Drawing.Size(200, 20);
            this.txtNFiscal.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "NOTA FISCAL";
            // 
            // dtDataCompra
            // 
            this.dtDataCompra.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dtDataCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataCompra.Location = new System.Drawing.Point(10, 157);
            this.dtDataCompra.Name = "dtDataCompra";
            this.dtDataCompra.Size = new System.Drawing.Size(100, 20);
            this.dtDataCompra.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(6, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "DATA DA COMPRA";
            // 
            // cbNParcelas
            // 
            this.cbNParcelas.BackColor = System.Drawing.Color.White;
            this.cbNParcelas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbNParcelas.FormattingEnabled = true;
            this.cbNParcelas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbNParcelas.Location = new System.Drawing.Point(10, 212);
            this.cbNParcelas.Name = "cbNParcelas";
            this.cbNParcelas.Size = new System.Drawing.Size(121, 21);
            this.cbNParcelas.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(6, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "PARCELAS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(6, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 19);
            this.label5.TabIndex = 25;
            this.label5.Text = "TOTAL";
            // 
            // txtTotalCompra
            // 
            this.txtTotalCompra.BackColor = System.Drawing.Color.White;
            this.txtTotalCompra.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTotalCompra.Location = new System.Drawing.Point(40, 385);
            this.txtTotalCompra.Name = "txtTotalCompra";
            this.txtTotalCompra.Size = new System.Drawing.Size(100, 20);
            this.txtTotalCompra.TabIndex = 26;
            this.txtTotalCompra.Text = "0.00";
            // 
            // cbTPagamento
            // 
            this.cbTPagamento.BackColor = System.Drawing.Color.White;
            this.cbTPagamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbTPagamento.FormattingEnabled = true;
            this.cbTPagamento.Location = new System.Drawing.Point(10, 270);
            this.cbTPagamento.Name = "cbTPagamento";
            this.cbTPagamento.Size = new System.Drawing.Size(182, 21);
            this.cbTPagamento.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(6, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 19);
            this.label6.TabIndex = 21;
            this.label6.Text = "TIPO DE PAGAMENTO";
            // 
            // dtDataIni
            // 
            this.dtDataIni.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dtDataIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataIni.Location = new System.Drawing.Point(10, 329);
            this.dtDataIni.Name = "dtDataIni";
            this.dtDataIni.Size = new System.Drawing.Size(100, 20);
            this.dtDataIni.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label7.Location = new System.Drawing.Point(6, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 19);
            this.label7.TabIndex = 23;
            this.label7.Text = "DATA DA 1º PARCELA";
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.BackgroundColor = System.Drawing.Color.White;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proCod,
            this.forNome,
            this.forQtde,
            this.provund,
            this.proTotal});
            this.dgvItens.Location = new System.Drawing.Point(227, 212);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(556, 193);
            this.dgvItens.TabIndex = 28;
            this.dgvItens.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItens_CellDoubleClick);
            // 
            // proCod
            // 
            this.proCod.HeaderText = "Codigo";
            this.proCod.Name = "proCod";
            this.proCod.ReadOnly = true;
            this.proCod.Width = 50;
            // 
            // forNome
            // 
            this.forNome.HeaderText = "Nome";
            this.forNome.Name = "forNome";
            this.forNome.ReadOnly = true;
            this.forNome.Width = 250;
            // 
            // forQtde
            // 
            this.forQtde.HeaderText = "Quantidade";
            this.forQtde.Name = "forQtde";
            this.forQtde.ReadOnly = true;
            this.forQtde.Width = 70;
            // 
            // provund
            // 
            this.provund.HeaderText = "Valor Unitario";
            this.provund.Name = "provund";
            this.provund.ReadOnly = true;
            this.provund.Width = 70;
            // 
            // proTotal
            // 
            this.proTotal.HeaderText = "Valor Total";
            this.proTotal.Name = "proTotal";
            this.proTotal.ReadOnly = true;
            this.proTotal.Width = 70;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label8.Location = new System.Drawing.Point(223, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 19);
            this.label8.TabIndex = 8;
            this.label8.Text = "CÓDIGO DO PRODUTO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label9.Location = new System.Drawing.Point(126, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(198, 19);
            this.label9.TabIndex = 2;
            this.label9.Text = "CÓDIGO DO FORNECEDOR";
            // 
            // txtForCod
            // 
            this.txtForCod.BackColor = System.Drawing.Color.White;
            this.txtForCod.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtForCod.Location = new System.Drawing.Point(125, 41);
            this.txtForCod.Name = "txtForCod";
            this.txtForCod.Size = new System.Drawing.Size(199, 20);
            this.txtForCod.TabIndex = 3;
            this.txtForCod.Leave += new System.EventHandler(this.TxtForCod_Leave);
            // 
            // btLocFor
            // 
            this.btLocFor.BackColor = System.Drawing.Color.Transparent;
            this.btLocFor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLocFor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLocFor.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLocFor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btLocFor.Location = new System.Drawing.Point(339, 34);
            this.btLocFor.Name = "btLocFor";
            this.btLocFor.Size = new System.Drawing.Size(103, 27);
            this.btLocFor.TabIndex = 5;
            this.btLocFor.Text = "LOCALIZAR";
            this.btLocFor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btLocFor.UseVisualStyleBackColor = false;
            this.btLocFor.Click += new System.EventHandler(this.btLocFor_Click);
            // 
            // lbFornecedor
            // 
            this.lbFornecedor.AutoSize = true;
            this.lbFornecedor.BackColor = System.Drawing.Color.Transparent;
            this.lbFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbFornecedor.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFornecedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbFornecedor.Location = new System.Drawing.Point(336, 13);
            this.lbFornecedor.Name = "lbFornecedor";
            this.lbFornecedor.Size = new System.Drawing.Size(367, 19);
            this.lbFornecedor.TabIndex = 4;
            this.lbFornecedor.Text = "Click em localizar ou informe o código do Fornecedor";
            // 
            // txtProCod
            // 
            this.txtProCod.Location = new System.Drawing.Point(227, 99);
            this.txtProCod.Name = "txtProCod";
            this.txtProCod.Size = new System.Drawing.Size(165, 20);
            this.txtProCod.TabIndex = 9;
            this.txtProCod.Leave += new System.EventHandler(this.TxtProCod_Leave);
            // 
            // btLocProd
            // 
            this.btLocProd.BackColor = System.Drawing.Color.Transparent;
            this.btLocProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLocProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLocProd.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLocProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btLocProd.Location = new System.Drawing.Point(412, 92);
            this.btLocProd.Name = "btLocProd";
            this.btLocProd.Size = new System.Drawing.Size(106, 27);
            this.btLocProd.TabIndex = 11;
            this.btLocProd.Text = "LOCALIZAR";
            this.btLocProd.UseVisualStyleBackColor = false;
            this.btLocProd.Click += new System.EventHandler(this.BtLocProd_Click);
            // 
            // lbProduto
            // 
            this.lbProduto.AutoSize = true;
            this.lbProduto.BackColor = System.Drawing.Color.Transparent;
            this.lbProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbProduto.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbProduto.Location = new System.Drawing.Point(409, 70);
            this.lbProduto.Name = "lbProduto";
            this.lbProduto.Size = new System.Drawing.Size(342, 19);
            this.lbProduto.TabIndex = 10;
            this.lbProduto.Text = "Click em localizar ou informe o código do Produto";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label11.Location = new System.Drawing.Point(224, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 19);
            this.label11.TabIndex = 14;
            this.label11.Text = "QUANTIDADE";
            // 
            // txtQtde
            // 
            this.txtQtde.Location = new System.Drawing.Point(227, 157);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(106, 20);
            this.txtQtde.TabIndex = 15;
            this.txtQtde.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label12.Location = new System.Drawing.Point(384, 131);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 19);
            this.label12.TabIndex = 16;
            this.label12.Text = "VALOR UNITÁRIO";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(388, 157);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 17;
            this.txtValor.Text = "0.00";
            // 
            // btAddProd
            // 
            this.btAddProd.BackColor = System.Drawing.Color.Transparent;
            this.btAddProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAddProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddProd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btAddProd.Location = new System.Drawing.Point(493, 157);
            this.btAddProd.Name = "btAddProd";
            this.btAddProd.Size = new System.Drawing.Size(21, 21);
            this.btAddProd.TabIndex = 18;
            this.btAddProd.Text = "+";
            this.btAddProd.UseVisualStyleBackColor = false;
            this.btAddProd.Click += new System.EventHandler(this.btAddProd_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label10.Location = new System.Drawing.Point(224, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 19);
            this.label10.TabIndex = 27;
            this.label10.Text = "ITENS DA COMPRA";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label13.Location = new System.Drawing.Point(354, 158);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 19);
            this.label13.TabIndex = 29;
            this.label13.Text = "R$";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label14.Location = new System.Drawing.Point(6, 386);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 19);
            this.label14.TabIndex = 30;
            this.label14.Text = "R$";
            // 
            // frmMovimentacaoDeCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(809, 589);
            this.Controls.Add(this.lbCadastroCategoria);
            this.Name = "frmMovimentacaoDeCompra";
            this.Text = "MOVIMENTAÇÃO DE COMPRA";
            this.Load += new System.EventHandler(this.frmMovimentacaoDeCompra_Load);
            this.Controls.SetChildIndex(this.pnDados, 0);
            this.Controls.SetChildIndex(this.pnBotoes, 0);
            this.Controls.SetChildIndex(this.lbCadastroCategoria, 0);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCadastroCategoria;
        private System.Windows.Forms.TextBox txtTotalCompra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbNParcelas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtDataCompra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNFiscal;
        private System.Windows.Forms.TextBox txtComCod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtDataIni;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbTPagamento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbFornecedor;
        private System.Windows.Forms.Button btLocFor;
        private System.Windows.Forms.TextBox txtForCod;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbProduto;
        private System.Windows.Forms.Button btLocProd;
        private System.Windows.Forms.TextBox txtProCod;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btAddProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn proCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn forNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn forQtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn provund;
        private System.Windows.Forms.DataGridViewTextBoxColumn proTotal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
    }
}
