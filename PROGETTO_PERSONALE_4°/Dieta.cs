using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGETTO_PERSONALE_4_
{
    public class Dieta
    {
        public string Nome { get; set; }
        public List<string> Colazione { get; set; }
        public List<string> Snack { get; set; }
        public List<string> Pranzo { get; set; }
        public List<string> Merenda { get; set; }
        public List<string> Cena { get; set; }

        // Costruttore per inizializzare una Dieta
        public Dieta(string nome, List<string> colazione, List<string> snack, List<string> pranzo, List<string> merenda, List<string> cena)
        {
            Nome = nome;
            Colazione = colazione;
            Snack = snack;
            Pranzo = pranzo;
            Merenda = merenda;
            Cena = cena;
        }
    }
}
