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
            label2.Text = u.getposAtual().ToString();
            Calendario cal = new Calendario();
            List<Tuple<int, string, string, string>> eve = cal.getEvento();
            int posatual = u.getposAtual();
            int conT = cal.getcontItem();

            if (conT > 0)
            {
                for (int i = 0; i < conT; i++)
                {
                    
                    if (eve[i].Item1 == posatual)
                    {
                        ListViewItem item = new ListViewItem(eve[i].Item2);
                        item.SubItems.Add(eve[i].Item4);
                        item.SubItems.Add(eve[i].Item3);
                        listView1.Items.Add(item);

                    }
                }
                


            }
            
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
            
            if (contador > 0)
            {
                
                string a = "Compromissos: ";
                for (int i = 0; i < contador; i++)
                {
                    if (n[i].Item1 == u.getposAtual())
                    {
                        if(n[i].Item4.Contains(date))
                        {
                            a = a +
                                "\n" + n[i].Item2 + "Horário: " + n[i].Item3;
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
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            
            

        }

        private void calAtual_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void calAtual_DateSelected(object sender, DateRangeEventArgs e)
        {
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
                    if (n[i].Item4.Contains(date))
                    {
                        a = a +
                            "\n" + n[i].Item2 + "Horário: " + n[i].Item3;
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
            if(e.KeyCode == Keys.Delete)
            {
                
                DialogResult dr = MessageBox.Show("Deseja excluir o compromisso?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(dr == DialogResult.Yes)
                {
                    Calendario cal = new Calendario();
                    User u = new User();
                    int iteM = cal.getcontItem();
                    ListViewItem list = new ListViewItem();
                    list = listView1.SelectedItems[0];
                    int ano = 2022;
                    int mes = 03;
                    int dia = 02;
                    DateTime dT = new DateTime(ano, mes, dia);
                    for (int i = 0; i < iteM; i++)
                    {
                        List<Tuple<int, string, string, string>> b = cal.getEvento();

                        if (b[i].Item2 == list.Text)
                        {
                            string dt = b[i].Item4;
                            string[] data = dt.Split('/');
                             ano = int.Parse(data[2]);
                             mes = int.Parse(data[1]);
                             dia = int.Parse(data[0]);


                            dT =  new DateTime(ano, mes, dia);
                            cal.delEvento(i);
                            
                        }
                        calAtual.RemoveBoldedDate(dT);

                    }
                    
                    listView1.Items.Remove(list);

                    cal.contmenosItem();
                }
               
                
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
