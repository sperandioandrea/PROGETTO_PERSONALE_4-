﻿using System;
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
        public double CalcolaProteine()
        {
            return Peso * 2;
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

            CalcoloProteine altro = (CalcoloProteine)obj;
            return Peso == altro.Peso;
        }

        //METODO GetHashCode
        public override int GetHashCode()
        {
            return Peso.GetHashCode();
        }
    }
}
