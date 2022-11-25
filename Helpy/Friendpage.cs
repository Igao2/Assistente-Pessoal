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
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.BackColor = Color.Transparent;
        }
        bool find = false;
        string meunome;
        string nomeamigo;
        private void button1_Click(object sender, EventArgs e)
        {
            User u = new User();
            List<Tuple<string, string, string, string>> b = u.getUsuario();
            int contador = u.getCount();
            Amigo am = new Amigo();
            string a = textBox1.Text;
            for(int i = 0; i < contador; i++)
            {
                if (b[i].Item1 == a && b[u.getposAtual()].Item1 !=a)
                {
                    am.setPosamigo(i);
                    am.setSolicitacao(am.getPosamigo(), b[u.getposAtual()].Item1);
                    MessageBox.Show("Solicitação de amizade enviada", "Mensagem do Sistema", MessageBoxButtons.OK);
                    find = true;
                    am.setcontSolicita();
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
            List<Tuple<int, string>> c = am.getAmigo();
            int contamigo = am.getcontAmigo();
            int contsol = am.getcontSolicita();
            if ( contador>0)
            {  if(contamigo>0)
                {
                    for(int i = 0;i<contamigo;i++)
                    {
                        if(c[i].Item1==u.getposAtual())
                        {
                            listView1.Items.Add(c[i].Item2);
                        }
                    }
                }
                if (contsol>0)
                {
                    for (int i = 0; i < contsol; i++)
                    {

                        if (b[i].Item1 == pos)
                        {
                            nomeamigo = b[i].Item2;
                            meunome = s[pos].Item1;
                            DialogResult dr = MessageBox.Show("O usuário " + b[i].Item2 + " lhe enviou uma solicitação de amizade,deseja aceitar?", "Mensagem do Sistema", MessageBoxButtons.YesNoCancel);
                            if (dr == DialogResult.Yes)
                            {
                                for (int j = 0; j < s.Count; j++)
                                {
                                    if (s[j].Item1 == nomeamigo)
                                    {
                                        pos2 = j;
                                        
                                        am.setAmigo(pos,nomeamigo);
                                        am.setAmigo(pos2,meunome);
                                        listView1.Items.Add(nomeamigo);
                                        am.setcontAmigo();
                                        am.setcontAmigo();
                                        am.delSolicitacao(i);
                                        am.delcontSolicita();
                                        
                                    }
                                }
                            }
                            else
                            {
                                am.delSolicitacao(0);
                            }
                            break;
                        }


                    }
                }   
            }
        }

        private void ListView1_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
