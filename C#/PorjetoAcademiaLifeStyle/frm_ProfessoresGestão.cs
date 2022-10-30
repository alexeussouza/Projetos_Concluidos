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
    public partial class frm_ProfessoresGestão : Form
    {
        int idSelecionado = 0;
        int modoSalvar = 0;
        public frm_ProfessoresGestão()
        {
            InitializeComponent();
        }

        private void frm_Professores_Load(object sender, EventArgs e)
        {
            AtualizaDataGridView();
        }
        private void dgv_ProfessorGestao_SelectionChanged(object sender, EventArgs e)
        {
            string query = "";
            DataGridView dgv = (DataGridView)sender;

            int linha = dgv.SelectedRows.Count;

            if(linha > 0)
            {
                idSelecionado = int.Parse(dgv.SelectedRows[0].Cells[0].Value.ToString());

                query = "SELECT * FROM tb_professores WHERE N_IDPROFESSOR=" + idSelecionado;
                DataTable dt = Banco.dql(query);

                if(dt.Rows.Count > 0)
                {
                    txt_IdProfessor.Text = dt.Rows[0].ItemArray[0].ToString();
                    txt_nome.Text = dt.Rows[0].ItemArray[1].ToString();
                    txt_telefone.Text = dt.Rows[0].ItemArray[2].ToString();
                    txt_email.Text = dt.Rows[0].ItemArray[3].ToString();
                }
            }
        }
        private void btn_novo_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            txt_nome.Focus();
            modoSalvar = 1;
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            string query = "";
            Professor p = new Professor();
            p.NomeProfessor = txt_nome.Text;
            p.Telefone = txt_telefone.Text;
            p.Email = txt_email.Text;

            if (modoSalvar == 0)
            {
                // query = "UPDATE tb_usuarios SET T_NOMEUSUARIO='" + u.Nome + "', T_USERNAME='" + u.UserName + "', T_SENHAUSUARIO='" + u.Password +"', T_STATUSUSUARIO='" + u.Status +"', N_NIVELUSUARIO=" + u.Nivel  + " WHERE N_IDUSUARIO=" + idSelecionado;
                query = String.Format("UPDATE tb_professores SET T_NOMEPROFESSOR='{0}', T_TELEFONE='{1}', T_EMAIL='{2}' WHERE N_IDPROFESSOR={3}", p.NomeProfessor, p.Telefone, p.Email, idSelecionado);
            }
            else
            {
                query = string.Format("INSERT INTO tb_professores (T_NOMEPROFESSOR, T_TELEFONE, T_EMAIL) VALUES ('{0}', '{1}', '{2}')", p.NomeProfessor, p.Telefone, p.Email);

            }

            Banco.dml(query);
            modoSalvar = 0; // Modo edição ativado
            AtualizaDataGridView();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            string query = "";
            DialogResult res = MessageBox.Show("Confirma a exclusão?", "Academia Life Style", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {
                query = "DELETE FROM tb_professores WHERE N_IDPROFESSOR=" + idSelecionado;
                Banco.dml(query);
                AtualizaDataGridView();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            AtualizaDataGridView();
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

        private void AtualizaDataGridView()
        {
            string query = "SELECT N_IDPROFESSOR AS 'Id Professor', T_NOMEPROFESSOR AS 'Nome', T_TELEFONE AS 'Telefone' FROM tb_professores";
            dgv_ProfessorGestao.DataSource = Banco.dql(query);
            dgv_ProfessorGestao.Columns[0].Width = 90;
            dgv_ProfessorGestao.Columns[1].Width = 160;
            dgv_ProfessorGestao.Columns[2].Width = 110;

        }
    }
}
