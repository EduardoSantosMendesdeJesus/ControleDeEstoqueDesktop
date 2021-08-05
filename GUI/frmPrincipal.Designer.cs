namespace Formulario
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unidadeDeMedidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDePagamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.subCategoriaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.unidadeDeMedidaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDePagamentoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçãoDoBancoDeDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupDoBancoDeDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.explorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blocoDeNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powerPointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outlookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbFechar = new System.Windows.Forms.PictureBox();
            this.pbMinimizar = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.movimentaçãoToolStripMenuItem,
            this.relatorioToolStripMenuItem,
            this.ferramentasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(72, 5);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(473, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "MENU";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriaToolStripMenuItem,
            this.subCategoriaToolStripMenuItem,
            this.unidadeDeMedidaToolStripMenuItem,
            this.produtoToolStripMenuItem,
            this.toolStripSeparator1,
            this.clienteToolStripMenuItem,
            this.fornecedorToolStripMenuItem,
            this.tipoDePagamentoToolStripMenuItem});
            this.cadastroToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(82, 23);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // subCategoriaToolStripMenuItem
            // 
            this.subCategoriaToolStripMenuItem.Name = "subCategoriaToolStripMenuItem";
            this.subCategoriaToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.subCategoriaToolStripMenuItem.Text = "SubCategoria";
            this.subCategoriaToolStripMenuItem.Click += new System.EventHandler(this.subCategoriaToolStripMenuItem_Click);
            // 
            // unidadeDeMedidaToolStripMenuItem
            // 
            this.unidadeDeMedidaToolStripMenuItem.Name = "unidadeDeMedidaToolStripMenuItem";
            this.unidadeDeMedidaToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.unidadeDeMedidaToolStripMenuItem.Text = "Unidade de Medida";
            this.unidadeDeMedidaToolStripMenuItem.Click += new System.EventHandler(this.unidadeDeMedidaToolStripMenuItem_Click);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.produtoToolStripMenuItem.Text = "Produto";
            this.produtoToolStripMenuItem.Click += new System.EventHandler(this.produtoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(204, 6);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // fornecedorToolStripMenuItem
            // 
            this.fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            this.fornecedorToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.fornecedorToolStripMenuItem.Text = "Fornecedor";
            this.fornecedorToolStripMenuItem.Click += new System.EventHandler(this.fornecedorToolStripMenuItem_Click);
            // 
            // tipoDePagamentoToolStripMenuItem
            // 
            this.tipoDePagamentoToolStripMenuItem.Name = "tipoDePagamentoToolStripMenuItem";
            this.tipoDePagamentoToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.tipoDePagamentoToolStripMenuItem.Text = "Tipo de Pagamento";
            this.tipoDePagamentoToolStripMenuItem.Click += new System.EventHandler(this.tipoDePagamentoToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriaToolStripMenuItem1,
            this.subCategoriaToolStripMenuItem1,
            this.unidadeDeMedidaToolStripMenuItem1,
            this.produtoToolStripMenuItem1,
            this.toolStripSeparator2,
            this.clienteToolStripMenuItem1,
            this.fornecedorToolStripMenuItem1,
            this.tipoDePagamentoToolStripMenuItem1});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(77, 23);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // categoriaToolStripMenuItem1
            // 
            this.categoriaToolStripMenuItem1.Name = "categoriaToolStripMenuItem1";
            this.categoriaToolStripMenuItem1.Size = new System.Drawing.Size(207, 24);
            this.categoriaToolStripMenuItem1.Text = "Categoria";
            this.categoriaToolStripMenuItem1.Click += new System.EventHandler(this.categoriaToolStripMenuItem1_Click);
            // 
            // subCategoriaToolStripMenuItem1
            // 
            this.subCategoriaToolStripMenuItem1.Name = "subCategoriaToolStripMenuItem1";
            this.subCategoriaToolStripMenuItem1.Size = new System.Drawing.Size(207, 24);
            this.subCategoriaToolStripMenuItem1.Text = "SubCategoria";
            this.subCategoriaToolStripMenuItem1.Click += new System.EventHandler(this.subCategoriaToolStripMenuItem1_Click);
            // 
            // unidadeDeMedidaToolStripMenuItem1
            // 
            this.unidadeDeMedidaToolStripMenuItem1.Name = "unidadeDeMedidaToolStripMenuItem1";
            this.unidadeDeMedidaToolStripMenuItem1.Size = new System.Drawing.Size(207, 24);
            this.unidadeDeMedidaToolStripMenuItem1.Text = "Unidade de Medida";
            this.unidadeDeMedidaToolStripMenuItem1.Click += new System.EventHandler(this.unidadeDeMedidaToolStripMenuItem1_Click);
            // 
            // produtoToolStripMenuItem1
            // 
            this.produtoToolStripMenuItem1.Name = "produtoToolStripMenuItem1";
            this.produtoToolStripMenuItem1.Size = new System.Drawing.Size(207, 24);
            this.produtoToolStripMenuItem1.Text = "Produto";
            this.produtoToolStripMenuItem1.Click += new System.EventHandler(this.produtoToolStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(204, 6);
            // 
            // clienteToolStripMenuItem1
            // 
            this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            this.clienteToolStripMenuItem1.Size = new System.Drawing.Size(207, 24);
            this.clienteToolStripMenuItem1.Text = "Cliente";
            this.clienteToolStripMenuItem1.Click += new System.EventHandler(this.clienteToolStripMenuItem1_Click);
            // 
            // fornecedorToolStripMenuItem1
            // 
            this.fornecedorToolStripMenuItem1.Name = "fornecedorToolStripMenuItem1";
            this.fornecedorToolStripMenuItem1.Size = new System.Drawing.Size(207, 24);
            this.fornecedorToolStripMenuItem1.Text = "Fornecedor";
            this.fornecedorToolStripMenuItem1.Click += new System.EventHandler(this.fornecedorToolStripMenuItem1_Click);
            // 
            // tipoDePagamentoToolStripMenuItem1
            // 
            this.tipoDePagamentoToolStripMenuItem1.Name = "tipoDePagamentoToolStripMenuItem1";
            this.tipoDePagamentoToolStripMenuItem1.Size = new System.Drawing.Size(207, 24);
            this.tipoDePagamentoToolStripMenuItem1.Text = "Tipo de Pagamento";
            this.tipoDePagamentoToolStripMenuItem1.Click += new System.EventHandler(this.tipoDePagamentoToolStripMenuItem1_Click);
            // 
            // movimentaçãoToolStripMenuItem
            // 
            this.movimentaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compraToolStripMenuItem,
            this.vendaToolStripMenuItem});
            this.movimentaçãoToolStripMenuItem.Name = "movimentaçãoToolStripMenuItem";
            this.movimentaçãoToolStripMenuItem.Size = new System.Drawing.Size(114, 23);
            this.movimentaçãoToolStripMenuItem.Text = "Movimentação";
            // 
            // compraToolStripMenuItem
            // 
            this.compraToolStripMenuItem.Name = "compraToolStripMenuItem";
            this.compraToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.compraToolStripMenuItem.Text = "Compra";
            this.compraToolStripMenuItem.Click += new System.EventHandler(this.compraToolStripMenuItem_Click);
            // 
            // vendaToolStripMenuItem
            // 
            this.vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            this.vendaToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.vendaToolStripMenuItem.Text = "Venda";
            // 
            // relatorioToolStripMenuItem
            // 
            this.relatorioToolStripMenuItem.Name = "relatorioToolStripMenuItem";
            this.relatorioToolStripMenuItem.Size = new System.Drawing.Size(82, 23);
            this.relatorioToolStripMenuItem.Text = "Relatório";
            // 
            // ferramentasToolStripMenuItem
            // 
            this.ferramentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraçãoDoBancoDeDadosToolStripMenuItem,
            this.backupDoBancoDeDadosToolStripMenuItem,
            this.toolStripSeparator3,
            this.calculadoraToolStripMenuItem,
            this.explorerToolStripMenuItem,
            this.blocoDeNotasToolStripMenuItem,
            this.exelToolStripMenuItem,
            this.wordToolStripMenuItem,
            this.powerPointToolStripMenuItem,
            this.outlookToolStripMenuItem});
            this.ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            this.ferramentasToolStripMenuItem.Size = new System.Drawing.Size(108, 23);
            this.ferramentasToolStripMenuItem.Text = "Ferramentas";
            // 
            // configuraçãoDoBancoDeDadosToolStripMenuItem
            // 
            this.configuraçãoDoBancoDeDadosToolStripMenuItem.Name = "configuraçãoDoBancoDeDadosToolStripMenuItem";
            this.configuraçãoDoBancoDeDadosToolStripMenuItem.Size = new System.Drawing.Size(296, 24);
            this.configuraçãoDoBancoDeDadosToolStripMenuItem.Text = "Configuração do Banco de Dados";
            this.configuraçãoDoBancoDeDadosToolStripMenuItem.Click += new System.EventHandler(this.configuraçãoDoBancoDeDadosToolStripMenuItem_Click);
            // 
            // backupDoBancoDeDadosToolStripMenuItem
            // 
            this.backupDoBancoDeDadosToolStripMenuItem.Name = "backupDoBancoDeDadosToolStripMenuItem";
            this.backupDoBancoDeDadosToolStripMenuItem.Size = new System.Drawing.Size(296, 24);
            this.backupDoBancoDeDadosToolStripMenuItem.Text = "Backup do Banco de dados";
            this.backupDoBancoDeDadosToolStripMenuItem.Click += new System.EventHandler(this.backupDoBancoDeDadosToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(293, 6);
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(296, 24);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click);
            // 
            // explorerToolStripMenuItem
            // 
            this.explorerToolStripMenuItem.Name = "explorerToolStripMenuItem";
            this.explorerToolStripMenuItem.Size = new System.Drawing.Size(296, 24);
            this.explorerToolStripMenuItem.Text = "Explorer";
            this.explorerToolStripMenuItem.Click += new System.EventHandler(this.explorerToolStripMenuItem_Click);
            // 
            // blocoDeNotasToolStripMenuItem
            // 
            this.blocoDeNotasToolStripMenuItem.Name = "blocoDeNotasToolStripMenuItem";
            this.blocoDeNotasToolStripMenuItem.Size = new System.Drawing.Size(296, 24);
            this.blocoDeNotasToolStripMenuItem.Text = "Bloco de Notas";
            this.blocoDeNotasToolStripMenuItem.Click += new System.EventHandler(this.blocoDeNotasToolStripMenuItem_Click);
            // 
            // exelToolStripMenuItem
            // 
            this.exelToolStripMenuItem.Name = "exelToolStripMenuItem";
            this.exelToolStripMenuItem.Size = new System.Drawing.Size(296, 24);
            this.exelToolStripMenuItem.Text = "Excel";
            this.exelToolStripMenuItem.Click += new System.EventHandler(this.exelToolStripMenuItem_Click);
            // 
            // wordToolStripMenuItem
            // 
            this.wordToolStripMenuItem.Name = "wordToolStripMenuItem";
            this.wordToolStripMenuItem.Size = new System.Drawing.Size(296, 24);
            this.wordToolStripMenuItem.Text = "Word";
            this.wordToolStripMenuItem.Click += new System.EventHandler(this.wordToolStripMenuItem_Click);
            // 
            // powerPointToolStripMenuItem
            // 
            this.powerPointToolStripMenuItem.Name = "powerPointToolStripMenuItem";
            this.powerPointToolStripMenuItem.Size = new System.Drawing.Size(296, 24);
            this.powerPointToolStripMenuItem.Text = "PowerPoint";
            this.powerPointToolStripMenuItem.Click += new System.EventHandler(this.powerPointToolStripMenuItem_Click);
            // 
            // outlookToolStripMenuItem
            // 
            this.outlookToolStripMenuItem.Name = "outlookToolStripMenuItem";
            this.outlookToolStripMenuItem.Size = new System.Drawing.Size(296, 24);
            this.outlookToolStripMenuItem.Text = "Outlook";
            this.outlookToolStripMenuItem.Click += new System.EventHandler(this.outlookToolStripMenuItem_Click);
            // 
            // pbFechar
            // 
            this.pbFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFechar.BackColor = System.Drawing.Color.Transparent;
            this.pbFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFechar.Image = ((System.Drawing.Image)(resources.GetObject("pbFechar.Image")));
            this.pbFechar.Location = new System.Drawing.Point(587, 5);
            this.pbFechar.Margin = new System.Windows.Forms.Padding(4);
            this.pbFechar.Name = "pbFechar";
            this.pbFechar.Size = new System.Drawing.Size(27, 27);
            this.pbFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFechar.TabIndex = 7;
            this.pbFechar.TabStop = false;
            this.pbFechar.Click += new System.EventHandler(this.pbFechar_Click);
            // 
            // pbMinimizar
            // 
            this.pbMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.pbMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pbMinimizar.Image")));
            this.pbMinimizar.Location = new System.Drawing.Point(559, 5);
            this.pbMinimizar.Margin = new System.Windows.Forms.Padding(4);
            this.pbMinimizar.Name = "pbMinimizar";
            this.pbMinimizar.Size = new System.Drawing.Size(27, 27);
            this.pbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMinimizar.TabIndex = 10;
            this.pbMinimizar.TabStop = false;
            this.pbMinimizar.Click += new System.EventHandler(this.pbMinimizar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(617, 400);
            this.Controls.Add(this.pbMinimizar);
            this.Controls.Add(this.pbFechar);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrincipal";
            this.Opacity = 0.7D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMA DE CONTROLE DE ESTOQUE";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmPrincipal_MouseDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unidadeDeMedidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ferramentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem subCategoriaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem unidadeDeMedidaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem configuraçãoDoBancoDeDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupDoBancoDeDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem explorerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blocoDeNotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem powerPointToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outlookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDePagamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDePagamentoToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pbFechar;
        private System.Windows.Forms.PictureBox pbMinimizar;
        private System.Windows.Forms.ToolStripMenuItem compraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendaToolStripMenuItem;
    }
}

