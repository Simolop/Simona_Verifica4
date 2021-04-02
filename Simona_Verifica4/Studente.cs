using System;
using System.Collections.Generic;
using System.Text;

namespace Simona_Verifica4
{
    //ha bisogno della matricola
    class Studente
    {
        private List<Esame> _esami = new List<Esame>();

        private Immatricolazione _immatricolazione;

        //copia di una lista(shallow copy)
        public List<Esame> Esami
        {
            get
            {
                return new List<Esame>(_esami);
            }
        }

        public string Nome { get; }
        public string Cognome { get; }
        public int AnnoDiNascita { get; }
        public bool RichiestaLaurea { get; }

        

        //Costruttore
        public Studente (string nome, string cognome, int annoDiNascita)
        {
            Nome = nome;
            Cognome = cognome;
            AnnoDiNascita = annoDiNascita;
            
        }



        public void RichiestaEsame(Esame esame )
        {

        //    CorsoLaurea Cl = _immatricolazione.CorsoLaurea;
        //    int MAXCFU = Cl.CFUTot;
        //    int s = 0;

        //    foreach (Esame e in _esami)
        //        s += e.Corso.CFU;

            //if...
            _esami.Add(esame);

        }


    }
}
