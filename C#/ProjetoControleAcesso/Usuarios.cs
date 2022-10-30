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
    public class Usuarios
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string NomeCurto { get; set; }
        public string Email { get; set; }   
        public char Ativo { get; set; } 

        public Usuarios() { }

        public Usuarios(int id, string nome, string nomecurto, string email, char ativo)
        {
            Id = id;
            Nome = nome;
            NomeCurto = nomecurto;  
            Email = email;
            Ativo = ativo;
        }

        public bool Excluir(int id)
        {
            var sql = "DELETE FROM Usuarios WHERE id=@id";
            try
            {
                using (var cn = new SqlConnection(Program.strConn))
                {
                    cn.Open();
                    using (var cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();

                    }
                }
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }

        }

        public string Salvar(Usuarios usuario)
        {
            var sql = "";

            // se Id == 0 é feito INSERT
            if (usuario.Id == 0)
                // para os parametros usar @ 
                sql = "INSERT INTO usuarios (email, nome, nomeCurto, ativo) VALUES (@email, @nome, @nomeCurto, @ativo)";
            else
                // se Id > 0 é feito UPDATE
                sql = " UPDATE usuarios SET email=@email, nome=@nome, nomeCurto = @nomeCurto, ativo=@ativo WHERE id=@id";


            try
            {
                using (var cn = new SqlConnection(Program.strConn))
                {
                    cn.Open();

                    using (var cmd = new SqlCommand(sql,cn))
                    {
                        // Se Id > 0 temos um UPDATE e neste caso usamos o ID
                        if (usuario.Id > 0) 
                            cmd.Parameters.AddWithValue("@id", usuario.Id);
                            cmd.Parameters.AddWithValue("@nome", usuario.Nome);
                            cmd.Parameters.AddWithValue("@nomeCurto", usuario.NomeCurto);
                            cmd.Parameters.AddWithValue("@email", usuario.Email);
                            cmd.Parameters.AddWithValue("@ativo", usuario.Ativo);

                            cmd.ExecuteNonQuery();
                    }
                }
                return "ok";
            }
            catch (Exception ex)
            {

                var result = "";

                if (ex.HResult == -2146232060)
                    //criado index na tabela usuario para bloquear duplicidade de email no banco
                    // create unique index UsuarioEmail on Usuarios (Email)
                    result = usuario.Email + " já existe no cadastro usuarios.";
                else
                    result = ex.Message;
                return result;  
            }
        }

        public static DataTable BuscarTodos()
        {
            var sql = "SELECT id, email, nome, nomecurto, ativo FROM usuarios";

            var dt = new DataTable();

            try
            {
                using (var cn = new SqlConnection(Program.strConn))
                {
                    cn.Open();
                    using (var da = new SqlDataAdapter(sql, cn))
                    {
                        da.Fill(dt);

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return dt;

        }
    }
}
