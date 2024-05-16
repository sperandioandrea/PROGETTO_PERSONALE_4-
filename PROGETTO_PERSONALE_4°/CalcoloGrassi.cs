using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGETTO_PERSONALE_4_
{
    public class CalcoloGrassi
    {
        //ATTRIBUTI
        public double Peso { get; set; }

        


        //COSTRUTTORE SENZA PARAMETRI
        public CalcoloGrassi()
        {
            Peso = 0;
        }

        //COSTRUTTORE CON PARAMETRI
        public CalcoloGrassi(double peso)
        {
            Peso = peso;
        }

        //COSTRUTTORE DI COPIA
        public CalcoloGrassi(CalcoloGrassi g)
        {
            Peso = g.Peso;
        }



        //FUNZIONE CALCOLO GRASSI GIORNALIERI
        public double CalcolaGrassi()
        {
            return Peso * 0.9;
        }



        //METODO ToString
        public override string ToString()
        {
            return $"Peso: {Peso}";
        }

        //METODO Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            CalcoloGrassi altro = (CalcoloGrassi)obj;
            return Peso == altro.Peso;
        }

        //METODO GetHashCode
        public override int GetHashCode()
        {
            return Peso.GetHashCode();
        }
    }
}
