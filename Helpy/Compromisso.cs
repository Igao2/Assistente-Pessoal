using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helpy
{
    public partial class Compromisso : Form
    {
        public Compromisso()
        {
            InitializeComponent();
        }
        public int count = 0;
        bool find = false;
        string meunome;
        int posamigo;
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calendario cal = new Calendario();
            User u = new User();
            int a = cal.getcontItem();
            
            if(find)
            {
                cal.setEvento(u.getposAtual(), textBox1.Text, textBox2.Text, textBox3.Text);
                List<Tuple<int, string, string, string>> b = cal.getEvento();
                ListViewItem item = listView1.Items.Add(b[a].Item2);
                item.SubItems.Add(b[a].Item4);
                item.SubItems.Add(b[a].Item3);
                meunome = textBox1.Text + "(" + meunome + ")";
                cal.setEvento(posamigo, meunome, textBox2.Text, textBox3.Text);
            }
            else
            {
                cal.setEvento(u.getposAtual(), textBox1.Text, textBox2.Text, textBox3.Text);
                List<Tuple<int, string, string, string>> b = cal.getEvento();
                ListViewItem item = listView1.Items.Add(b[a].Item2);
                item.SubItems.Add(b[a].Item4);
                item.SubItems.Add(b[a].Item3);
            }
           
            
           
            
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            count++;
            cal.setcontItem();
        }

        private void Compromisso_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Compromisso_Load(object sender, EventArgs e)
        {
            User u = new User();
            Calendario cal = new Calendario();
            List<Tuple<int, string, string, string>> b = new List<Tuple<int, string, string, string>>();
            int pos = u.getposAtual();
            if (cal.getcontItem() > 0)
            {
                for (int i = 0; i < cal.getcontItem(); i++)
                {
                    b = cal.getEvento();
                    if (b[i].Item1 == u.getposAtual())
                    {
                        ListViewItem item = new ListViewItem(b[i].Item2);
                        item.SubItems.Add(b[i].Item4);
                        item.SubItems.Add(b[i].Item3);
                        listView1.Items.Add(item);
                        
                    }
                }
                count--;
              
                
            }
           

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem list = new ListViewItem();
            
           
        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                Calendario cal = new Calendario();
                User u = new User();
                int iteM = cal.getcontItem();
                ListViewItem list = new ListViewItem();
                list = listView1.SelectedItems[0];
                
                
                for(int i = 0; i <iteM;i++)
                {
                    List<Tuple<int,string,string,string>> b = cal.getEvento();
                    
                    if (b[i].Item2 ==list.Text)
                    {
                        cal.delEvento(i);
                    }
                    
                    
                }
                listView1.Items.Remove(list);
                cal.contmenosItem();


            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Amigo am = new Amigo();
            User u = new User();
            Calendario cal = new Calendario();
            List<Tuple<string, string, string, string>> a = u.getUsuario();
            int pos = u.getposAtual();
            List<Tuple<int, string>> b = am.getAmigo();
            if (b.Count > 1)
            {
                for (int i = 0; i < u.getCount(); i++)
                {
                    
                    if (i==pos)
                    {
                        meunome = a[i].Item1;
                        if (b[i].Item1 == pos)
                        {
                            string name = b[i].Item2;
                           
                            for (int j = 0; j < u.getCount(); j++)
                            {
                                if (a[i].Item1 == name)
                                {

                                    posamigo = j;
                                    MessageBox.Show("Usuário " + name + " adicionado ao proximo evento", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    find = true;
                                }
                                
                            }
                        }
                    }
                    
                }
            }
        }
    }
}
