using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGETTO_PERSONALE_4_
{
    public class CalcoloProteine
    {
        //ATTRIBUTI
        public double Peso { get; set; }




        //COSTRUTTORE SENZA PARAMETRI
        public CalcoloProteine()
        {
            Peso = 0;
        }

        //COSTRUTTORE CON PARAMETRI
        public CalcoloProteine(double peso)
        {
            Peso = peso;
        }

        //COSTRUTTORE DI COPIA
        public CalcoloProteine(CalcoloProteine p)
        {
            Peso = p.Peso;
        }




        //FUNZIONE CALCOLO PROTEINE GIORNALIERE


    }
}
