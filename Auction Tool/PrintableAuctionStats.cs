using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Collections.Generic;

namespace Auction_Tool {
    public partial class PrintableAuctionStats : Form, ILocalizable {
        private MainForm main;
        private Bitmap formCapture;
        private Size pageSize;

        private Dictionary<string, string> localeJSON;

        public string LocaleFileName => "stats_form";
        public Dictionary<string, string> LocaleJSON { get => localeJSON; set => localeJSON = value; }


        public PrintableAuctionStats(MainForm main) {
            InitializeComponent();
            this.main = main;
            setStatistics();
        }

        public PrintableAuctionStats(MainForm main, Size pageSize) {
            InitializeComponent();
            this.main = main;
            this.pageSize = pageSize;

            LocaleJSON = Utils.getJsonLang(main.DefaultLang, LocaleFileName);
            localize();

            setStatistics();
        }

        public void localize() {
            title.Text = LocaleJSON["title"];
            auctionStart.Text = LocaleJSON["auction_start_label"];
            auctionEnd.Text = LocaleJSON["auction_end_label"];
            auctionItem.Text = LocaleJSON["auction_item_label"];
            totalClients.Text = LocaleJSON["total_clients_label"];
            activityRate.Text = LocaleJSON["activity_rate_label"];
            highestBet.Text = LocaleJSON["highest_bet_label"];
            totalBiddingMoney.Text = LocaleJSON["total_biddings_label"];
            bidStdDev.Text = LocaleJSON["bid_std_dev_label"];

            if (!main.LocalizedForms.Contains(this))
                main.LocalizedForms.Add(this);
        }

        public void print() {
            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("", pageSize.Width, pageSize.Height);
            getPrintArea();
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            Close();
        }

        private void getPrintArea() {
            formCapture = new Bitmap(statSheet_pan.Width, statSheet_pan.Height);
            statSheet_pan.DrawToBitmap(formCapture, new Rectangle(0, 0, statSheet_pan.Width, statSheet_pan.Height));
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e) {
            formCapture = (Bitmap) Utils.resizeImage(formCapture, pageSize);
            e.Graphics.DrawImage(formCapture, (pageSize.Width - formCapture.Width) / 2, statSheet_pan.Location.Y);
        }

        private void setStatistics() {
            AuctionStatistics stats = AuctionStatistics.generateStatistics(main.AuctionInstance);

            auctionStart_out.Text = stats.AuctionStart.ToString(LocaleJSON["time_format"]);
            auctionEnd_out.Text = stats.AuctionEnd.ToString(LocaleJSON["time_format"]);
            auctionItem_out.Text = LocaleJSON["id_format"].Replace("%id%", stats.AuctionItemID.ToString());
            totalClients_out.Text = stats.TotalClients.ToString();
            activityRate_out.Text = $"{stats.ActivityRate:0.00}%";
            highestBet_out.Text = LocaleJSON["currency_format"]
                .Replace("%amount%", stats.HighestBet.ToString("0.00"))
                .Replace("%curr%", main.LocaleJSON["currency_unit"]);
            totalBiddingMoney_out.Text = LocaleJSON["currency_format"]
                .Replace("%amount%", stats.TotalBiddingMoney.ToString("0.00"))
                .Replace("%curr%", main.LocaleJSON["currency_unit"]);
            bidStdDev_out.Text = LocaleJSON["currency_format"]
                .Replace("%amount%", stats.BidStandardDeviation.ToString("0.00"))
                .Replace("%curr%", main.LocaleJSON["currency_unit"]);
        }
    }
}
