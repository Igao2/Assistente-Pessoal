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
using System.Net.Mail;
using System.Net;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;

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
        string eM = " ";
        string sE = " ";
        bool lgin = false;
        int count = 0;
        private void Loginpopu_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void enviarEmailerro()
        {
            string email = Interaction.InputBox("E-mail não encontrado, por favor digite o email registrado ou outro email", "Erro");
            try
            {
                MailMessage mail = new MailMessage("projetohelpy1@outlook.com", email);
                mail.Subject = "Recuperar senha";
                SmtpClient smtp = new SmtpClient("smtp.office365.com", 587);
                smtp.UseDefaultCredentials = false;
                mail.Body = "Sua senha é: " + sE;
                smtp.Credentials = new NetworkCredential("projetohelpy1@outlook.com", "1234@.com");
                smtp.EnableSsl = true;
                smtp.Send(mail);
                MessageBox.Show("Sucesso!! Sua senha foi enviada para seu email registrado", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                enviarEmailerro();
            }
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
        public void semnetErro()
        {
            Random rand = new Random();
            string z = rand.Next(0,1000).ToString();
            MessageBox.Show("Você recebérá uma notificação com o codigo a ser digitado!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            notifyIcon1.ShowBalloonTip(5000, "Código", "Digite esse código para receber sua senha: " + z, ToolTipIcon.Info);
            string ez = Interaction.InputBox("Digite o código que foi enviado por notificação", "Mensagem do sistema");
            if (ez == z)
            {
                MessageBox.Show("Sua senha é " + sE, "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Código incorreto, por favor tente novamente","Mensagem do Sistema",MessageBoxButtons.OK,MessageBoxIcon.Error);
                semnetErro();
            }
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
                        
                        this.Close();
                     
                    lgin = true;

                    h.Show();


                    }
                if (a[i].Item2 == email.Text && a[i].Item4 != senha.Text)
                {
                    eM = a[i].Item2;
                    sE = a[i].Item4;
                }
                    
                
                

            }
            
            if(lgin==false)
            {
                MessageBox.Show("Email e/ou Senha incorreto(s)!!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                count++;
                if(count>1)
                {
                    if(u.getCount()>0)
                    {
                        for(int i = 0; i<u.getCount();i++)
                        {
                            List<Tuple<string, string, string, string>> b = u.getUsuario();
                            if (b[i].Item2 == email.Text)
                            {
                                eM = b[i].Item2;
                                sE = b[i].Item4;
                                Network net = new Network();
                                if (net.IsAvailable)
                                {
                                    MessageBox.Show("Sua senha será enviada para o email registrado", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    try
                                    {
                                        MailMessage mail = new MailMessage("projetohelpy@outlook.com", eM);
                                        mail.Subject = "Recuperar senha";
                                        SmtpClient smtp = new SmtpClient("smtp.office365.com", 587);
                                        smtp.UseDefaultCredentials = false;
                                        mail.Body = "Sua senha é: " + sE;
                                        smtp.Credentials = new NetworkCredential("projetohelpy@outlook.com", "1234@.com");
                                        smtp.EnableSsl = true;
                                        smtp.Send(mail);
                                        MessageBox.Show("Sucesso!! Sua senha foi enviada para seu email registrado", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    catch (Exception)
                                    {
                                        enviarEmailerro();
                                    }
                                }
                                else
                                {
                                    semnetErro();
                                }
                            }
                            
                                
                           
                        }
                    }
                }
            }
                

        }
        

        private void Loginpopu_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }
    }

}

