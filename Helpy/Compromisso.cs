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
                if (checkBox1.Checked)
                {
                    string[] dt = maskedTextBox2.Text.Split('/');
                    int mes = int.Parse(dt[1]);
                    if (mes<=12)

                    { int conta = 12 - mes;
                        for(int i = 0;i<conta;i++)
                        {
                           
                            dt[1] = mes.ToString();
                            string data = dt[0] + "/" + dt[1] + "/" + dt[2];
                            cal.setEvento(u.getposAtual(), textBox1.Text, maskedTextBox1.Text, data);
                            meunome = "-" + meunome + "-" + textBox1.Text;
                            cal.setLocal(u.getposAtual(), textBox2.Text);
                            cal.setEvento(posamigo, meunome, maskedTextBox1.Text, data);
                            cal.setLocal(posamigo, textBox2.Text);
                            List<Tuple<int, string, string, string>> b = cal.getEvento();
                            ListViewItem item = new ListViewItem(textBox1.Text);
                          
                            item.SubItems.Add(maskedTextBox2.Text);
                            item.SubItems.Add(maskedTextBox1.Text);
                            item.SubItems.Add(textBox2.Text);
                            listView1.Items.Add(item);
                            cal.setcontItem();
                            cal.setcontItem();
                            mes++;
                        }
                       
                    }
                }
                if (!checkBox1.Checked)
                {
                    cal.setEvento(u.getposAtual(), textBox1.Text, maskedTextBox1.Text, maskedTextBox2.Text);
                    cal.setEvento(posamigo, textBox1.Text, maskedTextBox1.Text, maskedTextBox2.Text);
                    cal.setLocal(posamigo, textBox2.Text);
                    cal.setLocal(u.getposAtual(), textBox2.Text);

                    List<Tuple<int, string, string, string>> b = cal.getEvento();
                    ListViewItem item = new ListViewItem(textBox1.Text);
          
                    item.SubItems.Add(maskedTextBox2.Text);
                    item.SubItems.Add(maskedTextBox1.Text);
                    item.SubItems.Add(textBox2.Text);
                    listView1.Items.Add(item);

                    cal.setcontItem();
                    cal.setcontItem();
                }


            }
            else
            {
                if (checkBox1.Checked)
                {
                    string[] dt = maskedTextBox2.Text.Split('/');
                    int mes = int.Parse(dt[1],00);
                    if (mes <= 12)

                    {
                        double conta = 13 - mes;
                        string data;
                        for (int i = 0; i < conta; i++)
                        {
                            cal.setcontItem();
                            if (mes<10)
                            {
                                dt[1] = "0" + mes.ToString();
                            }
                            if(mes>=10)
                            {
                                dt[1] = mes.ToString();
                            }
                            data = dt[0] + "/" + dt[1] + "/" + dt[2];

                            string mees = "Mes: " + i + textBox1.Text;
                            cal.setEvento(u.getposAtual(), textBox1.Text, maskedTextBox1.Text, data);

                                cal.setLocal(u.getposAtual(), textBox2.Text);

                                List<Tuple<int, string, string, string>> bc = cal.getEvento();
                                ListViewItem itemm = new ListViewItem(textBox1.Text);

                                itemm.SubItems.Add(data);
                                itemm.SubItems.Add(maskedTextBox1.Text);
                                itemm.SubItems.Add(textBox2.Text);
                                listView1.Items.Add(itemm);

                                
                            
                            
                            
                            mes++;
                        }

                    }

                }
                if(!checkBox1.Checked && !checkBox2.Checked)
                {
                    cal.setEvento(u.getposAtual(), textBox1.Text, maskedTextBox1.Text, maskedTextBox2.Text);

                    cal.setLocal(u.getposAtual(), textBox2.Text);

                    List<Tuple<int, string, string, string>> b = cal.getEvento();
                    ListViewItem item = new ListViewItem(textBox1.Text);
               
                    item.SubItems.Add(maskedTextBox2.Text);
                    item.SubItems.Add(maskedTextBox1.Text);
                    item.SubItems.Add(textBox2.Text);
                    listView1.Items.Add(item);

                    cal.setcontItem();
                }
                if(checkBox2.Checked)
                {
                    string[] dt = maskedTextBox2.Text.Split('/');
                    string data;
                    int ano = int.Parse(dt[2]);
                  DateTime dat = DateTime.Now.AddYears(3);
                    string v = dat.ToString();
                    int anofinal = dat.Year;
                    
                    
                    int contador = anofinal - ano;
                    for(int i = 0;i<contador;i++)
                    {
                        cal.setcontItem();
                        dt[2] = ano.ToString();
                        data = dt[0] + "/" + dt[1] + "/" + dt[2];
                        cal.setEvento(u.getposAtual(), textBox1.Text, maskedTextBox1.Text, data);
                        cal.setLocal(u.getposAtual(), textBox2.Text);
                        ListViewItem item = new ListViewItem(textBox1.Text);

                        item.SubItems.Add(data);
                        item.SubItems.Add(maskedTextBox1.Text);
                        item.SubItems.Add(textBox2.Text);
                        listView1.Items.Add(item);
                        ano++;
                        
                        
                        
                    }
                    
                }
               
            }



            MessageBox.Show("Compromisso cadastrado", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox1.Text = "";
            maskedTextBox2.Text = "";
            maskedTextBox1.Text = "";
            textBox2.Text = "";
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
           

            List<Tuple<int, string, string, string>> eve = cal.getEvento();
            int posatual = u.getposAtual();
            int conT = cal.getcontItem();
            List<Tuple<int, string>> loc = cal.getLocal();
            if (conT > 0)
            {
                for (int i = 0; i < conT; i++)
                {

                    if (eve[i].Item1 == posatual)
                    {
                        ListViewItem item = new ListViewItem(eve[i].Item2);
                        item.SubItems.Add(eve[i].Item4);
                        item.SubItems.Add(eve[i].Item3);
                        item.SubItems.Add(loc[i].Item2);
                        listView1.Items.Add(item);

                    }
                }



            }


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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_KeyUp(object sender, KeyEventArgs e)
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
                   
                   
                    for (int i = 0; i < iteM; i++)
                    {
                        List<Tuple<int, string, string, string>> f = cal.getEvento();

                        if (f[i].Item4 == list.SubItems[1].Text)
                        {
                            cal.contmenosItem();
                            cal.delEvento(i);
                            cal.delLocal(i);
                            listView1.Items.Remove(list);
                            break;
                            
                            
                        }


                    }
                    




                }


            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked && checkBox2.Checked)
            {
                checkBox2.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox2.Checked)
            {
                checkBox1.Checked = false;
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
