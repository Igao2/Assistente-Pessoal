using System;
using System.Collections;
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
    public partial class Loginpopu : Form
    {
        public Loginpopu()
        {
            InitializeComponent();
            buttonlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonlogin.FlatAppearance.BorderSize = 0;
            buttonlogin.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonlogin.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonlogin.BackColor = Color.Transparent;
        }
        public int em = 0;
        public int pas = 0;

        private void Loginpopu_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void email_Click(object sender, EventArgs e)
        {
            em++;
            if (email.Text == "Email")
            {
                email.Text = "";
            }
            else
            {
                email.Text = email.Text;
            }
            if (pas > 0 && em > 0 && senha.Text == "")
            {
                senha.Text = "Senha";
            }
        }

        private void senha_Click(object sender, EventArgs e)
        {
            pas++;
            if (senha.Text == "Senha")
            {
                senha.Text = "";
            }
            else
            {
                senha.Text = senha.Text;
            }
            if (em > 0 && pas > 0 && email.Text == "")
            {
                email.Text = "Email";
            }
        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            
        }

        private void Buttonlogin_Click(object sender, EventArgs e)
        {
            User u = new User();
            List<Tuple<string, string, string, string>> a = u.getUsuario();
            int contador = u.getCount();

            for (int i = 0; i < contador; i++)
            {
                if (a[i].Item2 == email.Text && a[i].Item4 == senha.Text)
                {
                   
                    u.setposAtual(i);
                    Homepage h = new Homepage();
                    Cadastro cad = new Cadastro();
                    cad.Hide();
                    this.Hide();
                    h.Closed += (s, args) => this.Close();

                    h.Show();


                }
                else
                {
                    MessageBox.Show("Email e/ou Senha incorreto(s)!!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                }

            }
        }
    }
}
