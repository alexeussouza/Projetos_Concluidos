namespace ControleAcesso
{
    partial class frmUsuarios
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AdicionartoolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.EditartoolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.ConsultartoolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.ExcluirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SelecionartoolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(775, 386);
            this.dataGridView1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AdicionartoolStripButton1,
            this.toolStripSeparator2,
            this.EditartoolStripButton3,
            this.ConsultartoolStripButton2,
            this.ExcluirToolStripButton,
            this.toolStripSeparator,
            this.toolStripSeparator1,
            this.SelecionartoolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AdicionartoolStripButton1
            // 
            this.AdicionartoolStripButton1.Image = global::ControleAcesso.Properties.Resources.icons8_mais_25666;
            this.AdicionartoolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AdicionartoolStripButton1.Name = "AdicionartoolStripButton1";
            this.AdicionartoolStripButton1.Size = new System.Drawing.Size(78, 22);
            this.AdicionartoolStripButton1.Text = "&Adicionar";
            this.AdicionartoolStripButton1.ToolTipText = "Adicionar um usuário";
            this.AdicionartoolStripButton1.Click += new System.EventHandler(this.AdicionartoolStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // EditartoolStripButton3
            // 
            this.EditartoolStripButton3.Image = global::ControleAcesso.Properties.Resources.icons8_editar_256;
            this.EditartoolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditartoolStripButton3.Name = "EditartoolStripButton3";
            this.EditartoolStripButton3.Size = new System.Drawing.Size(57, 22);
            this.EditartoolStripButton3.Text = "&Editar";
            this.EditartoolStripButton3.ToolTipText = "Editar um usuário";
            this.EditartoolStripButton3.Click += new System.EventHandler(this.EditartoolStripButton3_Click);
            // 
            // ConsultartoolStripButton2
            // 
            this.ConsultartoolStripButton2.Image = global::ControleAcesso.Properties.Resources.icons8_pesquisar_256;
            this.ConsultartoolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ConsultartoolStripButton2.Name = "ConsultartoolStripButton2";
            this.ConsultartoolStripButton2.Size = new System.Drawing.Size(78, 22);
            this.ConsultartoolStripButton2.Text = "&Consultar";
            this.ConsultartoolStripButton2.ToolTipText = "Consultar um usuário";
            this.ConsultartoolStripButton2.Click += new System.EventHandler(this.ConsultartoolStripButton2_Click);
            // 
            // ExcluirToolStripButton
            // 
            this.ExcluirToolStripButton.Image = global::ControleAcesso.Properties.Resources.icons8_lixo_256;
            this.ExcluirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExcluirToolStripButton.Name = "ExcluirToolStripButton";
            this.ExcluirToolStripButton.Size = new System.Drawing.Size(62, 22);
            this.ExcluirToolStripButton.Text = "&Excluir";
            this.ExcluirToolStripButton.ToolTipText = "Excluir um usuário";
            this.ExcluirToolStripButton.Click += new System.EventHandler(this.ExcluirToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // SelecionartoolStripButton
            // 
            this.SelecionartoolStripButton.Image = global::ControleAcesso.Properties.Resources.icons8_pesquisar_256;
            this.SelecionartoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SelecionartoolStripButton.Name = "SelecionartoolStripButton";
            this.SelecionartoolStripButton.Size = new System.Drawing.Size(81, 22);
            this.SelecionartoolStripButton.Text = "&Selecionar";
            this.SelecionartoolStripButton.ToolTipText = "Selecionar um usuário";
            this.SelecionartoolStripButton.Click += new System.EventHandler(this.SelecionartoolStripButton_Click);
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Usuários";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ExcluirToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton AdicionartoolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton ConsultartoolStripButton2;
        private System.Windows.Forms.ToolStripButton EditartoolStripButton3;
        private System.Windows.Forms.ToolStripButton SelecionartoolStripButton;
    }
}