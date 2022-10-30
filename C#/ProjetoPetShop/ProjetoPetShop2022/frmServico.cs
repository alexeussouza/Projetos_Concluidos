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
    public partial class frmServico : Form
    {
        public frmServico()
        {
            InitializeComponent();
        }

        private void btnSalvar_Servico_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.servicoBindingSource.EndEdit();
                servicoTableAdapter.Update(dataSetPetshop2022.servico);
                MessageBox.Show("Registro salvo com sucesso.", "Petshop 2022", MessageBoxButtons.OK, MessageBoxIcon.Information);
                groupBoxServicos.Enabled = false;   
                
                //this.tableAdapterManager.UpdateAll(this.petshop2022DataSet);
            }
            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu um erro ao salvar o registro." + erro, "Petshop 2022", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmServico_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSetPetshop2022.servico'. Você pode movê-la ou removê-la conforme necessário.
            this.servicoTableAdapter.Fill(this.dataSetPetshop2022.servico);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            servicoBindingSource.AddNew();
            groupBoxServicos.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupBoxServicos.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            servicoBindingSource.CancelEdit();
            groupBoxServicos.Enabled=false;
        }

        private void btnExcluir_Servico_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Confirma exclusão do registro?", "Petshop 2022", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    servicoBindingSource.EndEdit();
                    servicoBindingSource.RemoveCurrent();
                    servicoTableAdapter.Update(dataSetPetshop2022.servico);
                    MessageBox.Show("Registro excluído com sucesso.", "Petshop 2022", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception erro)
            {

                MessageBox.Show("Registro não pode ser excluído." + erro, "Petshop 2022", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.servicoTableAdapter.Fill(this.dataSetPetshop2022.servico);  
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            ClasseGlobal.CoditoTroca = 0;
            frmLocalizarServico frmServico = new frmLocalizarServico();
            frmServico.ShowDialog();

            if (ClasseGlobal.CoditoTroca > 0)
            {
                servicoBindingSource.Position = servicoBindingSource.Find("serv_id", ClasseGlobal.CoditoTroca);
            }
        }
    }
}
