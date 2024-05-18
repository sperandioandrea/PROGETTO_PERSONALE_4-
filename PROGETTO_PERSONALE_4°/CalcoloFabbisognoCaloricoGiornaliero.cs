using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Newtonsoft.Json;

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

        //COSTRUTTORE DI COPIA.
        public CalcoloFabbisognoCaloricoGiornaliero(CalcoloFabbisognoCaloricoGiornaliero c)
        {
            Sesso = c.Sesso;
            Peso = c.Peso;
            Altezza = c.Altezza;
            Eta = c.Eta;
            LivelloAttivita = c.LivelloAttivita;
        }




        //FUNZIONE CHE CALCOLA IL FABBISOGNO CALORICO GIORNALIERO
        public double CalcolaFabbisognoCaloricoGiornaliero()
        {
            double fabbisognoCalorico = 0;

            //Equazione di Harris-Benedict per il calcolo del metabolismo basale (MB)
            if (Sesso == "uomo")
            {
                fabbisognoCalorico = 88.362 + (13.397 * Peso) + (4.799 * Altezza) - (5.677 * Eta);
            }
            else if (Sesso == "donna")
            {
                fabbisognoCalorico = 447.593 + (9.247 * Peso) + (3.098 * Altezza) - (4.330 * Eta);
            }
            else
            {
                throw new ArgumentException("Sesso non valido");
            }

            // Moltiplichiamo MB per il fattore di attività fisica
            switch (LivelloAttivita)
            {
                case AttivitaFisica.Sedentario:
                    fabbisognoCalorico *= 1.2; // Sedentario
                    break;
                case AttivitaFisica.ModeratamenteAttivo:
                    fabbisognoCalorico *= 1.55; // Moderatamente attivo
                    break;
                case AttivitaFisica.Attivo:
                    fabbisognoCalorico *= 1.725; // Attivo
                    break;
            }

            fabbisognoCalorico -= 200;
            return fabbisognoCalorico;
        }




        //METODO ToString
        public override string ToString()
        {
            return $"Sesso: {Sesso}, Peso: {Peso}, Altezza: {Altezza}, Età: {Eta}, Livello Attività: {LivelloAttivita}";
        }

        //METODO Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            CalcoloFabbisognoCaloricoGiornaliero altro = (CalcoloFabbisognoCaloricoGiornaliero)obj;
            return Sesso == altro.Sesso && Peso == altro.Peso && Altezza == altro.Altezza && Eta == altro.Eta && LivelloAttivita == altro.LivelloAttivita;
        }

        //MOTODO GetHashCode
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

