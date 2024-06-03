using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace PROGETTO_PERSONALE_4_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<string> schede = new List<string>();

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            CaricaSchedeDaJson();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SalvaSchedeInJson();
        }

        // CALCOLO FABBISOGNO CALORICO GIORNALIERO - BOTTONE
        private void CalcoloCalorieButton_Click(object sender, EventArgs e)
        {
            string sesso = SessoComboBox.Text;
            double peso = double.Parse(PesoTextBox.Text);
            double altezza = double.Parse(AltezzaTextBox.Text);
            int eta = int.Parse(EtaTextBox.Text);
            AttivitaFisica livelloAttivita = (AttivitaFisica)LivelloAttivitaComboBox.SelectedIndex;

            CalcoloFabbisognoCaloricoGiornaliero calcolatore = new CalcoloFabbisognoCaloricoGiornaliero(sesso, peso, altezza, eta, livelloAttivita);

            double fabbisognoCalorico = calcolatore.CalcolaFabbisognoCaloricoGiornaliero();

            string risultato = "Fabbisogno Calorico Giornaliero: " + fabbisognoCalorico.ToString() + " cal";
            ListViewItem item = new ListViewItem(risultato);
            listView1.Items.Add(item);

            Calorie.Text = fabbisognoCalorico.ToString();

            schede.Add(risultato);
            SalvaSchedeInJson();
        }

        // CALCOLO GRASSI - BOTTONE
        private void CalcoloGrassibutton_Click(object sender, EventArgs e)
        {
            double peso = double.Parse(PesoTextBox.Text);

            CalcoloGrassi calcolatore = new CalcoloGrassi(peso);

            double grassi = calcolatore.CalcolaGrassi();

            string risultato = "Numero Grassi: " + grassi.ToString() + " g";
            ListViewItem item = new ListViewItem(risultato);
            listView1.Items.Add(item);

            Grassi.Text = grassi.ToString();

            schede.Add(risultato);
            SalvaSchedeInJson();
        }

        // CALCOLO PROTEINE - BOTTONE
        private void CalcoloProteinebutton_Click(object sender, EventArgs e)
        {
            double peso = double.Parse(PesoTextBox.Text);

            CalcoloProteine calcolatore = new CalcoloProteine(peso);

            double proteine = calcolatore.CalcolaProteine();

            string risultato = "Numero Proteine: " + proteine.ToString() + " g";
            ListViewItem item = new ListViewItem(risultato);
            listView1.Items.Add(item);

            Proteine.Text = proteine.ToString();

            schede.Add(risultato);
            SalvaSchedeInJson();
        }

        // CALCOLO CARBOIDRATI - BOTTONE
        private void CalcoloCarboidratibutton_Click(object sender, EventArgs e)
        {
            double peso = double.Parse(PesoTextBox.Text);

            CalcoloCarboidrati calcolatore = new CalcoloCarboidrati(peso);

            double carboidrati = calcolatore.CalcolaCarboidrati();

            string risultato = "Numero Carboidrati: " + carboidrati.ToString() + " g";
            ListViewItem item = new ListViewItem(risultato);
            listView1.Items.Add(item);

            Carboidrati.Text = carboidrati.ToString();

            schede.Add(risultato);
            SalvaSchedeInJson();
        }

        // SERIALIZZAZIONE
        private void SalvaSchedeInJson()
        {
            string json = JsonConvert.SerializeObject(schede, Formatting.Indented);
            File.WriteAllText("scheda.json", json);
        }

        // DESERIALIZZAZIONE
        private void CaricaSchedeDaJson()
        {
            if (File.Exists("scheda.json"))
            {
                string json = File.ReadAllText("scheda.json");
                schede = JsonConvert.DeserializeObject<List<string>>(json) ?? new List<string>();

                foreach (string scheda in schede)
                {
                    listView1.Items.Add(new ListViewItem(scheda));
                }
            }
        }
        
        //BOTTONE PULISCI LISTA
        private void PulisciLista_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        //BOTTONE USCITA DAL PROGRAMMA
        private void UscitaProgramma_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
