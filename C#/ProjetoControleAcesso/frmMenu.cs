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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var opcoes = Opcoes.Criar(menuStrip1);
            dataGridView1.DataSource = opcoes.ToList();

            // Configura tamanho das colunas
            ConfigurarGrade();
            
            // executa metodo que salva menu na tabela do banco
           // Opcoes.SalvarMenu(opcoes);   
        }

        private void ConfigurarGrade()
        {

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9);
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 9);

            dataGridView1.Columns["id"].Visible = false;

            dataGridView1.Columns["nome"].HeaderText = "Nome";
            dataGridView1.Columns["nome"].Width = 300;
            dataGridView1.Columns["nome"].ReadOnly = true;

            dataGridView1.Columns["descricao"].HeaderText = "Descrição";
            dataGridView1.Columns["descricao"].Width = 380;
            dataGridView1.Columns["descricao"].ReadOnly = true;

            dataGridView1.Columns["nivel"].HeaderText = "Nivel";
            dataGridView1.Columns["nivel"].Width = 60;
            dataGridView1.Columns["nivel"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["nivel"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["nivel"].ReadOnly = true;

            // Adiciona coluna CheckBox ao DataGridView
            var acesso = new DataGridViewCheckBoxColumn();

            acesso.HeaderText = "Liberado";
            acesso.Width = 60;
            acesso.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            acesso.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns.Add(acesso);  

        }

        private void cadastroDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var frm = new frmUsuarios())
            {
                frm.ShowDialog();
            }
        }
    }
}
