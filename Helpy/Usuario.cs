using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
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
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.BackColor = Color.Transparent;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.BackColor = Color.Transparent;
            button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button3.BackColor = Color.Transparent;
            button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button4.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button4.BackColor = Color.Transparent;
            button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button5.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button5.BackColor = Color.Transparent;
            User u = new User();
            List<Tuple<string, string, string, string>> c = u.getUsuario();
            for(int i =0;i<u.getCount();i++)
            {
                textBox2.Text = c[i].Item1;
                textBox1.Text = c[i].Item2;
                textBox3.Text = c[i].Item3;
                textBox4.Text = c[i].Item4;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calendario cal = new Calendario();
            User u = new User();
            List<Tuple<string, string, string, string>> b = u.getUsuario();
            List<String> c = new List<string>();
            for(int j = 0; j < u.getCount(); j++)
            {
                c.Add(b[j].Item1);
            }
            int contador = u.getCount();
            string a = Interaction.InputBox("Digite sua senha para confirmar a troca de nome de usuario");
    
            for(int i = 0; i<contador;i++)
            {
                if (i==u.getposAtual())
                {

                    if (b[i].Item4 == a)
                    {
                        if (textBox2.Text != "")
                        {
                            if (c.Contains(textBox2.Text))
                            {
                                MessageBox.Show("Nome de usuário já existe", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string nomeantigo = b[u.getposAtual()].Item1;
                                u.editUsuario(i, textBox2.Text, b[i].Item2, b[i].Item3, b[i].Item4);
                                List<Tuple<string, string, string, string>> z = u.getUsuario();

                                string nomeatual = z[i].Item1;
                                Amigo am = new Amigo();
                                List<Tuple<int, string>> s = am.getAmigo();
                                for (int j = 0; j < am.getcontAmigo(); j++)
                                {
                                    if (s[j].Item2 == nomeantigo)
                                    {
                                        am.editAmigo(j, s[j].Item1, nomeatual);
                                    }
                                }
                                MessageBox.Show("Sucesso!Você terá que fazer login novamente para atualizar seus dados");
                                var form = Application.OpenForms["Homepage"] as Homepage;
                                if (form != null)
                                {
                                    form.butlogoff.PerformClick();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Preencha os campos corretamente!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Senha incorreta!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Amigo am = new Amigo();
            User u = new User();
            List<Tuple<string, string, string, string>> b = u.getUsuario();
            Calendario cal = new Calendario();
            List<Tuple<int, string, string, string,string>> c = cal.getEvento();
            List<Tuple<int, string>> d = cal.getTarefa();
            
            List<Tuple<int, string>> amg = am.getAmigo();
            
            int contador = 0;
            int obvio = u.getposAtual() + 1;
            for (int v = 0; v < u.getCount(); v++)
            {
                if (v > u.getposAtual())
                {
                    contador++;
                }
            }
            int cont = 1;
            int a = u.getposAtual() + cont;
            string ez = Interaction.InputBox("Digite sua senha para confirmar a deleção da conta", "Mensagem do Sistema");
            if(ez == b[u.getposAtual()].Item4)
            {
                if (cal.getcontItem() > 0)
                {
                    for (int i = 0; i < cal.getcontItem(); i++)
                    {


                        if (c[i].Item1 == a)
                        {
                            cal.editEvento(i, u.getposAtual(), c[i].Item2, c[i].Item3, c[i].Item4, c[i].Item5);

                            



                        }
                        if (c[i].Item1 == a + 1)
                        {

                            cal.editEvento(i, obvio, c[i].Item2, c[i].Item3, c[i].Item4, c[i].Item5);

                           
                            a++;
                            obvio++;

                        }




                    }
                }
                if (cal.getcontTarefa() > 0)
                {
                    for (int j = 0; j < cal.getcontTarefa(); j++)
                    {
                        a = u.getposAtual() + 1;
                        obvio = u.getposAtual() + 1;
                        if (d[j].Item1 == a)
                        {
                            cal.editTarefa(u.getposAtual(), j, d[j].Item2);
                        }
                        if (d[j].Item1 == a + 1)
                        {
                            cal.editTarefa(obvio, j, d[j].Item2);
                            a++;
                            obvio++;
                        }
                    }
                }
               
                if (am.getcontAmigo()>0)
                {
                    for(int i = 0;i<am.getcontAmigo();i++)
                    {
                        a = u.getposAtual() + 1;
                        obvio = u.getposAtual() + 1;
                        if (amg[i].Item1 == a)
                        {
                            am.editAmigo(i, u.getposAtual(), amg[i].Item2);
                        }
                        if (amg[i].Item1 == a+1)
                        {
                            am.editAmigo(obvio,i,amg[i].Item2);
                            a++;
                            obvio++;
                        }
                    }
                }

                u.delUsuario(u.getposAtual());
                u.delCount();
                var form = Application.OpenForms["Homepage"] as Homepage;
                if (form != null)
                {
                    form.butlogoff.PerformClick();
                }
            }
            else
            {
                MessageBox.Show("Senha incorreta!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calendario cal = new Calendario();
            string arroba = "@";
            string pontocom = ".com";
            User u = new User();
            List<Tuple<string, string, string, string>> b = u.getUsuario();
            List<String> c = new List<string>();
            for (int j = 0; j < u.getCount(); j++)
            {
                c.Add(b[j].Item2);
            }
            int contador = u.getCount();
            if(textBox1.Text.Contains(arroba)&&textBox1.Text.Contains(pontocom))
            {
                string a = Interaction.InputBox("Digite sua senha para confirmar a troca de email");
                for (int i = 0; i < contador; i++)
                {
                    if (i == u.getposAtual())
                    {

                        if (b[i].Item4 == a)
                        {
                            if (c.Contains(textBox1.Text))
                            {
                                MessageBox.Show("E-mail já cadastrado", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                
                                u.editUsuario(i, b[i].Item1, textBox1.Text, b[i].Item3, b[i].Item4);
                                
                                MessageBox.Show("Sucesso!Você terá que fazer login novamente para atualizar seus dados");
                                var form = Application.OpenForms["Homepage"] as Homepage;
                                if (form != null)
                                {
                                    form.butlogoff.PerformClick();
                                }
                            }

                        }
                        else
                        {
                            MessageBox.Show("Senha incorreta!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("Digite um email válido", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Calendario cal = new Calendario();
           
            User u = new User();
            List<Tuple<string, string, string, string>> b = u.getUsuario();
            List<String> c = new List<string>();
            for (int j = 0; j < u.getCount(); j++)
            {
                c.Add(b[j].Item3);
            }
            int contador = u.getCount();
            string a = Interaction.InputBox("Digite sua senha para confirmar a troca de telefone");
            for (int i = 0; i < contador; i++)
            {
                if (i == u.getposAtual())
                {

                    if (b[i].Item4 == a)
                    {
                        if (c.Contains(textBox3.Text))
                        {
                            MessageBox.Show("Telefone já cadastrado", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {

                            u.editUsuario(i, b[i].Item1, b[i].Item2, textBox3.Text, b[i].Item4);
                            
                            MessageBox.Show("Sucesso!Você terá que fazer login novamente para atualizar seus dados");
                            var form = Application.OpenForms["Homepage"] as Homepage;
                            if (form != null)
                            {
                                form.butlogoff.PerformClick();
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Senha incorreta!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Calendario cal = new Calendario();

            User u = new User();
            List<Tuple<string, string, string, string>> b = u.getUsuario();
            List<String> c = new List<string>();
         
            int contador = u.getCount();
            string a = Interaction.InputBox("Digite sua senha atual para confirmar a troca de senha");
            for (int i = 0; i < contador; i++)
            {
                if (i == u.getposAtual())
                {

                    if (b[i].Item4 == a)
                    {
                        
                        

                            u.editUsuario(i, b[i].Item1, b[i].Item2, b[i].Item3, textBox4.Text);
                            
                            MessageBox.Show("Sucesso!Você terá que fazer login novamente para atualizar seus dados");
                            var form = Application.OpenForms["Homepage"] as Homepage;
                            if (form != null)
                            {
                                form.butlogoff.PerformClick();
                            }
                        

                    }
                    else
                    {
                        MessageBox.Show("Senha incorreta!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void Usuario_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }
    }
}



