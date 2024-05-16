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

namespace PROGETTO_PERSONALE_4_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        ListViewItem item = new ListViewItem("             SCHEDA PERSONALE UTENTE ");
       


        //CALCOLO FABBISOGNO CALORICO GIORNALIERO - BOTTONE
        private void CalcoloCalorieButton_Click(object sender, EventArgs e)
        {
            // Ottieni i valori inseriti dall'utente dalle textbox
            string sesso = SessoComboBox.Text;
            double peso = double.Parse(PesoTextBox.Text);
            double altezza = double.Parse(AltezzaTextBox.Text);
            int eta = int.Parse(EtaTextBox.Text);
            AttivitaFisica livelloAttivita = (AttivitaFisica)LivelloAttivitaComboBox.SelectedIndex;

            // Crea un'istanza della classe CalcoloFabbisognoCaloricoGiornaliero
            CalcoloFabbisognoCaloricoGiornaliero calcolatore = new CalcoloFabbisognoCaloricoGiornaliero(sesso, peso, altezza, eta, livelloAttivita);

            // Calcola il fabbisogno calorico giornaliero
            double fabbisognoCalorico = calcolatore.CalcolaFabbisognoCaloricoGiornaliero();

            // Visualizza il risultato nella ListView
            ListViewItem item = new ListViewItem("Fabbisogno Calorico Giornaliero: " + fabbisognoCalorico.ToString() + " cal");
            listView1.Items.Add(item);
        }


        //CALCOLO GRASSI - BOTTONE
        private void CalcoloGrassibutton_Click(object sender, EventArgs e)
        {
            // Ottieni i valori inseriti dall'utente dalla textbox
            double peso = double.Parse(PesoTextBox.Text);

            // Crea un'istanza della classe CalcoloFabbisognoCaloricoGiornaliero
            CalcoloGrassi calcolatore = new CalcoloGrassi(peso);

            // Calcola il fabbisogno calorico giornaliero
            double grassi = calcolatore.CalcolaGrassi();

            // Visualizza il risultato nella ListView
            ListViewItem item = new ListViewItem("Numero Grassi: " + grassi.ToString() + " g");
            listView1.Items.Add(item);
        }


        //CALCOLO PROTEINE - BOTTONE
        private void CalcoloProteinebutton_Click(object sender, EventArgs e)
        {
            // Ottieni i valori inseriti dall'utente dalla textbox
            double peso = double.Parse(PesoTextBox.Text);

            // Crea un'istanza della classe CalcoloFabbisognoCaloricoGiornaliero
            CalcoloProteine calcolatore = new CalcoloProteine(peso);

            // Calcola il fabbisogno calorico giornaliero
            double proteine = calcolatore.CalcolaProteine();

            // Visualizza il risultato nella ListView
            ListViewItem item = new ListViewItem("Numero Proteine: " + proteine.ToString() + " g");
            listView1.Items.Add(item);
        }
    }
}
