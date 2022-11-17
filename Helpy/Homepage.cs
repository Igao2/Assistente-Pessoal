using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Hosting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helpy
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
            butlogoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            butlogoff.FlatAppearance.BorderSize = 0;
            butlogoff.FlatAppearance.MouseDownBackColor = Color.Transparent;
            butlogoff.FlatAppearance.MouseOverBackColor = Color.Transparent;
            butlogoff.BackColor = Color.Transparent;
            butHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            butHome.FlatAppearance.BorderSize = 0;
            butHome.FlatAppearance.MouseDownBackColor = Color.FromArgb(173, 122, 181);
            butHome.FlatAppearance.MouseOverBackColor = Color.Transparent;
            butHome.BackColor = Color.Transparent;
            User u = new User();
            List<Tuple<string, string, string, string>> b = u.getUsuario();
            int cont = u.getCount();
            int posatual = u.getposAtual();

            for(int i =0;i<cont;i++)
            {
                if(i == posatual)
                {
                    label2.Text = b[i].Item1;
                }
            }
        }
        bool aviso = false;
        private void Homepage_Load(object sender, EventArgs e)
        {
            this.formLoader.Controls.Clear();
             HomeScreen hs= new HomeScreen() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.formLoader.Controls.Add(hs);
            hs.Show();
            
        }

        private void Homepage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Cadastro cad = new Cadastro();
            cad.Show();
            this.Hide();
        }

        private void logoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro cad = new Cadastro();
            cad.Show();
            this.Close();

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MonthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        

  

        private void Compromissos_Click(object sender, EventArgs e)
        {
            Change();
            Tarefas.BackColor = Color.Orchid; ;

            this.formLoader.Controls.Clear();
            Tasks tas = new Tasks() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.formLoader.Controls.Add(tas);
            tas.Show();
            

        }

        private void Compromissos_Click_1(object sender, EventArgs e)
        {
            Change();
            Compromissos.BackColor = Color.Orchid;
            this.formLoader.Controls.Clear();
            Compromisso com = new Compromisso() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.formLoader.Controls.Add(com);
            com.Show();
            

        }

        private void butlogoff_Click(object sender, EventArgs e)
        {
            Cadastro cad = new Cadastro();
            this.Hide();
            cad.Show();
        }

        private void butHome_Click(object sender, EventArgs e)
        {
            Change();
            this.formLoader.Controls.Clear();
            HomeScreen hs = new HomeScreen() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.formLoader.Controls.Add(hs);
            hs.Show();
        }

        private void Amigos_Click(object sender, EventArgs e)
        {
            Change();
            Amigos.BackColor = Color.Orchid;
            this.formLoader.Controls.Clear();
            Friendpage fp = new Friendpage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.formLoader.Controls.Add(fp);
            fp.Show();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = new DateTime();
            dt = DateTime.Now;
            label1.Text = DateTime.Now.ToString("HH:mm:ss");
            Calendario cal = new Calendario();
            User u = new User();
            int posatual = u.getposAtual();
            List<Tuple<int, string,string,string>> b = cal.getEvento();
            int contador = cal.getcontItem();
            int pos = 0;
            string evento = " ";
            if(contador>0)
            {
                for(int i = 0;i<contador;i++)
                {
                    if (b[i].Item1 == posatual)
                    {
                        if (aviso==false)
                        {
                            if (b[i].Item3 == DateTime.Now.ToString("HH:mm") && b[i].Item4 == DateTime.Now.ToString("dd/MM/yyyy"))
                            {
                                evento = b[i].Item2;
                                pos = i;
                                aviso = true;

                            }
                        }
                        
                    }
                }
                if(aviso==true)
                {
                    timer1.Stop();
                    MessageBox.Show("Você tem compromisso: \n" + evento + " !!" ,"Mensagem do Sistema",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    cal.delEvento(pos);
                    cal.contmenosItem();
                    aviso = false;
                    timer1.Start();
                }
                

            }
        }

     
        public void Change()
        {
            Tarefas.BackColor = Color.FromArgb(173, 122, 181);
            Compromissos.BackColor = Color.FromArgb(173, 122, 181);
            Amigos.BackColor = Color.FromArgb(173, 122, 181);
        }

        private void ButHome_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.butHome, "Home");
        }

        private void Butlogoff_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.butlogoff, "Fazer Logoff");
        }
    }
}
