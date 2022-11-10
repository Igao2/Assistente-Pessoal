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
    public partial class Friendpage : Form
    {
        public Friendpage()
        {
            InitializeComponent();
        }
        bool find = false;
        private void button1_Click(object sender, EventArgs e)
        {
            User u = new User();
            List<Tuple<string, string, string, string>> b = u.getUsuario();
            int contador = u.getCount();
            Amigo am = new Amigo();
            string a = textBox1.Text;
            for(int i = 0; i < contador; i++)
            {
                if (b[i].Item1 == a)
                {
                    am.setPosamigo(i);
                    am.setSolicitacao(am.getPosamigo(), b[i].Item1);
                    MessageBox.Show("Solicitação de amizade enviada", "Mensagem do Sistema", MessageBoxButtons.OK);
                    find = true;
                }
                
            }
            if (find == false)
            {
                MessageBox.Show("Usuário não encontrado", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Friendpage_Load(object sender, EventArgs e)
        {
            Amigo am = new Amigo();
            List<Tuple<int, string>> b = am.getSolicitacao();
            User u = new User();
            List<Tuple<string, string, string, string>> s = u.getUsuario();
            int pos = u.getposAtual();

            int pos2 = 0;
            int contador = u.getCount();
            if ( s.Count > 1)
            {
                for (int i = 0; i < contador; i++)
                {
                    if (b.Count > 0)
                    {
                        if (b[i].Item1 == pos)
                        {
                            string name= b[i].Item2;
                            DialogResult dr = MessageBox.Show("O usuário " + b[i].Item2 + " Lhe enviou uma solicitação de amizade,deseja aceitar?", "Mensagem do Sistema", MessageBoxButtons.YesNoCancel);
                            if (dr == DialogResult.Yes)
                            {
                                for (int j = 0; j < contador; j++)
                                {
                                    if (s[j].Item1 == name)
                                    {
                                        pos2 = j;
                                        am.setAmigo(pos2, name);
                                        am.setAmigo(pos, s[j].Item1);
                                        am.delSolicitacao(j);
                                    }
                                }
                            }
                            else
                            {
                                am.delSolicitacao(i);
                            }
                        }
                    }
                    

                }
            }
        }
    }
}
