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

    }
}
