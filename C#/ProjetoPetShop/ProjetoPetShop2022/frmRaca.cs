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
    public partial class frmRaca : Form
    {
        public frmRaca()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.racaBindingSource.EndEdit();
                racaTableAdapter.Update(this.dataSetPetshop2022.raca);
                MessageBox.Show("Resgistro salvo com sucesso.");
                groupBoxRaca.Enabled = false;

            }
            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu um erro ao inserir os dados." + erro, "Petshop 2022", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmRaca_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSetPetshop2022.raca'. Você pode movê-la ou removê-la conforme necessário.
            this.racaTableAdapter.Fill(this.dataSetPetshop2022.raca);

        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupBoxRaca.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            racaBindingSource.CancelEdit(); 
            groupBoxRaca.Enabled = false;
        }

        private void BtnAdicionarNovo_Click_1(object sender, EventArgs e)
        {
            racaBindingSource.AddNew();
            groupBoxRaca.Enabled = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Confirma a exclusão do registro?", "Petshop 2022", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    racaBindingSource.EndEdit();
                    racaBindingSource.RemoveCurrent();
                    MessageBox.Show("Registro excluido com sucesso.", "Petshop 2022", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu um erro ao exlcuir o registro." + erro, "Petshop 2022", MessageBoxButtons.OK, MessageBoxIcon.Error);
                racaTableAdapter.Fill(dataSetPetshop2022.raca);
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            ClasseGlobal.CoditoTroca = 0;
            frmLocalizarRaca frmLocalizarRaca = new frmLocalizarRaca();
            frmLocalizarRaca.ShowDialog();

            if(ClasseGlobal.CoditoTroca > 0)
            {
                racaBindingSource.Position = racaBindingSource.Find("raca_id", ClasseGlobal.CoditoTroca);
            }
        }
    }
}
