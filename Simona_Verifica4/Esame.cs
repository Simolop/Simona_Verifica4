using System;
using System.Collections.Generic;
using System.Text;

namespace Simona_Verifica4
{
    class Esame
    {
       

        private List<Studente> _studenti = new List<Studente>();

        public string NomeEsame { get; }
        public DateTime DataEsame { get; }
        public int Esito { get; }

        public Corso Corso { get; }

        //Costruttore
        public Esame (string nomeEsame, DateTime dataEsame, int esito, Corso corso)
        {
            NomeEsame = nomeEsame;
            DataEsame = dataEsame;
            Esito = esito;
            Corso = corso;
        }


        public Esame(params Studente[] studenti)
        {
            foreach (Studente studente in studenti)
            {
                _studenti.Add(studente);
            }
        }
    }
}
