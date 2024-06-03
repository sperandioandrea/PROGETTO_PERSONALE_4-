namespace PROGETTO_PERSONALE_4_
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.PesoTextBox = new System.Windows.Forms.TextBox();
            this.AltezzaTextBox = new System.Windows.Forms.TextBox();
            this.EtaTextBox = new System.Windows.Forms.TextBox();
            this.LivelloAttivitaComboBox = new System.Windows.Forms.ComboBox();
            this.SessoComboBox = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CalcoloGrassibutton = new System.Windows.Forms.Button();
            this.CalcoloProteinebutton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.CalcoloCarboidratibutton = new System.Windows.Forms.Button();
            this.CalcoloCalorieButton = new System.Windows.Forms.Button();
            this.PulisciLista = new System.Windows.Forms.Button();
            this.UscitaProgramma = new System.Windows.Forms.Button();
            this.Calorie = new System.Windows.Forms.TextBox();
            this.Grassi = new System.Windows.Forms.TextBox();
            this.Proteine = new System.Windows.Forms.TextBox();
            this.Carboidrati = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.FormazioneDieta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PesoTextBox
            // 
            this.PesoTextBox.Location = new System.Drawing.Point(179, 296);
            this.PesoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PesoTextBox.Name = "PesoTextBox";
            this.PesoTextBox.Size = new System.Drawing.Size(132, 29);
            this.PesoTextBox.TabIndex = 2;
            // 
            // AltezzaTextBox
            // 
            this.AltezzaTextBox.Location = new System.Drawing.Point(179, 332);
            this.AltezzaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.AltezzaTextBox.Name = "AltezzaTextBox";
            this.AltezzaTextBox.Size = new System.Drawing.Size(132, 29);
            this.AltezzaTextBox.TabIndex = 3;
            // 
            // EtaTextBox
            // 
            this.EtaTextBox.Location = new System.Drawing.Point(179, 368);
            this.EtaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.EtaTextBox.Name = "EtaTextBox";
            this.EtaTextBox.Size = new System.Drawing.Size(132, 29);
            this.EtaTextBox.TabIndex = 4;
            // 
            // LivelloAttivitaComboBox
            // 
            this.LivelloAttivitaComboBox.FormattingEnabled = true;
            this.LivelloAttivitaComboBox.Items.AddRange(new object[] {
            "sedentario",
            "moderamente attivo",
            "attivo"});
            this.LivelloAttivitaComboBox.Location = new System.Drawing.Point(163, 404);
            this.LivelloAttivitaComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.LivelloAttivitaComboBox.Name = "LivelloAttivitaComboBox";
            this.LivelloAttivitaComboBox.Size = new System.Drawing.Size(160, 30);
            this.LivelloAttivitaComboBox.TabIndex = 5;
            // 
            // SessoComboBox
            // 
            this.SessoComboBox.FormattingEnabled = true;
            this.SessoComboBox.Items.AddRange(new object[] {
            "uomo",
            "donna"});
            this.SessoComboBox.Location = new System.Drawing.Point(179, 261);
            this.SessoComboBox.Name = "SessoComboBox";
            this.SessoComboBox.Size = new System.Drawing.Size(132, 30);
            this.SessoComboBox.TabIndex = 6;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(592, 39);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(824, 551);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(50, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 27);
            this.label2.TabIndex = 9;
            this.label2.Text = "peso - kg";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "sesso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(50, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 27);
            this.label3.TabIndex = 11;
            this.label3.Text = "altezza - cm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(50, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 27);
            this.label4.TabIndex = 12;
            this.label4.Text = "età";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(50, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 27);
            this.label5.TabIndex = 13;
            this.label5.Text = "stato fisico";
            // 
            // CalcoloGrassibutton
            // 
            this.CalcoloGrassibutton.BackColor = System.Drawing.Color.Yellow;
            this.CalcoloGrassibutton.Location = new System.Drawing.Point(414, 236);
            this.CalcoloGrassibutton.Name = "CalcoloGrassibutton";
            this.CalcoloGrassibutton.Size = new System.Drawing.Size(142, 63);
            this.CalcoloGrassibutton.TabIndex = 14;
            this.CalcoloGrassibutton.Text = "CALCOLO GRASSI";
            this.CalcoloGrassibutton.UseVisualStyleBackColor = false;
            this.CalcoloGrassibutton.Click += new System.EventHandler(this.CalcoloGrassibutton_Click);
            // 
            // CalcoloProteinebutton
            // 
            this.CalcoloProteinebutton.BackColor = System.Drawing.Color.Yellow;
            this.CalcoloProteinebutton.Location = new System.Drawing.Point(414, 305);
            this.CalcoloProteinebutton.Name = "CalcoloProteinebutton";
            this.CalcoloProteinebutton.Size = new System.Drawing.Size(142, 60);
            this.CalcoloProteinebutton.TabIndex = 15;
            this.CalcoloProteinebutton.Text = "CALCOLO PROTEINE";
            this.CalcoloProteinebutton.UseVisualStyleBackColor = false;
            this.CalcoloProteinebutton.Click += new System.EventHandler(this.CalcoloProteinebutton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(911, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(247, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "DIETA PERSONALE   UTENTE";
            // 
            // CalcoloCarboidratibutton
            // 
            this.CalcoloCarboidratibutton.BackColor = System.Drawing.Color.Yellow;
            this.CalcoloCarboidratibutton.Location = new System.Drawing.Point(414, 371);
            this.CalcoloCarboidratibutton.Name = "CalcoloCarboidratibutton";
            this.CalcoloCarboidratibutton.Size = new System.Drawing.Size(142, 63);
            this.CalcoloCarboidratibutton.TabIndex = 17;
            this.CalcoloCarboidratibutton.Text = "CALCOLO CARBOIDRATI";
            this.CalcoloCarboidratibutton.UseVisualStyleBackColor = false;
            this.CalcoloCarboidratibutton.Click += new System.EventHandler(this.CalcoloCarboidratibutton_Click);
            // 
            // CalcoloCalorieButton
            // 
            this.CalcoloCalorieButton.BackColor = System.Drawing.Color.Yellow;
            this.CalcoloCalorieButton.Location = new System.Drawing.Point(52, 175);
            this.CalcoloCalorieButton.Margin = new System.Windows.Forms.Padding(4);
            this.CalcoloCalorieButton.Name = "CalcoloCalorieButton";
            this.CalcoloCalorieButton.Size = new System.Drawing.Size(331, 79);
            this.CalcoloCalorieButton.TabIndex = 0;
            this.CalcoloCalorieButton.Text = "CALCOLO FABBISOGNO CALORICO GIORNALIERO CALORIE";
            this.CalcoloCalorieButton.UseVisualStyleBackColor = false;
            this.CalcoloCalorieButton.Click += new System.EventHandler(this.CalcoloCalorieButton_Click);
            // 
            // PulisciLista
            // 
            this.PulisciLista.BackColor = System.Drawing.Color.Red;
            this.PulisciLista.Location = new System.Drawing.Point(431, 476);
            this.PulisciLista.Name = "PulisciLista";
            this.PulisciLista.Size = new System.Drawing.Size(142, 45);
            this.PulisciLista.TabIndex = 20;
            this.PulisciLista.Text = "PULISCI LISTA";
            this.PulisciLista.UseVisualStyleBackColor = false;
            this.PulisciLista.Click += new System.EventHandler(this.PulisciLista_Click);
            // 
            // UscitaProgramma
            // 
            this.UscitaProgramma.BackColor = System.Drawing.Color.Red;
            this.UscitaProgramma.Location = new System.Drawing.Point(431, 527);
            this.UscitaProgramma.Name = "UscitaProgramma";
            this.UscitaProgramma.Size = new System.Drawing.Size(142, 63);
            this.UscitaProgramma.TabIndex = 21;
            this.UscitaProgramma.Text = "USCITA DAL PROGRAMMA";
            this.UscitaProgramma.UseVisualStyleBackColor = false;
            this.UscitaProgramma.Click += new System.EventHandler(this.UscitaProgramma_Click);
            // 
            // Calorie
            // 
            this.Calorie.Location = new System.Drawing.Point(45, 86);
            this.Calorie.Name = "Calorie";
            this.Calorie.Size = new System.Drawing.Size(100, 29);
            this.Calorie.TabIndex = 22;
            // 
            // Grassi
            // 
            this.Grassi.Location = new System.Drawing.Point(179, 86);
            this.Grassi.Name = "Grassi";
            this.Grassi.Size = new System.Drawing.Size(100, 29);
            this.Grassi.TabIndex = 23;
            // 
            // Proteine
            // 
            this.Proteine.Location = new System.Drawing.Point(316, 86);
            this.Proteine.Name = "Proteine";
            this.Proteine.Size = new System.Drawing.Size(100, 29);
            this.Proteine.TabIndex = 24;
            // 
            // Carboidrati
            // 
            this.Carboidrati.Location = new System.Drawing.Point(456, 86);
            this.Carboidrati.Name = "Carboidrati";
            this.Carboidrati.Size = new System.Drawing.Size(100, 29);
            this.Carboidrati.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(41, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 23);
            this.label7.TabIndex = 26;
            this.label7.Text = "Calorie";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(175, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 23);
            this.label8.TabIndex = 27;
            this.label8.Text = "Grassi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(312, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 23);
            this.label9.TabIndex = 28;
            this.label9.Text = "Proteine";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(452, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 23);
            this.label10.TabIndex = 29;
            this.label10.Text = "Carboidrati";
            // 
            // FormazioneDieta
            // 
            this.FormazioneDieta.BackColor = System.Drawing.Color.LawnGreen;
            this.FormazioneDieta.Location = new System.Drawing.Point(34, 456);
            this.FormazioneDieta.Name = "FormazioneDieta";
            this.FormazioneDieta.Size = new System.Drawing.Size(368, 134);
            this.FormazioneDieta.TabIndex = 30;
            this.FormazioneDieta.Text = "FORMAZIONE/STAMPA DIETA";
            this.FormazioneDieta.UseVisualStyleBackColor = false;
            this.FormazioneDieta.Click += new System.EventHandler(this.FormazioneDieta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROGETTO_PERSONALE_4_.Properties.Resources._75204555_selezione_di_spezie_erbe_e_verdi_ingredienti_per_la_cottura_sfondo_alimentare_sul_tavolo_nero;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1428, 602);
            this.Controls.Add(this.FormazioneDieta);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Carboidrati);
            this.Controls.Add(this.Proteine);
            this.Controls.Add(this.Grassi);
            this.Controls.Add(this.Calorie);
            this.Controls.Add(this.UscitaProgramma);
            this.Controls.Add(this.PulisciLista);
            this.Controls.Add(this.CalcoloCarboidratibutton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CalcoloProteinebutton);
            this.Controls.Add(this.CalcoloGrassibutton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.SessoComboBox);
            this.Controls.Add(this.LivelloAttivitaComboBox);
            this.Controls.Add(this.EtaTextBox);
            this.Controls.Add(this.AltezzaTextBox);
            this.Controls.Add(this.PesoTextBox);
            this.Controls.Add(this.CalcoloCalorieButton);
            this.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox PesoTextBox;
        private System.Windows.Forms.TextBox AltezzaTextBox;
        private System.Windows.Forms.TextBox EtaTextBox;
        private System.Windows.Forms.ComboBox LivelloAttivitaComboBox;
        private System.Windows.Forms.ComboBox SessoComboBox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CalcoloGrassibutton;
        private System.Windows.Forms.Button CalcoloProteinebutton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CalcoloCarboidratibutton;
        private System.Windows.Forms.Button CalcoloCalorieButton;
        private System.Windows.Forms.Button PulisciLista;
        private System.Windows.Forms.Button UscitaProgramma;
        private System.Windows.Forms.TextBox Calorie;
        private System.Windows.Forms.TextBox Grassi;
        private System.Windows.Forms.TextBox Proteine;
        private System.Windows.Forms.TextBox Carboidrati;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button FormazioneDieta;
    }
}

