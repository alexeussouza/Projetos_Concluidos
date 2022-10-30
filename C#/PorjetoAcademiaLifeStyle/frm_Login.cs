using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeStyle
{
    
    public partial class frm_Login : Form
    {
        frm_Principal p;
        public frm_Login(frm_Principal principal)
        {
            InitializeComponent();
            this.p = principal;
        }

        private void btn_Logar_Click(object sender, EventArgs e)
        {
            string query = "";
            string username= txt_usuario.Text;
            string password= txt_senha.Text;
            DataTable dt = new DataTable();

            if (txt_usuario.Text == "" || txt_senha.Text == "")
            {

                MessageBox.Show("Usuário e senha incorretos;");
                txt_usuario.Focus();
                return;
            }
           
            query = "SELECT * FROM tb_usuarios WHERE T_USERNAME='" + username  + "' AND T_SENHAUSUARIO='" + password  + "'";

            dt =  Banco.dql(query);

            if(dt.Rows.Count == 1)
            {
                p.lb_usuario.Text = dt.Rows[0].ItemArray[2].ToString();
                p.lb_nivel.Text = dt.Rows[0].ItemArray[5].ToString();
                p.pb_Logado.Image = Properties.Resources.Led_Verde;
                Global.nivel = int.Parse(dt.Rows[0].ItemArray[5].ToString());
                Global.logado = true;
                this.Close(); // apos autenticar fecha janela de login
            }
            else
            {
                MessageBox.Show("Usuário não encontrado");
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
