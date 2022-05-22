using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Auction_Tool {
    public partial class CreateEditClientForm : Form, ISubmitter {
        private MainForm main;
        private Operation op;
        private AuctionClient toEdit;

        public CreateEditClientForm(MainForm main) {
            InitializeComponent();
            this.main = main;
        }

        public CreateEditClientForm(MainForm main, Operation op) : this(main) {
            this.op = op;

            switch (op) {
                case Operation.Create:
                    title.Text = "Creează un client nou";
                    submit_btn.Text = "Creează";
                    break;
                case Operation.Edit:
                    title.Text = "Editează client";
                    submit_btn.Text = "Editează";
                    break;
            }
        }

        public CreateEditClientForm(MainForm main, AuctionClient toEdit) : this(main, Operation.Edit) {
            this.toEdit = toEdit;
            firstName_tb.Text = toEdit.FirstName;
            lastName_tb.Text = toEdit.LastName;
            auctionNumber_tb.Text = toEdit.AuctionNumber.ToString();
            clientBudget_tb.Text = toEdit.AuctionBudget.ToString();
            saveHistory_ckb.Checked = toEdit.SavesHistory;
        }

        public bool checkValidity() {
            return firstNameValid() && lastNameValid() && firstLastNameValid() 
                && auctionNumberValid() && clientBudgetValid();
        }

        public void Submit() {
            if(checkValidity()) {
                switch(op) {
                    case Operation.Create:
                        string firstName = firstName_tb.Text.Trim();
                        string lastName = lastName_tb.Text.Trim();
                        int auctionNumber = int.Parse(auctionNumber_tb.Text);
                        float clientBudget = string.IsNullOrEmpty(clientBudget_tb.Text)
                                                ? float.MaxValue : float.Parse(clientBudget_tb.Text);
                        bool savesHistory = saveHistory_ckb.Checked;

                        AuctionClient client = new AuctionClient(
                            firstName, lastName,
                            auctionNumber, clientBudget,
                            savesHistory ? new ClientHistory() : null
                        );
                        client.serialize();

                        AuctionClient.Cache.Collection.Add(client);

                        main.refreshClientList(false);

                        DialogResult choice = MessageBox.Show(
                            "Clientul a fost salvat cu succes!",
                            "Client creat",
                            MessageBoxButtons.OK, MessageBoxIcon.Information
                        );

                        if (choice == DialogResult.OK || choice == DialogResult.Cancel) 
                            this.Close();
                        break;
                    case Operation.Edit:
                        firstName = firstName_tb.Text.Trim();
                        lastName = lastName_tb.Text.Trim();
                        auctionNumber = int.Parse(auctionNumber_tb.Text);
                        clientBudget = string.IsNullOrEmpty(clientBudget_tb.Text)
                                                ? float.MaxValue : float.Parse(clientBudget_tb.Text);
                        savesHistory = saveHistory_ckb.Checked;

                        client = new AuctionClient(
                            firstName, lastName,
                            auctionNumber, clientBudget,
                            savesHistory ? new ClientHistory() : null
                        ) { Id = toEdit.Id };

                        AuctionClient.Cache.Collection = client.saveThis();

                        choice = MessageBox.Show(
                            "Clientul a fost editat cu succes!",
                            "Client editat",
                            MessageBoxButtons.OK, MessageBoxIcon.Information
                        );

                        if (choice == DialogResult.OK || choice == DialogResult.Cancel) {
                            main.refreshClientList(false);
                            Close();
                        }
                        break;
                }
                
            }
        }

        private void auctionNumberInfo_Click(object sender, EventArgs e) {
            MessageBox.Show("Acest număr întreg trebuie să fie unic și va servi ca o metodă de identificare " +
                "și abreviere a clientului virtual cu cel din sala de licitații. A se lua în considerare că acest număr nu este " +
                "același lucru cu ID-ul clientului, care este folosit strict în aplicație",
                "Ajutor", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void clientBudgetInfo_Click(object sender, EventArgs e) {
            MessageBox.Show("Acest număr rațional va fi folosit pentru a valida dacă prețul propus de client " +
                "în timpul unei licitații se află în bugetul acestuia. Dacă suma nu v-a fost comunicată de către client, " +
                "lăsați acest câmp gol",
                "Ajutor", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool firstNameValid() {
            const int nameCharLimit = 50;

            if (string.IsNullOrEmpty(firstName_tb.Text)) {
                errorProvider.SetError(firstName_tb, "Acest câmp nu poate fi lăsat gol");
                return false;
            } else if (firstName_tb.Text.Length > nameCharLimit) {
                errorProvider.SetError(firstName_tb, $"Numele clientului nu poate depăși {nameCharLimit} caractere");
                return false;
            } else {
                errorProvider.SetError(firstName_tb, null);
                return true;
            }
        }

        private bool lastNameValid() {
            const int nameCharLimit = 50;

            if (string.IsNullOrEmpty(lastName_tb.Text)) {
                errorProvider.SetError(lastName_tb, "Acest câmp nu poate fi lăsat gol");
                return false;
            } else if (lastName_tb.Text.Length > nameCharLimit) {
                errorProvider.SetError(lastName_tb, $"Prenumele clientului nu poate depăși {nameCharLimit} caractere");
                return false;
            } else {
                errorProvider.SetError(lastName_tb, null);
                return true;
            }
        }

        private bool firstLastNameValid() {
            if (File.Exists($"{MainForm.WorkPath}\\clients.dat")) {
                List<AuctionClient> clients = AuctionClient.deserialize();

                if (clients.Count > 0) {
                    foreach (AuctionClient client in clients) {
                        if (client.FirstName == firstName_tb.Text && client.LastName == lastName_tb.Text) {
                            /*
                             * RO:
                             * Dacă nu s-a făcut nicio modificare la nume sau prenume, facem o excepție
                             * și lăsăm validarea să meargă mai departe
                             * 
                             * EN:
                             * If no first or last name modification was made, we'll excuse this case
                             * and let the validation process go on
                             */
                            if (op == Operation.Edit && firstName_tb.Text == toEdit.FirstName
                                && lastName_tb.Text == toEdit.LastName) return true;

                            errorProvider.SetError(lastName_tb, "Acest nume și prenume aparțin deja altui client");
                            return false;
                        }
                    }
                }

                errorProvider.SetError(lastName_tb, null);
                return true;
            } else {
                errorProvider.SetError(lastName_tb, null);
                return true;
            }
        }

        private bool auctionNumberValid() {
            int num;
            bool converted = int.TryParse(auctionNumber_tb.Text, out num);

            if (!converted) {
                errorProvider.SetError(auctionNumber_tb, "Acest câmp nu conține un număr întreg pozitiv");
                return false;
            } else if (num < 0) {
                errorProvider.SetError(auctionNumber_tb, "Prețul de bază nu poate fi mai mic decât 0");
                return false;
            } else if (File.Exists($"{MainForm.WorkPath}\\clients.dat")) {
                List<AuctionClient> clienti = AuctionClient.deserialize();

                if (clienti.Count > 0) {
                    foreach (AuctionClient client in clienti) {
                        if(client.AuctionNumber == num) {
                            if (op == Operation.Edit && num == toEdit.AuctionNumber) return true;

                            errorProvider.SetError(auctionNumber_tb, "Acest număr aparține deja altui client");
                            return false;
                        }
                    }
                }

                errorProvider.SetError(auctionNumber_tb, null);
                return true;
            } else {
                errorProvider.SetError(auctionNumber_tb, null);
                return true;
            }
        }

        private bool clientBudgetValid() {
            float budget;
            bool converted = float.TryParse(clientBudget_tb.Text, out budget);

            // Acest câmp este opțional, deci permitem validării să treacă mai departe
            // în cazul în care este gol
            if(string.IsNullOrEmpty(clientBudget_tb.Text)) {
                errorProvider.SetError(clientBudget_tb, null);
                return true;
            } else if(!converted) {
                errorProvider.SetError(clientBudget_tb, "Acest câmp nu conține un număr rațional pozitiv");
                return false;
            } else if(budget < 0) {
                errorProvider.SetError(clientBudget_tb, "Suma disponibilă declarată nu poate fi mai mică decât 0");
                return false;
            } else {
                errorProvider.SetError(clientBudget_tb, null);
                return true;
            }
        }

        private void submit_btn_Click(object sender, EventArgs e) {
            Submit();
        }
    }
}
