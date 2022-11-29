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
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.BackColor = Color.Transparent;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User u = new User();
            int posatual = u.getposAtual();
            Calendario cal = new Calendario();
            cal.setTarefa(posatual, textBox2.Text);
            checkedListBox1.Items.Add(textBox2.Text);
            cal.setcontTarefa();
            textBox2.Text = "";
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            
        }

        private void Tasks_Load(object sender, EventArgs e)
        {
            
            
        }

        private void CheckedListBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {

                DialogResult dr = MessageBox.Show("Deseja excluir a tarefa?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
}
