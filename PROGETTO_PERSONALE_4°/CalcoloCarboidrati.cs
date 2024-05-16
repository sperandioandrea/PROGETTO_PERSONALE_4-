using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGETTO_PERSONALE_4_
{
    public class CalcoloCarboidrati
    {
        //ATTRIBUTI
        public double Peso { get; set; }



        //COSTRUTTURE SENZA PARAMETRI
        public CalcoloCarboidrati() 
        {
            Peso = 0;
        }

        //COSTRUTTORE CON PARAMETRI
        public CalcoloCarboidrati(double peso)
        {
            Peso = peso;    
        }

        //COSTRUTTORE DI COPIA
        public CalcoloCarboidrati(CalcoloCarboidrati cr)
        {
            Peso = cr.Peso;
        }



        //FUNZIONE CALCOLO CARBOIDRATI GIORNALIERI
        public double CalcolaCarboidrati()
        {
            return Peso * 5;
        }



        //METODO ToString
        public override string ToString()
        {
            return $"Peso: {Peso}";
        }
    }
}
