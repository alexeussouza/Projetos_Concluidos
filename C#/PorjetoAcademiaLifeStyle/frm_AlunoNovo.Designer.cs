namespace LifeStyle
{
    partial class frm_AlunoNovo
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
            this.pn_Inferior = new System.Windows.Forms.Panel();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtb_telefone = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbx_Status = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_turma = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_plano = new System.Windows.Forms.TextBox();
            this.btn_turma = new System.Windows.Forms.Button();
            this.btn_plano = new System.Windows.Forms.Button();
            this.pn_Inferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_Inferior
            // 
            this.pn_Inferior.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pn_Inferior.Controls.Add(this.btn_fechar);
            this.pn_Inferior.Controls.Add(this.btn_cancelar);
            this.pn_Inferior.Controls.Add(this.btn_salvar);
            this.pn_Inferior.Controls.Add(this.btn_novo);
            this.pn_Inferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_Inferior.Location = new System.Drawing.Point(0, 473);
            this.pn_Inferior.Name = "pn_Inferior";
            this.pn_Inferior.Size = new System.Drawing.Size(800, 43);
            this.pn_Inferior.TabIndex = 11;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(631, 7);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(145, 30);
            this.btn_fechar.TabIndex = 10;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Enabled = false;
            this.btn_cancelar.Location = new System.Drawing.Point(426, 7);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(145, 30);
            this.btn_cancelar.TabIndex = 9;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Enabled = false;
            this.btn_salvar.Location = new System.Drawing.Point(221, 7);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(145, 30);
            this.btn_salvar.TabIndex = 8;
            this.btn_salvar.Text = "Salvar Aluno";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.Location = new System.Drawing.Point(16, 7);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(145, 30);
            this.btn_novo.TabIndex = 7;
            this.btn_novo.Text = "Novo Aluno";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(508, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Telefone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Email";
            // 
            // txt_email
            // 
            this.txt_email.Enabled = false;
            this.txt_email.Location = new System.Drawing.Point(16, 70);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(410, 20);
            this.txt_email.TabIndex = 3;
            // 
            // txt_nome
            // 
            this.txt_nome.Enabled = false;
            this.txt_nome.Location = new System.Drawing.Point(16, 22);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(410, 20);
            this.txt_nome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Nome";
            // 
            // mtb_telefone
            // 
            this.mtb_telefone.Enabled = false;
            this.mtb_telefone.Location = new System.Drawing.Point(511, 22);
            this.mtb_telefone.Mask = "(99) 9999-9999";
            this.mtb_telefone.Name = "mtb_telefone";
            this.mtb_telefone.Size = new System.Drawing.Size(226, 20);
            this.mtb_telefone.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LifeStyle.Properties.Resources.foto3;
            this.pictureBox1.Location = new System.Drawing.Point(34, 193);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(726, 260);
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // cbx_Status
            // 
            this.cbx_Status.Enabled = false;
            this.cbx_Status.FormattingEnabled = true;
            this.cbx_Status.Location = new System.Drawing.Point(511, 69);
            this.cbx_Status.Name = "cbx_Status";
            this.cbx_Status.Size = new System.Drawing.Size(235, 21);
            this.cbx_Status.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(508, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Status";
            // 
            // txt_turma
            // 
            this.txt_turma.Location = new System.Drawing.Point(16, 115);
            this.txt_turma.Name = "txt_turma";
            this.txt_turma.ReadOnly = true;
            this.txt_turma.Size = new System.Drawing.Size(410, 20);
            this.txt_turma.TabIndex = 47;
            this.txt_turma.Tag = "8";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Turma";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Plano";
            // 
            // txt_plano
            // 
            this.txt_plano.Location = new System.Drawing.Point(16, 157);
            this.txt_plano.Name = "txt_plano";
            this.txt_plano.ReadOnly = true;
            this.txt_plano.Size = new System.Drawing.Size(410, 20);
            this.txt_plano.TabIndex = 49;
            // 
            // btn_turma
            // 
            this.btn_turma.Enabled = false;
            this.btn_turma.Location = new System.Drawing.Point(432, 115);
            this.btn_turma.Name = "btn_turma";
            this.btn_turma.Size = new System.Drawing.Size(30, 23);
            this.btn_turma.TabIndex = 5;
            this.btn_turma.Text = "....";
            this.btn_turma.UseVisualStyleBackColor = true;
            this.btn_turma.Click += new System.EventHandler(this.btn_turma_Click);
            // 
            // btn_plano
            // 
            this.btn_plano.Enabled = false;
            this.btn_plano.Location = new System.Drawing.Point(432, 155);
            this.btn_plano.Name = "btn_plano";
            this.btn_plano.Size = new System.Drawing.Size(30, 23);
            this.btn_plano.TabIndex = 6;
            this.btn_plano.Text = "....";
            this.btn_plano.UseVisualStyleBackColor = true;
            // 
            // frm_AlunoNovo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.btn_plano);
            this.Controls.Add(this.btn_turma);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_plano);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_turma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbx_Status);
            this.Controls.Add(this.mtb_telefone);
            this.Controls.Add(this.pn_Inferior);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frm_AlunoNovo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_AlunoNovo";
            this.Load += new System.EventHandler(this.frm_AlunoNovo_Load);
            this.pn_Inferior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pn_Inferior;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtb_telefone;
        private System.Windows.Forms.ComboBox cbx_Status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_plano;
        private System.Windows.Forms.Button btn_turma;
        private System.Windows.Forms.Button btn_plano;
        public System.Windows.Forms.TextBox txt_turma;
    }
}