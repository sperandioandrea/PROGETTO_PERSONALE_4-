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
            this.CalcoloCalorieButton = new System.Windows.Forms.Button();
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
            this.UscitaDalProgramma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CalcoloCalorieButton
            // 
            this.CalcoloCalorieButton.Location = new System.Drawing.Point(183, 22);
            this.CalcoloCalorieButton.Margin = new System.Windows.Forms.Padding(4);
            this.CalcoloCalorieButton.Name = "CalcoloCalorieButton";
            this.CalcoloCalorieButton.Size = new System.Drawing.Size(252, 58);
            this.CalcoloCalorieButton.TabIndex = 0;
            this.CalcoloCalorieButton.Text = "CALCOLO FABBISOGNO CALORICO GIORNALIERO CALORIE";
            this.CalcoloCalorieButton.UseVisualStyleBackColor = true;
            this.CalcoloCalorieButton.Click += new System.EventHandler(this.CalcoloCalorieButton_Click);
            // 
            // PesoTextBox
            // 
            this.PesoTextBox.Location = new System.Drawing.Point(233, 122);
            this.PesoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PesoTextBox.Name = "PesoTextBox";
            this.PesoTextBox.Size = new System.Drawing.Size(132, 25);
            this.PesoTextBox.TabIndex = 2;
            // 
            // AltezzaTextBox
            // 
            this.AltezzaTextBox.Location = new System.Drawing.Point(233, 158);
            this.AltezzaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.AltezzaTextBox.Name = "AltezzaTextBox";
            this.AltezzaTextBox.Size = new System.Drawing.Size(132, 25);
            this.AltezzaTextBox.TabIndex = 3;
            // 
            // EtaTextBox
            // 
            this.EtaTextBox.Location = new System.Drawing.Point(233, 194);
            this.EtaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.EtaTextBox.Name = "EtaTextBox";
            this.EtaTextBox.Size = new System.Drawing.Size(132, 25);
            this.EtaTextBox.TabIndex = 4;
            // 
            // LivelloAttivitaComboBox
            // 
            this.LivelloAttivitaComboBox.FormattingEnabled = true;
            this.LivelloAttivitaComboBox.Items.AddRange(new object[] {
            "sedentario",
            "moderamente attivo",
            "attivo"});
            this.LivelloAttivitaComboBox.Location = new System.Drawing.Point(217, 230);
            this.LivelloAttivitaComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.LivelloAttivitaComboBox.Name = "LivelloAttivitaComboBox";
            this.LivelloAttivitaComboBox.Size = new System.Drawing.Size(160, 26);
            this.LivelloAttivitaComboBox.TabIndex = 5;
            // 
            // SessoComboBox
            // 
            this.SessoComboBox.FormattingEnabled = true;
            this.SessoComboBox.Items.AddRange(new object[] {
            "uomo",
            "donna"});
            this.SessoComboBox.Location = new System.Drawing.Point(233, 87);
            this.SessoComboBox.Name = "SessoComboBox";
            this.SessoComboBox.Size = new System.Drawing.Size(132, 26);
            this.SessoComboBox.TabIndex = 6;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(743, 39);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(397, 510);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "peso - kg";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "sesso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "altezza - cm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "età";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "stato";
            // 
            // CalcoloGrassibutton
            // 
            this.CalcoloGrassibutton.Location = new System.Drawing.Point(512, 54);
            this.CalcoloGrassibutton.Name = "CalcoloGrassibutton";
            this.CalcoloGrassibutton.Size = new System.Drawing.Size(142, 63);
            this.CalcoloGrassibutton.TabIndex = 14;
            this.CalcoloGrassibutton.Text = "CALCOLO GRASSI";
            this.CalcoloGrassibutton.UseVisualStyleBackColor = true;
            this.CalcoloGrassibutton.Click += new System.EventHandler(this.CalcoloGrassibutton_Click);
            // 
            // CalcoloProteinebutton
            // 
            this.CalcoloProteinebutton.Location = new System.Drawing.Point(512, 123);
            this.CalcoloProteinebutton.Name = "CalcoloProteinebutton";
            this.CalcoloProteinebutton.Size = new System.Drawing.Size(142, 60);
            this.CalcoloProteinebutton.TabIndex = 15;
            this.CalcoloProteinebutton.Text = "CALCOLO PROTEINE";
            this.CalcoloProteinebutton.UseVisualStyleBackColor = true;
            this.CalcoloProteinebutton.Click += new System.EventHandler(this.CalcoloProteinebutton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(833, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "SCHEDA  PERSONALE   UTENTE";
            // 
            // CalcoloCarboidratibutton
            // 
            this.CalcoloCarboidratibutton.Location = new System.Drawing.Point(512, 189);
            this.CalcoloCarboidratibutton.Name = "CalcoloCarboidratibutton";
            this.CalcoloCarboidratibutton.Size = new System.Drawing.Size(142, 63);
            this.CalcoloCarboidratibutton.TabIndex = 17;
            this.CalcoloCarboidratibutton.Text = "CALCOLO CARBOIDRATI";
            this.CalcoloCarboidratibutton.UseVisualStyleBackColor = true;
            this.CalcoloCarboidratibutton.Click += new System.EventHandler(this.CalcoloCarboidratibutton_Click);
            // 
            // UscitaDalProgramma
            // 
            this.UscitaDalProgramma.Location = new System.Drawing.Point(894, 555);
            this.UscitaDalProgramma.Name = "UscitaDalProgramma";
            this.UscitaDalProgramma.Size = new System.Drawing.Size(114, 44);
            this.UscitaDalProgramma.TabIndex = 18;
            this.UscitaDalProgramma.Text = "USCITA DAL PROGRAMMA ";
            this.UscitaDalProgramma.UseVisualStyleBackColor = true;
            this.UscitaDalProgramma.Click += new System.EventHandler(this.UscitaDalProgramma_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROGETTO_PERSONALE_4_.Properties.Resources._75204555_selezione_di_spezie_erbe_e_verdi_ingredienti_per_la_cottura_sfondo_alimentare_sul_tavolo_nero;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1164, 602);
            this.Controls.Add(this.UscitaDalProgramma);
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

        private System.Windows.Forms.Button CalcoloCalorieButton;
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
        private System.Windows.Forms.Button UscitaDalProgramma;
    }
}

