﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpy
{
     class Amigo
    {
        public static List<Tuple<int,string>> solicitacao = new List<Tuple<int,string>>();
        public static List<Tuple<int, string>> amigo = new List<Tuple<int, string>>();
        public static int posAmigo = 0;

        public List<Tuple<int, string>> getSolicitacao()
        {
            return solicitacao;
        }
        public void setSolicitacao(int posamigo,string nome)
        {
            solicitacao.Add(Tuple.Create(posamigo,nome));
        }
        public List<Tuple<int, string>> getAmigo()
        {
            return amigo;
        }
        public void setAmigo(int minhapos,string nomeamigo)
        {
            amigo.Add(Tuple.Create(minhapos,nomeamigo));
        }
        public int getPosamigo()
        {
            return posAmigo;
        }
        public void setPosamigo(int posicao)
        {

            posAmigo = posicao;
        }



    }
}
