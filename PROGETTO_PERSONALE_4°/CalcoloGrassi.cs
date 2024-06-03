using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGETTO_PERSONALE_4_
{
    public class CalcoloGrassi
    {
        // Attributo pubblico per il peso
        public double Peso { get; set; }

        // Costruttore senza parametri che imposta il peso a 0
        public CalcoloGrassi()
        {
            Peso = 0;
        }

        // Costruttore con parametri che imposta il peso con il valore fornito
        public CalcoloGrassi(double peso)
        {
            Peso = peso;
        }

        // Costruttore di copia che copia il peso da un'altra istanza di CalcoloGrassi
        public CalcoloGrassi(CalcoloGrassi g)
        {
            Peso = g.Peso;
        }

        // Funzione per calcolare i grassi giornalieri basati sul peso
        public double CalcolaGrassi()
        {
            return Peso * 0.9;
        }

        // Metodo ToString che restituisce una rappresentazione testuale dell'oggetto
        public override string ToString()
        {
            return $"Peso: {Peso}";
        }

        // Metodo Equals per confrontare due istanze di CalcoloGrassi
        public override bool Equals(object obj)
        {
            // Verifica se l'oggetto è nullo o non è dello stesso tipo di CalcoloGrassi
            if (obj == null || GetType() != obj.GetType())
                return false;

            // Converte l'oggetto in CalcoloGrassi
            CalcoloGrassi altro = (CalcoloGrassi)obj;

            // Confronta i pesi delle due istanze
            return Peso == altro.Peso;
        }

        // Metodo GetHashCode per ottenere il codice hash dell'oggetto
        public override int GetHashCode()
        {
            return Peso.GetHashCode();
        }

    }
}
