using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleAcesso
{
    public partial class frmUsuariosCadastrar : Form
    {
        Usuarios usuario = new Usuarios();
        public frmUsuariosCadastrar(Usuarios usuario, Operacao operacao)
        {
            InitializeComponent();
            this.usuario = usuario;

            if (operacao == Operacao.Adicionar && usuario.Id == 0)
            {
                this.Text += " - Adicionar";
                btn_salvar.Visible = true;
                btn_ok.Visible = false;
                
            }
            else if (operacao == Operacao.Alterar)
            {
                this.Text += " - Alterar";
                btn_salvar.Visible = true;
                btn_ok.Visible = false;
                
            }
               
            else if (operacao == Operacao.Excluir)
            {
                this.Text += " -  Excluir";
                TravarControles();
                btn_salvar.Visible = false;
                btn_ok.Visible = true;
                btn_ok.Text = "Excluir";

            }
            else if (operacao == Operacao.Consulta)
            {
                this.Text += " - Consultar";
                TravarControles();
                btn_salvar.Visible=false;
                btn_ok.Visible = true;
                btn_ok.Text = "Fechar";
            }


            // Transferir dados do objeto usuario para o form

            lb_id.Text = usuario.Id.ToString();
            txt_email.Text = usuario.Email;
            txt_nome.Text = usuario.Nome;
            txt_nomeCurto.Text = usuario.NomeCurto;
            cmbAtivo.Text = usuario.Ativo == 'S' ? "Sim" : "Não";   
        }

        private void TravarControles()
        {
            txt_email.Enabled = false;
            txt_nome.Enabled = false;
            txt_nomeCurto.Enabled = false;
            cmbAtivo.Enabled = false;
        }


        private void btn_salvar_Click(object sender, EventArgs e)
        {
            usuario.Id = Convert.ToInt32(lb_id.Text);
            usuario.Nome = txt_nome.Text;  
            usuario.NomeCurto = txt_nomeCurto.Text;
            usuario.Email = txt_email.Text;
            usuario.Ativo = cmbAtivo.Text[0]; // recebe o primeiro caracter do ComboBox Text[0]

            // recebe o resutlado o metodo salvar
            var result = usuario.Salvar(usuario);

            if (result == "ok")
            {
                MessageBox.Show("registro salvo com sucesso");
                this.Close();
            }
            else
            {
                MessageBox.Show("Não foi possivel salvar o registro.\n" + result);
                usuario.Id = -1;
                // id = -1 não é feito nenhuma alteração no frmUsuarios
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if(btn_ok.Text == "Fechar")
                this.Close();
            else
            {
                var resposta = MessageBox.Show("Deseja excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2 );
                
                if (resposta == DialogResult.Yes)
                {
                    var result = usuario.Excluir(usuario.Id);
                    if (result)
                    {
                        MessageBox.Show("Excluido");
                        this.Close();
                    }
                }
            }
        }
    }
}
