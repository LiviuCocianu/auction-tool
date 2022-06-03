namespace Auction_Tool {
    partial class PrintableAuctionStats {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintableAuctionStats));
            this.title = new System.Windows.Forms.Label();
            this.title_pan = new System.Windows.Forms.Panel();
            this.stats_pan = new System.Windows.Forms.FlowLayoutPanel();
            this.auctionStart_pan = new System.Windows.Forms.FlowLayoutPanel();
            this.auctionStart = new System.Windows.Forms.Label();
            this.auctionStart_out = new System.Windows.Forms.Label();
            this.auctionEnd_pan = new System.Windows.Forms.FlowLayoutPanel();
            this.auctionEnd = new System.Windows.Forms.Label();
            this.auctionEnd_out = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.statSheet_pan = new System.Windows.Forms.Panel();
            this.auctionItem_pan = new System.Windows.Forms.FlowLayoutPanel();
            this.auctionItem = new System.Windows.Forms.Label();
            this.auctionItem_out = new System.Windows.Forms.Label();
            this.totalClients_pan = new System.Windows.Forms.FlowLayoutPanel();
            this.totalClients = new System.Windows.Forms.Label();
            this.totalClients_out = new System.Windows.Forms.Label();
            this.activityRate_pan = new System.Windows.Forms.FlowLayoutPanel();
            this.activityRate = new System.Windows.Forms.Label();
            this.activityRate_out = new System.Windows.Forms.Label();
            this.highestBet_pan = new System.Windows.Forms.FlowLayoutPanel();
            this.highestBet = new System.Windows.Forms.Label();
            this.highestBet_out = new System.Windows.Forms.Label();
            this.totalBiddingMoney_pan = new System.Windows.Forms.FlowLayoutPanel();
            this.totalBiddingMoney = new System.Windows.Forms.Label();
            this.totalBiddingMoney_out = new System.Windows.Forms.Label();
            this.bidStdDev_pan = new System.Windows.Forms.FlowLayoutPanel();
            this.bidStdDev = new System.Windows.Forms.Label();
            this.bidStdDev_out = new System.Windows.Forms.Label();
            this.title_pan.SuspendLayout();
            this.stats_pan.SuspendLayout();
            this.auctionStart_pan.SuspendLayout();
            this.auctionEnd_pan.SuspendLayout();
            this.statSheet_pan.SuspendLayout();
            this.auctionItem_pan.SuspendLayout();
            this.totalClients_pan.SuspendLayout();
            this.activityRate_pan.SuspendLayout();
            this.highestBet_pan.SuspendLayout();
            this.totalBiddingMoney_pan.SuspendLayout();
            this.bidStdDev_pan.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.title.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(577, 103);
            this.title.TabIndex = 0;
            this.title.Text = "Statistici licitație";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // title_pan
            // 
            this.title_pan.BackColor = System.Drawing.Color.Transparent;
            this.title_pan.Controls.Add(this.title);
            this.title_pan.Dock = System.Windows.Forms.DockStyle.Top;
            this.title_pan.Location = new System.Drawing.Point(0, 0);
            this.title_pan.Name = "title_pan";
            this.title_pan.Size = new System.Drawing.Size(577, 103);
            this.title_pan.TabIndex = 1;
            // 
            // stats_pan
            // 
            this.stats_pan.Controls.Add(this.auctionStart_pan);
            this.stats_pan.Controls.Add(this.auctionEnd_pan);
            this.stats_pan.Controls.Add(this.auctionItem_pan);
            this.stats_pan.Controls.Add(this.totalClients_pan);
            this.stats_pan.Controls.Add(this.activityRate_pan);
            this.stats_pan.Controls.Add(this.highestBet_pan);
            this.stats_pan.Controls.Add(this.totalBiddingMoney_pan);
            this.stats_pan.Controls.Add(this.bidStdDev_pan);
            this.stats_pan.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.stats_pan.Location = new System.Drawing.Point(81, 106);
            this.stats_pan.Name = "stats_pan";
            this.stats_pan.Size = new System.Drawing.Size(425, 554);
            this.stats_pan.TabIndex = 2;
            // 
            // auctionStart_pan
            // 
            this.auctionStart_pan.Controls.Add(this.auctionStart);
            this.auctionStart_pan.Controls.Add(this.auctionStart_out);
            this.auctionStart_pan.Location = new System.Drawing.Point(3, 3);
            this.auctionStart_pan.Name = "auctionStart_pan";
            this.auctionStart_pan.Size = new System.Drawing.Size(422, 32);
            this.auctionStart_pan.TabIndex = 0;
            // 
            // auctionStart
            // 
            this.auctionStart.AutoSize = true;
            this.auctionStart.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auctionStart.Location = new System.Drawing.Point(3, 0);
            this.auctionStart.Name = "auctionStart";
            this.auctionStart.Size = new System.Drawing.Size(84, 19);
            this.auctionStart.TabIndex = 0;
            this.auctionStart.Text = "Început la: ";
            // 
            // auctionStart_out
            // 
            this.auctionStart_out.AutoSize = true;
            this.auctionStart_out.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auctionStart_out.Location = new System.Drawing.Point(93, 0);
            this.auctionStart_out.Name = "auctionStart_out";
            this.auctionStart_out.Size = new System.Drawing.Size(167, 19);
            this.auctionStart_out.TabIndex = 1;
            this.auctionStart_out.Text = "01-01-2000, 00:00:00";
            // 
            // auctionEnd_pan
            // 
            this.auctionEnd_pan.Controls.Add(this.auctionEnd);
            this.auctionEnd_pan.Controls.Add(this.auctionEnd_out);
            this.auctionEnd_pan.Location = new System.Drawing.Point(3, 41);
            this.auctionEnd_pan.Name = "auctionEnd_pan";
            this.auctionEnd_pan.Size = new System.Drawing.Size(422, 32);
            this.auctionEnd_pan.TabIndex = 2;
            // 
            // auctionEnd
            // 
            this.auctionEnd.AutoSize = true;
            this.auctionEnd.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auctionEnd.Location = new System.Drawing.Point(3, 0);
            this.auctionEnd.Name = "auctionEnd";
            this.auctionEnd.Size = new System.Drawing.Size(88, 19);
            this.auctionEnd.TabIndex = 0;
            this.auctionEnd.Text = "Încheiat la: ";
            // 
            // auctionEnd_out
            // 
            this.auctionEnd_out.AutoSize = true;
            this.auctionEnd_out.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auctionEnd_out.Location = new System.Drawing.Point(97, 0);
            this.auctionEnd_out.Name = "auctionEnd_out";
            this.auctionEnd_out.Size = new System.Drawing.Size(167, 19);
            this.auctionEnd_out.TabIndex = 1;
            this.auctionEnd_out.Text = "01-01-2000, 00:00:00";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // statSheet_pan
            // 
            this.statSheet_pan.Controls.Add(this.title_pan);
            this.statSheet_pan.Controls.Add(this.stats_pan);
            this.statSheet_pan.Location = new System.Drawing.Point(0, 0);
            this.statSheet_pan.Name = "statSheet_pan";
            this.statSheet_pan.Size = new System.Drawing.Size(577, 795);
            this.statSheet_pan.TabIndex = 3;
            // 
            // auctionItem_pan
            // 
            this.auctionItem_pan.Controls.Add(this.auctionItem);
            this.auctionItem_pan.Controls.Add(this.auctionItem_out);
            this.auctionItem_pan.Location = new System.Drawing.Point(3, 79);
            this.auctionItem_pan.Name = "auctionItem_pan";
            this.auctionItem_pan.Size = new System.Drawing.Size(422, 32);
            this.auctionItem_pan.TabIndex = 3;
            // 
            // auctionItem
            // 
            this.auctionItem.AutoSize = true;
            this.auctionItem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auctionItem.Location = new System.Drawing.Point(3, 0);
            this.auctionItem.Name = "auctionItem";
            this.auctionItem.Size = new System.Drawing.Size(107, 19);
            this.auctionItem.TabIndex = 0;
            this.auctionItem.Text = "Articol licitat:";
            // 
            // auctionItem_out
            // 
            this.auctionItem_out.AutoSize = true;
            this.auctionItem_out.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auctionItem_out.Location = new System.Drawing.Point(116, 0);
            this.auctionItem_out.Name = "auctionItem_out";
            this.auctionItem_out.Size = new System.Drawing.Size(53, 19);
            this.auctionItem_out.TabIndex = 1;
            this.auctionItem_out.Text = "#0000";
            // 
            // totalClients_pan
            // 
            this.totalClients_pan.Controls.Add(this.totalClients);
            this.totalClients_pan.Controls.Add(this.totalClients_out);
            this.totalClients_pan.Location = new System.Drawing.Point(3, 117);
            this.totalClients_pan.Name = "totalClients_pan";
            this.totalClients_pan.Size = new System.Drawing.Size(422, 32);
            this.totalClients_pan.TabIndex = 4;
            // 
            // totalClients
            // 
            this.totalClients.AutoSize = true;
            this.totalClients.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalClients.Location = new System.Drawing.Point(3, 0);
            this.totalClients.Name = "totalClients";
            this.totalClients.Size = new System.Drawing.Size(176, 19);
            this.totalClients.TabIndex = 0;
            this.totalClients.Text = "Număr total participanți:";
            // 
            // totalClients_out
            // 
            this.totalClients_out.AutoSize = true;
            this.totalClients_out.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalClients_out.Location = new System.Drawing.Point(185, 0);
            this.totalClients_out.Name = "totalClients_out";
            this.totalClients_out.Size = new System.Drawing.Size(18, 19);
            this.totalClients_out.TabIndex = 1;
            this.totalClients_out.Text = "0";
            // 
            // activityRate_pan
            // 
            this.activityRate_pan.Controls.Add(this.activityRate);
            this.activityRate_pan.Controls.Add(this.activityRate_out);
            this.activityRate_pan.Location = new System.Drawing.Point(3, 155);
            this.activityRate_pan.Name = "activityRate_pan";
            this.activityRate_pan.Size = new System.Drawing.Size(422, 32);
            this.activityRate_pan.TabIndex = 5;
            // 
            // activityRate
            // 
            this.activityRate.AutoSize = true;
            this.activityRate.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityRate.Location = new System.Drawing.Point(3, 0);
            this.activityRate.Name = "activityRate";
            this.activityRate.Size = new System.Drawing.Size(130, 19);
            this.activityRate.TabIndex = 0;
            this.activityRate.Text = "Rată de activitate:";
            // 
            // activityRate_out
            // 
            this.activityRate_out.AutoSize = true;
            this.activityRate_out.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityRate_out.Location = new System.Drawing.Point(139, 0);
            this.activityRate_out.Name = "activityRate_out";
            this.activityRate_out.Size = new System.Drawing.Size(32, 19);
            this.activityRate_out.TabIndex = 1;
            this.activityRate_out.Text = "0%";
            // 
            // highestBet_pan
            // 
            this.highestBet_pan.Controls.Add(this.highestBet);
            this.highestBet_pan.Controls.Add(this.highestBet_out);
            this.highestBet_pan.Location = new System.Drawing.Point(3, 193);
            this.highestBet_pan.Name = "highestBet_pan";
            this.highestBet_pan.Size = new System.Drawing.Size(422, 32);
            this.highestBet_pan.TabIndex = 6;
            // 
            // highestBet
            // 
            this.highestBet.AutoSize = true;
            this.highestBet.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highestBet.Location = new System.Drawing.Point(3, 0);
            this.highestBet.Name = "highestBet";
            this.highestBet.Size = new System.Drawing.Size(137, 19);
            this.highestBet.TabIndex = 0;
            this.highestBet.Text = "Sumă câștigătoare:";
            // 
            // highestBet_out
            // 
            this.highestBet_out.AutoSize = true;
            this.highestBet_out.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highestBet_out.Location = new System.Drawing.Point(146, 0);
            this.highestBet_out.Name = "highestBet_out";
            this.highestBet_out.Size = new System.Drawing.Size(51, 19);
            this.highestBet_out.TabIndex = 1;
            this.highestBet_out.Text = "0 u.m.";
            // 
            // totalBiddingMoney_pan
            // 
            this.totalBiddingMoney_pan.Controls.Add(this.totalBiddingMoney);
            this.totalBiddingMoney_pan.Controls.Add(this.totalBiddingMoney_out);
            this.totalBiddingMoney_pan.Location = new System.Drawing.Point(3, 231);
            this.totalBiddingMoney_pan.Name = "totalBiddingMoney_pan";
            this.totalBiddingMoney_pan.Size = new System.Drawing.Size(422, 32);
            this.totalBiddingMoney_pan.TabIndex = 7;
            // 
            // totalBiddingMoney
            // 
            this.totalBiddingMoney.AutoSize = true;
            this.totalBiddingMoney.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBiddingMoney.Location = new System.Drawing.Point(3, 0);
            this.totalBiddingMoney.Name = "totalBiddingMoney";
            this.totalBiddingMoney.Size = new System.Drawing.Size(154, 19);
            this.totalBiddingMoney.TabIndex = 0;
            this.totalBiddingMoney.Text = "Sumă totală investită:";
            // 
            // totalBiddingMoney_out
            // 
            this.totalBiddingMoney_out.AutoSize = true;
            this.totalBiddingMoney_out.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBiddingMoney_out.Location = new System.Drawing.Point(163, 0);
            this.totalBiddingMoney_out.Name = "totalBiddingMoney_out";
            this.totalBiddingMoney_out.Size = new System.Drawing.Size(51, 19);
            this.totalBiddingMoney_out.TabIndex = 1;
            this.totalBiddingMoney_out.Text = "0 u.m.";
            // 
            // bidStdDev_pan
            // 
            this.bidStdDev_pan.Controls.Add(this.bidStdDev);
            this.bidStdDev_pan.Controls.Add(this.bidStdDev_out);
            this.bidStdDev_pan.Location = new System.Drawing.Point(3, 269);
            this.bidStdDev_pan.Name = "bidStdDev_pan";
            this.bidStdDev_pan.Size = new System.Drawing.Size(422, 32);
            this.bidStdDev_pan.TabIndex = 8;
            // 
            // bidStdDev
            // 
            this.bidStdDev.AutoSize = true;
            this.bidStdDev.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bidStdDev.Location = new System.Drawing.Point(3, 0);
            this.bidStdDev.Name = "bidStdDev";
            this.bidStdDev.Size = new System.Drawing.Size(197, 19);
            this.bidStdDev.TabIndex = 0;
            this.bidStdDev.Text = "Abatere standard propuneri:";
            // 
            // bidStdDev_out
            // 
            this.bidStdDev_out.AutoSize = true;
            this.bidStdDev_out.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bidStdDev_out.Location = new System.Drawing.Point(206, 0);
            this.bidStdDev_out.Name = "bidStdDev_out";
            this.bidStdDev_out.Size = new System.Drawing.Size(51, 19);
            this.bidStdDev_out.TabIndex = 1;
            this.bidStdDev_out.Text = "0 u.m.";
            // 
            // PrintableAuctionStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(577, 795);
            this.Controls.Add(this.statSheet_pan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrintableAuctionStats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.title_pan.ResumeLayout(false);
            this.stats_pan.ResumeLayout(false);
            this.auctionStart_pan.ResumeLayout(false);
            this.auctionStart_pan.PerformLayout();
            this.auctionEnd_pan.ResumeLayout(false);
            this.auctionEnd_pan.PerformLayout();
            this.statSheet_pan.ResumeLayout(false);
            this.auctionItem_pan.ResumeLayout(false);
            this.auctionItem_pan.PerformLayout();
            this.totalClients_pan.ResumeLayout(false);
            this.totalClients_pan.PerformLayout();
            this.activityRate_pan.ResumeLayout(false);
            this.activityRate_pan.PerformLayout();
            this.highestBet_pan.ResumeLayout(false);
            this.highestBet_pan.PerformLayout();
            this.totalBiddingMoney_pan.ResumeLayout(false);
            this.totalBiddingMoney_pan.PerformLayout();
            this.bidStdDev_pan.ResumeLayout(false);
            this.bidStdDev_pan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel title_pan;
        private System.Windows.Forms.FlowLayoutPanel stats_pan;
        private System.Windows.Forms.FlowLayoutPanel auctionStart_pan;
        private System.Windows.Forms.Label auctionStart;
        private System.Windows.Forms.Label auctionStart_out;
        private System.Windows.Forms.FlowLayoutPanel auctionEnd_pan;
        private System.Windows.Forms.Label auctionEnd;
        private System.Windows.Forms.Label auctionEnd_out;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Panel statSheet_pan;
        private System.Windows.Forms.FlowLayoutPanel auctionItem_pan;
        private System.Windows.Forms.Label auctionItem;
        private System.Windows.Forms.Label auctionItem_out;
        private System.Windows.Forms.FlowLayoutPanel totalClients_pan;
        private System.Windows.Forms.Label totalClients;
        private System.Windows.Forms.Label totalClients_out;
        private System.Windows.Forms.FlowLayoutPanel activityRate_pan;
        private System.Windows.Forms.Label activityRate;
        private System.Windows.Forms.Label activityRate_out;
        private System.Windows.Forms.FlowLayoutPanel highestBet_pan;
        private System.Windows.Forms.Label highestBet;
        private System.Windows.Forms.Label highestBet_out;
        private System.Windows.Forms.FlowLayoutPanel totalBiddingMoney_pan;
        private System.Windows.Forms.Label totalBiddingMoney;
        private System.Windows.Forms.Label totalBiddingMoney_out;
        private System.Windows.Forms.FlowLayoutPanel bidStdDev_pan;
        private System.Windows.Forms.Label bidStdDev;
        private System.Windows.Forms.Label bidStdDev_out;
    }
}