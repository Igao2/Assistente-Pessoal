using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Helpy
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
            User u = new User();
            
            Calendario cal = new Calendario();
            List<Tuple<int, string, string, string>> eve = cal.getEvento();
            int posatual = u.getposAtual();
            int conT = cal.getcontItem();

            int posatua = u.getposAtual();
            int contador = cal.getcontItem();
            if (contador > 0)
            {
                

                for (int i = 0; i < contador; i++)

                {
                    if (eve[i].Item1 == posatua)
                    {
                        string dt = eve[i].Item4;
                        string[] data = dt.Split('/');
                        int ano = int.Parse(data[2]);
                        int mes = int.Parse(data[1]);
                        int dia = int.Parse(data[0]);

                        DateTime dts = new DateTime(ano, mes, dia);
                        
                        calAtual.AddBoldedDate(dts);

                    }
                }
            }
            DateTime dat = new DateTime();
            dat = calAtual.SelectionStart;
       
            string date = dat.ToShortDateString();
            
            List<Tuple<int, string, string, string>> n = cal.getEvento();
            int poss = u.getposAtual();
            if (contador > 0)
            {

                string a = "Compromissos: ";
                for (int i = 0; i < contador; i++)
                {
                    if (n[i].Item1 == poss)
                    {
                        if (n[i].Item4.Contains(dat.ToShortDateString()))
                        {
                            a = a +
                                "\n" + n[i].Item2 + "  horario: " + n[i].Item3;
                        }
                    }
                }
                if (a != "Compromissos: ")
                {
                    label1.Text = date + " " + a;
                }
                else
                {
                    label1.Text = dat.ToShortDateString() + " Sem compromissos";
                }


            }

            else
            {

                label1.Text = dat.ToShortDateString() + " Sem compromissos";
            }
            List<Tuple<int, string>> b = cal.getTarefa();
            int cont = cal.getcontTarefa();
            if (cont > 0)
            {
                for (int i = 0; i < cont; i++)
                {
                    if (b[i].Item1 == posatual)
                    {
                        checkedListBox1.Items.Add(b[i].Item2);
                    }

                }


            }



        }
        List<Tuple<int, string, string, string>> b = new List<Tuple<int, string, string, string>>();
        public List<Tuple<int,string,string,string>> getB()
        {
            return b;
        }
        public void setB(int pos,string a,string d, string c)
        {
            b.Add(Tuple.Create(pos, a, d, c));
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            
            

        }

        private void calAtual_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void calAtual_DateSelected(object sender, DateRangeEventArgs e)
        {
            User u = new User();
            int poss = u.getposAtual();
            DateTime dat = new DateTime();
            dat = calAtual.SelectionStart;
            string date = dat.ToShortDateString();
            Calendario cal = new Calendario();
            List<Tuple<int, string, string, string>> n = cal.getEvento();
            int contador = cal.getcontItem();
                if(contador > 0)
                {
                string a = "Compromissos: ";
                for (int i = 0; i < contador; i++)
                {
                    if (n[i].Item1 == poss)
                    {
                        if (n[i].Item4.Contains(date))
                        {
                            a = a +
                                "\n" + n[i].Item2 + "  horário: " + n[i].Item3;
                        }
                    }
                  
                   
                }
                    if(a!= "Compromissos: ")
                    {
                    label1.Text = date + " "+ a;
                    }
                    else
                    {
                    label1.Text = dat.ToShortDateString() + " Sem compromissos";
                    }
                 
                }
            else
            {

                label1.Text = dat.ToShortDateString() + " Sem compromissos";
            }

        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ToolStrip2_MouseHover(object sender, EventArgs e)
        {
           
        }

        

        private void Button1_Click(object sender, EventArgs e)
        {
            
           
        }

        private void CheckedListBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Delete)
            {
                if (e.KeyCode == Keys.Delete)
                {

                    DialogResult dr = MessageBox.Show("Deseja excluir o compromisso?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        Calendario cal = new Calendario();
                        User u = new User();
                        int iteM = cal.getcontTarefa();
                        object list = checkedListBox1.SelectedItem;


                        for (int i = 0; i < iteM; i++)
                        {
                            List<Tuple<int, string>> f = cal.getTarefa();

                            if (f[i].Item2 == checkedListBox1.Text)
                            {
                                cal.delcontTarefa();
                                cal.removeTarefa(i);
                               
                                checkedListBox1.Items.Remove(list);
                                break;


                            }


                        }





                    }


                }
                
                
            }
        }

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
