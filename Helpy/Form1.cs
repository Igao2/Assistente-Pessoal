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
    public partial class Form1 : Form
    {
        public Form1()
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

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Usuario_Click(object sender, EventArgs e)
        {
            usuario.Text = "";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Loginpopu loginpopu = new Loginpopu();
            loginpopu.Show();
        }

        private void RichTextBox4_Click(object sender, EventArgs e)
        {
            richTextBox4.Text = "";
        }

        private void RichTextBox5_Click(object sender, EventArgs e)
        {
            richTextBox5.Text = "";
        }

        private void RichTextBox6_Click(object sender, EventArgs e)
        {
            richTextBox6.Text = "";

        }

       
    }
}
