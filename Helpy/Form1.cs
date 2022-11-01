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
    public partial class Cadastro : Form
    {
        public int us = 0;
        public int ema = 0;
        public int tel = 0;
        public int pass = 0;
        public Cadastro()
        {
            InitializeComponent();
            butLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            butLogin.FlatAppearance.BorderSize = 0;
            butLogin.FlatAppearance.MouseDownBackColor = Color.Transparent;
            butLogin.FlatAppearance.MouseOverBackColor = Color.Transparent;
            butLogin.BackColor = Color.Transparent;
            butCad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            butCad.FlatAppearance.BorderSize = 0;
            butCad.FlatAppearance.MouseDownBackColor = Color.Transparent;
            butCad.FlatAppearance.MouseOverBackColor = Color.Transparent;
            butCad.BackColor = Color.Transparent;
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void TextoAuto()
        {
            usuario.Text = "Nome de usuário";
        }

        

        private void Usuario_Click(object sender, EventArgs e)
        {
            us++;
            if (usuario.Text == "Nome de usuário")
            {
                usuario.Text = "";
            }

            else
            {
                usuario.Text = usuario.Text;
            }
            if (ema > 0 && us > 0 && email.Text == "")
            {
                email.Text = "Email";
            }
            if (tel > 0 && us > 0 && telefone.Text == "")
            {
                telefone.Text = "Telefone";
            }
            if (pass > 0 && us > 0 && senha.Text == "")
            {
                senha.Text = "Senha";
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Loginpopu loginpopu = new Loginpopu();
          
            loginpopu.Show();
        }

        private void RichTextBox4_Click(object sender, EventArgs e)
        {
            ema++;
            if(email.Text == "Email")
            {
                email.Text = "";
            }
            else
            {
                email.Text = email.Text;    
            }
            if (us > 0 && ema > 0 && usuario.Text == "")
            {
                usuario.Text = "Nome de usuário";
            }
            if (tel > 0 && ema > 0 && telefone.Text == "")
            {
                telefone.Text = "Telefone";
            }
            if(pass>0 && ema>0 && senha.Text == "")
            {
                senha.Text = "Senha";
            }
            
        }

        private void RichTextBox5_Click(object sender, EventArgs e)
        {
            tel++;
            
            if (telefone.Text == "Telefone")
            {
                telefone.Text = "";
            }

            else
            {
                telefone.Text = telefone.Text;
            }
            if (ema > 0 && tel > 0 && email.Text == "")
            {
                email.Text = "Email";
            }
            
            if (pass > 0 && tel > 0 && senha.Text == "")
            {
                senha.Text = "Senha";
            }
            if(us > 0 && tel > 0 && usuario.Text == "")
            {
                usuario.Text = "Nome de usuário";
            }
        }


        private void senha_Click(object sender, EventArgs e)
        {
            pass++;
            if (senha.Text == "Senha")
            {
                senha.Text = "";
            }

            else
            {
                senha.Text = senha.Text;
            }
            if (ema > 0 && pass > 0 && email.Text == "")
            {
                email.Text = "Email";
            }
            if (tel > 0 && pass > 0 && telefone.Text == "")
            {
                telefone.Text = "Telefone";
            }
            if(us>0 && pass > 0 && usuario.Text == "")
            {
                usuario.Text = "Nome de usuário";
            }
        }
    }
}
