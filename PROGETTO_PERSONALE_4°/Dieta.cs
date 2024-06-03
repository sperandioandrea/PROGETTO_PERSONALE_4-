using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGETTO_PERSONALE_4_
{
    public class Dieta
    {
        // Dichiarazione delle proprietà della classe Dieta
        public string Nome { get; set; }          //Nome della dieta
        public List<string> Colazione { get; set; }   //opzioni per la colazione
        public List<string> Snack { get; set; }       //Opzioni per lo spuntino
        public List<string> Pranzo { get; set; }      //Opzioni per il pranzo
        public List<string> Merenda { get; set; }     //Opzioni per la merenda
        public List<string> Cena { get; set; }        //Opzioni per la cena

        // Costruttore per inizializzare una Dieta
        public Dieta(string nome, List<string> colazione, List<string> snack, List<string> pranzo, List<string> merenda, List<string> cena)
        {
            //Inizializzazione delle proprietà della dieta con i valori forniti come parametri
            Nome = nome;                    //Inizializzazione del nome
            Colazione = colazione;          //Inizializzazione delle opzioni per la colazione
            Snack = snack;                  //Inizializzazione delle opzioni per lo spuntino
            Pranzo = pranzo;                //Inizializzazione delle opzioni per il pranzo
            Merenda = merenda;              //Inizializzazione delle opzioni per la merenda
            Cena = cena;                    //Inizializzazione delle opzioni per la cena
        }
    }
}
