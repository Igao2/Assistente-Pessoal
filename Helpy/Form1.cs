﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Helpy
{
    public partial class Cadastro : Form
    {
        public ArrayList lOgin = new ArrayList();
        public ArrayList sEnha = new ArrayList();
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
        
        

      
        private void Button2_Click(object sender, EventArgs e)
        {
            Loginpopu loginpopu = new Loginpopu();
          
            loginpopu.Show();
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

        

        private void butCad_Click(object sender, EventArgs e)
        {
            string arroba = "@";
            string com = ".com";
            if (email.Text != "" && usuario.Text != "" && telefone.Text != "" && senha.Text != "")
            {
                if (email.Text.Contains(arroba) && email.Text.Contains(com))
                {
                    User u = new User();
                    
                    lOgin.Add(email.Text);
                    sEnha.Add(senha.Text);
                    u.setEmail(lOgin);
                    u.setSenha(sEnha);
                    MessageBox.Show("Cadastro realizado com sucesso, Seja bem vindo!!" , "Mensagem do Sistema",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("E-mail inválido", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void usuario_Click_1(object sender, EventArgs e)
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

        private void email_Click(object sender, EventArgs e)
        {
            ema++;
            if (email.Text == "Email")
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
            if (pass > 0 && ema > 0 && senha.Text == "")
            {
                senha.Text = "Senha";
            }
        }

        private void telefone_Click(object sender, EventArgs e)
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
            if (us > 0 && tel > 0 && usuario.Text == "")
            {
                usuario.Text = "Nome de usuário";
            }
        }
    }
}
