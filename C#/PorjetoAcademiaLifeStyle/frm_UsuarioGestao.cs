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
    public partial class frm_UsuarioGestao : Form
    {
        int idSelecionado = 0;
        int modoSalvar = 0;  // 1 =  Insert     0 = Update
        public frm_UsuarioGestao()
        {
            InitializeComponent();
        }

        
        private void frm_UsuarioGestao_Load(object sender, EventArgs e)
        {
            AtualizaDataGridView();
        }

        private void dgv_UsuarioGestao_SelectionChanged(object sender, EventArgs e) // se houver mudança de linha metodo será invocado
        {
            DataGridView dgv = (DataGridView)sender;

            int cont = dgv.SelectedRows.Count; //verifica se linha está selecionada, retorna valor maior que zero se true

            if(cont > 0)
            {
                DataTable dt = new DataTable();
                idSelecionado = int.Parse(dgv.SelectedRows[0].Cells[0].Value.ToString());
                string query = "SELECT * FROM tb_usuarios WHERE N_IDUSUARIO =" + idSelecionado;// retorna usuaro pelo id do DataGrid
                dt = Banco.dql(query);   
                txt_IdUsuario.Text = dt.Rows[0].ItemArray[0].ToString();
                txt_nome.Text = dt.Rows[0].ItemArray[1].ToString();
                txt_username.Text = dt.Rows[0].ItemArray[2].ToString();
                txt_senha.Text = dt.Rows[0].ItemArray[3].ToString();
                cbx_status.Text = dt.Rows[0].ItemArray[4].ToString();
                nud_nivel.Value = decimal.Parse(dt.Rows[0].ItemArray[5].ToString());
            }
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            txt_nome.Clear();
            txt_username.Clear();
            txt_senha.Clear();
            nud_nivel.Value = 0;
            cbx_status.Text = "";
            txt_nome.Focus();
            modoSalvar = 1;
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            string query = "";
            Usuario u = new Usuario();

            
            u.Nome = txt_nome.Text;
            u.UserName = txt_username.Text;
            u.Password = txt_senha.Text;
            u.Status = cbx_status.Text;
            u.Nivel = Convert.ToInt32(Math.Round(nud_nivel.Value));

            if (u.Nome == "" || u.UserName == "" || u.Password == "" || u.Status == "")
            {
                MessageBox.Show("Preencha todos os campos antes de salvar.");
                txt_nome.Focus();
                return;
            }


            if (modoSalvar == 0)
            {
                // query = "UPDATE tb_usuarios SET T_NOMEUSUARIO='" + u.Nome + "', T_USERNAME='" + u.UserName + "', T_SENHAUSUARIO='" + u.Password +"', T_STATUSUSUARIO='" + u.Status +"', N_NIVELUSUARIO=" + u.Nivel  + " WHERE N_IDUSUARIO=" + idSelecionado;
                query = String.Format("UPDATE tb_usuarios SET T_NOMEUSUARIO='{0}', T_USERNAME='{1}', T_SENHAUSUARIO='{2}', T_STATUSUSUARIO='{3}', N_NIVELUSUARIO={4} WHERE N_IDUSUARIO={5}",u.Nome, u.UserName, u.Password, u.Status, u.Nivel, idSelecionado);
            }
            else
            {
              query = string.Format("INSERT INTO tb_usuarios (T_NOMEUSUARIO, T_USERNAME, T_SENHAUSUARIO, T_STATUSUSUARIO, N_NIVELUSUARIO) VALUES ('{0}', '{1}', '{2}', '{3}',{4}", u.Nome, u.UserName, u.Password, u.Status, u.Nivel + ")");

            }

            Banco.dml(query);
            modoSalvar = 0; // Modo edição ativado
            AtualizaDataGridView();
            
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja realmente excluir o registro?", "Academia Life Style", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if(res == DialogResult.Yes)
            {
                string query = "DELETE FROM tb_usuarios WHERE N_IDUSUARIO=" + idSelecionado;
                Banco.dml(query);

                AtualizaDataGridView();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            AtualizaDataGridView();
            txt_nome.Focus();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        } 

        private void AtualizaDataGridView()
        {

            string query = "SELECT N_IDUSUARIO AS 'Id Usuário', T_NOMEUSUARIO AS 'Nome' FROM tb_usuarios";
            dgv_UsuarioGestao.DataSource = Banco.dql(query);
            dgv_UsuarioGestao.Columns[0].Width = 80;
            dgv_UsuarioGestao.Columns[1].Width = 250;
        }
    }
}
