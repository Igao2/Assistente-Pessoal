using System;
using System.Collections;
using System.Collections.Generic;

namespace Helpy
{
    class User
    {
        public static List<Tuple<string,string,string,string>> usuario = new List<Tuple<string,string,string,string>>();
        public static bool SM = false;
        public static int posAtual = 0;
        public static int count = 0;

        public bool getSM()
        {
            return SM;
        }
        public void setSMtrue()
        {
            SM = true;
        }
        public void setSMfalse()
        {
            SM = false;
        }
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
        public void setCount()
        {
            count++;
        }
        public void delCount()
        {
            count--;
        }
        public List<Tuple<string,string,string,string>> getUsuario()
        {
            return usuario;
        }
        public void setUsuario(string nome,string email,string telefone,string senha)
        {
            usuario.Add(Tuple.Create(nome, email, telefone, senha));
        }
        public void editUsuario(int posusuario,string nome,string email,string telefone,string senha)
        {
            List<Tuple<string,string,string,string>> b = new List<Tuple<string,string,string,string>>();
            b.Add(Tuple.Create(nome, email, telefone, senha));
            usuario[posusuario] = b[0];
            b.RemoveAt(0);
        }
        public void delUsuario(int i)
        {
            usuario.RemoveAt(i);
        }
    }
}
