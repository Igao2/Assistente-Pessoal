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
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calendario cal = new Calendario();
            User u = new User();
            List<Tuple<string, string, string, string>> b = u.getUsuario();
            int contador = u.getCount();
            for(int i = 0; i<contador;i++)
            {
                if (i==u.getposAtual())
                {
                    u.editUsuario(i, textBox2.Text, b[i].Item2, b[i].Item3, b[i].Item4);
                    List<Tuple<string, string, string, string>> z = u.getUsuario();
                    label1.Text = z[i].Item1;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
