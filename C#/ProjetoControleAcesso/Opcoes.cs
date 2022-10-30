using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleAcesso
{
    public class Opcoes
    {
        
        public int Id { get; set; } 
        public string Nome { get; set; }
        public string Descricao { get; set; }   
        public byte Nivel { get; set; } 

        public Opcoes(string nome, string descricao, byte nivel)
        {
            Nome = nome;    
            Descricao = descricao;  
            Nivel = nivel;
        }

        public static HashSet<Opcoes> Criar(MenuStrip menu)
        {

            var hashSetOpcoes = new HashSet<Opcoes>();

            // Menu Nivel 1

            foreach (ToolStripMenuItem item in menu.Items)
            {

                var descricao1 = item.Text;

                if (item.HasDropDownItems)
                {
                    // Menu Nivel 2
                    foreach (ToolStripMenuItem opcao in item.DropDownItems)
                    {
                        var descricao2 = descricao1 + " / " + opcao.Text;

                        if (opcao.HasDropDownItems)
                        {
                           
                            // Menu Nivel 3
                            foreach (ToolStripMenuItem subopcao in opcao.DropDownItems)
                            {
                                var descricao3 = descricao2 + " / " + subopcao.Text;
                                hashSetOpcoes.Add(new Opcoes(subopcao.Name, descricao3, 3));

                                

                            }
                        }
                        else
                        {

                            hashSetOpcoes.Add(new Opcoes(opcao.Name, descricao2, 2));
                        }
                    }
                }
                else
                {
                    hashSetOpcoes.Add(new Opcoes(item.Name, descricao1, 1));
                }
            }
            return hashSetOpcoes;   
        }

        // Salva dados do menu na tabela do banco de dados
        public static bool SalvarMenu(HashSet<Opcoes> opcoes)
        {

            var sql = "INSERT INTO MenuOpcoes (nome, descricao, nivel) VALUES (@nome, @descricao, @nivel)";

            try
            {
                using (var cn = new SqlConnection(Program.strConn))
                {
                    // abre conexão com banco de dados
                    cn.Open();

                    using (var cmd = new SqlCommand(sql,cn))
                    {
                        // Declaração dos parametros da tabela
                        cmd.Parameters.Add("@nome", SqlDbType.VarChar);
                        cmd.Parameters.Add("@descricao", SqlDbType.VarChar);
                        cmd.Parameters.Add("@nivel", SqlDbType.TinyInt);

                        foreach (var item in opcoes)
                        {
                            cmd.Parameters["@nome"].Value = item.Nome;
                            cmd.Parameters["@descricao"].Value = item.Descricao;
                            cmd.Parameters["@nivel"].Value = item.Nivel;
                            cmd.ExecuteNonQuery();

                        }
                    }
                }
                return true;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
