using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;

namespace LifeStyle
{
    public class Banco
    {
        public static SQLiteConnection conexao;
        public static SQLiteConnection ConexaoBanco() // Cria conexão com banco de dados
        {
            conexao = new SQLiteConnection("Data Source=" + Global.diretorioBanco + Global.NomeBanco);
            conexao.Open();
            return conexao;
        }


        public static DataTable dql(string sql)
        {
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = Banco.ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = sql;
                    SQLiteDataAdapter da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Banco.ConexaoBanco().Close();
            }
        }

        public static void dml(string sql)
        {
            try
            {
                using (var cmd = Banco.ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = sql;
                    SQLiteDataAdapter da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Operação concluída com sucesso");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Banco.ConexaoBanco().Close();
            }
        }
    }
}
