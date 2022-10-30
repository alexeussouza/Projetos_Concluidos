namespace LifeStyle
{
    partial class frm_ProfessoresGestão
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
            this.label12 = new System.Windows.Forms.Label();
            this.txt_IdProfessor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_telefone = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pn_Inferior = new System.Windows.Forms.Panel();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.dgv_ProfessorGestao = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pn_Inferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProfessorGestao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 2);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 58;
            this.label12.Text = "Id Professor";
            // 
            // txt_IdProfessor
            // 
            this.txt_IdProfessor.Location = new System.Drawing.Point(12, 19);
            this.txt_IdProfessor.Name = "txt_IdProfessor";
            this.txt_IdProfessor.Size = new System.Drawing.Size(201, 20);
            this.txt_IdProfessor.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Telefone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Email";
            // 
            // txt_telefone
            // 
            this.txt_telefone.Location = new System.Drawing.Point(12, 156);
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(201, 20);
            this.txt_telefone.TabIndex = 43;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(12, 108);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(410, 20);
            this.txt_email.TabIndex = 42;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(12, 60);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(410, 20);
            this.txt_nome.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Nome";
            // 
            // pn_Inferior
            // 
            this.pn_Inferior.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pn_Inferior.Controls.Add(this.btn_fechar);
            this.pn_Inferior.Controls.Add(this.btn_cancelar);
            this.pn_Inferior.Controls.Add(this.btn_excluir);
            this.pn_Inferior.Controls.Add(this.btn_salvar);
            this.pn_Inferior.Controls.Add(this.btn_novo);
            this.pn_Inferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_Inferior.Location = new System.Drawing.Point(0, 407);
            this.pn_Inferior.Name = "pn_Inferior";
            this.pn_Inferior.Size = new System.Drawing.Size(800, 43);
            this.pn_Inferior.TabIndex = 39;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(632, 7);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(145, 30);
            this.btn_fechar.TabIndex = 4;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(478, 7);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(145, 30);
            this.btn_cancelar.TabIndex = 3;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(324, 7);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(145, 30);
            this.btn_excluir.TabIndex = 2;
            this.btn_excluir.Text = "Excluir Professor";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(170, 7);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(145, 30);
            this.btn_salvar.TabIndex = 1;
            this.btn_salvar.Text = "Salvar Professor";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.Location = new System.Drawing.Point(16, 7);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(145, 30);
            this.btn_novo.TabIndex = 0;
            this.btn_novo.Text = "Novo Professor";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // dgv_ProfessorGestao
            // 
            this.dgv_ProfessorGestao.AllowUserToAddRows = false;
            this.dgv_ProfessorGestao.AllowUserToDeleteRows = false;
            this.dgv_ProfessorGestao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ProfessorGestao.Location = new System.Drawing.Point(442, 11);
            this.dgv_ProfessorGestao.MultiSelect = false;
            this.dgv_ProfessorGestao.Name = "dgv_ProfessorGestao";
            this.dgv_ProfessorGestao.ReadOnly = true;
            this.dgv_ProfessorGestao.RowHeadersVisible = false;
            this.dgv_ProfessorGestao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ProfessorGestao.Size = new System.Drawing.Size(346, 445);
            this.dgv_ProfessorGestao.TabIndex = 38;
            this.dgv_ProfessorGestao.TabStop = false;
            this.dgv_ProfessorGestao.SelectionChanged += new System.EventHandler(this.dgv_ProfessorGestao_SelectionChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LifeStyle.Properties.Resources.foto3;
            this.pictureBox1.Location = new System.Drawing.Point(12, 194);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(424, 207);
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // frm_Professores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_IdProfessor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_telefone);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pn_Inferior);
            this.Controls.Add(this.dgv_ProfessorGestao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frm_Professores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Professores";
            this.Load += new System.EventHandler(this.frm_Professores_Load);
            this.pn_Inferior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProfessorGestao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_IdProfessor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_telefone;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pn_Inferior;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.DataGridView dgv_ProfessorGestao;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}