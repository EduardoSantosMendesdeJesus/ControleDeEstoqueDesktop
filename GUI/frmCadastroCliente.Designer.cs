namespace Formulario
{
    partial class frmCadastroCliente
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
            this.lbNome = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbJuridica = new System.Windows.Forms.RadioButton();
            this.rbFisica = new System.Windows.Forms.RadioButton();
            this.lbRSocial = new System.Windows.Forms.Label();
            this.txtRSocial = new System.Windows.Forms.TextBox();
            this.lbCPFCNPJ = new System.Windows.Forms.Label();
            this.txtCPFCNPJ = new System.Windows.Forms.TextBox();
            this.lbRGIE = new System.Windows.Forms.Label();
            this.txtRGIE = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lbValorIncorreto = new System.Windows.Forms.Label();
            this.lbCadastroCliente = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.btcFoto = new System.Windows.Forms.Button();
            this.btrFoto = new System.Windows.Forms.Button();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnDados.Controls.Add(this.btrFoto);
            this.pnDados.Controls.Add(this.btcFoto);
            this.pnDados.Controls.Add(this.panel1);
            this.pnDados.Controls.Add(this.lbValorIncorreto);
            this.pnDados.Controls.Add(this.label10);
            this.pnDados.Controls.Add(this.label9);
            this.pnDados.Controls.Add(this.txtEmail);
            this.pnDados.Controls.Add(this.label8);
            this.pnDados.Controls.Add(this.txtBairro);
            this.pnDados.Controls.Add(this.label7);
            this.pnDados.Controls.Add(this.txtEstado);
            this.pnDados.Controls.Add(this.label5);
            this.pnDados.Controls.Add(this.txtCidade);
            this.pnDados.Controls.Add(this.label6);
            this.pnDados.Controls.Add(this.txtCep);
            this.pnDados.Controls.Add(this.label4);
            this.pnDados.Controls.Add(this.txtNumero);
            this.pnDados.Controls.Add(this.label3);
            this.pnDados.Controls.Add(this.txtRua);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.lbRGIE);
            this.pnDados.Controls.Add(this.lbCPFCNPJ);
            this.pnDados.Controls.Add(this.txtRSocial);
            this.pnDados.Controls.Add(this.lbRSocial);
            this.pnDados.Controls.Add(this.groupBox1);
            this.pnDados.Controls.Add(this.txtNome);
            this.pnDados.Controls.Add(this.txtCodigo);
            this.pnDados.Controls.Add(this.lbNome);
            this.pnDados.Controls.Add(this.label1);
            this.pnDados.Controls.Add(this.txtCelular);
            this.pnDados.Controls.Add(this.txtTelefone);
            this.pnDados.Controls.Add(this.txtRGIE);
            this.pnDados.Controls.Add(this.txtCPFCNPJ);
            this.pnDados.Location = new System.Drawing.Point(10, 97);
            this.pnDados.Size = new System.Drawing.Size(780, 453);
            // 
            // pnBotoes
            // 
            this.pnBotoes.Location = new System.Drawing.Point(10, 556);
            this.pnBotoes.Size = new System.Drawing.Size(780, 53);
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
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "CÓDIGO";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.BackColor = System.Drawing.Color.Transparent;
            this.lbNome.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbNome.Location = new System.Drawing.Point(10, 67);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(52, 19);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "NOME";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(10, 38);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(120, 20);
            this.txtCodigo.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(11, 92);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(760, 20);
            this.txtNome.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbJuridica);
            this.groupBox1.Controls.Add(this.rbFisica);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.Location = new System.Drawing.Point(147, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 47);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TIPO DO CLIENTE:";
            // 
            // rbJuridica
            // 
            this.rbJuridica.AutoSize = true;
            this.rbJuridica.BackColor = System.Drawing.Color.Transparent;
            this.rbJuridica.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbJuridica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rbJuridica.Location = new System.Drawing.Point(275, 18);
            this.rbJuridica.Name = "rbJuridica";
            this.rbJuridica.Size = new System.Drawing.Size(102, 23);
            this.rbJuridica.TabIndex = 1;
            this.rbJuridica.Text = "JURUDICA";
            this.rbJuridica.UseVisualStyleBackColor = false;
            // 
            // rbFisica
            // 
            this.rbFisica.AutoSize = true;
            this.rbFisica.BackColor = System.Drawing.Color.Transparent;
            this.rbFisica.Checked = true;
            this.rbFisica.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFisica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rbFisica.Location = new System.Drawing.Point(162, 18);
            this.rbFisica.Name = "rbFisica";
            this.rbFisica.Size = new System.Drawing.Size(81, 23);
            this.rbFisica.TabIndex = 0;
            this.rbFisica.TabStop = true;
            this.rbFisica.Text = "FISICA";
            this.rbFisica.UseVisualStyleBackColor = false;
            this.rbFisica.CheckedChanged += new System.EventHandler(this.rbFisica_CheckedChanged);
            // 
            // lbRSocial
            // 
            this.lbRSocial.AutoSize = true;
            this.lbRSocial.BackColor = System.Drawing.Color.Transparent;
            this.lbRSocial.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRSocial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbRSocial.Location = new System.Drawing.Point(8, 120);
            this.lbRSocial.Name = "lbRSocial";
            this.lbRSocial.Size = new System.Drawing.Size(121, 19);
            this.lbRSocial.TabIndex = 5;
            this.lbRSocial.Text = "RAZÃO SOCIAL";
            this.lbRSocial.Visible = false;
            // 
            // txtRSocial
            // 
            this.txtRSocial.Location = new System.Drawing.Point(9, 148);
            this.txtRSocial.Name = "txtRSocial";
            this.txtRSocial.Size = new System.Drawing.Size(760, 20);
            this.txtRSocial.TabIndex = 6;
            this.txtRSocial.Visible = false;
            // 
            // lbCPFCNPJ
            // 
            this.lbCPFCNPJ.AutoSize = true;
            this.lbCPFCNPJ.BackColor = System.Drawing.Color.Transparent;
            this.lbCPFCNPJ.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCPFCNPJ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbCPFCNPJ.Location = new System.Drawing.Point(8, 179);
            this.lbCPFCNPJ.Name = "lbCPFCNPJ";
            this.lbCPFCNPJ.Size = new System.Drawing.Size(34, 19);
            this.lbCPFCNPJ.TabIndex = 7;
            this.lbCPFCNPJ.Text = "CPF";
            // 
            // txtCPFCNPJ
            // 
            this.txtCPFCNPJ.Location = new System.Drawing.Point(8, 204);
            this.txtCPFCNPJ.Name = "txtCPFCNPJ";
            this.txtCPFCNPJ.Size = new System.Drawing.Size(355, 20);
            this.txtCPFCNPJ.TabIndex = 8;
            this.txtCPFCNPJ.Leave += new System.EventHandler(this.txtCPFCNPJ_Leave);
            // 
            // lbRGIE
            // 
            this.lbRGIE.AutoSize = true;
            this.lbRGIE.BackColor = System.Drawing.Color.Transparent;
            this.lbRGIE.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRGIE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbRGIE.Location = new System.Drawing.Point(413, 179);
            this.lbRGIE.Name = "lbRGIE";
            this.lbRGIE.Size = new System.Drawing.Size(28, 19);
            this.lbRGIE.TabIndex = 9;
            this.lbRGIE.Text = "RG";
            // 
            // txtRGIE
            // 
            this.txtRGIE.Location = new System.Drawing.Point(417, 204);
            this.txtRGIE.Name = "txtRGIE";
            this.txtRGIE.Size = new System.Drawing.Size(355, 20);
            this.txtRGIE.TabIndex = 10;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(148, 260);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(541, 20);
            this.txtRua.TabIndex = 14;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(701, 260);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(71, 20);
            this.txtNumero.TabIndex = 16;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(8, 260);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(120, 20);
            this.txtCep.TabIndex = 12;
            this.txtCep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCep_KeyPress);
            this.txtCep.Leave += new System.EventHandler(this.txtCep_Leave);
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(417, 315);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(272, 20);
            this.txtCidade.TabIndex = 20;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(8, 316);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(385, 20);
            this.txtBairro.TabIndex = 18;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(11, 423);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(760, 20);
            this.txtEmail.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label9.Location = new System.Drawing.Point(8, 344);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 19);
            this.label9.TabIndex = 23;
            this.label9.Text = "TELEFONE";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(8, 371);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(355, 20);
            this.txtTelefone.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label10.Location = new System.Drawing.Point(413, 344);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 19);
            this.label10.TabIndex = 25;
            this.label10.Text = "CELULAR";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(415, 371);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(355, 20);
            this.txtCelular.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label8.Location = new System.Drawing.Point(8, 398);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 19);
            this.label8.TabIndex = 27;
            this.label8.Text = "E-MAIL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label7.Location = new System.Drawing.Point(8, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "BAIRRO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(8, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "CEP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(412, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "CIDADE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(700, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "NÚMERO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(146, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "LOGRADOURO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(700, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 19);
            this.label5.TabIndex = 21;
            this.label5.Text = "UF";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(700, 314);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(71, 20);
            this.txtEstado.TabIndex = 22;
            // 
            // lbValorIncorreto
            // 
            this.lbValorIncorreto.AutoSize = true;
            this.lbValorIncorreto.BackColor = System.Drawing.Color.Transparent;
            this.lbValorIncorreto.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorIncorreto.ForeColor = System.Drawing.Color.Red;
            this.lbValorIncorreto.Location = new System.Drawing.Point(267, 179);
            this.lbValorIncorreto.Name = "lbValorIncorreto";
            this.lbValorIncorreto.Size = new System.Drawing.Size(96, 19);
            this.lbValorIncorreto.TabIndex = 29;
            this.lbValorIncorreto.Text = "INCORRETO";
            this.lbValorIncorreto.Visible = false;
            // 
            // lbCadastroCliente
            // 
            this.lbCadastroCliente.AutoSize = true;
            this.lbCadastroCliente.BackColor = System.Drawing.Color.Transparent;
            this.lbCadastroCliente.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadastroCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbCadastroCliente.Location = new System.Drawing.Point(215, 25);
            this.lbCadastroCliente.Name = "lbCadastroCliente";
            this.lbCadastroCliente.Size = new System.Drawing.Size(371, 38);
            this.lbCadastroCliente.TabIndex = 4;
            this.lbCadastroCliente.Text = "CADASTRO DE CLIENTES";
            this.lbCadastroCliente.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbCadastroCliente_MouseDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbFoto);
            this.panel1.Location = new System.Drawing.Point(683, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(88, 58);
            this.panel1.TabIndex = 30;
            // 
            // pbFoto
            // 
            this.pbFoto.BackColor = System.Drawing.Color.Transparent;
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFoto.Location = new System.Drawing.Point(0, 0);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(88, 58);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto.TabIndex = 0;
            this.pbFoto.TabStop = false;
            // 
            // btcFoto
            // 
            this.btcFoto.BackColor = System.Drawing.Color.Transparent;
            this.btcFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btcFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btcFoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btcFoto.Location = new System.Drawing.Point(567, 12);
            this.btcFoto.Name = "btcFoto";
            this.btcFoto.Size = new System.Drawing.Size(110, 23);
            this.btcFoto.TabIndex = 31;
            this.btcFoto.Text = "CARREGAR FOTO";
            this.btcFoto.UseVisualStyleBackColor = false;
            this.btcFoto.Click += new System.EventHandler(this.btcFoto_Click);
            // 
            // btrFoto
            // 
            this.btrFoto.BackColor = System.Drawing.Color.Transparent;
            this.btrFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btrFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btrFoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btrFoto.Location = new System.Drawing.Point(567, 46);
            this.btrFoto.Name = "btrFoto";
            this.btrFoto.Size = new System.Drawing.Size(110, 23);
            this.btrFoto.TabIndex = 32;
            this.btrFoto.Text = "REMOVER FOTO";
            this.btrFoto.UseVisualStyleBackColor = false;
            this.btrFoto.Click += new System.EventHandler(this.btrFoto_Click);
            // 
            // frmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(801, 626);
            this.Controls.Add(this.lbCadastroCliente);
            this.DoubleBuffered = true;
            this.Name = "frmCadastroCliente";
            this.Text = "CADASTRO DE CLIENTES";
            this.Load += new System.EventHandler(this.frmCadastroCliente_Load);
            this.Controls.SetChildIndex(this.pnDados, 0);
            this.Controls.SetChildIndex(this.pnBotoes, 0);
            this.Controls.SetChildIndex(this.lbCadastroCliente, 0);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRSocial;
        private System.Windows.Forms.Label lbRSocial;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbJuridica;
        private System.Windows.Forms.RadioButton rbFisica;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRGIE;
        private System.Windows.Forms.Label lbRGIE;
        private System.Windows.Forms.TextBox txtCPFCNPJ;
        private System.Windows.Forms.Label lbCPFCNPJ;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbValorIncorreto;
        private System.Windows.Forms.Label lbCadastroCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Button btcFoto;
        private System.Windows.Forms.Button btrFoto;
    }
}
