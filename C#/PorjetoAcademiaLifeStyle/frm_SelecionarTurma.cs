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
    public partial class frm_SelecionarTurma : Form
    {
        frm_AlunoNovo formNovoAluno;
        public frm_SelecionarTurma(frm_AlunoNovo f)
        {
            InitializeComponent();
            formNovoAluno = f;      
        }

        private void frm_SelecionarTurma_Load(object sender, EventArgs e)
        {
            string query = string.Format(@"
            SELECT
                T.N_IDTURMA as 'Id Turma',
                T.T_DSCTURMA as 'Turma',
                H.T_DSCHORARIO as 'Horário',
                P.T_NOMEPROFESSOR as 'Professor',
                T.N_MAXALUNOS  as 'Max.Aluno',
                ( SELECT
                         count(N_IDALUNO) 
                    FROM
                         tb_alunos AS A
                    WHERE 
                         T.N_IDTURMA = A.N_IDTURMA AND T_STATUS='A'
                ) AS 'Qtde. Alunos'
            FROM
                tb_turmas as T
            INNER JOIN
            tb_horarios as H on H.N_IDHORARIO =  T.N_IDHORARIO,
            tb_professores as P on P.N_IDPROFESSOR = T.N_IDPROFESSOR
            ");

            dgv_SelecionarTurma.DataSource = Banco.dql(query);
        }

        private void dgv_SelecionarTurma_DoubleClick(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            int maxAlunos = 0;
            int qtdeAlunos = 0;

            maxAlunos = int.Parse(dgv.SelectedRows[0].Cells[4].Value.ToString());
            qtdeAlunos = int.Parse((dgv.SelectedRows[0].Cells[5].Value.ToString()).ToString());

            if(qtdeAlunos >= maxAlunos)
            {
                MessageBox.Show("Não há vagas nesta turma");
                return;
            }
            else
            {
                formNovoAluno.txt_turma.Text = dgv.Rows[dgv.SelectedRows[0].Index].Cells[1].Value.ToString(); // recebe a descrição no texto do campo
                formNovoAluno.txt_turma.Tag = dgv.Rows[dgv.SelectedRows[0].Index].Cells[0].Value.ToString(); // recebe o id na Tad do campo
                Close();
            }
        }
    }
}
