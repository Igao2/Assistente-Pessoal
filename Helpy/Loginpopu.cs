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
    public partial class Loginpopu : Form
    {
        public Loginpopu()
        {
            InitializeComponent();
            butLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            butLogin.FlatAppearance.BorderSize = 0;
            butLogin.FlatAppearance.MouseDownBackColor = Color.Transparent;
            butLogin.FlatAppearance.MouseOverBackColor = Color.Transparent;
            butLogin.BackColor = Color.Transparent;
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
            if(email.Text == "Email")
            {
                email.Text = "";
            }
            else
            {
                email.Text = email.Text;
            }
            if(pas > 0 && em >0 && senha.Text == "")
            {
                senha.Text = "Senha";
            }
        }

        private void senha_Click(object sender, EventArgs e)
        {
            pas++;
            if(senha.Text == "Senha")
            {
                senha.Text = "";
            }
            else
            {
                senha.Text = senha.Text;
            }
            if(em > 0 && pas > 0 && email.Text == "")
            {
                email.Text = "Email";
            }
        }
    }
}
