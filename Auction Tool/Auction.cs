using System.Windows.Forms;

namespace Auction_Tool {
    public class Auction {
        private MainForm main;

        public Auction(MainForm main) { 
            this.main = main;
        }

        public void start() {
            MessageBox.Show("Licitația a început!", "Licitație", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void stop() {

        }

        public void reset() {

        }

        public void setHighestBet(float amount) {
            main.highestBid_out.Text = $"{amount} lei";
            main.highestBid_out.Tag = amount;
        }

        public float getHighestBet() {
            return (float)main.highestBid_out.Tag;
        }

        public void setTopBidder(AuctionClient client) {
            main.topBidderNo_out.Text = client.AuctionNumber.ToString();
            main.topBidderNo_out.Tag = client;
        }

        public AuctionClient getTopBidder() {
            if (main.topBidderNo_out.Tag == null) return null;
            return (AuctionClient)main.topBidderNo_out.Tag;
        }
    }
}
