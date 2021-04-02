using System;
using System.Collections.Generic;
using System.Text;

namespace Simona_Verifica4
{
    enum NomeCorsoDiLaurea
    {
        Matematica,
        Fisica,
        Informatica, 
        Ingegneria,
        Lettere
    }

    class CorsoLaurea
    {
        private List<Corso> _corsi = new List<Corso>();
        
        public NomeCorsoDiLaurea Nome{ get; }
        public int AnniDiCorso { get; }
        public int CFUTot { get; }

       

        public CorsoLaurea(List<Corso> corso, NomeCorsoDiLaurea nome, int anniDiCorso, int cfuTot)
        {
           Nome = nome;
           AnniDiCorso = anniDiCorso;
           CFUTot = cfuTot;
            
        }


        

        
    }
}
