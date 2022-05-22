using System;
using System.Windows.Forms;

namespace Auction_Tool {
    public partial class ClientBetForm : Form, ISubmitter {
        private MainForm main;
        private AuctionClient client;

        public ClientBetForm(MainForm main, AuctionClient client) {
            this.main = main;
            this.client = client;
            InitializeComponent();

            currentBid.Text = $"Sumă propusă anterior: {client.BidPrice} lei";
            clientBudget.Text = $"Sumă disponibilă (buget): {client.AuctionBudget} lei";
        }

        public void Submit() {
            if(checkValidity()) {
                float newBid = float.Parse(newBid_tb.Text);
                client.BidPrice = newBid;
                client.saveThisInCache();
                main.refreshClientList(true);

                main.AuctionInstance.setHighestBet(newBid);
                main.AuctionInstance.setTopBidder(client);

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
                errorProvider.SetError(newBid_tb, "Acest câmp nu conține un număr rațional pozitiv");
                return false;
            } else if (suma < 0) {
                errorProvider.SetError(newBid_tb, "Suma nouă nu poate fi mai mică decât 0");
                return false;
            } else if (suma <= main.getDisplayedItem().BasePrice) {
                errorProvider.SetError(newBid_tb, "Suma nouă trebuie să fie mai mare decat prețul de bază al articolului");
                return false;
            } else if (suma <= client.BidPrice) {
                errorProvider.SetError(newBid_tb, "Suma nouă trebuie să fie mai mare decât suma propriu propusă anterior");
                return false;
            } else if (suma <= main.AuctionInstance.getHighestBet()) {
                errorProvider.SetError(newBid_tb, "Suma nouă trebuie să fie mai mare decât suma propusă de ceilalți clienți");
                return false;
            } else if (suma > client.AuctionBudget) {
                errorProvider.SetError(newBid_tb, "Suma nouă nu se află în bugetul clientului");
                return false;
            } else {
                errorProvider.SetError(newBid_tb, null);
                return true;
            }
        }

        private void submit_btn_Click(object sender, EventArgs e) {
            Submit();
        }
    }
}
