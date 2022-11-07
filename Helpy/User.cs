using System;
using System.Collections;
using System.Collections.Generic;

namespace Helpy
{
    class User
    {
        public static List<Tuple<string,string,string,string>> usuario = new List<Tuple<string,string,string,string>>();    
        
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
        public List<Tuple<string,string,string,string>> getUsuario()
        {
            return usuario;
        }
        public void setUsuario(string nome,string email,string telefone,string senha)
        {
            usuario.Add(Tuple.Create(nome, email, telefone, senha));
        }
    }
}
