namespace LifeStyle
{
    partial class frm_Turmas
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
            System.Windows.Forms.Panel pn_inferior;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Imprimir = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.dgv_turmas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.nud_MaxAlunos = new System.Windows.Forms.NumericUpDown();
            this.cbx_Status = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_professores = new System.Windows.Forms.ComboBox();
            this.cbx_Horario = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_dscTurma = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_vagas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            pn_inferior = new System.Windows.Forms.Panel();
            pn_inferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_turmas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MaxAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_inferior
            // 
            pn_inferior.BackColor = System.Drawing.SystemColors.ButtonFace;
            pn_inferior.Controls.Add(this.btn_Imprimir);
            pn_inferior.Controls.Add(this.btn_fechar);
            pn_inferior.Controls.Add(this.btn_excluir);
            pn_inferior.Controls.Add(this.btn_salvar);
            pn_inferior.Controls.Add(this.btn_novo);
            pn_inferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            pn_inferior.Location = new System.Drawing.Point(0, 484);
            pn_inferior.Name = "pn_inferior";
            pn_inferior.Size = new System.Drawing.Size(800, 32);
            pn_inferior.TabIndex = 11;
            // 
            // btn_Imprimir
            // 
            this.btn_Imprimir.Location = new System.Drawing.Point(492, 3);
            this.btn_Imprimir.Name = "btn_Imprimir";
            this.btn_Imprimir.Size = new System.Drawing.Size(134, 23);
            this.btn_Imprimir.TabIndex = 9;
            this.btn_Imprimir.Text = "Imprimir Turma";
            this.btn_Imprimir.UseVisualStyleBackColor = true;
            this.btn_Imprimir.Click += new System.EventHandler(this.btn_Imprimir_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(643, 3);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(134, 23);
            this.btn_fechar.TabIndex = 10;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(341, 3);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(134, 23);
            this.btn_excluir.TabIndex = 8;
            this.btn_excluir.Text = "Excluir Turma";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(190, 3);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(134, 23);
            this.btn_salvar.TabIndex = 7;
            this.btn_salvar.Text = "Salvar Turma";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.Location = new System.Drawing.Point(39, 3);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(134, 23);
            this.btn_novo.TabIndex = 6;
            this.btn_novo.Text = "Novo Turma";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // dgv_turmas
            // 
            this.dgv_turmas.AllowUserToAddRows = false;
            this.dgv_turmas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_turmas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_turmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_turmas.Location = new System.Drawing.Point(13, 13);
            this.dgv_turmas.MultiSelect = false;
            this.dgv_turmas.Name = "dgv_turmas";
            this.dgv_turmas.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_turmas.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_turmas.RowHeadersVisible = false;
            this.dgv_turmas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_turmas.Size = new System.Drawing.Size(446, 465);
            this.dgv_turmas.TabIndex = 0;
            this.dgv_turmas.SelectionChanged += new System.EventHandler(this.dgv_turmas_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(465, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Professor";
            // 
            // nud_MaxAlunos
            // 
            this.nud_MaxAlunos.Location = new System.Drawing.Point(468, 138);
            this.nud_MaxAlunos.Name = "nud_MaxAlunos";
            this.nud_MaxAlunos.Size = new System.Drawing.Size(157, 20);
            this.nud_MaxAlunos.TabIndex = 3;
            // 
            // cbx_Status
            // 
            this.cbx_Status.FormattingEnabled = true;
            this.cbx_Status.Location = new System.Drawing.Point(631, 138);
            this.cbx_Status.Name = "cbx_Status";
            this.cbx_Status.Size = new System.Drawing.Size(157, 21);
            this.cbx_Status.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(468, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Max. Alunos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(631, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Status";
            // 
            // cbx_professores
            // 
            this.cbx_professores.FormattingEnabled = true;
            this.cbx_professores.Location = new System.Drawing.Point(468, 85);
            this.cbx_professores.Name = "cbx_professores";
            this.cbx_professores.Size = new System.Drawing.Size(320, 21);
            this.cbx_professores.TabIndex = 2;
            // 
            // cbx_Horario
            // 
            this.cbx_Horario.FormattingEnabled = true;
            this.cbx_Horario.Location = new System.Drawing.Point(468, 187);
            this.cbx_Horario.Name = "cbx_Horario";
            this.cbx_Horario.Size = new System.Drawing.Size(320, 21);
            this.cbx_Horario.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(465, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Horário";
            // 
            // txt_dscTurma
            // 
            this.txt_dscTurma.Location = new System.Drawing.Point(468, 30);
            this.txt_dscTurma.Name = "txt_dscTurma";
            this.txt_dscTurma.Size = new System.Drawing.Size(317, 20);
            this.txt_dscTurma.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(465, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Turma";
            // 
            // txt_vagas
            // 
            this.txt_vagas.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_vagas.Location = new System.Drawing.Point(468, 257);
            this.txt_vagas.Name = "txt_vagas";
            this.txt_vagas.ReadOnly = true;
            this.txt_vagas.Size = new System.Drawing.Size(157, 20);
            this.txt_vagas.TabIndex = 18;
            this.txt_vagas.TabStop = false;
            this.txt_vagas.TextChanged += new System.EventHandler(this.txt_vagas_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(468, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Vagas";
            // 
            // frm_Turmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_vagas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_dscTurma);
            this.Controls.Add(this.cbx_Horario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbx_professores);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbx_Status);
            this.Controls.Add(this.nud_MaxAlunos);
            this.Controls.Add(this.label1);
            this.Controls.Add(pn_inferior);
            this.Controls.Add(this.dgv_turmas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frm_Turmas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turmas";
            this.Load += new System.EventHandler(this.frm_Turmas_Load);
            pn_inferior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_turmas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MaxAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_turmas;
        private System.Windows.Forms.Button btn_Imprimir;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nud_MaxAlunos;
        private System.Windows.Forms.ComboBox cbx_Status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_professores;
        private System.Windows.Forms.ComboBox cbx_Horario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_dscTurma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_vagas;
        private System.Windows.Forms.Label label6;
    }
}