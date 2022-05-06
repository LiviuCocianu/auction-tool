using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Auction_Tool {
    public partial class CreateClientForm : Form, ISubmitter {
        private MainForm main;

        public CreateClientForm(MainForm main) {
            InitializeComponent();
            this.main = main;
        }

        public bool checkValidity() {
            return numeValid() && prenumeValid() && numePrenumeValid() 
                && numarPersonalValid() && sumaDeclarataValid();
        }

        public void Submit() {
            if(checkValidity()) {
                string nume = numeClient_tb.Text.Trim();
                string prenume = prenumeClient_tb.Text.Trim();
                int numarPersonal = int.Parse(numarLicitatie_tb.Text);
                float sumaDeclarata = string.IsNullOrEmpty(sumaDisp_tb.Text) 
                                        ? float.MaxValue : float.Parse(sumaDisp_tb.Text);
                bool salveazaIst = salveazaIst_ckb.Checked;

                ClientLicitatie client = new ClientLicitatie(
                    nume, prenume,
                    numarPersonal, sumaDeclarata,
                    salveazaIst ? new IstoricClient() : null
                );
                client.serializeaza();

                ClientLicitatie.Cache.Clienti.Add(client);

                main.refreshListaClienti();

                DialogResult res = MessageBox.Show(
                    "Clientul a fost salvat cu succes!",
                    "Client creat",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );

                if (res == DialogResult.OK || res == DialogResult.Cancel) {
                    this.Close();
                }
            }
        }

        private void numarLicitatieInfo_Click(object sender, EventArgs e) {
            MessageBox.Show("Acest număr întreg trebuie să fie unic și va servi ca o metodă de identificare " +
                "și abreviere a clientului virtual cu cel din sala de licitații. A se lua în considerare că acest număr nu este " +
                "același lucru cu ID-ul clientului, care este folosit strict în aplicație",
                "Ajutor", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sumaDispInfo_Click(object sender, EventArgs e) {
            MessageBox.Show("Acest număr rațional va fi folosit pentru a valida dacă prețul propus de client " +
                "în timpul unei licitații se află în bugetul acestuia. Dacă suma nu v-a fost comunicată de către client, " +
                "lăsați acest câmp gol",
                "Ajutor", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                List<ClientLicitatie> clienti = ClientLicitatie.deserializeaza();

                if (clienti.Count > 0) {
                    foreach (ClientLicitatie client in clienti) {
                        if (client.Nume == numeClient_tb.Text && client.Prenume == prenumeClient_tb.Text) {
                            errorProvider.SetError(prenumeClient_tb, "Acest nume și prenume aparțin deja altui client");
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
            } else if (File.Exists($"{MainForm.WorkPath}\\clients.dat")) {
                List<ClientLicitatie> clienti = ClientLicitatie.deserializeaza();

                if (clienti.Count > 0) {
                    foreach (ClientLicitatie client in clienti) {
                        if(client.Numar == numar) {
                            errorProvider.SetError(numarLicitatie_tb, "Acest număr aparține deja altui client");
                            return false;
                        }
                    }
                }

                errorProvider.SetError(numarLicitatie_tb, null);
                return true;
            } else {
                errorProvider.SetError(numarLicitatie_tb, null);
                return true;
            }
        }

        private bool sumaDeclarataValid() {
            float suma;
            bool converted = float.TryParse(sumaDisp_tb.Text, out suma);

            // Acest câmp este opțional, deci permitem validării să treacă mai departe
            // în cazul în care este gol
            if(string.IsNullOrEmpty(sumaDisp_tb.Text)) {
                errorProvider.SetError(sumaDisp_tb, null);
                return true;
            } else if(!converted) {
                errorProvider.SetError(sumaDisp_tb, "Acest câmp nu conține un număr rațional pozitiv");
                return false;
            } else if(suma < 0) {
                errorProvider.SetError(sumaDisp_tb, "Suma disponibilă declarată nu poate fi mai mică decât 0");
                return false;
            } else {
                errorProvider.SetError(sumaDisp_tb, null);
                return true;
            }
        }

        private void creeazaClient_btn_Click(object sender, EventArgs e) {
            Submit();
        }
    }
}
