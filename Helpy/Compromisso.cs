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
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.BackColor = Color.Transparent;

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



            MessageBox.Show("Compromisso cadastrado", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void MaskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void ListView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

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
