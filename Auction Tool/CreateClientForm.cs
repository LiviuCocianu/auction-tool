using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW {
    public partial class CreateClientForm : Form, ISubmitter {
        public CreateClientForm() {
            InitializeComponent();
        }

        public bool checkValidity() {
            return numeValid() && prenumeValid() && numePrenumeValid();
        }

        public void Submit() {

        }

        private void numarLicitatieInfo_Click(object sender, EventArgs e) {
            MessageBox.Show("Acest număr întreg trebuie să fie unic și va servi ca o metodă de identificare " +
                "și abreviere a clientului virtual cu cel din sala de licitații. A se lua în considerare că acest număr nu este " +
                "același lucru cu ID-ul clientului, care este folosit strict în aplicație", "Ajutor", MessageBoxButtons.OK);
        }

        private void sumaDispInfo_Click(object sender, EventArgs e) {
            MessageBox.Show("Acest număr rațional va fi folosit pentru a valida dacă prețul propus de client" +
                "în timpul unei licitații se află în bugetul acestuia. Dacă suma nu v-a fost comunicată de către client, " +
                "lăsați acest câmp gol", "Ajutor", MessageBoxButtons.OK);
        }

        private bool numeValid() {
            const int nameCharLimit = 50;

            if (string.IsNullOrEmpty(numeClient_tb.Text)) {
                errorProvider.SetError(numeClient_tb, "Acest câmp nu poate fi lăsat gol");
                return false;
            } else if (numeClient_tb.Text.Length > nameCharLimit) {
                errorProvider.SetError(numeClient_tb, $"Numele clientului nu poate depăși {nameCharLimit} caractere");
                return false;
            } else {
                errorProvider.SetError(numeClient_tb, null);
                return true;
            }
        }

        private bool prenumeValid() {
            const int nameCharLimit = 50;

            if (string.IsNullOrEmpty(prenumeClient_tb.Text)) {
                errorProvider.SetError(prenumeClient_tb, "Acest câmp nu poate fi lăsat gol");
                return false;
            } else if (prenumeClient_tb.Text.Length > nameCharLimit) {
                errorProvider.SetError(prenumeClient_tb, $"Prenumele clientului nu poate depăși {nameCharLimit} caractere");
                return false;
            } else {
                errorProvider.SetError(prenumeClient_tb, null);
                return true;
            }
        }

        private bool numePrenumeValid() {
            if (File.Exists($"{MainForm.WorkPath}\\clients.dat")) {
                List<ClientLicitatie> clienti = ClientLicitatie.deserialize();

                if (clienti.Count > 0) {
                    foreach (ClientLicitatie client in clienti) {
                        if (client.Nume == numeClient_tb.Text && client.Prenume == prenumeClient_tb.Text) {
                            errorProvider.SetError(prenumeClient_tb, $"Acest nume și prenume aparțin deja altui client");
                            return false;
                        }
                    }
                }

                errorProvider.SetError(prenumeClient_tb, null);
                return true;
            } else {
                errorProvider.SetError(prenumeClient_tb, null);
                return true;
            }
        }

        private bool numarPersonalValid() {
            int numar;
            bool converted = int.TryParse(numarLicitatie_tb.Text, out numar);

            if (!converted) {
                errorProvider.SetError(numarLicitatie_tb, "Acest câmp nu conține un număr întreg pozitiv");
                return false;
            } else if (numar < 0) {
                errorProvider.SetError(numarLicitatie_tb, "Prețul de bază nu poate fi mai mic decât 0");
                return false;
            } else {
                errorProvider.SetError(numarLicitatie_tb, null);
                return true;
            }
        }
    }
}
