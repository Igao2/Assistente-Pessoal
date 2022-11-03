using System.Collections;

namespace Helpy
{
    class User
    {
        public static ArrayList email = new ArrayList();
        public static ArrayList senha = new ArrayList();
        public static int count = 0;


        public int getCount()
        {
            return count;
        }
        public void setCount(int a)
        {
            count++;
        }
        public ArrayList getEmail()
        {
            return email;
        }
        public void setEmail(ArrayList a )
        {
            email.Add(a);
        }
        public ArrayList getSenha()
        {
            return senha;
        }
        public void setSenha(ArrayList e)
        {
            senha.Add(e);
        }
    }
}
