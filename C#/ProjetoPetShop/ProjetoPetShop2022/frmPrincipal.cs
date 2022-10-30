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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja sair?", "**** PetShop Faísca ltda ****", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            } 
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;   
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmCliente cliente = new frmCliente();
            cliente.TopLevel = false; // para não tentar fica acima do form inicio
            cliente.Dock = DockStyle.Fill;
            panelCentral.Controls.Clear(); // limpa qualquer form que estiver no painel para não ficar mais de um form aberto.
            panelCentral.Controls.Add(cliente); // adiciona o formulario cliente no painel central
            panelMarcador.Top = btnCliente.Top;
            cliente.Show();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            panelCentral.Controls.Clear();
            panelMarcador.Top = btnInicio.Top;
        }

        private void btnAnimal_Click(object sender, EventArgs e)
        {
            frmAnimal animal = new frmAnimal(); 
            animal.TopLevel = false;
            animal.Dock = DockStyle.Fill;
            panelCentral.Controls.Clear();
            panelCentral.Controls.Add(animal);
            panelMarcador.Top = btnAnimal.Top;
            animal.Show();  
        }

        private void btnRaca_Click(object sender, EventArgs e)
        {
            frmRaca raca = new frmRaca();
            raca.TopLevel = false;
            raca.Dock = DockStyle.Fill;
            panelCentral.Controls.Clear();
            panelCentral.Controls.Add(raca);
            panelMarcador.Top = btnRaca.Top;
            raca.Show();
        }

        private void btnServico_Click(object sender, EventArgs e)
        {
            frmServico servico = new frmServico();
            servico.TopLevel = false;
            servico.Dock = DockStyle.Fill;
            panelCentral.Controls.Clear();
            panelCentral.Controls.Add(servico);
            panelMarcador.Top = btnServico.Top;
            servico.Show();
        }

        private void btnAgendamento_Click(object sender, EventArgs e)
        {
            frmAgendamento agendamento = new frmAgendamento();
            agendamento.TopLevel = false;
            agendamento.Dock = DockStyle.Fill;
            panelCentral.Controls.Clear();
            panelCentral.Controls.Add(agendamento);
            panelMarcador.Top = btnAgendamento.Top; 
            agendamento.Show();
        }

        private void frmPrincipal_Shown(object sender, EventArgs e)
        {
            frmSplash frmSplash = new frmSplash();
            frmSplash.ShowDialog();
        }
    }
}
