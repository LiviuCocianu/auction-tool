using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Auction_Tool {
    public class Auction {
        private MainForm main;
        private ClientBetForm betFormInstance = null;
        private DateTime auctionStart;

        public MainForm MainInstance {
            get => main;
            set => main = value;
        }

        public DateTime AuctionStartTime {
            get => auctionStart;
            set => auctionStart = value;
        }

        public float HighestBet {
            get => (float)main.highestBid_out.Tag;
            set {
                main.highestBid_out.Text = $"{value} {main.LocaleJSON["currency_unit"]}";
                main.highestBid_out.Tag = value;
            }
        }

        public AuctionClient TopBidder {
            get {
                if (main.topBidderNo_out.Tag == null) return null;
                return (AuctionClient)main.topBidderNo_out.Tag;
            }

            set {
                if (value == null) {
                    main.topBidderNo_out.Text = main.LocaleJSON["info_soon"];
                } else {
                    main.topBidderNo_out.Text = value.AuctionNumber.ToString();
                }

                main.topBidderNo_out.Tag = value;
            }
        }

        public ClientBetForm BetForm {
            get => betFormInstance;
            set => betFormInstance = value;
        }

        public Auction(MainForm main) { 
            MainInstance = main;
        }

        public void start() {
            MessageBox.Show(main.LocaleJSON["auction_started"], main.LocaleJSON["dialog_info"], 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            AuctionStartTime = DateTime.Now;
        }

        public void stop() {
            DialogResult choice = MessageBox.Show(main.LocaleJSON["dialog_ask_stop_auction"], main.LocaleJSON["dialog_warning"],
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (choice == DialogResult.Yes) {
                reset_();
                main.displayNoItem();

                MessageBox.Show(main.LocaleJSON["auction_stopped"], main.LocaleJSON["dialog_info"],
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void reset() {
            DialogResult choice = MessageBox.Show(main.LocaleJSON["dialog_ask_reset_auction"], main.LocaleJSON["dialog_warning"],
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (choice == DialogResult.Yes) {
                reset_();

                MessageBox.Show(main.LocaleJSON["auction_reset"], main.LocaleJSON["dialog_info"],
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void finish() {
            DialogResult choice = MessageBox.Show(main.LocaleJSON["dialog_ask_finish_auction"], main.LocaleJSON["dialog_warning"],
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (choice == DialogResult.Yes) {
                DialogResult choice2 = MessageBox.Show(main.LocaleJSON["auction_finished"], main.LocaleJSON["dialog_info"],
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (choice2 == DialogResult.Yes) {
                    PrintableAuctionStats pas = new PrintableAuctionStats(main, new Size(816, 1056));
                    pas.Show();
                    pas.print();
                }
                
                reset_();
                main.displayNoItem();
            }
        }

        public void resetAllBets() {
            AuctionClient.Cache.Collection.ForEach(c => {
                c.BidPrice = 0;
            });
        }

        private void reset_() {
            resetAllBets();
            HighestBet = 0;
            TopBidder = null;
            main.refreshClientList(true);

            if(BetForm != null) {
                BetForm.Close();
                BetForm = null;
            }
        }

 
    }
}
