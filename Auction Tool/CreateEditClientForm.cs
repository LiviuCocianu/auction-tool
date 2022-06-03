using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Auction_Tool {
    public partial class CreateEditClientForm : Form, ISubmitter, ILocalizable {
        private MainForm main;
        private Operation op;
        private AuctionClient toEdit;
        private Dictionary<string, string> localeJSON;

        public string LocaleFileName { get => "client_form"; }
        public Dictionary<string, string> LocaleJSON { get => localeJSON; set => localeJSON = value; }

        public CreateEditClientForm(MainForm main) {
            InitializeComponent();
            this.main = main;

            LocaleJSON = Utils.getJsonLang(main.DefaultLang, LocaleFileName);
            localize();
        }

        public CreateEditClientForm(MainForm main, Operation op) : this(main) {
            this.op = op;
            localize(op);
        }

        public CreateEditClientForm(MainForm main, AuctionClient toEdit) : this(main, Operation.Edit) {
            this.toEdit = toEdit;
            firstName_tb.Text = toEdit.FirstName;
            lastName_tb.Text = toEdit.LastName;
            auctionNumber_tb.Text = toEdit.AuctionNumber.ToString();
            clientBudget_tb.Text = toEdit.AuctionBudget.ToString();
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

                        AuctionClient client = new AuctionClient(
                            firstName, lastName,
                            auctionNumber, clientBudget
                        );
                        client.serialize();

                        AuctionClient.Cache.Collection.Add(client);

                        main.refreshClientList(false);

                        DialogResult choice = MessageBox.Show(
                            LocaleJSON["dialog_client_created"],
                            main.LocaleJSON["dialog_info"],
                            MessageBoxButtons.OK, MessageBoxIcon.Information
                        );

                        if (choice == DialogResult.OK || choice == DialogResult.Cancel) 
                            Close();
                        break;
                    case Operation.Edit:
                        firstName = firstName_tb.Text.Trim();
                        lastName = lastName_tb.Text.Trim();
                        auctionNumber = int.Parse(auctionNumber_tb.Text);
                        clientBudget = string.IsNullOrEmpty(clientBudget_tb.Text)
                                                ? float.MaxValue : float.Parse(clientBudget_tb.Text);

                        client = new AuctionClient(
                            firstName, lastName,
                            auctionNumber, clientBudget
                        ) { Id = toEdit.Id };

                        AuctionClient.Cache.Collection = client.saveThis();

                        choice = MessageBox.Show(
                            LocaleJSON["dialog_client_edited"],
                            main.LocaleJSON["dialog_info"],
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
            MessageBox.Show(LocaleJSON["auction_number_guide"],
                main.LocaleJSON["dialog_info"], MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void clientBudgetInfo_Click(object sender, EventArgs e) {
            MessageBox.Show(LocaleJSON["budget_guide"],
                main.LocaleJSON["dialog_info"], MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool firstNameValid() {
            const int nameCharLimit = 50;

            if (string.IsNullOrEmpty(firstName_tb.Text)) {
                errorProvider.SetError(firstName_tb, LocaleJSON["error_empty_field"]);
                return false;
            } else if (firstName_tb.Text.Length > nameCharLimit) {
                errorProvider.SetError(firstName_tb, LocaleJSON["error_first_name_too_long"].Replace("%max%", nameCharLimit.ToString()));
                return false;
            } else {
                errorProvider.SetError(firstName_tb, null);
                return true;
            }
        }

        private bool lastNameValid() {
            const int nameCharLimit = 50;

            if (string.IsNullOrEmpty(lastName_tb.Text)) {
                errorProvider.SetError(lastName_tb, LocaleJSON["error_empty_field"]);
                return false;
            } else if (lastName_tb.Text.Length > nameCharLimit) {
                errorProvider.SetError(lastName_tb, LocaleJSON["error_last_name_too_long"].Replace("%max%", nameCharLimit.ToString()));
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

                            errorProvider.SetError(lastName_tb, LocaleJSON["error_name_exists"]);
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
                errorProvider.SetError(auctionNumber_tb, LocaleJSON["error_nan"]);
                return false;
            } else if (num < 0) {
                errorProvider.SetError(auctionNumber_tb, LocaleJSON["error_auction_number_less_zero"]);
                return false;
            } else if (File.Exists($"{MainForm.WorkPath}\\clients.dat")) {
                List<AuctionClient> clienti = AuctionClient.deserialize();

                if (clienti.Count > 0) {
                    foreach (AuctionClient client in clienti) {
                        if(client.AuctionNumber == num) {
                            if (op == Operation.Edit && num == toEdit.AuctionNumber) return true;

                            errorProvider.SetError(auctionNumber_tb, LocaleJSON["error_auction_number_exists"]);
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
                errorProvider.SetError(clientBudget_tb, LocaleJSON["error_nan_float"]);
                return false;
            } else if(budget < 0) {
                errorProvider.SetError(clientBudget_tb, LocaleJSON["error_budget_less_zero"]);
                return false;
            } else {
                errorProvider.SetError(clientBudget_tb, null);
                return true;
            }
        }

        private void submit_btn_Click(object sender, EventArgs e) {
            Submit();
        }

        public void localize(Operation op) {
            switch (op) {
                case Operation.Create:
                    title.Text = LocaleJSON["create_form_title"];
                    submit_btn.Text = LocaleJSON["create_submit_button"];
                    break;
                case Operation.Edit:
                    title.Text = LocaleJSON["edit_form_title"];
                    submit_btn.Text = LocaleJSON["edit_submit_button"];
                    break;
            }

            firstName.Text = LocaleJSON["client_first_name_label"];
            lastName.Text = LocaleJSON["client_last_name_label"];
            auctionNumber.Text = LocaleJSON["client_auction_number_label"];
            clientBudget.Text = LocaleJSON["client_budget_label"];

            if (!main.LocalizedForms.Contains(this))
                main.LocalizedForms.Add(this);
        }

        public void localize() {
            localize(Operation.Create);
        }
    }
}
