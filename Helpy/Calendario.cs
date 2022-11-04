using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpy
{
    class Calendario
    {
        public static List<string> nome = new List<string>();
        public static List<string> descricao = new List<string>();
        public static int[] dias = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31 };
        public static string[] meses = { "janeiro", "fevereiro", "março", "abril", "junho", "julho", "agosto", "setembro", "outubro", "novembro", "dezembro" };


        public List<string> getNome()
        {
            return nome;
        }
    }
}
