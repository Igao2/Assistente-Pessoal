using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpy
{
    class Calendario
    {
        
       
        public static List<Tuple<int, string, string, string,string>> evento = new List<Tuple<int, string, string, string,string>>();
        public static List<Tuple<int, string>> tarefa = new List<Tuple<int, string>>();
        public static int contitem = 0;
        public static int contarefa = 0;

     
      
        public int getcontTarefa()
        {
            return contarefa;
        }
        public void setcontTarefa()
        {
            contarefa++;
        }
        public void delcontTarefa()
        {
            contarefa--;
        }
            
            public int getcontItem()
        {
            return contitem;
        }
        public void setcontItem()
        {
            contitem++;
        }
        public void contmenosItem()
        {
            contitem--;
        }
        public List<Tuple<int,string,string,string,string>> getEvento()
        {
            return evento;
        }
        public void setEvento(int pos,string nome,string descricao, string data,string local)
        {
            evento.Add(Tuple.Create(pos,nome,descricao,data,local));
        }
        public void editEvento(int poseve,int pos,string name,string hour,string data,string local)
        {
         List<Tuple<int, string, string, string,string>> edit = new List<Tuple<int, string, string, string,string>>();
        edit.Add(Tuple.Create(pos, name, hour, data,local));
            
             evento[poseve] = edit[0];
            edit.RemoveAt(0);
            
        }
        public void delEvento(int nome)
        {
            evento.RemoveAt(nome);
            
        }
        public List<Tuple<int,string>> getTarefa()
        {
            return tarefa;
        }
        public void setTarefa(int pos,string nome)
        {
            tarefa.Add(Tuple.Create(pos, nome));
        }
        public void removeTarefa(int z)
        {
            tarefa.RemoveAt(z);
        }
        public void editTarefa(int posusuario,int postarefa,string nome)
        {
            List<Tuple<int, string>> edittarefa = new List<Tuple<int, string>>();
            edittarefa.Add(Tuple.Create(posusuario, nome));
            tarefa[postarefa] = edittarefa[0];
            edittarefa.RemoveAt(0);
        }
    }
}
