using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Collections.Generic;
using System.Linq;
using System;

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
            graph.Text = LocaleJSON["graph_label"];
        }

        private void graph_pan_Paint(object sender, PaintEventArgs e) {
            Graphics g = e.Graphics;
            List<float> bids = main.AuctionInstance.Bids;
            Color[] colors = { Color.Cyan, Color.Turquoise, Color.Aquamarine, Color.DarkTurquoise, Color.LightSeaGreen};

            Point baseLineP1 = new Point(e.ClipRectangle.X, e.ClipRectangle.Height - 10);
            Point baseLineP2 = new Point(e.ClipRectangle.Width, e.ClipRectangle.Height - 10);
            g.DrawLine(new Pen(Color.Black), baseLineP1, baseLineP2);

            Point vertLineP1 = new Point(e.ClipRectangle.X, e.ClipRectangle.Y + 40);
            g.DrawLine(new Pen(Color.Black), vertLineP1, baseLineP1);

            // DEBUG
            bids.AddRange(new float[] {50, 70, 100, 200, 300, 500, 750, 800, 900, 1200, 1240, 2000});

            if (bids.Count > 0) {
                float maxBid = bids.Max();
                int maxGraphHeight = baseLineP1.Y - vertLineP1.Y;
                int maxGraphWidth = baseLineP2.X - baseLineP1.X;
                int rectWidth = maxGraphWidth / ((bids.Count > 20 ? 20 : bids.Count) * 2);

                /*
                 * RO: Limitează numărul de coloane la 20 pe grafic dacă sunt mai mult de 20
                 * EN: Limit the number of columns to 20 on the graph if there are more than 20
                 */
                for (int i = bids.Count > 20 ? bids.Count - 20 : 0; i < bids.Count; i++) {
                    float bid = bids[i];
                    int rectHeight = (int)(maxGraphHeight * (bid / maxBid));
                    int rectY = baseLineP1.Y - rectHeight;
                    int rectX = ((i * rectWidth) + baseLineP1.X) + 1;

                    g.FillRectangle(new SolidBrush(colors[i % colors.Count()]), rectX, rectY, rectWidth, rectHeight);

                    Point textLoc = new Point(rectX, rectHeight >= (maxGraphHeight * 0.14) ? rectY + 5 : rectY - 25);
                    StringFormat sf = new StringFormat();
                    sf.FormatFlags = StringFormatFlags.DirectionVertical;
                    g.DrawString(bid.ToString(), new Font("Times New Roman", bids.Count > 10 ? 8 : 10), new SolidBrush(Color.Black), textLoc, sf);
                }
            }
        }
    }
}
