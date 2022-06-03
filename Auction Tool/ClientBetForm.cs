using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Auction_Tool {
    public partial class ClientBetForm : Form, ISubmitter, ILocalizable {
        private MainForm main;
        private AuctionClient client;
        private Dictionary<string, string> localeJSON;

        public string LocaleFileName { get => "bet_form"; }
        public Dictionary<string, string> LocaleJSON { get => localeJSON; set => localeJSON = value; }

        public ClientBetForm(MainForm main, AuctionClient client) {
            this.main = main;
            this.client = client;
            InitializeComponent();

            main.AuctionInstance.BetForm = this;

            LocaleJSON = Utils.getJsonLang(main.DefaultLang, LocaleFileName);
            localize();
        }

        public void Submit() {
            if(checkValidity()) {
                float newBid = float.Parse(newBid_tb.Text);
                client.BidPrice = newBid;
                client.saveThisInCache();
                main.refreshClientList(true);

                main.AuctionInstance.HighestBet = newBid;
                main.AuctionInstance.TopBidder = client;

                Close();
            }
        }

        public bool checkValidity() {
            return sumaValid();
        }

        private bool sumaValid() {
            float suma;
            bool converted = float.TryParse(newBid_tb.Text, out suma);

            if (!converted || float.IsNaN(suma) || float.IsInfinity(suma)) {
                errorProvider.SetError(newBid_tb, LocaleJSON["error_nan"]);
                return false;
            } else if (suma < 0) {
                errorProvider.SetError(newBid_tb, LocaleJSON["error_less_zero"]);
                return false;
            } else if (suma <= main.getDisplayedItem().BasePrice) {
                errorProvider.SetError(newBid_tb, LocaleJSON["error_less_base_price"]);
                return false;
            } else if (suma <= client.BidPrice) {
                errorProvider.SetError(newBid_tb, LocaleJSON["error_less_bid"]);
                return false;
            } else if (suma <= main.AuctionInstance.HighestBet) {
                errorProvider.SetError(newBid_tb, LocaleJSON["error_less_highest"]);
                return false;
            } else if (suma > client.AuctionBudget) {
                errorProvider.SetError(newBid_tb, LocaleJSON["error_budget"]);
                return false;
            } else {
                errorProvider.SetError(newBid_tb, null);
                return true;
            }
        }

        private void submit_btn_Click(object sender, EventArgs e) {
            Submit();
        }

        private void ClientBetForm_FormClosed(object sender, FormClosedEventArgs e) {
            main.AuctionInstance.BetForm = null;
        }

        public void localize() {
            title.Text = LocaleJSON["form_title"];
            previousBid.Text = $"{LocaleJSON["prev_bet_label"]} {client.BidPrice} {main.LocaleJSON["currency_unit"]}";
            clientBudget.Text = $"{LocaleJSON["budget_label"]} {client.AuctionBudget} {main.LocaleJSON["currency_unit"]}";
            newBid.Text = LocaleJSON["new_bid_label"];
            submit_btn.Text = LocaleJSON["submit_button"];

            if (!main.LocalizedForms.Contains(this))
                main.LocalizedForms.Add(this);
        }
    }
}
