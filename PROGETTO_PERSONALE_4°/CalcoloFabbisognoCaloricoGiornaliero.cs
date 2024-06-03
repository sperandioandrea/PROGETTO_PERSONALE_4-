using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace PROGETTO_PERSONALE_4_
{
    //Enumerazione che rappresenta i livelli di attività fisica
    public enum AttivitaFisica { Sedentario, ModeratamenteAttivo, Attivo }

    //Classe per il calcolo del fabbisogno calorico giornaliero
    public class CalcoloFabbisognoCaloricoGiornaliero
    {
        // Attributi
        public string Sesso { get; set; } //Sesso della persona
        public double Peso { get; set; } //Peso della persona
        public double Altezza { get; set; } //Altezza della persona
        public int Eta { get; set; } //Età della persona
        public AttivitaFisica LivelloAttivita { get; set; } //Livello di attività fisica della persona

        //Costruttore senza parametri che inizializza gli attributi
        public CalcoloFabbisognoCaloricoGiornaliero()
        {
            Sesso = string.Empty; //Inizializza il sesso come stringa vuota
            Peso = 0; //Inizializza il peso come zero
            Altezza = 0; //Inizializza l'altezza come zero
            Eta = 0; //Inizializza l'età come zero
            LivelloAttivita = AttivitaFisica.Sedentario; // Impostazione predefinita del livello di attività fisica
        }

        // Costruttore con parametri che imposta gli attributi con i valori forniti
        public CalcoloFabbisognoCaloricoGiornaliero(string sesso, double peso, double altezza, int eta, AttivitaFisica livelloAttivita)
        {
            Sesso = sesso; // Imposta il sesso con il valore fornito
            Peso = peso; // Imposta il peso con il valore fornito
            Altezza = altezza; // Imposta l'altezza con il valore fornito
            Eta = eta; // Imposta l'età con il valore fornito
            LivelloAttivita = livelloAttivita; // Imposta il livello di attività fisica con il valore fornito
        }

        // Costruttore di copia che copia gli attributi da un'altra istanza di CalcoloFabbisognoCaloricoGiornaliero
        public CalcoloFabbisognoCaloricoGiornaliero(CalcoloFabbisognoCaloricoGiornaliero c)
        {
            Sesso = c.Sesso; // Copia il sesso dall'istanza fornita
            Peso = c.Peso; // Copia il peso dall'istanza fornita
            Altezza = c.Altezza; // Copia l'altezza dall'istanza fornita
            Eta = c.Eta; // Copia l'età dall'istanza fornita
            LivelloAttivita = c.LivelloAttivita; // Copia il livello di attività fisica dall'istanza fornita
        }

        // Funzione per calcolare il fabbisogno calorico giornaliero
        public double CalcolaFabbisognoCaloricoGiornaliero()
        {
            double fabbisognoCalorico = 0;

            // Equazione di Harris-Benedict per il calcolo del metabolismo basale (MB)
            if (Sesso == "uomo")
            {
                fabbisognoCalorico = 88.362 + (13.397 * Peso) + (4.799 * Altezza) - (5.677 * Eta); // Calcolo per l'uomo
            }
            else if (Sesso == "donna")
            {
                fabbisognoCalorico = 447.593 + (9.247 * Peso) + (3.098 * Altezza) - (4.330 * Eta); // Calcolo per la donna
            }
            else
            {
                throw new ArgumentException("Sesso non valido"); // Eccezione se il sesso non è valido
            }

            //Moltiplichiamo MB per il fattore di attività fisica
            switch (LivelloAttivita)
            {
                case AttivitaFisica.Sedentario:
                    fabbisognoCalorico *= 1.2; // Fattore per livello sedentario
                    break;
                case AttivitaFisica.ModeratamenteAttivo:
                    fabbisognoCalorico *= 1.55; // Fattore per livello moderatamente attivo
                    break;
                case AttivitaFisica.Attivo:
                    fabbisognoCalorico *= 1.725; // Fattore per livello attivo
                    break;
            }

            fabbisognoCalorico -= 200; //Sottraiamo 200 calorie per la riduzione desiderata

            return fabbisognoCalorico; //Restituisce il fabbisogno calorico giornaliero calcolato
        }

        //Metodo ToString che restituisce una rappresentazione testuale dell'oggetto
        public override string ToString()
        {
            return $"Sesso: {Sesso}, Peso: {Peso}, Altezza: {Altezza}, Età: {Eta}, Livello Attività: {LivelloAttivita}";
        }

        //Metodo Equals per confrontare due istanze di CalcoloFabbisognoCaloricoGiornaliero
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            CalcoloFabbisognoCaloricoGiornaliero altro = (CalcoloFabbisognoCaloricoGiornaliero)obj;
            return Sesso == altro.Sesso && Peso == altro.Peso && Altezza == altro.Altezza && Eta == altro.Eta && LivelloAttivita == altro.LivelloAttivita;
        }

        //Metodo GetHashCode per ottenere il codice hash dell'oggetto
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

