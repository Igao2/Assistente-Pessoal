using System.Collections;
using System.Collections.Generic;

namespace Helpy
{
    class User
    {
        public static List<string> email = new List<string>();
        public static List<string> senha = new List<string>();
        public static int posAtual = 0;
        public static int count = 0;

        public int getposAtual()
        {
            return posAtual;
        }

        public void setposAtual(int x)
        {
            posAtual = x;
        }

        public int getCount()
        {
            return count;
        }
        public void setCount(int a)
        {
            count++;
        }
        public List<string> getEmail()
        {
            return email;
        }
        public void setEmail(string a )
        {
            email.Add(a);
        }
        public List<string> getSenha()
        {
            return senha;
        }
        public void setSenha(string e)
        {
            senha.Add(e);
        }
    }
}
