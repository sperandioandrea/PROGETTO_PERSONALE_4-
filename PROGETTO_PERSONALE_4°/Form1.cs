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
        //Dichiarazione del campo privato gestoreDiete di tipo GestoreDiete
        private GestoreDiete gestoreDiete;

        public Form1()
        {
            //Inizializzazione del form
            InitializeComponent();
            //Creazione di un'istanza di GestoreDiete
            gestoreDiete = new GestoreDiete();
        }

        //Dichiarazione di una lista di stringhe chiamata schede
        private List<string> schede = new List<string>();

       
        private void Form1_Load(object sender, EventArgs e)
        {
            //Pulisce la listView1
            listView1.Items.Clear();
            //Carica le schede da un file JSON
            CaricaSchedeDaJson();
        }

       
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SalvaSchedeInJson();
        }

        // CALCOLO FABBISOGNO CALORICO GIORNALIERO - BOTTONE (Metodo chiamato quando si clicca sul bottone per il calcolo del fabbisogno calorico giornaliero)
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
            //Metodo per salvare le schede in un file JSON
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

        // Metodo per la serializzazione della lista di schede in JSON e salvataggio su file
        private void SalvaSchedeInJson()
        {
            // Serializza la lista di schede in formato JSON con formattazione indentata
            string json = JsonConvert.SerializeObject(schede, Formatting.Indented);

            // Scrive il JSON nel file "scheda.json"
            File.WriteAllText("scheda.json", json);
        }

        // Metodo per la deserializzazione delle schede da un file JSON e caricamento nella lista schede
        private void CaricaSchedeDaJson()
        {
            // Verifica se il file "scheda.json" esiste
            if (File.Exists("scheda.json"))
            {
                // Legge il contenuto del file "scheda.json"
                string json = File.ReadAllText("scheda.json");

                // Deserializza il JSON in una lista di schede
                // Se il file è vuoto o non può essere deserializzato, crea una nuova lista vuota
                schede = JsonConvert.DeserializeObject<List<string>>(json) ?? new List<string>();

                // Aggiunge ogni scheda alla listView1
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

        //BOTTONE FORMAZIONE DIETA (Metodo chiamato quando si clicca sul bottone per la formazione della dieta)
        private void FormazioneDieta_Click(object sender, EventArgs e)
        {
            // Recupera il valore delle calorie dalla TextBox
            if (double.TryParse(Calorie.Text, out double fabbisognoCalorico))
            {
                // Seleziona la dieta in base al fabbisogno calorico
                Dieta dietaSelezionata = gestoreDiete.SelezionaDieta((int)fabbisognoCalorico);

                // Aggiungi la dieta selezionata alla listView1
                AggiungiDietaToListView(dietaSelezionata);

                // Salva la dieta visualizzata nel file JSON
                SalvaDietaVisualizzataInJson();
            }
            else
            {
                MessageBox.Show("Inserisci un valore numerico valido per le calorie.");
            }
        }

        // Metodo per aggiungere la dieta alla listView1
        private void AggiungiDietaToListView(Dieta dieta)
        {
            // Se la dieta è nulla, esci dalla funzione
            if (dieta == null)
            {
                MessageBox.Show("Non è stata trovata una dieta adatta al tuo fabbisogno calorico.");
                return;
            }

            // Cancella gli elementi presenti nella listView1
            listView1.Items.Clear();

            // Aggiungi le informazioni della dieta alla listView1
            AggiungiElementoListView("Colazione", dieta.Colazione);
            AggiungiElementoListView("Snack", dieta.Snack);
            AggiungiElementoListView("Pranzo", dieta.Pranzo);
            AggiungiElementoListView("Merenda", dieta.Merenda);
            AggiungiElementoListView("Cena", dieta.Cena);
        }

        // Metodo per aggiungere un elemento alla listView1
        private void AggiungiElementoListView(string titolo, List<string> elementi)
        {
            // Aggiunge un nuovo elemento alla ListView con il titolo fornito
            listView1.Items.Add(new ListViewItem(titolo));

            // Itera attraverso ciascun elemento nella lista elementi
            foreach (var elemento in elementi)
            {
                // Aggiunge un nuovo elemento alla ListView con il testo dell'elemento corrente della lista
                listView1.Items.Add(new ListViewItem(elemento));
            }
        }

        private void SalvaDietaVisualizzataInJson()
        {
            // Creazione di una lista di stringhe per memorizzare le informazioni della dieta visualizzata
            List<string> dietaVisualizzata = new List<string>();

            // Iterazione attraverso gli elementi della listView1
            foreach (ListViewItem item in listView1.Items)
            {
                // Aggiunge il testo di ogni elemento della ListView alla lista dietaVisualizzata
                dietaVisualizzata.Add(item.Text);
            }

            // Serializza la lista dietaVisualizzata in formato JSON con formattazione indentata
            string json = JsonConvert.SerializeObject(dietaVisualizzata, Formatting.Indented);

            // Scrive il JSON nel file "dieta_visualizzata.json"
            File.WriteAllText("dieta_visualizzata.json", json);
        }
    }
}
