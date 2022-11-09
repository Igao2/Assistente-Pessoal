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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calendario cal = new Calendario();
            User u = new User();
            int a = cal.getcontItem();
            cal.setEvento(u.getposAtual(), textBox1.Text, textBox2.Text, textBox3.Text);
            cal.setcontItem();
            List<Tuple<int, string, string, string>> b = cal.getEvento();
            ListViewItem item = new ListViewItem(b[a].Item4);
            item.SubItems.Add(b[a].Item2);
            item.SubItems.Add(b[a].Item3);
            listView1.Items.Add(item);
           
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
            if (cal.getcontItem() > 0)
            {
                for (int i = 0; i < cal.getcontItem(); i++)
                {
                    b = cal.getEvento();
                    if (b[i].Item1 == u.getposAtual())
                    {
                        ListViewItem item = new ListViewItem(b[i].Item4);
                        item.SubItems.Add(b[i].Item2);
                        item.SubItems.Add(b[i].Item3);
                        listView1.Items.Add(item);
                    }
                }
            }
           

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
