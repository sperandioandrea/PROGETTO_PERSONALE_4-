using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGETTO_PERSONALE_4_
{
    public enum AttivitaFisica { Sedentario, ModeratamenteAttivo, Attivo }

    public class CalcoloFabbisognoCaloricoGiornaliero
    {
        //ATTRIBUTI
        public string Sesso { get; set; }
        public double Peso { get; set; }
        public double Altezza { get; set; }
        public int Eta { get; set; }
        public AttivitaFisica LivelloAttivita { get; set; }



        //COSTRUTTORE SENZA PARAMETRI
        public CalcoloFabbisognoCaloricoGiornaliero()
        {
            Sesso = string.Empty; ;
            Peso = 0;
            Altezza = 0;
            Eta = 0;
            LivelloAttivita = new AttivitaFisica();
        }

        //COSTRUTTORE CON PARAMETRI
        public CalcoloFabbisognoCaloricoGiornaliero(string sesso, double peso, double altezza, int eta, AttivitaFisica livelloAttivita)
        {
            Sesso = sesso;
            Peso = peso;
            Altezza = altezza;
            Eta = eta;
            LivelloAttivita = livelloAttivita;
        }

        //COSTRUTTORE DI COPIA
        public CalcoloFabbisognoCaloricoGiornaliero(CalcoloFabbisognoCaloricoGiornaliero c)
        {
            Sesso = c.Sesso;
            Peso = c.Peso;
            Altezza = c.Altezza;
            Eta = c.Eta;
            LivelloAttivita = c.LivelloAttivita;
        }
    }
}
