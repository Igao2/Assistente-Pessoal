using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Helpy
{
    public partial class Compromisso : Form
    {
        public Compromisso()
        {
            InitializeComponent();
            Calendario cal = new Calendario();
            List<Tuple<int, string, string, string>> b = cal.getEvento();
            
        }
        public int count = 0;
        bool find = false;
        string meunome;
        string name;
        int posamigo;
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calendario cal = new Calendario();
            User u = new User();
            int a = cal.getcontItem();
            Amigo am = new Amigo();
            if(am.gettRue()==true)
            {
                cal.setEvento(u.getposAtual(), textBox1.Text, maskedTextBox1.Text, maskedTextBox2.Text);
                meunome = "-"+meunome+"-"+textBox1.Text;
                label1.Text = meunome;
                cal.setEvento(posamigo, meunome, maskedTextBox1.Text, maskedTextBox2.Text);
                List<Tuple<int, string, string, string>> b = cal.getEvento();
                
                cal.setcontItem();
                cal.setcontItem();
                
            }
            else
            {
                cal.setEvento(u.getposAtual(), textBox1.Text, maskedTextBox1.Text, maskedTextBox2.Text);
                List<Tuple<int, string, string, string>> b = cal.getEvento();
               
                cal.setcontItem();
            }
           
            
           
            
            textBox1.Text = "";
            maskedTextBox2.Text = "";
            maskedTextBox1.Text = "";
            count++;
            
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
                
                
                
                for(int i = 0; i <iteM;i++)
                {
                    List<Tuple<int,string,string,string>> b = cal.getEvento();
                    
                    if (b[i].Item2 ==list.Text)
                    {
                        cal.delEvento(i);
                    }
                    
                    
                }
                
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
                for (int i = 0; i < b.Count; i++)
                {
                    
                    if (b[i].Item1==pos)
                    {
                        meunome = a[pos].Item1;
                        
                             name = b[i].Item2;
                           
                            for (int j = 0; j < u.getCount(); j++)
                            {
                                if (a[j].Item1 == name)
                                {
                                
                                    posamigo = j;
                                label1.Text = meunome;
                                label2.Text = posamigo.ToString();

                               
                                }
                                
                            }
                        am.settRue();
                        
                    }
                    
                }
                if (am.gettRue()==true)
                {
                    MessageBox.Show("Usuário " + name + " adicionado ao proximo evento", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
    public partial class True
    {
        public static bool a = false;
        public bool getA()
        {
            return a;
        }
        public void setA(bool b)
        {
            b = true;
            a = b;
        }
    }
}
