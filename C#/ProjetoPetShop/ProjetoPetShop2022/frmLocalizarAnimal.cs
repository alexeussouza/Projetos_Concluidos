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
    public partial class frmLocalizarAnimal : Form
    {
        public frmLocalizarAnimal()
        {
            InitializeComponent();
        }

        private void animalBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.view_AnimaisClientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetPetshop2022);

        }

        private void frmLocalizarAnimal_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSetPetshop2022.View_AnimaisClientes'. Você pode movê-la ou removê-la conforme necessário.
            this.view_AnimaisClientesTableAdapter.Fill(this.dataSetPetshop2022.View_AnimaisClientes);
            // TODO: esta linha de código carrega dados na tabela 'dataSetPetshop2022.animal'. Você pode movê-la ou removê-la conforme necessário.
            this.view_AnimaisClientesTableAdapter.Fill(this.dataSetPetshop2022.View_AnimaisClientes);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
