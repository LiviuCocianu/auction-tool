
using System.Windows.Forms;

namespace Auction_Tool {
    partial class MainForm {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolbar = new System.Windows.Forms.ToolStripMenuItem();
            this.fileTB_create = new System.Windows.Forms.ToolStripMenuItem();
            this.fileTB_create_item = new System.Windows.Forms.ToolStripMenuItem();
            this.fileTB_create_client = new System.Windows.Forms.ToolStripMenuItem();
            this.fileTB_remove = new System.Windows.Forms.ToolStripMenuItem();
            this.fileTB_remove_item = new System.Windows.Forms.ToolStripMenuItem();
            this.fileTB_remove_item_all = new System.Windows.Forms.ToolStripMenuItem();
            this.fileTB_remove_item_ID = new System.Windows.Forms.ToolStripMenuItem();
            this.fileTB_remove_client = new System.Windows.Forms.ToolStripMenuItem();
            this.fileTB_remove_client_all = new System.Windows.Forms.ToolStripMenuItem();
            this.fileTB_remove_client_ID = new System.Windows.Forms.ToolStripMenuItem();
            this.fileTB_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.fileTB_edit_item = new System.Windows.Forms.ToolStripMenuItem();
            this.fileTB_edit_client = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsToolbar = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsTB_load = new System.Windows.Forms.ToolStripMenuItem();
            this.auctionToolbar = new System.Windows.Forms.ToolStripMenuItem();
            this.auctionTB_stop = new System.Windows.Forms.ToolStripMenuItem();
            this.auctionTB_reset = new System.Windows.Forms.ToolStripMenuItem();
            this.auctionTB_finish = new System.Windows.Forms.ToolStripMenuItem();
            this.langToolbar = new System.Windows.Forms.ToolStripMenuItem();
            this.langTB_RO = new System.Windows.Forms.ToolStripMenuItem();
            this.langTB_EN = new System.Windows.Forms.ToolStripMenuItem();
            this.auctionItemName = new System.Windows.Forms.Label();
            this.auctionItemName_out = new System.Windows.Forms.Label();
            this.basePrice = new System.Windows.Forms.Label();
            this.basePrice_out = new System.Windows.Forms.Label();
            this.highestBid = new System.Windows.Forms.Label();
            this.highestBid_out = new System.Windows.Forms.Label();
            this.topBidderNo = new System.Windows.Forms.Label();
            this.topBidderNo_out = new System.Windows.Forms.Label();
            this.generalInfo_pan = new System.Windows.Forms.Panel();
            this.auctionItemId_pan = new System.Windows.Forms.FlowLayoutPanel();
            this.auctionItemID = new System.Windows.Forms.Label();
            this.auctionItemID_out = new System.Windows.Forms.Label();
            this.generalInfo_title = new System.Windows.Forms.Label();
            this.auctionItemDesc_pan = new System.Windows.Forms.FlowLayoutPanel();
            this.auctionItemDesc = new System.Windows.Forms.Label();
            this.auctionItemDesc_link = new System.Windows.Forms.Label();
            this.auctionItemName_pan = new System.Windows.Forms.FlowLayoutPanel();
            this.itemInfo_pan = new System.Windows.Forms.Panel();
            this.auctionInfo_pan = new System.Windows.Forms.Panel();
            this.auctionInfo_title = new System.Windows.Forms.Label();
            this.basePrice_pan = new System.Windows.Forms.FlowLayoutPanel();
            this.topBidderNo_pan = new System.Windows.Forms.FlowLayoutPanel();
            this.highestBid_pan = new System.Windows.Forms.FlowLayoutPanel();
            this.itemImage_pb = new System.Windows.Forms.PictureBox();
            this.clientSearch_tb = new System.Windows.Forms.TextBox();
            this.preItemSelect1 = new System.Windows.Forms.Label();
            this.preItemSelect_pan = new System.Windows.Forms.Panel();
            this.preItemSelect2_pan = new System.Windows.Forms.Panel();
            this.preItemSelect2 = new System.Windows.Forms.Label();
            this.preItemSelect1_pan = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.clientList_panel = new System.Windows.Forms.Panel();
            this.tableIndexNo = new System.Windows.Forms.Label();
            this.clientListHeader_tlp = new System.Windows.Forms.TableLayoutPanel();
            this.tableClientID = new System.Windows.Forms.Label();
            this.tableAuctionNumber = new System.Windows.Forms.Label();
            this.tableClientFirstName = new System.Windows.Forms.Label();
            this.tableClientLastName = new System.Windows.Forms.Label();
            this.tableClientBidAmount = new System.Windows.Forms.Label();
            this.tableClientBudget = new System.Windows.Forms.Label();
            this.clientSearch_tlp = new System.Windows.Forms.TableLayoutPanel();
            this.searchIconBG_pan = new System.Windows.Forms.Panel();
            this.searchIcon_pb = new System.Windows.Forms.PictureBox();
            this.clientElement_ctx = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cli_ctx_remove = new System.Windows.Forms.ToolStripMenuItem();
            this.cli_ctx_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.cli_ctx_bet = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.generalInfo_pan.SuspendLayout();
            this.auctionItemId_pan.SuspendLayout();
            this.auctionItemDesc_pan.SuspendLayout();
            this.auctionItemName_pan.SuspendLayout();
            this.itemInfo_pan.SuspendLayout();
            this.auctionInfo_pan.SuspendLayout();
            this.basePrice_pan.SuspendLayout();
            this.topBidderNo_pan.SuspendLayout();
            this.highestBid_pan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemImage_pb)).BeginInit();
            this.preItemSelect_pan.SuspendLayout();
            this.preItemSelect2_pan.SuspendLayout();
            this.preItemSelect1_pan.SuspendLayout();
            this.clientListHeader_tlp.SuspendLayout();
            this.clientSearch_tlp.SuspendLayout();
            this.searchIconBG_pan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon_pb)).BeginInit();
            this.clientElement_ctx.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Black;
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolbar,
            this.itemsToolbar,
            this.auctionToolbar,
            this.langToolbar});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(1019, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolbar
            // 
            this.fileToolbar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileTB_create,
            this.fileTB_remove,
            this.fileTB_edit});
            this.fileToolbar.ForeColor = System.Drawing.Color.White;
            this.fileToolbar.Name = "fileToolbar";
            this.fileToolbar.Size = new System.Drawing.Size(57, 24);
            this.fileToolbar.Text = "Fișier";
            this.fileToolbar.DropDownClosed += new System.EventHandler(this.fileToolbar_DropDownClosed);
            this.fileToolbar.Click += new System.EventHandler(this.fileToolbar_Click);
            this.fileToolbar.MouseLeave += new System.EventHandler(this.fileToolbar_MouseLeave);
            this.fileToolbar.MouseHover += new System.EventHandler(this.fileToolbar_MouseHover);
            // 
            // fileTB_create
            // 
            this.fileTB_create.BackColor = System.Drawing.Color.White;
            this.fileTB_create.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileTB_create_item,
            this.fileTB_create_client});
            this.fileTB_create.ForeColor = System.Drawing.Color.Black;
            this.fileTB_create.Image = global::Auction_Tool.Properties.Resources.add;
            this.fileTB_create.Name = "fileTB_create";
            this.fileTB_create.Size = new System.Drawing.Size(149, 26);
            this.fileTB_create.Text = "Creează";
            // 
            // fileTB_create_item
            // 
            this.fileTB_create_item.Image = ((System.Drawing.Image)(resources.GetObject("fileTB_create_item.Image")));
            this.fileTB_create_item.Name = "fileTB_create_item";
            this.fileTB_create_item.Size = new System.Drawing.Size(136, 26);
            this.fileTB_create_item.Text = "Articol";
            this.fileTB_create_item.Click += new System.EventHandler(this.fileCreateItem_Click);
            // 
            // fileTB_create_client
            // 
            this.fileTB_create_client.Image = global::Auction_Tool.Properties.Resources.bidder;
            this.fileTB_create_client.Name = "fileTB_create_client";
            this.fileTB_create_client.Size = new System.Drawing.Size(136, 26);
            this.fileTB_create_client.Text = "Client";
            this.fileTB_create_client.Click += new System.EventHandler(this.fileCreateClient_Click);
            // 
            // fileTB_remove
            // 
            this.fileTB_remove.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileTB_remove_item,
            this.fileTB_remove_client});
            this.fileTB_remove.Image = global::Auction_Tool.Properties.Resources.remove;
            this.fileTB_remove.Name = "fileTB_remove";
            this.fileTB_remove.Size = new System.Drawing.Size(149, 26);
            this.fileTB_remove.Text = "Elimină";
            // 
            // fileTB_remove_item
            // 
            this.fileTB_remove_item.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileTB_remove_item_all,
            this.fileTB_remove_item_ID});
            this.fileTB_remove_item.Image = ((System.Drawing.Image)(resources.GetObject("fileTB_remove_item.Image")));
            this.fileTB_remove_item.Name = "fileTB_remove_item";
            this.fileTB_remove_item.Size = new System.Drawing.Size(136, 26);
            this.fileTB_remove_item.Text = "Articol";
            // 
            // fileTB_remove_item_all
            // 
            this.fileTB_remove_item_all.Image = global::Auction_Tool.Properties.Resources.all;
            this.fileTB_remove_item_all.Name = "fileTB_remove_item_all";
            this.fileTB_remove_item_all.Size = new System.Drawing.Size(195, 26);
            this.fileTB_remove_item_all.Text = "Toate articolele";
            this.fileTB_remove_item_all.Click += new System.EventHandler(this.fileRemoveAllItems_Click);
            // 
            // fileTB_remove_item_ID
            // 
            this.fileTB_remove_item_ID.Image = global::Auction_Tool.Properties.Resources.by_id;
            this.fileTB_remove_item_ID.Name = "fileTB_remove_item_ID";
            this.fileTB_remove_item_ID.Size = new System.Drawing.Size(195, 26);
            this.fileTB_remove_item_ID.Text = "După ID";
            this.fileTB_remove_item_ID.Click += new System.EventHandler(this.fileRemoveItem_Click);
            // 
            // fileTB_remove_client
            // 
            this.fileTB_remove_client.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileTB_remove_client_all,
            this.fileTB_remove_client_ID});
            this.fileTB_remove_client.Image = global::Auction_Tool.Properties.Resources.bidder;
            this.fileTB_remove_client.Name = "fileTB_remove_client";
            this.fileTB_remove_client.Size = new System.Drawing.Size(136, 26);
            this.fileTB_remove_client.Text = "Client";
            // 
            // fileTB_remove_client_all
            // 
            this.fileTB_remove_client_all.Image = global::Auction_Tool.Properties.Resources.all;
            this.fileTB_remove_client_all.Name = "fileTB_remove_client_all";
            this.fileTB_remove_client_all.Size = new System.Drawing.Size(165, 26);
            this.fileTB_remove_client_all.Text = "Toți clienții";
            this.fileTB_remove_client_all.Click += new System.EventHandler(this.fileRemoveClientID_Click);
            // 
            // fileTB_remove_client_ID
            // 
            this.fileTB_remove_client_ID.Image = global::Auction_Tool.Properties.Resources.by_id;
            this.fileTB_remove_client_ID.Name = "fileTB_remove_client_ID";
            this.fileTB_remove_client_ID.Size = new System.Drawing.Size(165, 26);
            this.fileTB_remove_client_ID.Text = "După ID";
            this.fileTB_remove_client_ID.Click += new System.EventHandler(this.fileRemoveItemID_Click);
            // 
            // fileTB_edit
            // 
            this.fileTB_edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileTB_edit_item,
            this.fileTB_edit_client});
            this.fileTB_edit.Image = global::Auction_Tool.Properties.Resources.edit;
            this.fileTB_edit.Name = "fileTB_edit";
            this.fileTB_edit.Size = new System.Drawing.Size(149, 26);
            this.fileTB_edit.Text = "Editează";
            // 
            // fileTB_edit_item
            // 
            this.fileTB_edit_item.Image = global::Auction_Tool.Properties.Resources.item;
            this.fileTB_edit_item.Name = "fileTB_edit_item";
            this.fileTB_edit_item.Size = new System.Drawing.Size(136, 26);
            this.fileTB_edit_item.Text = "Articol";
            this.fileTB_edit_item.Click += new System.EventHandler(this.fileEditItem_Click);
            // 
            // fileTB_edit_client
            // 
            this.fileTB_edit_client.Image = global::Auction_Tool.Properties.Resources.bidder;
            this.fileTB_edit_client.Name = "fileTB_edit_client";
            this.fileTB_edit_client.Size = new System.Drawing.Size(136, 26);
            this.fileTB_edit_client.Text = "Client";
            this.fileTB_edit_client.Click += new System.EventHandler(this.fileEditClient_Click);
            // 
            // itemsToolbar
            // 
            this.itemsToolbar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemsTB_load});
            this.itemsToolbar.ForeColor = System.Drawing.Color.White;
            this.itemsToolbar.Name = "itemsToolbar";
            this.itemsToolbar.Size = new System.Drawing.Size(75, 24);
            this.itemsToolbar.Text = "Articole";
            this.itemsToolbar.DropDownClosed += new System.EventHandler(this.itemsToolbar_DropDownClosed);
            this.itemsToolbar.Click += new System.EventHandler(this.itemsToolbar_Click);
            this.itemsToolbar.MouseLeave += new System.EventHandler(this.itemsToolbar_MouseLeave);
            this.itemsToolbar.MouseHover += new System.EventHandler(this.itemsToolbar_MouseHover);
            // 
            // itemsTB_load
            // 
            this.itemsTB_load.Image = ((System.Drawing.Image)(resources.GetObject("itemsTB_load.Image")));
            this.itemsTB_load.Name = "itemsTB_load";
            this.itemsTB_load.Size = new System.Drawing.Size(139, 26);
            this.itemsTB_load.Text = "Încarcă";
            // 
            // auctionToolbar
            // 
            this.auctionToolbar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.auctionTB_stop,
            this.auctionTB_reset,
            this.auctionTB_finish});
            this.auctionToolbar.ForeColor = System.Drawing.Color.White;
            this.auctionToolbar.Name = "auctionToolbar";
            this.auctionToolbar.Size = new System.Drawing.Size(75, 24);
            this.auctionToolbar.Text = "Licitație";
            this.auctionToolbar.DropDownClosed += new System.EventHandler(this.auctionToolbar_DropDownClosed);
            this.auctionToolbar.Click += new System.EventHandler(this.auctionToolbar_Click);
            this.auctionToolbar.MouseLeave += new System.EventHandler(this.auctionToolbar_MouseLeave);
            this.auctionToolbar.MouseHover += new System.EventHandler(this.auctionToolbar_MouseHover);
            // 
            // auctionTB_stop
            // 
            this.auctionTB_stop.Name = "auctionTB_stop";
            this.auctionTB_stop.Size = new System.Drawing.Size(159, 26);
            this.auctionTB_stop.Text = "Oprește";
            this.auctionTB_stop.Click += new System.EventHandler(this.auctionTB_stop_Click);
            // 
            // auctionTB_reset
            // 
            this.auctionTB_reset.Name = "auctionTB_reset";
            this.auctionTB_reset.Size = new System.Drawing.Size(159, 26);
            this.auctionTB_reset.Text = "Resetează";
            this.auctionTB_reset.Click += new System.EventHandler(this.auctionTB_reset_Click);
            // 
            // auctionTB_finish
            // 
            this.auctionTB_finish.Name = "auctionTB_finish";
            this.auctionTB_finish.Size = new System.Drawing.Size(159, 26);
            this.auctionTB_finish.Text = "Termină";
            this.auctionTB_finish.Click += new System.EventHandler(this.auctionTB_finish_Click);
            // 
            // langToolbar
            // 
            this.langToolbar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.langTB_RO,
            this.langTB_EN});
            this.langToolbar.ForeColor = System.Drawing.Color.White;
            this.langToolbar.Name = "langToolbar";
            this.langToolbar.Size = new System.Drawing.Size(64, 24);
            this.langToolbar.Text = "Limbă";
            this.langToolbar.DropDownClosed += new System.EventHandler(this.langToolbar_DropDownClosed);
            this.langToolbar.Click += new System.EventHandler(this.langToolbar_Click);
            this.langToolbar.MouseLeave += new System.EventHandler(this.langToolbar_MouseLeave);
            this.langToolbar.MouseHover += new System.EventHandler(this.langToolbar_MouseHover);
            // 
            // langTB_RO
            // 
            this.langTB_RO.Image = global::Auction_Tool.Properties.Resources.lang_ro;
            this.langTB_RO.Name = "langTB_RO";
            this.langTB_RO.Size = new System.Drawing.Size(147, 26);
            this.langTB_RO.Text = "Română";
            this.langTB_RO.Click += new System.EventHandler(this.langTB_RO_Click);
            // 
            // langTB_EN
            // 
            this.langTB_EN.Image = global::Auction_Tool.Properties.Resources.lang_en;
            this.langTB_EN.Name = "langTB_EN";
            this.langTB_EN.Size = new System.Drawing.Size(147, 26);
            this.langTB_EN.Text = "Engleză";
            this.langTB_EN.Click += new System.EventHandler(this.langTB_EN_Click);
            // 
            // auctionItemName
            // 
            this.auctionItemName.AutoSize = true;
            this.auctionItemName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.auctionItemName.Location = new System.Drawing.Point(4, 0);
            this.auctionItemName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.auctionItemName.Name = "auctionItemName";
            this.auctionItemName.Size = new System.Drawing.Size(116, 18);
            this.auctionItemName.TabIndex = 2;
            this.auctionItemName.Text = "Denumire articol:";
            // 
            // auctionItemName_out
            // 
            this.auctionItemName_out.AutoSize = true;
            this.auctionItemName_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auctionItemName_out.Location = new System.Drawing.Point(128, 0);
            this.auctionItemName_out.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.auctionItemName_out.Name = "auctionItemName_out";
            this.auctionItemName_out.Size = new System.Drawing.Size(78, 17);
            this.auctionItemName_out.TabIndex = 3;
            this.auctionItemName_out.Text = "Indisponibil";
            // 
            // basePrice
            // 
            this.basePrice.AutoSize = true;
            this.basePrice.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basePrice.Location = new System.Drawing.Point(4, 0);
            this.basePrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.basePrice.Name = "basePrice";
            this.basePrice.Size = new System.Drawing.Size(88, 18);
            this.basePrice.TabIndex = 6;
            this.basePrice.Text = "Preț de bază:";
            // 
            // basePrice_out
            // 
            this.basePrice_out.AutoSize = true;
            this.basePrice_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basePrice_out.Location = new System.Drawing.Point(100, 0);
            this.basePrice_out.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.basePrice_out.Name = "basePrice_out";
            this.basePrice_out.Size = new System.Drawing.Size(78, 17);
            this.basePrice_out.TabIndex = 7;
            this.basePrice_out.Text = "Indisponibil";
            // 
            // highestBid
            // 
            this.highestBid.AutoSize = true;
            this.highestBid.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highestBid.Location = new System.Drawing.Point(4, 0);
            this.highestBid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.highestBid.Name = "highestBid";
            this.highestBid.Size = new System.Drawing.Size(142, 18);
            this.highestBid.TabIndex = 8;
            this.highestBid.Text = "Sumă propusă curent:";
            // 
            // highestBid_out
            // 
            this.highestBid_out.AutoSize = true;
            this.highestBid_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highestBid_out.Location = new System.Drawing.Point(154, 0);
            this.highestBid_out.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.highestBid_out.Name = "highestBid_out";
            this.highestBid_out.Size = new System.Drawing.Size(78, 17);
            this.highestBid_out.TabIndex = 9;
            this.highestBid_out.Tag = 0F;
            this.highestBid_out.Text = "Indisponibil";
            // 
            // topBidderNo
            // 
            this.topBidderNo.AutoSize = true;
            this.topBidderNo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topBidderNo.Location = new System.Drawing.Point(4, 0);
            this.topBidderNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.topBidderNo.Name = "topBidderNo";
            this.topBidderNo.Size = new System.Drawing.Size(131, 18);
            this.topBidderNo.TabIndex = 10;
            this.topBidderNo.Text = "Număr client în top:";
            // 
            // topBidderNo_out
            // 
            this.topBidderNo_out.AutoSize = true;
            this.topBidderNo_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topBidderNo_out.Location = new System.Drawing.Point(143, 0);
            this.topBidderNo_out.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.topBidderNo_out.Name = "topBidderNo_out";
            this.topBidderNo_out.Size = new System.Drawing.Size(78, 17);
            this.topBidderNo_out.TabIndex = 11;
            this.topBidderNo_out.Text = "Indisponibil";
            // 
            // generalInfo_pan
            // 
            this.generalInfo_pan.Controls.Add(this.auctionItemId_pan);
            this.generalInfo_pan.Controls.Add(this.generalInfo_title);
            this.generalInfo_pan.Controls.Add(this.auctionItemDesc_pan);
            this.generalInfo_pan.Controls.Add(this.auctionItemName_pan);
            this.generalInfo_pan.Location = new System.Drawing.Point(45, 293);
            this.generalInfo_pan.Margin = new System.Windows.Forms.Padding(4);
            this.generalInfo_pan.Name = "generalInfo_pan";
            this.generalInfo_pan.Size = new System.Drawing.Size(305, 106);
            this.generalInfo_pan.TabIndex = 13;
            // 
            // auctionItemId_pan
            // 
            this.auctionItemId_pan.Controls.Add(this.auctionItemID);
            this.auctionItemId_pan.Controls.Add(this.auctionItemID_out);
            this.auctionItemId_pan.Location = new System.Drawing.Point(0, 27);
            this.auctionItemId_pan.Margin = new System.Windows.Forms.Padding(0);
            this.auctionItemId_pan.Name = "auctionItemId_pan";
            this.auctionItemId_pan.Size = new System.Drawing.Size(305, 22);
            this.auctionItemId_pan.TabIndex = 18;
            // 
            // auctionItemID
            // 
            this.auctionItemID.AutoSize = true;
            this.auctionItemID.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.auctionItemID.Location = new System.Drawing.Point(4, 0);
            this.auctionItemID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.auctionItemID.Name = "auctionItemID";
            this.auctionItemID.Size = new System.Drawing.Size(67, 18);
            this.auctionItemID.TabIndex = 15;
            this.auctionItemID.Text = "ID articol:";
            // 
            // auctionItemID_out
            // 
            this.auctionItemID_out.AutoSize = true;
            this.auctionItemID_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auctionItemID_out.Location = new System.Drawing.Point(79, 0);
            this.auctionItemID_out.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.auctionItemID_out.Name = "auctionItemID_out";
            this.auctionItemID_out.Size = new System.Drawing.Size(78, 17);
            this.auctionItemID_out.TabIndex = 16;
            this.auctionItemID_out.Text = "Indisponibil";
            // 
            // generalInfo_title
            // 
            this.generalInfo_title.AutoSize = true;
            this.generalInfo_title.Font = new System.Drawing.Font("Calibri", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generalInfo_title.Location = new System.Drawing.Point(4, 2);
            this.generalInfo_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.generalInfo_title.Name = "generalInfo_title";
            this.generalInfo_title.Size = new System.Drawing.Size(146, 21);
            this.generalInfo_title.TabIndex = 14;
            this.generalInfo_title.Text = "Informații generale";
            // 
            // auctionItemDesc_pan
            // 
            this.auctionItemDesc_pan.Controls.Add(this.auctionItemDesc);
            this.auctionItemDesc_pan.Controls.Add(this.auctionItemDesc_link);
            this.auctionItemDesc_pan.Location = new System.Drawing.Point(0, 69);
            this.auctionItemDesc_pan.Margin = new System.Windows.Forms.Padding(0);
            this.auctionItemDesc_pan.Name = "auctionItemDesc_pan";
            this.auctionItemDesc_pan.Size = new System.Drawing.Size(305, 22);
            this.auctionItemDesc_pan.TabIndex = 20;
            // 
            // auctionItemDesc
            // 
            this.auctionItemDesc.AutoSize = true;
            this.auctionItemDesc.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.auctionItemDesc.Location = new System.Drawing.Point(4, 0);
            this.auctionItemDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.auctionItemDesc.Name = "auctionItemDesc";
            this.auctionItemDesc.Size = new System.Drawing.Size(113, 18);
            this.auctionItemDesc.TabIndex = 12;
            this.auctionItemDesc.Text = "Descriere articol:";
            // 
            // auctionItemDesc_link
            // 
            this.auctionItemDesc_link.AutoSize = true;
            this.auctionItemDesc_link.Cursor = System.Windows.Forms.Cursors.Hand;
            this.auctionItemDesc_link.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auctionItemDesc_link.ForeColor = System.Drawing.Color.DodgerBlue;
            this.auctionItemDesc_link.Location = new System.Drawing.Point(125, 0);
            this.auctionItemDesc_link.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.auctionItemDesc_link.Name = "auctionItemDesc_link";
            this.auctionItemDesc_link.Size = new System.Drawing.Size(77, 17);
            this.auctionItemDesc_link.TabIndex = 13;
            this.auctionItemDesc_link.Text = "Vizualizare";
            this.auctionItemDesc_link.Click += new System.EventHandler(this.auctionItemDescription_link_Click);
            // 
            // auctionItemName_pan
            // 
            this.auctionItemName_pan.Controls.Add(this.auctionItemName);
            this.auctionItemName_pan.Controls.Add(this.auctionItemName_out);
            this.auctionItemName_pan.Location = new System.Drawing.Point(0, 48);
            this.auctionItemName_pan.Margin = new System.Windows.Forms.Padding(0);
            this.auctionItemName_pan.Name = "auctionItemName_pan";
            this.auctionItemName_pan.Size = new System.Drawing.Size(305, 22);
            this.auctionItemName_pan.TabIndex = 19;
            // 
            // itemInfo_pan
            // 
            this.itemInfo_pan.BackColor = System.Drawing.Color.LightGray;
            this.itemInfo_pan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemInfo_pan.Controls.Add(this.auctionInfo_pan);
            this.itemInfo_pan.Controls.Add(this.itemImage_pb);
            this.itemInfo_pan.Controls.Add(this.generalInfo_pan);
            this.itemInfo_pan.Location = new System.Drawing.Point(0, 30);
            this.itemInfo_pan.Margin = new System.Windows.Forms.Padding(4);
            this.itemInfo_pan.Name = "itemInfo_pan";
            this.itemInfo_pan.Size = new System.Drawing.Size(406, 529);
            this.itemInfo_pan.TabIndex = 14;
            // 
            // auctionInfo_pan
            // 
            this.auctionInfo_pan.Controls.Add(this.auctionInfo_title);
            this.auctionInfo_pan.Controls.Add(this.basePrice_pan);
            this.auctionInfo_pan.Controls.Add(this.topBidderNo_pan);
            this.auctionInfo_pan.Controls.Add(this.highestBid_pan);
            this.auctionInfo_pan.Location = new System.Drawing.Point(45, 402);
            this.auctionInfo_pan.Margin = new System.Windows.Forms.Padding(4);
            this.auctionInfo_pan.Name = "auctionInfo_pan";
            this.auctionInfo_pan.Size = new System.Drawing.Size(305, 102);
            this.auctionInfo_pan.TabIndex = 14;
            // 
            // auctionInfo_title
            // 
            this.auctionInfo_title.AutoSize = true;
            this.auctionInfo_title.Font = new System.Drawing.Font("Calibri", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auctionInfo_title.Location = new System.Drawing.Point(4, 6);
            this.auctionInfo_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.auctionInfo_title.Name = "auctionInfo_title";
            this.auctionInfo_title.Size = new System.Drawing.Size(136, 21);
            this.auctionInfo_title.TabIndex = 15;
            this.auctionInfo_title.Text = "Informații licitație";
            // 
            // basePrice_pan
            // 
            this.basePrice_pan.Controls.Add(this.basePrice);
            this.basePrice_pan.Controls.Add(this.basePrice_out);
            this.basePrice_pan.Location = new System.Drawing.Point(0, 27);
            this.basePrice_pan.Margin = new System.Windows.Forms.Padding(0);
            this.basePrice_pan.Name = "basePrice_pan";
            this.basePrice_pan.Size = new System.Drawing.Size(305, 22);
            this.basePrice_pan.TabIndex = 21;
            // 
            // topBidderNo_pan
            // 
            this.topBidderNo_pan.Controls.Add(this.topBidderNo);
            this.topBidderNo_pan.Controls.Add(this.topBidderNo_out);
            this.topBidderNo_pan.Location = new System.Drawing.Point(0, 69);
            this.topBidderNo_pan.Margin = new System.Windows.Forms.Padding(0);
            this.topBidderNo_pan.Name = "topBidderNo_pan";
            this.topBidderNo_pan.Size = new System.Drawing.Size(305, 22);
            this.topBidderNo_pan.TabIndex = 23;
            // 
            // highestBid_pan
            // 
            this.highestBid_pan.Controls.Add(this.highestBid);
            this.highestBid_pan.Controls.Add(this.highestBid_out);
            this.highestBid_pan.Location = new System.Drawing.Point(0, 48);
            this.highestBid_pan.Margin = new System.Windows.Forms.Padding(0);
            this.highestBid_pan.Name = "highestBid_pan";
            this.highestBid_pan.Size = new System.Drawing.Size(305, 22);
            this.highestBid_pan.TabIndex = 22;
            // 
            // itemImage_pb
            // 
            this.itemImage_pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemImage_pb.Image = global::Auction_Tool.Properties.Resources.no_image;
            this.itemImage_pb.Location = new System.Drawing.Point(64, 22);
            this.itemImage_pb.Margin = new System.Windows.Forms.Padding(4);
            this.itemImage_pb.Name = "itemImage_pb";
            this.itemImage_pb.Size = new System.Drawing.Size(270, 258);
            this.itemImage_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.itemImage_pb.TabIndex = 1;
            this.itemImage_pb.TabStop = false;
            // 
            // clientSearch_tb
            // 
            this.clientSearch_tb.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.clientSearch_tb.BackColor = System.Drawing.Color.Gainsboro;
            this.clientSearch_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientSearch_tb.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.clientSearch_tb.Location = new System.Drawing.Point(14, 6);
            this.clientSearch_tb.Margin = new System.Windows.Forms.Padding(0);
            this.clientSearch_tb.Name = "clientSearch_tb";
            this.clientSearch_tb.Size = new System.Drawing.Size(418, 15);
            this.clientSearch_tb.TabIndex = 15;
            this.clientSearch_tb.TabStop = false;
            this.clientSearch_tb.Text = "Caută ID client..";
            this.clientSearch_tb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clientSearch_tb_MouseClick);
            this.clientSearch_tb.TextChanged += new System.EventHandler(this.clientSearch_tb_TextChanged);
            this.clientSearch_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.clientSearch_tb_KeyPress);
            this.clientSearch_tb.Leave += new System.EventHandler(this.clientSearch_tb_Leave);
            this.clientSearch_tb.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.clientSearch_tb_MouseDoubleClick);
            this.clientSearch_tb.MouseLeave += new System.EventHandler(this.clientSearch_tb_MouseLeave);
            // 
            // preItemSelect1
            // 
            this.preItemSelect1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.preItemSelect1.Location = new System.Drawing.Point(0, 0);
            this.preItemSelect1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.preItemSelect1.Name = "preItemSelect1";
            this.preItemSelect1.Size = new System.Drawing.Size(516, 40);
            this.preItemSelect1.TabIndex = 16;
            this.preItemSelect1.Text = "Selectează un articol din categoria \"Articole\" înainte de a continua";
            this.preItemSelect1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // preItemSelect_pan
            // 
            this.preItemSelect_pan.BackColor = System.Drawing.Color.White;
            this.preItemSelect_pan.Controls.Add(this.preItemSelect2_pan);
            this.preItemSelect_pan.Controls.Add(this.preItemSelect1_pan);
            this.preItemSelect_pan.Location = new System.Drawing.Point(465, 237);
            this.preItemSelect_pan.Margin = new System.Windows.Forms.Padding(4);
            this.preItemSelect_pan.Name = "preItemSelect_pan";
            this.preItemSelect_pan.Size = new System.Drawing.Size(516, 89);
            this.preItemSelect_pan.TabIndex = 18;
            // 
            // preItemSelect2_pan
            // 
            this.preItemSelect2_pan.Controls.Add(this.preItemSelect2);
            this.preItemSelect2_pan.Location = new System.Drawing.Point(0, 34);
            this.preItemSelect2_pan.Name = "preItemSelect2_pan";
            this.preItemSelect2_pan.Size = new System.Drawing.Size(516, 40);
            this.preItemSelect2_pan.TabIndex = 19;
            // 
            // preItemSelect2
            // 
            this.preItemSelect2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.preItemSelect2.Location = new System.Drawing.Point(0, 0);
            this.preItemSelect2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.preItemSelect2.Name = "preItemSelect2";
            this.preItemSelect2.Size = new System.Drawing.Size(516, 40);
            this.preItemSelect2.TabIndex = 17;
            this.preItemSelect2.Text = "Dacă nu sunt articole de selectat, creează unul folosind categoria \"Fișier\"";
            this.preItemSelect2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // preItemSelect1_pan
            // 
            this.preItemSelect1_pan.Controls.Add(this.preItemSelect1);
            this.preItemSelect1_pan.Location = new System.Drawing.Point(0, 0);
            this.preItemSelect1_pan.Name = "preItemSelect1_pan";
            this.preItemSelect1_pan.Size = new System.Drawing.Size(516, 40);
            this.preItemSelect1_pan.TabIndex = 18;
            // 
            // clientList_panel
            // 
            this.clientList_panel.AutoScroll = true;
            this.clientList_panel.BackColor = System.Drawing.Color.White;
            this.clientList_panel.Location = new System.Drawing.Point(304, 58);
            this.clientList_panel.Margin = new System.Windows.Forms.Padding(2);
            this.clientList_panel.Name = "clientList_panel";
            this.clientList_panel.Size = new System.Drawing.Size(461, 367);
            this.clientList_panel.TabIndex = 19;
            // 
            // tableIndexNo
            // 
            this.tableIndexNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableIndexNo.ForeColor = System.Drawing.SystemColors.Control;
            this.tableIndexNo.Location = new System.Drawing.Point(4, 11);
            this.tableIndexNo.Name = "tableIndexNo";
            this.tableIndexNo.Size = new System.Drawing.Size(24, 13);
            this.tableIndexNo.TabIndex = 0;
            this.tableIndexNo.Text = "Nr";
            this.tableIndexNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clientListHeader_tlp
            // 
            this.clientListHeader_tlp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clientListHeader_tlp.BackColor = System.Drawing.Color.Black;
            this.clientListHeader_tlp.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.clientListHeader_tlp.ColumnCount = 7;
            this.clientListHeader_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.726458F));
            this.clientListHeader_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.417041F));
            this.clientListHeader_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.65919F));
            this.clientListHeader_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.60987F));
            this.clientListHeader_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.34783F));
            this.clientListHeader_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.86957F));
            this.clientListHeader_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.6087F));
            this.clientListHeader_tlp.Controls.Add(this.tableIndexNo, 0, 0);
            this.clientListHeader_tlp.Controls.Add(this.tableClientID, 1, 0);
            this.clientListHeader_tlp.Controls.Add(this.tableAuctionNumber, 2, 0);
            this.clientListHeader_tlp.Controls.Add(this.tableClientFirstName, 3, 0);
            this.clientListHeader_tlp.Controls.Add(this.tableClientLastName, 4, 0);
            this.clientListHeader_tlp.Controls.Add(this.tableClientBidAmount, 5, 0);
            this.clientListHeader_tlp.Controls.Add(this.tableClientBudget, 6, 0);
            this.clientListHeader_tlp.Location = new System.Drawing.Point(304, 24);
            this.clientListHeader_tlp.Name = "clientListHeader_tlp";
            this.clientListHeader_tlp.RowCount = 1;
            this.clientListHeader_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.clientListHeader_tlp.Size = new System.Drawing.Size(460, 36);
            this.clientListHeader_tlp.TabIndex = 19;
            // 
            // tableClientID
            // 
            this.tableClientID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableClientID.ForeColor = System.Drawing.SystemColors.Control;
            this.tableClientID.Location = new System.Drawing.Point(35, 1);
            this.tableClientID.Name = "tableClientID";
            this.tableClientID.Size = new System.Drawing.Size(36, 34);
            this.tableClientID.TabIndex = 20;
            this.tableClientID.Text = "ID\r\nclient";
            this.tableClientID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableAuctionNumber
            // 
            this.tableAuctionNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableAuctionNumber.ForeColor = System.Drawing.SystemColors.Control;
            this.tableAuctionNumber.Location = new System.Drawing.Point(78, 1);
            this.tableAuctionNumber.Name = "tableAuctionNumber";
            this.tableAuctionNumber.Size = new System.Drawing.Size(65, 34);
            this.tableAuctionNumber.TabIndex = 21;
            this.tableAuctionNumber.Text = "Număr\r\nlicitație";
            this.tableAuctionNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableClientFirstName
            // 
            this.tableClientFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableClientFirstName.ForeColor = System.Drawing.SystemColors.Control;
            this.tableClientFirstName.Location = new System.Drawing.Point(150, 1);
            this.tableClientFirstName.Name = "tableClientFirstName";
            this.tableClientFirstName.Size = new System.Drawing.Size(78, 34);
            this.tableClientFirstName.TabIndex = 22;
            this.tableClientFirstName.Text = "Nume client";
            this.tableClientFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableClientLastName
            // 
            this.tableClientLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableClientLastName.ForeColor = System.Drawing.SystemColors.Control;
            this.tableClientLastName.Location = new System.Drawing.Point(235, 1);
            this.tableClientLastName.Name = "tableClientLastName";
            this.tableClientLastName.Size = new System.Drawing.Size(86, 34);
            this.tableClientLastName.TabIndex = 23;
            this.tableClientLastName.Text = "Prenume client";
            this.tableClientLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableClientBidAmount
            // 
            this.tableClientBidAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableClientBidAmount.ForeColor = System.Drawing.SystemColors.Control;
            this.tableClientBidAmount.Location = new System.Drawing.Point(328, 1);
            this.tableClientBidAmount.Name = "tableClientBidAmount";
            this.tableClientBidAmount.Size = new System.Drawing.Size(70, 34);
            this.tableClientBidAmount.TabIndex = 24;
            this.tableClientBidAmount.Text = "Sumă licitată";
            this.tableClientBidAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableClientBudget
            // 
            this.tableClientBudget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableClientBudget.ForeColor = System.Drawing.SystemColors.Control;
            this.tableClientBudget.Location = new System.Drawing.Point(405, 1);
            this.tableClientBudget.Name = "tableClientBudget";
            this.tableClientBudget.Size = new System.Drawing.Size(51, 34);
            this.tableClientBudget.TabIndex = 25;
            this.tableClientBudget.Text = "Buget\r\ndisponibil";
            this.tableClientBudget.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clientSearch_tlp
            // 
            this.clientSearch_tlp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clientSearch_tlp.BackColor = System.Drawing.Color.Gainsboro;
            this.clientSearch_tlp.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.clientSearch_tlp.ColumnCount = 2;
            this.clientSearch_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94.13043F));
            this.clientSearch_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.869565F));
            this.clientSearch_tlp.Controls.Add(this.searchIconBG_pan, 1, 0);
            this.clientSearch_tlp.Controls.Add(this.clientSearch_tb, 0, 0);
            this.clientSearch_tlp.Location = new System.Drawing.Point(304, 424);
            this.clientSearch_tlp.Margin = new System.Windows.Forms.Padding(0);
            this.clientSearch_tlp.Name = "clientSearch_tlp";
            this.clientSearch_tlp.RowCount = 1;
            this.clientSearch_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.clientSearch_tlp.Size = new System.Drawing.Size(461, 27);
            this.clientSearch_tlp.TabIndex = 19;
            // 
            // searchIconBG_pan
            // 
            this.searchIconBG_pan.BackColor = System.Drawing.Color.Black;
            this.searchIconBG_pan.Controls.Add(this.searchIcon_pb);
            this.searchIconBG_pan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchIconBG_pan.Location = new System.Drawing.Point(433, 1);
            this.searchIconBG_pan.Margin = new System.Windows.Forms.Padding(0);
            this.searchIconBG_pan.Name = "searchIconBG_pan";
            this.searchIconBG_pan.Size = new System.Drawing.Size(27, 25);
            this.searchIconBG_pan.TabIndex = 20;
            // 
            // searchIcon_pb
            // 
            this.searchIcon_pb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchIcon_pb.Image = global::Auction_Tool.Properties.Resources.search_icon_white;
            this.searchIcon_pb.Location = new System.Drawing.Point(3, 3);
            this.searchIcon_pb.Margin = new System.Windows.Forms.Padding(0);
            this.searchIcon_pb.Name = "searchIcon_pb";
            this.searchIcon_pb.Padding = new System.Windows.Forms.Padding(3);
            this.searchIcon_pb.Size = new System.Drawing.Size(20, 20);
            this.searchIcon_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.searchIcon_pb.TabIndex = 19;
            this.searchIcon_pb.TabStop = false;
            // 
            // clientElement_ctx
            // 
            this.clientElement_ctx.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.clientElement_ctx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cli_ctx_remove,
            this.cli_ctx_edit,
            this.cli_ctx_bet});
            this.clientElement_ctx.Name = "clientElement_context";
            this.clientElement_ctx.Size = new System.Drawing.Size(177, 82);
            // 
            // cli_ctx_remove
            // 
            this.cli_ctx_remove.Image = global::Auction_Tool.Properties.Resources.remove;
            this.cli_ctx_remove.Name = "cli_ctx_remove";
            this.cli_ctx_remove.Size = new System.Drawing.Size(176, 26);
            this.cli_ctx_remove.Text = "Elimină";
            this.cli_ctx_remove.Click += new System.EventHandler(this.contextRemoveItem_Click);
            // 
            // cli_ctx_edit
            // 
            this.cli_ctx_edit.Image = global::Auction_Tool.Properties.Resources.edit;
            this.cli_ctx_edit.Name = "cli_ctx_edit";
            this.cli_ctx_edit.Size = new System.Drawing.Size(176, 26);
            this.cli_ctx_edit.Text = "Editează";
            this.cli_ctx_edit.Click += new System.EventHandler(this.contextEditItem_Click);
            // 
            // cli_ctx_bet
            // 
            this.cli_ctx_bet.Image = global::Auction_Tool.Properties.Resources.bet;
            this.cli_ctx_bet.Name = "cli_ctx_bet";
            this.cli_ctx_bet.Size = new System.Drawing.Size(176, 26);
            this.cli_ctx_bet.Text = "Propune sumă";
            this.cli_ctx_bet.Click += new System.EventHandler(this.contextBet_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1019, 554);
            this.Controls.Add(this.itemInfo_pan);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.preItemSelect_pan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Licitații (.NET Form Designer App)";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.generalInfo_pan.ResumeLayout(false);
            this.generalInfo_pan.PerformLayout();
            this.auctionItemId_pan.ResumeLayout(false);
            this.auctionItemId_pan.PerformLayout();
            this.auctionItemDesc_pan.ResumeLayout(false);
            this.auctionItemDesc_pan.PerformLayout();
            this.auctionItemName_pan.ResumeLayout(false);
            this.auctionItemName_pan.PerformLayout();
            this.itemInfo_pan.ResumeLayout(false);
            this.auctionInfo_pan.ResumeLayout(false);
            this.auctionInfo_pan.PerformLayout();
            this.basePrice_pan.ResumeLayout(false);
            this.basePrice_pan.PerformLayout();
            this.topBidderNo_pan.ResumeLayout(false);
            this.topBidderNo_pan.PerformLayout();
            this.highestBid_pan.ResumeLayout(false);
            this.highestBid_pan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemImage_pb)).EndInit();
            this.preItemSelect_pan.ResumeLayout(false);
            this.preItemSelect2_pan.ResumeLayout(false);
            this.preItemSelect1_pan.ResumeLayout(false);
            this.clientListHeader_tlp.ResumeLayout(false);
            this.clientSearch_tlp.ResumeLayout(false);
            this.clientSearch_tlp.PerformLayout();
            this.searchIconBG_pan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon_pb)).EndInit();
            this.clientElement_ctx.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        #region declarari
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolbar;
        private System.Windows.Forms.ToolStripMenuItem fileTB_create;
        private System.Windows.Forms.ToolStripMenuItem fileTB_create_item;
        private System.Windows.Forms.ToolStripMenuItem fileTB_remove;
        private System.Windows.Forms.ToolStripMenuItem fileTB_remove_item;
        private System.Windows.Forms.ToolStripMenuItem itemsToolbar;
        private System.Windows.Forms.PictureBox itemImage_pb;
        private System.Windows.Forms.ToolStripMenuItem fileTB_create_client;
        private System.Windows.Forms.ToolStripMenuItem fileTB_remove_client;
        private System.Windows.Forms.Label auctionItemName;
        private System.Windows.Forms.Label auctionItemName_out;
        private System.Windows.Forms.Label basePrice;
        private System.Windows.Forms.Label basePrice_out;
        private System.Windows.Forms.Label highestBid;
        public System.Windows.Forms.Label highestBid_out;
        private System.Windows.Forms.Label topBidderNo;
        public System.Windows.Forms.Label topBidderNo_out;
        private System.Windows.Forms.Panel generalInfo_pan;
        private System.Windows.Forms.Panel itemInfo_pan;
        private System.Windows.Forms.Label auctionItemDesc;
        private System.Windows.Forms.Label auctionItemDesc_link;
        private System.Windows.Forms.Label generalInfo_title;
        private System.Windows.Forms.Panel auctionInfo_pan;
        private System.Windows.Forms.Label auctionInfo_title;
        private System.Windows.Forms.TextBox clientSearch_tb;
        private System.Windows.Forms.Label preItemSelect1;
        private System.Windows.Forms.Panel preItemSelect_pan;
        private System.Windows.Forms.Label preItemSelect2;
        private System.Windows.Forms.ToolStripMenuItem fileTB_remove_item_all;
        private System.Windows.Forms.ToolStripMenuItem fileTB_remove_item_ID;
        private System.Windows.Forms.ToolStripMenuItem fileTB_remove_client_all;
        private System.Windows.Forms.ToolStripMenuItem fileTB_remove_client_ID;
        private System.Windows.Forms.Label auctionItemID;
        public System.Windows.Forms.Label auctionItemID_out;
        public System.Windows.Forms.ToolStripMenuItem itemsTB_load;
        private ToolTip toolTip1;
        public Panel clientList_panel;
        private Label tableIndexNo;
        public TableLayoutPanel clientListHeader_tlp;
        private Label tableClientID;
        private Label tableAuctionNumber;
        private Label tableClientFirstName;
        private Label tableClientLastName;
        private Label tableClientBidAmount;
        private Label tableClientBudget;
        private TableLayoutPanel clientSearch_tlp;
        private PictureBox searchIcon_pb;
        private Panel searchIconBG_pan;
        private ContextMenuStrip clientElement_ctx;
        private ToolStripMenuItem cli_ctx_remove;
        private ToolStripMenuItem cli_ctx_edit;
        #endregion

        private ToolStripMenuItem fileTB_edit;
        private ToolStripMenuItem fileTB_edit_item;
        private ToolStripMenuItem fileTB_edit_client;
        private ToolStripMenuItem cli_ctx_bet;
        private ToolStripMenuItem auctionToolbar;
        private ToolStripMenuItem auctionTB_stop;
        private ToolStripMenuItem auctionTB_reset;
        private FlowLayoutPanel auctionItemId_pan;
        private FlowLayoutPanel auctionItemDesc_pan;
        private FlowLayoutPanel auctionItemName_pan;
        private FlowLayoutPanel basePrice_pan;
        private FlowLayoutPanel topBidderNo_pan;
        private FlowLayoutPanel highestBid_pan;
        private ToolStripMenuItem langToolbar;
        private ToolStripMenuItem langTB_RO;
        private ToolStripMenuItem langTB_EN;
        private Panel preItemSelect2_pan;
        private Panel preItemSelect1_pan;
        private ToolStripMenuItem auctionTB_finish;
    }
}

