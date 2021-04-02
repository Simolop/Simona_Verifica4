using System;
using System.Collections.Generic;
using System.Text;

namespace Simona_Verifica4
{
    class Corso
    {
        public string NomeCorso { get; }
        public int CFU { get; }

        //Costruttore
        public Corso (string nomeCorso, int cfu)
        {
            NomeCorso = nomeCorso;
            CFU = cfu;
        }
    }
}
