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
    public partial class Tasks : Form
    {
        public Tasks()
        {
            InitializeComponent();
            Calendario cal = new Calendario();
            int cont = cal.getcontTarefa();
            User u = new User();
            int posatual = u.getposAtual();
            List<Tuple<int, string>> b = cal.getTarefa();
            if(cont>0)
            {
                for(int i = 0;i<cont;i++)
                {
                    if (b[i].Item1 == posatual)
                    {
                        checkedListBox1.Items.Add(b[i].Item2);
                    }

                }
                

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User u = new User();
            int posatual = u.getposAtual();
            Calendario cal = new Calendario();
            cal.setTarefa(posatual, textBox1.Text);
            checkedListBox1.Items.Add(textBox1.Text);
            cal.setcontTarefa();
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            
        }

        private void Tasks_Load(object sender, EventArgs e)
        {
            
            
        }

       
    }
}
