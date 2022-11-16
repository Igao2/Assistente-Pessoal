using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helpy
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();

            Calendario cal = new Calendario();
            List<Tuple<int, string, string, string>> eve = cal.getEvento();
            User u = new User();
            int posatual = u.getposAtual();
            int contador = cal.getcontItem();
            if (contador > 0)
            {
                for (int i = 0; i < contador; i++)

                {
                    if (eve[i].Item1 == posatual)
                    {
                        string dt = eve[i].Item4;
                        string[] data = dt.Split('/');
                        int ano = int.Parse(data[2]);
                        int mes = int.Parse(data[1]);
                        int dia = int.Parse(data[0]);

                        DateTime dts = new DateTime(ano, mes, dia);

                        calAtual.AddBoldedDate(dts);

                    }
                }
            }
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            
            

        }

        private void calAtual_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void calAtual_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime dat = new DateTime();
            dat = calAtual.SelectionStart;
            string date = dat.ToShortDateString();
            Calendario cal = new Calendario();
            List<Tuple<int, string, string, string>> n = cal.getEvento();
            int contador = cal.getcontItem();
                if(contador > 0)
            {
                string a = "Eventos: ";
                for (int i = 0; i < contador; i++)
                {
                    if (n[i].Item4.Contains(date))
                    {
                        a = a +" "+
                            " " + n[i].Item2;
                    }
                   
                }
                if(a!= "Eventos: ")
                {
                    label1.Text = date + " "+ a;
                }
                else
                {
                    label1.Text = dat.ToShortDateString();
                }
                 
            }
            else
            {

                label1.Text = dat.ToShortDateString();
            }

        }
    }
}
