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
    public partial class frm_AlunoNovo : Form
    {
        public frm_AlunoNovo()
        {
            InitializeComponent();
        }

        private void frm_AlunoNovo_Load(object sender, EventArgs e)
        {
            //************ Populando ComboBoxStatus

            //***************** popular comboBox Status ************************

            Dictionary<string, string> _status = new Dictionary<string, string>();

            //_status.Add("Key", "Value");
            _status.Add("A", "Ativa");
            _status.Add("P", "Paralisada");
            _status.Add("C", "Cancelada");

            cbx_Status.Items.Clear();
            cbx_Status.DataSource = new BindingSource(_status, null); //DataSource = _status  DataMember=null
            cbx_Status.DisplayMember = "Value";
            cbx_Status.ValueMember = "Key";
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DesativaCampos();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            txt_nome.Enabled = true;
            txt_email.Enabled = true;
            txt_plano.Enabled = true;
            txt_turma.Enabled = true;
            cbx_Status.Enabled = true;
            mtb_telefone.Enabled = true;
            txt_nome.Clear();
            txt_email.Clear();
            txt_plano.Clear();
            txt_turma.Clear();
            cbx_Status.Text = "";
            mtb_telefone.Clear();
            btn_cancelar.Enabled = true;
            btn_salvar.Enabled = true;
            btn_novo.Enabled = false;
            btn_plano.Enabled = true;
            btn_turma.Enabled = true;
            txt_nome.Focus();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            
            Aluno aluno = new Aluno();

            aluno.Nome = txt_nome.Text;
            aluno.Telefone = mtb_telefone.Text;
            aluno.Status = cbx_Status.SelectedValue.ToString();
            aluno.IdTurma = int.Parse(txt_turma.Tag.ToString());
            aluno.Plano = txt_plano.Text;
            
            string query = String.Format(@"
                INSERT INTO tb_alunos 
                    (T_NOMEALUNO, T_TELEFONE,T_STATUS,N_IDTURMA) 
                VALUES 
                    ('{0}','{1}','{2}',{3})", aluno.Nome, aluno.Telefone, aluno.Status, aluno.IdTurma);

            Banco.dml(query);
            DesativaCampos();
        }

        private void DesativaCampos()
        {
            txt_nome.Clear();
            txt_email.Clear();
            txt_plano.Clear();
            txt_turma.Clear();
            mtb_telefone.Clear();
            cbx_Status.Text = "";
            txt_nome.Enabled = false;
            txt_email.Enabled = false;
            txt_plano.Enabled = false;
            txt_turma.Enabled = false;
            cbx_Status.Enabled = false;
            mtb_telefone.Enabled = false;
            btn_cancelar.Enabled = false;
            btn_salvar.Enabled = false;
            btn_novo.Enabled = true;
            btn_plano.Enabled = false;
            btn_turma.Enabled = false;
        }

        private void btn_turma_Click(object sender, EventArgs e)
        {
            frm_SelecionarTurma selecionarTurma = new frm_SelecionarTurma(this);
            selecionarTurma.ShowDialog();   
        }
    }
}
