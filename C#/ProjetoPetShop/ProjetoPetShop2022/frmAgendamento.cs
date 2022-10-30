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
    public partial class frmAgendamento : Form
    {
        public frmAgendamento()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.agendamentoBindingSource.EndEdit();
                this.agendamentoTableAdapter.Update(dataSetPetshop2022.agendamento);
                MessageBox.Show("Registro salvo com sucesso.", "Petshop 2022", MessageBoxButtons.OK, MessageBoxIcon.Information);
                groupBoxAgendamentos.Enabled = false;

                //this.tableAdapterManager.UpdateAll(this.petshop2022DataSet);
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao salvar o registro." + erro, "Petshop 2022", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Finalizar();
        }

        private void frmAgendamento_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSetPetshop2022.View_Total_Servicos'. Você pode movê-la ou removê-la conforme necessário.
            this.view_Total_ServicosTableAdapter.Fill(this.dataSetPetshop2022.View_Total_Servicos);
            // TODO: esta linha de código carrega dados na tabela 'dataSetPetshop2022.agendamento_servicos'. Você pode movê-la ou removê-la conforme necessário.
            this.agendamento_servicosTableAdapter.Fill(this.dataSetPetshop2022.agendamento_servicos);
            // TODO: esta linha de código carrega dados na tabela 'dataSetPetshop2022.servico'. Você pode movê-la ou removê-la conforme necessário.
            this.servicoTableAdapter.Fill(this.dataSetPetshop2022.servico);
            // TODO: esta linha de código carrega dados na tabela 'dataSetPetshop2022.animal'. Você pode movê-la ou removê-la conforme necessário.
            this.animalTableAdapter.Fill(this.dataSetPetshop2022.animal);
            // TODO: esta linha de código carrega dados na tabela 'dataSetPetshop2022.View_AgendamentoServicos'. Você pode movê-la ou removê-la conforme necessário.
            this.view_AgendamentoServicosTableAdapter.Fill(this.dataSetPetshop2022.View_AgendamentoServicos);
            // TODO: esta linha de código carrega dados na tabela 'dataSetPetshop2022.agendamento'. Você pode movê-la ou removê-la conforme necessário.
            this.agendamentoTableAdapter.Fill(this.dataSetPetshop2022.agendamento);

            Finalizar();
        }

        private void btnCriarNovo_Click(object sender, EventArgs e)
        {
            agendamentoBindingSource.AddNew();
            groupBoxAgendamentos.Enabled = true;
            txt_agend_ValorTotal.Text = "0.00";
            agend_horarioMaskedTextBox.Text = DateTime.Now.ToShortTimeString();
            agend_dataMaskedTextBox.Text = DateTime.Now.ToShortDateString();
            agend_situacaoComboBox.Text = "Agendado";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupBoxAgendamentos.Enabled = true;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            agendamentoBindingSource.CancelEdit();  
            groupBoxAgendamentos.Enabled=false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Confirma a exclusão do registro?", "Petshop 2022", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    agendamentoBindingSource.EndEdit();
                    agendamentoBindingSource.RemoveCurrent();
                   

                }
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao excluir o registro." + erro, "Petshop 2022", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.agendamentoTableAdapter.Fill(this.dataSetPetshop2022.agendamento);
            }
        }

        private void txtServico_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtServico_id.Text != "" ) {

                servicoTableAdapter.Update(dataSetPetshop2022.servico);
                servicoBindingSource.Filter = "serv_id = " + txtServico_id.Text;

                if (servicoBindingSource.Count == 1)
                {

                    DataRowView Resultado = (DataRowView)servicoBindingSource.Current;

                    txtDescricao.Text = Resultado["serv_descricao"].ToString();   
                    txtValor.Text = Resultado["serv_preco"].ToString();   
                    txtTempo.Text = Resultado["serv_tempo"].ToString();
                    txtQuantidade.Text = "1";
                    txtQuantidade.SelectAll();  
                    txtQuantidade.Focus();  
                }
                else
                {
                    // abre o form para selecionar o serviço
                    frmServico servico = new frmServico();
                    servico.ShowDialog();   
                }
            }
        }

        private void txtQuantidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtQuantidade.Text != "")
            {
                txtValor.SelectAll();
                txtValor.Focus();
            }
        }

        private void txtValor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtValor.Text != "")
            {
                btnAdicionarServico_Click(sender, e);

            }
        }

        private void btnAdicionarServico_Click(object sender, EventArgs e)
        {

            try
            {

                //servico adicionado com procedure stored adicionar_servico
                agendamento_servicosTableAdapter.AdicionarServico(int.Parse(txt_agend_id.Text), int.Parse(txtServico_id.Text), int.Parse(txtQuantidade.Text), decimal.Parse(txtValor.Text));

                txtServico_id.Clear();
                txtDescricao.Clear();
                txtTempo.Clear();
                txtQuantidade.Clear();
                txtValor.Clear();
                txtServico_id.Focus();
                
            }
            catch (Exception)
            {
                throw;
            }
            AtualizarGrid();
            total();

        }

        private void view_AgendamentoServicosDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Remove serviço com procedure stored remover_serviço
            try
            {
                int codigo = 0;

                // Cells[0] porque a primeira coluna agend_id tem indice 0
                codigo = int.Parse(view_AgendamentoServicosDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                agendamento_servicosTableAdapter.RemoverServico(codigo);
            }
            catch (Exception)
            {

                throw;
            }
            AtualizarGrid();
            total();
        } 

        private void AtualizarGrid()
        {
            try
            {
                if (txt_agend_id.Text != "")
                {
                    view_AgendamentoServicosTableAdapter.Fill(dataSetPetshop2022.View_AgendamentoServicos); // Sempre carregar os dados com Fill antes de fazer o Filter
                    view_AgendamentoServicosBindingSource.Filter = "agend_id = " + txt_agend_id.Text;
                    txt_Tempo.Text = "00:00:00";
                    txt_agend_TempoTotal.Text = txt_Tempo.Text;
                }

            }
            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu um erro ao atualizar os dados" + erro);
            }
            
        }

        private void txt_agend_id_TextChanged(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma a finalização do agendamento?", "Petshop 2022", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                agend_situacaoComboBox.Text = "Finalizado";
                Finalizar();
                agendamentoBindingSource.EndEdit();
                agendamentoTableAdapter.Update(dataSetPetshop2022.agendamento);

            }

        }
        private void Finalizar()
        {
            
            if (agend_situacaoComboBox.Text == "Finalizado")
            {
                btnSalvar.Enabled = false;
                btnEditar.Enabled = false;
                btnCancelar.Enabled = false;
                btnExcluir.Enabled = false;
                btnFinalizar.Enabled = false;
               
                groupBoxAgendamentoServico.Enabled = false;

            }
            else
            {
                btnSalvar.Enabled = true;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = true;
                btnExcluir.Enabled = true;
                btnFinalizar.Enabled = true;
                groupBoxAgendamentoServico.Enabled = true;
            }
        }

        private void agendamentoBindingSource_PositionChanged(object sender, EventArgs e)
        {
            Finalizar();
        }

        private void txt_agend_id_TextChanged_1(object sender, EventArgs e)
        {
            AtualizarGrid();    
        }

        private void total()
        {
            if (txt_agend_id.Text != "")
            {
                view_Total_ServicosTableAdapter.Fill(dataSetPetshop2022.View_Total_Servicos);
                view_Total_ServicosBindingSource.Filter = "agend_id = " + txt_agend_id.Text;
                if (view_Total_ServicosBindingSource.Count == 1)
                {
                    DataRowView Resultado = (DataRowView)view_Total_ServicosBindingSource.Current;
                    txt_agend_ValorTotal.Text = Resultado["Total"].ToString();
                    agendamentoTableAdapter.Update(dataSetPetshop2022.agendamento); // salva os dados da groupbox agendamento;
                }
                else
                {

                    txt_agend_ValorTotal.Text = "0.00";
                }

            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            ClasseGlobal.CoditoTroca = 0;

            frmLocalizarAnimal frmLocalizarAnimal = new frmLocalizarAnimal();

            frmLocalizarAnimal.ShowDialog();
            frmLocalizarAnimal.Focus();

            if (ClasseGlobal.CoditoTroca >0)
            {
                animalBindingSource.Position = animalBindingSource.Find("anim_id", ClasseGlobal.CoditoTroca);

            }

        }
    }
}
