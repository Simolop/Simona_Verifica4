using System;
using System.Collections.Generic;
using System.Text;

namespace Simona_Verifica4
{ 
    //ha bisogno del corso
    class Immatricolazione
    {
        private static int _matricola;
        public int Matricola { get; }
        public DateTime DataInizio { get; }
        public string CorsoDiLaurea { get; }
        public bool FuoriCorso { get; set; }
        public int CFUAccumulati { get; set; }



        //Costruttore
        public Immatricolazione (int matricola, DateTime dataInizio, string corsoDiLaurea, bool fuoriCorso, int cfuAccumulati)
        {
            Matricola = ++_matricola;
            DataInizio = dataInizio;
            CorsoDiLaurea = corsoDiLaurea;
            FuoriCorso = fuoriCorso;
            CFUAccumulati = cfuAccumulati;
        }


    }
}
