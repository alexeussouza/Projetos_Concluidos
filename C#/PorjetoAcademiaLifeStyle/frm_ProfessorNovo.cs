using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeStyle
{
    public partial class frm_ProfessorNovo : Form
    {
        public frm_ProfessorNovo()
        {
            InitializeComponent();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            string query = "";
            Professor p = new Professor();
            p.NomeProfessor = txt_nome.Text;
            p.Telefone = txt_telefone.Text;
            p.Email = txt_email.Text;

            query = string.Format("INSERT INTO tb_professores (T_NOMEPROFESSOR, T_TELEFONE, T_EMAIL) VALUES ('{0}', '{1}', '{2}')", p.NomeProfessor, p.Telefone, p.Email);

            Banco.dml(query);
            LimpaCampos();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LimpaCampos()
        {
            txt_nome.Clear();
            txt_telefone.Clear();
            txt_email.Clear();
        }
    }
}
