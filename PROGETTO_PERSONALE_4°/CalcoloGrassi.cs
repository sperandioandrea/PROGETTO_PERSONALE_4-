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
    }
}
