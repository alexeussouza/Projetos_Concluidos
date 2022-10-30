using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleAcesso
{
    public partial class frmUsuarios : Form
    {
        Usuarios usuario = new Usuarios();

        public frmUsuarios()
        {
            InitializeComponent();
            dataGridView1.DataSource = Usuarios.BuscarTodos();
            
            ConfigurarGrade();
        }

        private void ConfigurarGrade()
        {

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9);
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 9);

            dataGridView1.Columns["id"].Visible = false;

            dataGridView1.Columns["email"].HeaderText = "Email";
            dataGridView1.Columns["email"].Width = 200;
            dataGridView1.Columns["email"].ReadOnly = true;

            dataGridView1.Columns["nome"].HeaderText = "Nome";
            dataGridView1.Columns["nome"].Width = 200;
            dataGridView1.Columns["nome"].ReadOnly = true;

            dataGridView1.Columns["nomecurto"].HeaderText = "Nome Curto";
            dataGridView1.Columns["nomecurto"].Width = 100;
            dataGridView1.Columns["nomecurto"].ReadOnly = true;

            dataGridView1.Columns["ativo"].HeaderText = "Ativo";
            dataGridView1.Columns["ativo"].Width = 100;
            dataGridView1.Columns["ativo"].ReadOnly = true;
            dataGridView1.Columns["ativo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["ativo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;  
        }

        private void AdicionartoolStripButton1_Click(object sender, EventArgs e)
        {
            ReiniciarUsuario(usuario);
            
            using (var frm = new frmUsuariosCadastrar(usuario, Operacao.Adicionar))
            {
                frm.ShowDialog();
                dataGridView1.DataSource = Usuarios.BuscarTodos();
            }
        }

        private void ReiniciarUsuario(Usuarios usuario)
        {
            usuario.Id = 0;
            usuario.Nome = "";
            usuario.NomeCurto = "";
            usuario.Email = "";
            usuario.Ativo = 'S';

        }

        private void EditartoolStripButton3_Click(object sender, EventArgs e)
        {
           
            //verifica se exite algum dado na Datagrid
            if (dataGridView1.Rows.Count > 0)
            {
                // transferindo os dados da grade (linha)  para o objeto usuario
                TransferirGradeParaUsuario();

                using (var frm = new frmUsuariosCadastrar(usuario, Operacao.Alterar))
                {
                    frm.ShowDialog();

                    // Se ocorrer erro ao salvar ou alterar os dados id recebe -1 em frmUsuariosCadastrar()
                    if (usuario.Id != -1)
                    {
                        dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["id"].Value = usuario.Id;

                        dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["email"].Value = usuario.Email;

                        dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["nome"].Value = usuario.Nome;

                        dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["nomeCurto"].Value = usuario.NomeCurto;

                        dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["ativo"].Value = usuario.Ativo;
                    }
                }
            }
        }

        private void ConsultartoolStripButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                TransferirGradeParaUsuario();

                using (var frm = new frmUsuariosCadastrar(usuario, Operacao.Consulta))
                {
                    frm.ShowDialog();

                    if (usuario.Id != -1)
                        dataGridView1.DataSource = Usuarios.BuscarTodos();
                }
            }
        }

        private void ExcluirToolStripButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                TransferirGradeParaUsuario();

                using (var frm = new frmUsuariosCadastrar(usuario, Operacao.Excluir))
                {
                    frm.ShowDialog();

                    if (usuario.Id != -1)
                        dataGridView1.DataSource = Usuarios.BuscarTodos();
                }
            }
        }

        public void TransferirGradeParaUsuario()
        {
            usuario.Id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["id"].Value);

            usuario.Email = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["email"].Value.ToString();

            usuario.Nome = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["nome"].Value.ToString();

            usuario.NomeCurto = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["nomeCurto"].Value.ToString();

            usuario.Ativo = Convert.ToChar(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["ativo"].Value);
        }

        private void SelecionartoolStripButton_Click(object sender, EventArgs e)
        {

        }
    }
}
