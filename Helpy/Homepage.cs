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
        }

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

        private void Button2_MouseEnter(object sender, EventArgs e)
        {
            Compromissos.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void Button2_MouseLeave(object sender, EventArgs e)
        {
            Compromissos.BackColor = Color.FromArgb(173, 122, 181);
        }

        private void Compromissos_MouseEnter(object sender, EventArgs e)
        {
            Tarefas.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void Compromissos_MouseLeave(object sender, EventArgs e)
        {
            Tarefas.BackColor = Color.FromArgb(173, 122, 181);
        }

        private void Compromissos_Click(object sender, EventArgs e)
        {
            

        }

        private void Compromissos_Click_1(object sender, EventArgs e)
        {
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
    }
}
