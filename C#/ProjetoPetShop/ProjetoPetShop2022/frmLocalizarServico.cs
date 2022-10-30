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
    public partial class frmLocalizarServico : Form
    {
        public frmLocalizarServico()
        {
            InitializeComponent();
        }

        private void servicoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.servicoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetPetshop2022);

        }

        private void frmLocalizarServico_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSetPetshop2022.servico'. Você pode movê-la ou removê-la conforme necessário.
            this.servicoTableAdapter.Fill(this.dataSetPetshop2022.servico);

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            servicoBindingSource.Filter = "serv_descricao like '" + txtNome.Text + "%'";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void servicoDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ClasseGlobal.CoditoTroca = int.Parse(servicoDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar o registro. " + erro.Message, "Petshop Faisca", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClasseGlobal.CoditoTroca = 0;
            }
           
            this.Dispose();        
        }
    }
}
