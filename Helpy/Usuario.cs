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
                   
                    if (b[i].Item4==a)
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
                            label1.Text = z[i].Item1;
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
                        }
                        
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
                                label1.Text = b[u.getposAtual()].Item2;
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
                            label1.Text = b[u.getposAtual()].Item3;
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
    }
}



