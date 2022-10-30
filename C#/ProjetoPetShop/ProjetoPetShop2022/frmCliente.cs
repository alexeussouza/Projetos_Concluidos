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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSetPetshop2022.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.dataSetPetshop2022.cliente);
            // TODO: esta linha de código carrega dados na tabela 'petshop2022DataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
            //this.clienteTableAdapter.Fill(this.petshop2022DataSet.cliente);

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.clienteBindingSource.EndEdit();
                clienteTableAdapter.Update(dataSetPetshop2022.cliente); // atualiza apenas os dados desta tabela.
                MessageBox.Show("Dados salvos com sucesso.");
                groupBoxCliente.Enabled = false; // Bloqueia o Groupbox apos salvar os dados
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Ocorreu um erro ao salvar os dados " + ex.Message);
            }
        }

        private void btnNovoItem_Click(object sender, EventArgs e)
        {
            clienteBindingSource.AddNew(); // adiciona novo cliente em branco
            groupBoxCliente.Enabled = true;
            // após liberar a Groupbox para edição o cliente pode salvar ou cancelar

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clienteBindingSource.CancelEdit();
            groupBoxCliente.Enabled = false;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupBoxCliente.Enabled = true;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Confirma a exclusão do registro?", "Petshop 2022", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    clienteBindingSource.RemoveCurrent();
                    clienteTableAdapter.Update(dataSetPetshop2022.cliente);
                    MessageBox.Show("Registro excluido com sucesso.", "Petshop 2022", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception erro)
            {

                MessageBox.Show("Registro não pode ser excluido." + erro, "Petshop 2022", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clienteTableAdapter.Fill(dataSetPetshop2022.cliente);
            } 
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog.Filter = "Foto: (*.jpg; *.png; *.jpeg | *.jpg; *.png; *.jpeg)";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    client_fotoPictureBox.Image = new Bitmap(openFileDialog.FileName);
                }

            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao inserir foto. Tente novamente." + erro, "Petshop Faisca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            ClasseGlobal.CoditoTroca = 0;

            frmLocalizarCliente localizar = new frmLocalizarCliente();
            localizar.ShowDialog();
            if (ClasseGlobal.CoditoTroca > 0)
            {
                //acha a posicao do registro com o FIND e Position recebe a posição localizada
                clienteBindingSource.Position = clienteBindingSource.Find("client_id", ClasseGlobal.CoditoTroca) ;

            }
        }
    }
}
