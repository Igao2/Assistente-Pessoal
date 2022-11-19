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
            int poss = u.getposAtual();
            if (contador > 0)
            {

                string a = "Compromissos: ";
                for (int i = 0; i < contador; i++)
                {
                    if (n[i].Item1 == poss)
                    {
                        if (n[i].Item4.Contains(date))
                        {
                            a = a +
                                "\n" + n[i].Item2 + ","+ "horário: " + n[i].Item3;
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
                                "\n" + n[i].Item2 + " ,Horário: " + n[i].Item3;
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

        private void ListView1_MouseHover(object sender, EventArgs e)
        {
            information.SetToolTip(this.listView1, "Pressione o botão delete para deletar o compromisso");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
           
        }

        private void ListView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char b = e.KeyChar;
            label2.Text = b.ToString();
        }

        private void ListView1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {

                DialogResult dr = MessageBox.Show("Deseja excluir o compromisso?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
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
                        List<Tuple<int, string, string, string>> f = cal.getEvento();

                        if (f[i].Item2 == list.Text)
                        {
                            string dt = f[i].Item4;
                            string[] data = dt.Split('/');
                            ano = int.Parse(data[2]);
                            mes = int.Parse(data[1]);
                            dia = int.Parse(data[0]);


                            dT = new DateTime(ano, mes, dia);
                            cal.delEvento(i);
                            calAtual.RemoveBoldedDate(dT);


                        }
                       

                    }

                    listView1.Items.Remove(list);

                    cal.contmenosItem();
                }


            }
            if (e.KeyCode == Keys.E)
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
                List<Tuple<int, string, string, string>> f = cal.getEvento();
                for (int i = 0; i < iteM; i++)
                {
                    
                if(list.Text != "")
                    {
                        if (f[i].Item2 == list.Text)
                        {
                            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                            {

                                cal.editEvento(i, u.getposAtual(), textBox1.Text, textBox3.Text, textBox2.Text);

                                string dt = textBox2.Text;
                                string[] data = dt.Split('/');
                                ano = int.Parse(data[2]);
                                mes = int.Parse(data[1]);
                                dia = int.Parse(data[0]);


                                dT = new DateTime(ano, mes, dia);
                             

                                
                                ListViewItem item = new ListViewItem(textBox1.Text);
                                item.SubItems.Add(textBox2.Text);
                                item.SubItems.Add(textBox3.Text);
                                listView1.Items.Add(item);
                                listView1.Items.Remove(list);

                                
                            }
                        }
                    }
                    
                    calAtual.AddBoldedDate(dT);

                }

            }
        }

        
    }
}
