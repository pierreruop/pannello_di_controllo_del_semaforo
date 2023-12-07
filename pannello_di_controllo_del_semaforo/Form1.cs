using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace pannello_di_controllo_del_semaforo
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        /*
         * 
         * VARIABILI UTILI
         * 
         */

        bool semafori = true;

        // VARIABILI CHE RICAVANO ORE/MINUTI/SECONDI CORRENTI
        int ore = DateTime.Now.Hour;
        //int minuti = DateTime.Now.Minute;
        //int seondi = DateTime.Now.Second;


        string[] arrayOre = new string[25];

        int oraInizio;
        int oraFine;

        string datiRicevuti;

        private void buttonONOFFSemafori_Click(object sender, EventArgs e)
        {
            if (serialPortArduino.IsOpen)
            {
                if (semafori)// SE LA VARIABILE E' TRUE
                {

                    serialPortArduino.Write("y");// INVIA UN CARATTERE CHE MOSTRA L'INVIO DI DATI IMPORTANTI
                    serialPortArduino.Write("onSemafori");// CARATTERE
                    serialPortArduino.Write(Environment.NewLine);
                    labelAbilitaDisabilita.ForeColor = Color.Green;
                    labelAbilitaDisabilita.Text = "ABILITATI";
                    buttonONOFFSemafori.Text = "OFF";

                    
                }
                else
                {
                    serialPortArduino.Write("y");
                    serialPortArduino.Write("offSemafori");
                    serialPortArduino.Write(Environment.NewLine);
                    labelAbilitaDisabilita.ForeColor = Color.Red;
                    labelAbilitaDisabilita.Text = "DISABILITATI";
                    buttonONOFFSemafori.Text = "ON";
                }
            }
        }
        

        private void Form1_Load(object sender, EventArgs e)// EVENTO CHE PARTE ALL'AVVIO DEL PROGRAMMA
        {
            
            try// PROVA
            {
                serialPortArduino.Open();// AD APRIRE LA SERIALE
            }
            catch(Exception ex)// SE DA ERRORE LO CATTURA
            {
                MessageBox.Show(ex.Message);// E LO MOSTRA CON LA MESSAGEBOX
            }

            for (int var = 1; var < arrayOre.Length;var++)
            {
                arrayOre[var]=var.ToString();
                comboBoxSelezionaPeriodoInizio.Items.Add(arrayOre[var]);
                comboBoxSelezionaPeriodoFine.Items.Add(arrayOre[var]);
            }
            //MessageBox.Show(timerTempoAccensione.ToString());
            
        }

        private void serialPortArduino_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            datiRicevuti = serialPortArduino.ReadExisting();
            datiRicevuti.Trim();
            if(datiRicevuti== "yAccesi")
            {
                this.Invoke(new EventHandler(dati_da_ArduinoSemaforiAcessi));
            }
            else if(datiRicevuti == "ySpenti")
            {
                this.Invoke(new EventHandler(dati_da_ArduinoSemaforiSpenti));
            }
        }

        private void dati_da_ArduinoSemaforiSpenti(object sender, EventArgs e)
        {
            labelAccesiSpenti.Text = "SEMAFORI SPENTI";
        }

        private void dati_da_ArduinoSemaforiAcessi(object sender, EventArgs e)
        {
            labelAccesiSpenti.Text = "SEMAFORI ACCESI";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPortArduino.Close();// DURANTE LA CHIUSURA DEL FORM CHIUDE ANCHE LA PORTA SERIALE
        }
      

        private void comboBoxSelezionaPeriodoInizio_SelectedIndexChanged(object sender, EventArgs e)
        {
            oraInizio =int.Parse(comboBoxSelezionaPeriodoInizio.SelectedItem.ToString());
            
        }

        private void comboBoxSelezionaPeriodoFine_SelectedIndexChanged(object sender, EventArgs e)
        {
            oraFine = int.Parse(comboBoxSelezionaPeriodoFine.SelectedItem.ToString());
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(ore>=oraFine)
            {
                // LAMPEGGIANTI GIALLI

            }else if(ore < oraInizio){

                // LAMPEGGIANTI GIALLI
            }
            else
            {
                // SEMAFORI CLASSICI
            }
        }
    }
}
