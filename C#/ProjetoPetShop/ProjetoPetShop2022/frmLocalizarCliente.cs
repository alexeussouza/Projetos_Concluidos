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
    public partial class frmLocalizarCliente : Form
    {
        public frmLocalizarCliente()
        {
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetPetshop2022);

        }

        private void frmLocalizarCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSetPetshop2022.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.dataSetPetshop2022.cliente);

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            
            clienteBindingSource.Filter = "client_nome like '" + txtNome.Text + "%'";

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void clienteDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ClasseGlobal.CoditoTroca = int.Parse(clienteDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception erro)
            {
                ClasseGlobal.CoditoTroca = 0;
                MessageBox.Show("Erro ao selecionar registro de cliente", erro.Message);
            }
            this.Dispose(); //descarrega o formulario achando o registro ou não.



        }
    }
}
