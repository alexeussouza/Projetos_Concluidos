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
    public partial class frmAnimal : Form
    {
        public frmAnimal()
        {
            InitializeComponent();
        }

        private void frmAnimal_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSetPetshop2022.raca'. Você pode movê-la ou removê-la conforme necessário.
            this.racaTableAdapter.Fill(this.dataSetPetshop2022.raca);
            // TODO: esta linha de código carrega dados na tabela 'dataSetPetshop2022.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.dataSetPetshop2022.cliente);
            // TODO: esta linha de código carrega dados na tabela 'dataSetPetshop2022.animal'. Você pode movê-la ou removê-la conforme necessário.
            this.animalTableAdapter.Fill(this.dataSetPetshop2022.animal);
            // TODO: esta linha de código carrega dados na tabela 'dataSetPetshop2022.animal'. Você pode movê-la ou removê-la conforme necessário.
            this.animalTableAdapter.Fill(this.dataSetPetshop2022.animal);

        }

        private void animalBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
            try
            {
                this.Validate();
                this.animalBindingSource.EndEdit();
                this.animalTableAdapter.Update(dataSetPetshop2022.animal);
                MessageBox.Show("Registro salvo com sucesso.", "Petshop 2022", MessageBoxButtons.OK, MessageBoxIcon.Information);
                groupBoxAnimal.Enabled = false;

                //this.tableAdapterManager.UpdateAll(this.petshop2022DataSet);

            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro ao salvar o registro. Tente novamente." + erro, "Petshop 2022", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void bntFoto_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog.Filter = "Fotos:(*.jpg; *.png;) | *.jpg; *.png";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    anim_fotoPictureBox.Image = new Bitmap(openFileDialog.FileName);

                }
            }
            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu um erro ao salvar o registro. Tente novamente." + erro, "Petshop 2022", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            animalBindingSource.AddNew();
            groupBoxAnimal.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Deseja realmente excluir este registro?", "Petshop 2022", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    animalBindingSource.RemoveCurrent();
                    animalTableAdapter.Update(dataSetPetshop2022.animal);
                    MessageBox.Show("Registro excluido com sucesso.", "Petshop 2022", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Registro não pode ser excluído.", "Petshop 2022", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupBoxAnimal.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            animalBindingSource.CancelEdit();   
            groupBoxAnimal.Enabled=false;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {

        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            ClasseGlobal.CoditoTroca = 0;
            frmLocalizarAnimal frmLocalizarAnimal = new frmLocalizarAnimal();   
            frmLocalizarAnimal.ShowDialog();

            if (ClasseGlobal.CoditoTroca > 0)
            {
                animalBindingSource.Position = animalBindingSource.Find("anim_id", ClasseGlobal.CoditoTroca);

            }

        }
    }
}
