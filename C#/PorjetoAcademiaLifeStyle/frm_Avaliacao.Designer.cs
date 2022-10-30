namespace LifeStyle
{
    partial class frm_Avaliacao
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
            this.nud_diaTreino = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_objetivo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nud_altura = new System.Windows.Forms.NumericUpDown();
            this.nud_peso = new System.Windows.Forms.NumericUpDown();
            this.nud_massaMagra = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.pn_inferior = new System.Windows.Forms.Panel();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_diaTreino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_altura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_peso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_massaMagra)).BeginInit();
            this.pn_inferior.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe o nº. de dias de treino.";
            // 
            // nud_diaTreino
            // 
            this.nud_diaTreino.Enabled = false;
            this.nud_diaTreino.Location = new System.Drawing.Point(18, 272);
            this.nud_diaTreino.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nud_diaTreino.Name = "nud_diaTreino";
            this.nud_diaTreino.Size = new System.Drawing.Size(148, 20);
            this.nud_diaTreino.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Peso KG";
            // 
            // cbx_objetivo
            // 
            this.cbx_objetivo.Enabled = false;
            this.cbx_objetivo.FormattingEnabled = true;
            this.cbx_objetivo.Items.AddRange(new object[] {
            "Hipertrofia",
            "Emagracimento",
            "Condicionamento"});
            this.cbx_objetivo.Location = new System.Drawing.Point(18, 81);
            this.cbx_objetivo.Name = "cbx_objetivo";
            this.cbx_objetivo.Size = new System.Drawing.Size(148, 21);
            this.cbx_objetivo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Objetivo";
            // 
            // txt_nome
            // 
            this.txt_nome.Enabled = false;
            this.txt_nome.Location = new System.Drawing.Point(15, 34);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(589, 20);
            this.txt_nome.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nome:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Altura Cm";
            // 
            // nud_altura
            // 
            this.nud_altura.Enabled = false;
            this.nud_altura.Location = new System.Drawing.Point(18, 222);
            this.nud_altura.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.nud_altura.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nud_altura.Name = "nud_altura";
            this.nud_altura.Size = new System.Drawing.Size(148, 20);
            this.nud_altura.TabIndex = 5;
            this.nud_altura.Value = new decimal(new int[] {
            160,
            0,
            0,
            0});
            // 
            // nud_peso
            // 
            this.nud_peso.DecimalPlaces = 2;
            this.nud_peso.Enabled = false;
            this.nud_peso.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nud_peso.Location = new System.Drawing.Point(18, 129);
            this.nud_peso.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.nud_peso.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nud_peso.Name = "nud_peso";
            this.nud_peso.Size = new System.Drawing.Size(148, 20);
            this.nud_peso.TabIndex = 3;
            this.nud_peso.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // nud_massaMagra
            // 
            this.nud_massaMagra.DecimalPlaces = 2;
            this.nud_massaMagra.Enabled = false;
            this.nud_massaMagra.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nud_massaMagra.Location = new System.Drawing.Point(18, 173);
            this.nud_massaMagra.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_massaMagra.Name = "nud_massaMagra";
            this.nud_massaMagra.Size = new System.Drawing.Size(148, 20);
            this.nud_massaMagra.TabIndex = 4;
            this.nud_massaMagra.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Massa Magra KG";
            // 
            // pn_inferior
            // 
            this.pn_inferior.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pn_inferior.Controls.Add(this.btn_cancelar);
            this.pn_inferior.Controls.Add(this.btn_fechar);
            this.pn_inferior.Controls.Add(this.btn_imprimir);
            this.pn_inferior.Controls.Add(this.btn_limpar);
            this.pn_inferior.Controls.Add(this.btn_novo);
            this.pn_inferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_inferior.Location = new System.Drawing.Point(0, 473);
            this.pn_inferior.Name = "pn_inferior";
            this.pn_inferior.Size = new System.Drawing.Size(800, 43);
            this.pn_inferior.TabIndex = 12;
            // 
            // btn_novo
            // 
            this.btn_novo.Location = new System.Drawing.Point(39, 3);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(130, 23);
            this.btn_novo.TabIndex = 7;
            this.btn_novo.Text = "Nova Avaliação";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Enabled = false;
            this.btn_limpar.Location = new System.Drawing.Point(189, 3);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(130, 23);
            this.btn_limpar.TabIndex = 8;
            this.btn_limpar.Text = "Limpar Avaliação";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Enabled = false;
            this.btn_imprimir.Location = new System.Drawing.Point(339, 3);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(130, 23);
            this.btn_imprimir.TabIndex = 9;
            this.btn_imprimir.Text = "Imprimir Avaliação";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(639, 3);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(130, 23);
            this.btn_fechar.TabIndex = 11;
            this.btn_fechar.Text = "Fechar ";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Enabled = false;
            this.btn_cancelar.Location = new System.Drawing.Point(489, 3);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(130, 23);
            this.btn_cancelar.TabIndex = 10;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // frm_Avaliacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.pn_inferior);
            this.Controls.Add(this.nud_massaMagra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nud_peso);
            this.Controls.Add(this.nud_altura);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbx_objetivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nud_diaTreino);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frm_Avaliacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Avaliação Física";
            ((System.ComponentModel.ISupportInitialize)(this.nud_diaTreino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_altura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_peso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_massaMagra)).EndInit();
            this.pn_inferior.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nud_diaTreino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_objetivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nud_altura;
        private System.Windows.Forms.NumericUpDown nud_peso;
        private System.Windows.Forms.NumericUpDown nud_massaMagra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pn_inferior;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_cancelar;
    }
}