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
    public partial class frmLocalizarRaca : Form
    {
        public frmLocalizarRaca()
        {
            InitializeComponent();
        }

        private void racaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.racaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetPetshop2022);

        }

        private void frmLocalizarRaca_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSetPetshop2022.raca'. Você pode movê-la ou removê-la conforme necessário.
            this.racaTableAdapter.Fill(this.dataSetPetshop2022.raca);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            racaBindingSource.Filter = "raca_nome like '" + txtNome.Text + "%'";
        }

        private void racaDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ClasseGlobal.CoditoTroca = int.Parse(racaDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar o registro. " + erro.Message, "PetShop Faisca", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClasseGlobal.CoditoTroca = 0;
            }
            this.Dispose();
            
        }
    }
}
