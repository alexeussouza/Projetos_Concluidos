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
    public partial class frm_UsuarioNovo : Form
    {
        public frm_UsuarioNovo()
        {
            InitializeComponent();
        }

        private void frm_Usuario_Load(object sender, EventArgs e)
        {

        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            txt_nome.Clear();
            txt_username.Clear();
            txt_senha.Clear();
            nud_nivel.Value = 0;
            cbx_status.Text = "";
            txt_nome.Focus();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            string query = "";

            u.Nome = txt_nome.Text;
            u.UserName = txt_username.Text;
            u.Password = txt_senha.Text;
            u.Status = cbx_status.Text;
            u.Nivel = Convert.ToInt32(Math.Round(nud_nivel.Value, 0));

            if(u.Nome == "" || u.UserName == "" || u.Password =="" || u.Status =="")
            {
                MessageBox.Show("Preencha todos os campos antes de salvar.");
                txt_nome.Focus();
                return;
            }

            query = string.Format("INSERT INTO tb_usuarios (T_NOMEUSUARIO, T_USERNAME, T_SENHAUSUARIO, T_STATUSUSUARIO, N_NIVELUSUARIO) VALUES ('{0}', '{1}', '{2}', '{3}',{4}", u.Nome, u.UserName, u.Password, u.Status, u.Nivel + ")");

            Banco.dml(query);
            LimpaCampos();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            txt_nome.Clear();
            txt_username.Clear();
            txt_senha.Clear();
            nud_nivel.Value = 0;
            cbx_status.Text = "";
            txt_nome.Focus();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void LimpaCampos()
        {
            txt_nome.Clear();
            txt_username.Clear();
            txt_senha.Clear();
            nud_nivel.Value = 0;
            cbx_status.Text = "";
            txt_nome.Focus();
        }
    }
}
