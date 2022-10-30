namespace ControleAcesso
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emitirNotaFiscalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarNotaFiscalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarNotaFiscalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarFaturamentoDoMesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comissãoDeVendedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acessoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controleDeAcessoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inativarEAtivarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acessoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.faturamentoToolStripMenuItem,
            this.acessoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1184, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.vendedoresToolStripMenuItem,
            this.fornecedoresToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 19);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // vendedoresToolStripMenuItem
            // 
            this.vendedoresToolStripMenuItem.Name = "vendedoresToolStripMenuItem";
            this.vendedoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vendedoresToolStripMenuItem.Text = "Vendedores";
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            // 
            // faturamentoToolStripMenuItem
            // 
            this.faturamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emitirNotaFiscalToolStripMenuItem,
            this.cancelarNotaFiscalToolStripMenuItem,
            this.consultarNotaFiscalToolStripMenuItem,
            this.consultarFaturamentoDoMesToolStripMenuItem,
            this.comissãoDeVendedoresToolStripMenuItem});
            this.faturamentoToolStripMenuItem.Name = "faturamentoToolStripMenuItem";
            this.faturamentoToolStripMenuItem.Size = new System.Drawing.Size(87, 19);
            this.faturamentoToolStripMenuItem.Text = "Faturamento";
            // 
            // emitirNotaFiscalToolStripMenuItem
            // 
            this.emitirNotaFiscalToolStripMenuItem.Name = "emitirNotaFiscalToolStripMenuItem";
            this.emitirNotaFiscalToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.emitirNotaFiscalToolStripMenuItem.Text = "Emitir Nota Fiscal";
            // 
            // cancelarNotaFiscalToolStripMenuItem
            // 
            this.cancelarNotaFiscalToolStripMenuItem.Name = "cancelarNotaFiscalToolStripMenuItem";
            this.cancelarNotaFiscalToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.cancelarNotaFiscalToolStripMenuItem.Text = "Cancelar Nota Fiscal";
            // 
            // consultarNotaFiscalToolStripMenuItem
            // 
            this.consultarNotaFiscalToolStripMenuItem.Name = "consultarNotaFiscalToolStripMenuItem";
            this.consultarNotaFiscalToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.consultarNotaFiscalToolStripMenuItem.Text = "Consultar Nota Fiscal";
            // 
            // consultarFaturamentoDoMesToolStripMenuItem
            // 
            this.consultarFaturamentoDoMesToolStripMenuItem.Name = "consultarFaturamentoDoMesToolStripMenuItem";
            this.consultarFaturamentoDoMesToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.consultarFaturamentoDoMesToolStripMenuItem.Text = "Consultar Faturamento do Mes";
            // 
            // comissãoDeVendedoresToolStripMenuItem
            // 
            this.comissãoDeVendedoresToolStripMenuItem.Name = "comissãoDeVendedoresToolStripMenuItem";
            this.comissãoDeVendedoresToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.comissãoDeVendedoresToolStripMenuItem.Text = "Comissão de Vendedores";
            // 
            // acessoToolStripMenuItem
            // 
            this.acessoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeUsuarioToolStripMenuItem,
            this.controleDeAcessoToolStripMenuItem});
            this.acessoToolStripMenuItem.Name = "acessoToolStripMenuItem";
            this.acessoToolStripMenuItem.Size = new System.Drawing.Size(56, 19);
            this.acessoToolStripMenuItem.Text = "Acesso";
            // 
            // cadastroDeUsuarioToolStripMenuItem
            // 
            this.cadastroDeUsuarioToolStripMenuItem.Name = "cadastroDeUsuarioToolStripMenuItem";
            this.cadastroDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastroDeUsuarioToolStripMenuItem.Text = "Cadastro de Usuario";
            this.cadastroDeUsuarioToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeUsuarioToolStripMenuItem_Click);
            // 
            // controleDeAcessoToolStripMenuItem
            // 
            this.controleDeAcessoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inativarEAtivarToolStripMenuItem,
            this.acessoToolStripMenuItem1});
            this.controleDeAcessoToolStripMenuItem.Name = "controleDeAcessoToolStripMenuItem";
            this.controleDeAcessoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.controleDeAcessoToolStripMenuItem.Text = "Controle de Acesso";
            // 
            // inativarEAtivarToolStripMenuItem
            // 
            this.inativarEAtivarToolStripMenuItem.Name = "inativarEAtivarToolStripMenuItem";
            this.inativarEAtivarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inativarEAtivarToolStripMenuItem.Text = "Inativar e Ativar";
            // 
            // acessoToolStripMenuItem1
            // 
            this.acessoToolStripMenuItem1.Name = "acessoToolStripMenuItem1";
            this.acessoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.acessoToolStripMenuItem1.Text = "Acesso";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 19);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 30);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1156, 452);
            this.dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(506, 510);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emitirNotaFiscalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelarNotaFiscalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarNotaFiscalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarFaturamentoDoMesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comissãoDeVendedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acessoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controleDeAcessoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inativarEAtivarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acessoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}

