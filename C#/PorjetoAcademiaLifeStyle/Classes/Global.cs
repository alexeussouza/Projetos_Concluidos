using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeStyle
{
    public class Global
    {

        public static int nivel = 0;

        public static Boolean logado = false;

        public static string versao = "0.1.0";

        public static string diretorio = System.Environment.CurrentDirectory; // caminho relativo para pasta do banco de dados

        public static string diretorioBanco = diretorio + @"\banco\";

        public static string NomeBanco= "banco_academia.db";

    }
}
