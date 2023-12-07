namespace pannello_di_controllo_del_semaforo
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
            this.components = new System.ComponentModel.Container();
            this.buttonONOFFSemafori = new System.Windows.Forms.Button();
            this.labelAbilitaDisabilita = new System.Windows.Forms.Label();
            this.groupBoxSemaforoPedoni = new System.Windows.Forms.GroupBox();
            this.serialPortArduino = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSelezionaPeriodo = new System.Windows.Forms.Button();
            this.comboBoxSelezionaPeriodoFine = new System.Windows.Forms.ComboBox();
            this.comboBoxSelezionaPeriodoInizio = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelAccesiSpenti = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonONOFFSemafori
            // 
            this.buttonONOFFSemafori.Location = new System.Drawing.Point(110, 161);
            this.buttonONOFFSemafori.Name = "buttonONOFFSemafori";
            this.buttonONOFFSemafori.Size = new System.Drawing.Size(75, 23);
            this.buttonONOFFSemafori.TabIndex = 0;
            this.buttonONOFFSemafori.Text = "ON";
            this.buttonONOFFSemafori.UseVisualStyleBackColor = true;
            this.buttonONOFFSemafori.Click += new System.EventHandler(this.buttonONOFFSemafori_Click);
            // 
            // labelAbilitaDisabilita
            // 
            this.labelAbilitaDisabilita.AutoSize = true;
            this.labelAbilitaDisabilita.ForeColor = System.Drawing.Color.Red;
            this.labelAbilitaDisabilita.Location = new System.Drawing.Point(20, 166);
            this.labelAbilitaDisabilita.Name = "labelAbilitaDisabilita";
            this.labelAbilitaDisabilita.Size = new System.Drawing.Size(75, 13);
            this.labelAbilitaDisabilita.TabIndex = 1;
            this.labelAbilitaDisabilita.Text = "DISABILITATI";
            // 
            // groupBoxSemaforoPedoni
            // 
            this.groupBoxSemaforoPedoni.Location = new System.Drawing.Point(496, 56);
            this.groupBoxSemaforoPedoni.Name = "groupBoxSemaforoPedoni";
            this.groupBoxSemaforoPedoni.Size = new System.Drawing.Size(232, 320);
            this.groupBoxSemaforoPedoni.TabIndex = 2;
            this.groupBoxSemaforoPedoni.TabStop = false;
            this.groupBoxSemaforoPedoni.Text = "Semaforo Pedoni";
            // 
            // serialPortArduino
            // 
            this.serialPortArduino.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPortArduino_DataReceived);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonSelezionaPeriodo);
            this.groupBox1.Controls.Add(this.comboBoxSelezionaPeriodoFine);
            this.groupBox1.Controls.Add(this.comboBoxSelezionaPeriodoInizio);
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 317);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestione accensione automatica semafori";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "A ore";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Da ore";
            // 
            // buttonSelezionaPeriodo
            // 
            this.buttonSelezionaPeriodo.Location = new System.Drawing.Point(77, 243);
            this.buttonSelezionaPeriodo.Name = "buttonSelezionaPeriodo";
            this.buttonSelezionaPeriodo.Size = new System.Drawing.Size(75, 23);
            this.buttonSelezionaPeriodo.TabIndex = 6;
            this.buttonSelezionaPeriodo.Text = "Conferma";
            this.buttonSelezionaPeriodo.UseVisualStyleBackColor = true;
            // 
            // comboBoxSelezionaPeriodoFine
            // 
            this.comboBoxSelezionaPeriodoFine.FormattingEnabled = true;
            this.comboBoxSelezionaPeriodoFine.Location = new System.Drawing.Point(31, 163);
            this.comboBoxSelezionaPeriodoFine.Name = "comboBoxSelezionaPeriodoFine";
            this.comboBoxSelezionaPeriodoFine.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSelezionaPeriodoFine.TabIndex = 5;
            this.comboBoxSelezionaPeriodoFine.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelezionaPeriodoFine_SelectedIndexChanged);
            // 
            // comboBoxSelezionaPeriodoInizio
            // 
            this.comboBoxSelezionaPeriodoInizio.FormattingEnabled = true;
            this.comboBoxSelezionaPeriodoInizio.Location = new System.Drawing.Point(31, 93);
            this.comboBoxSelezionaPeriodoInizio.Name = "comboBoxSelezionaPeriodoInizio";
            this.comboBoxSelezionaPeriodoInizio.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSelezionaPeriodoInizio.TabIndex = 4;
            this.comboBoxSelezionaPeriodoInizio.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelezionaPeriodoInizio_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelAccesiSpenti);
            this.groupBox2.Controls.Add(this.labelAbilitaDisabilita);
            this.groupBox2.Controls.Add(this.buttonONOFFSemafori);
            this.groupBox2.Location = new System.Drawing.Point(261, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 317);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // labelAccesiSpenti
            // 
            this.labelAccesiSpenti.AutoSize = true;
            this.labelAccesiSpenti.Location = new System.Drawing.Point(37, 93);
            this.labelAccesiSpenti.Name = "labelAccesiSpenti";
            this.labelAccesiSpenti.Size = new System.Drawing.Size(130, 13);
            this.labelAccesiSpenti.TabIndex = 2;
            this.labelAccesiSpenti.Text = "SEMAFORI NON ACCESI";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxSemaforoPedoni);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
             this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonONOFFSemafori;
        private System.Windows.Forms.Label labelAbilitaDisabilita;
        private System.Windows.Forms.GroupBox groupBoxSemaforoPedoni;
        private System.IO.Ports.SerialPort serialPortArduino;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSelezionaPeriodo;
        private System.Windows.Forms.ComboBox comboBoxSelezionaPeriodoFine;
        private System.Windows.Forms.ComboBox comboBoxSelezionaPeriodoInizio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelAccesiSpenti;
    }
}

