using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGETTO_PERSONALE_4_
{
    public class CalcoloCarboidrati
    {
        // Attributo pubblico per il peso
        public double Peso { get; set; }

        // Costruttore senza parametri che inizializza il peso a 0
        public CalcoloCarboidrati()
        {
            Peso = 0;
        }

        // Costruttore con parametri che imposta il peso con il valore fornito
        public CalcoloCarboidrati(double peso)
        {
            Peso = peso;
        }

        // Costruttore di copia che copia il peso da un'altra istanza di CalcoloCarboidrati
        public CalcoloCarboidrati(CalcoloCarboidrati cr)
        {
            Peso = cr.Peso;
        }

        // Funzione per calcolare i carboidrati giornalieri basati sul peso
        public double CalcolaCarboidrati()
        {
            return Peso * 5;
        }

        // Metodo ToString che restituisce una rappresentazione testuale dell'oggetto
        public override string ToString()
        {
            return $"Peso: {Peso}";
        }

        // Metodo Equals per confrontare due istanze di CalcoloCarboidrati
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            CalcoloProteine altro = (CalcoloProteine)obj;
            return Peso == altro.Peso;
        }

        // Metodo GetHashCode per ottenere il codice hash dell'oggetto
        public override int GetHashCode()
        {
            return Peso.GetHashCode();
        }
    }
}
