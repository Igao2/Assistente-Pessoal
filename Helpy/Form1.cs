using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Runtime;

namespace Helpy
{
    public partial class Cadastro : Form
    {
        public string originalUsuario = "Nome de usuário";
        public string originalEmail = "Email";
        public string originalTelefone = "Telefone";
        public string originalSenha = "Senha";
      
        public int us = 0;
        public int ema = 0;
        public int tel = 0;
        public int pass = 0;
        
        int countL = 0;
        
        public Cadastro()
        {
            InitializeComponent();
            butLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            butLogin.FlatAppearance.BorderSize = 0;
            butLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(173, 122, 181);
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
            this.Hide();
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
            countL++;
            string arroba = "@";
            string com = ".com";
            if (email.Text != "" && email.Text != originalEmail && usuario.Text != "" && usuario.Text!= originalUsuario && telefone.Text != "" && telefone.Text != originalTelefone && senha.Text != "" && senha.Text != originalSenha)
            {
                if (email.Text.Contains(arroba) && email.Text.Contains(com))
                {
                    User u = new User();
                    List<Tuple<string, string, string, string>> b = u.getUsuario();
                    if(u.getCount()>0)
                    {
                        for(int i = 0; i < b.Count; i++)
                        {
                            if (b[i].Item1 == usuario.Text || b[i].Item2 == email.Text )
                            {
                                DialogResult dr = MessageBox.Show("Usuário já cadastrado!");
                                usuario.Text = originalUsuario;
                                email.Text = originalEmail;
                                telefone.Text = originalTelefone;
                                senha.Text = originalSenha;
                                
                                countL = -1;
                              
                            }
                            
                        }
                        if (countL!=-1)
                        {
                            u.setUsuario(usuario.Text, email.Text, telefone.Text, senha.Text);
                            List<Tuple<string, string, string, string>> t = u.getUsuario();

                            MessageBox.Show("Cadastro realizado com sucesso, seja bem vindo " + t[u.getCount()].Item1 + " ", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            u.setCount();
                            senha.Text = originalSenha;
                            this.Hide();
                            Loginpopu login = new Loginpopu();
                            login.Show();
                        }
                        
                    }
                    else
                    {
                        u.setUsuario(usuario.Text, email.Text, telefone.Text, senha.Text);
                        List<Tuple<string, string, string, string>> t = u.getUsuario();

                        MessageBox.Show("Cadastro realizado com sucesso, seja bem vindo " + t[u.getCount()].Item1 + " ", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        u.setCount();
                        usuario.Text = originalUsuario;
                        email.Text = originalEmail;
                        telefone.Text = originalTelefone;
                        senha.Text = originalSenha;
                        this.Hide();
                        Loginpopu login = new Loginpopu();
                        login.Show();

                    }
                    
                }
                else
                {
                    MessageBox.Show("E-mail inválido", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            else
            {
                MessageBox.Show("Preencha todos os campos!!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                usuario.Text = originalUsuario;
                email.Text = originalEmail;
                senha.Text = originalSenha;
                telefone.Text= originalTelefone;
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
        
        

        private void Cadastro_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
