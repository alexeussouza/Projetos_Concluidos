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
    public partial class frm_Horario : Form
    {
        int idSelecionado;
        public frm_Horario()
        {
            InitializeComponent();
        }

        private void frm_Horario_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void dgv_horarios_SelectionChanged(object sender, EventArgs e)
        {
            string query = "";
            DataGridView dgv = (DataGridView)sender;
            DataTable dt = new DataTable();

            int linha = dgv.SelectedRows.Count;

            if(linha > 0)
            {
                idSelecionado = int.Parse(dgv.SelectedRows[0].Cells[0].Value.ToString());
                query = "SELECT * FROM tb_horarios WHERE N_IDHORARIO=" + idSelecionado;
                dt = Banco.dql(query);

                if(dt.Rows.Count > 0)
                {
                    txt_id.Text = dt.Rows[0].ItemArray[0].ToString();
                    mtb_dscHorario.Text = dt.Rows[0].ItemArray[1].ToString();
                }
            }

        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            txt_id.Clear();
            mtb_dscHorario.Clear();
            mtb_dscHorario.Focus();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            string query = "";
            if(txt_id.Text != "")
            {
                query = "UPDATE tb_horarios SET T_DSCHORARIO='"+ mtb_dscHorario.Text + "' WHERE N_IDHORARIO= " + idSelecionado;

            }
            else
            {
                query = "INSERT INTO tb_horarios (T_DSCHORARIO) VALUES ('"+ mtb_dscHorario.Text + "')";

            }

            Banco.dml(query);
            CarregaGrid();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            string query = "";
            DialogResult res = MessageBox.Show("Confirma a exclusão?", "Academia Life Style", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ;

            if(res == DialogResult.Yes)
            {
                query = "DELETE FROM tb_horarios WHERE N_IDHORARIO=" + idSelecionado;

                Banco.dml(query);
                CarregaGrid();
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CarregaGrid()
        {
            string query = "SELECT N_IDHORARIO AS 'Id Horario', T_DSCHORARIO AS 'Horário' FROM tb_horarios";
            dgv_horarios.DataSource = Banco.dql(query);
            dgv_horarios.Columns[0].Width = 80;
            dgv_horarios.Columns[1].Width = 250;
        }

        
    }
}