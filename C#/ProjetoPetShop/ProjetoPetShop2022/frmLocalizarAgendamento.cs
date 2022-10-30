using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPetShop2022
{
    public partial class frmLocalizarAgendamento : Form
    {
        public frmLocalizarAgendamento()
        {
            InitializeComponent();
        }

        private void frmLocalizarAgendamento_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSetPetshop2022.View_AnimaisClientes'. Você pode movê-la ou removê-la conforme necessário.
            this.view_AnimaisClientesTableAdapter.Fill(this.dataSetPetshop2022.View_AnimaisClientes);
            
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            view_AnimaisClientesBindingSource.Filter = "anim_nome like '" + txtNome.Text + "%'";
        }

        private void view_AnimaisClientesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ClasseGlobal.CoditoTroca = int.Parse(view_AnimaisClientesDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                ClasseGlobal.CoditoTroca = 0;
                throw;
            }
            this.Dispose();
        }
    }
}
