using System;

namespace Simona_Verifica4
{
    class Program
    {
        static void Main(string[] args)
        {
            //creo corsi
            Corso analisi1 = new Corso("Analisi1", 12);
            Corso analisi2 = new Corso("Analisi2", 12);
            Corso geometria = new Corso("Geometria", 12);
            Corso fisica1 = new Corso("Fisica1", 9);
            Corso fisica2 = new Corso("Fisica2", 9);

            //creo corsi di laurea
            //CorsoLaurea matematica = new CorsoLaurea(NomeCorsoDiLaurea.Matematica, 3, 36, new List<Corso>(analisi1, analisi2, fisica1, fisica2));
            //CorsoLaurea fisica = new CorsoLaurea(NomeCorsoDiLaurea.Fisica, 3, 36, new List<Corso>(analisi1, analisi2, fisica1, fisica2));
            //CorsoLaurea ingegneria = new CorsoLaurea(NomeCorsoDiLaurea.Ingegneria, 3, 36, new List<Corso>(analisi1, analisi2, fisica1, fisica2));
            
            
            //creo immatricolazioni
            //Immatricolazione imm1 = new Immatricolazione(DateTime.Today, matematica);
            //Immatricolazione imm2 = new Immatricolazione(DateTime.Today, fisica);
            //Immatricolazione imm3 = new Immatricolazione(DateTime.Today, ingegneria);


            ////creo studenti
            //Studente carlo = new Studente("Carlo", "Roma", 1996, imm1);
            //Studente simona = new Studente("Simona", "Rossi", 1996, imm2);
            //Studente pino = new Studente("Pino", "Pinii", 1995, imm3);

            //Esame e1 = carlo.RichiestaEsame("Analisi1"); //e1 != null
            //carlo.EsamePassato(e1);

            //Esame e2 = simona.RichiestaEsame("Fisica1");
            //Esame e3 = simona.RichiestaEsame("Fisica2");
            //simona.EsamePassato(e2);
            //simona.EsamePassato(e3);

            //Esame e4 = pino.RichiestaEsame("Analisi2");
            //pino.EsamePassato(e4);


        }
    }
}
