
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
            this.itemTB_load = new System.Windows.Forms.ToolStripMenuItem();
            this.auctionToolbar = new System.Windows.Forms.ToolStripMenuItem();
            this.auctionTB_stop = new System.Windows.Forms.ToolStripMenuItem();
            this.auctionTB_reset = new System.Windows.Forms.ToolStripMenuItem();
            this.auctionItemName = new System.Windows.Forms.Label();
            this.auctionItemName_out = new System.Windows.Forms.Label();
            this.basePrice = new System.Windows.Forms.Label();
            this.basePrice_out = new System.Windows.Forms.Label();
            this.highestBid = new System.Windows.Forms.Label();
            this.highestBid_out = new System.Windows.Forms.Label();
            this.topBidderNo = new System.Windows.Forms.Label();
            this.topBidderNo_out = new System.Windows.Forms.Label();
            this.generalInfo_pan = new System.Windows.Forms.Panel();
            this.auctionItemID = new System.Windows.Forms.Label();
            this.auctionItemID_out = new System.Windows.Forms.Label();
            this.generalInfo_title = new System.Windows.Forms.Label();
            this.auctionItemDesc_link = new System.Windows.Forms.Label();
            this.auctionItemDesc = new System.Windows.Forms.Label();
            this.itemInfo_pan = new System.Windows.Forms.Panel();
            this.auctionInfo_pan = new System.Windows.Forms.Panel();
            this.auctionInfo_title = new System.Windows.Forms.Label();
            this.itemImage_pb = new System.Windows.Forms.PictureBox();
            this.clientSearch_tb = new System.Windows.Forms.TextBox();
            this.preItemSelect1 = new System.Windows.Forms.Label();
            this.preItemSelect_pan = new System.Windows.Forms.Panel();
            this.preItemSelect2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.clientList_panel = new System.Windows.Forms.Panel();
            this.tableIndexNo = new System.Windows.Forms.Label();
            this.clientListHeader_tlp = new System.Windows.Forms.TableLayoutPanel();
            this.tableClientBudget = new System.Windows.Forms.Label();
            this.tableClientBidAmount = new System.Windows.Forms.Label();
            this.tableClientLastName = new System.Windows.Forms.Label();
            this.tableClientFirstName = new System.Windows.Forms.Label();
            this.tableClientID = new System.Windows.Forms.Label();
            this.tableAuctionID = new System.Windows.Forms.Label();
            this.clientSearch_tlp = new System.Windows.Forms.TableLayoutPanel();
            this.searchIconBG_pan = new System.Windows.Forms.Panel();
            this.searchIcon_pb = new System.Windows.Forms.PictureBox();
            this.clientElement_ctx = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cli_ctx_remove = new System.Windows.Forms.ToolStripMenuItem();
            this.cli_ctx_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.cli_ctx_bet = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.generalInfo_pan.SuspendLayout();
            this.itemInfo_pan.SuspendLayout();
            this.auctionInfo_pan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemImage_pb)).BeginInit();
            this.preItemSelect_pan.SuspendLayout();
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
            this.auctionToolbar});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(764, 24);
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
            this.fileToolbar.Size = new System.Drawing.Size(46, 20);
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
            this.fileTB_create.Size = new System.Drawing.Size(117, 22);
            this.fileTB_create.Text = "Creează";
            // 
            // fileTB_create_item
            // 
            this.fileTB_create_item.Image = ((System.Drawing.Image)(resources.GetObject("fileTB_create_item.Image")));
            this.fileTB_create_item.Name = "fileTB_create_item";
            this.fileTB_create_item.Size = new System.Drawing.Size(109, 22);
            this.fileTB_create_item.Text = "Articol";
            this.fileTB_create_item.Click += new System.EventHandler(this.fileCreateItem_Click);
            // 
            // fileTB_create_client
            // 
            this.fileTB_create_client.Image = global::Auction_Tool.Properties.Resources.bidder;
            this.fileTB_create_client.Name = "fileTB_create_client";
            this.fileTB_create_client.Size = new System.Drawing.Size(109, 22);
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
            this.fileTB_remove.Size = new System.Drawing.Size(117, 22);
            this.fileTB_remove.Text = "Elimină";
            // 
            // fileTB_remove_item
            // 
            this.fileTB_remove_item.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileTB_remove_item_all,
            this.fileTB_remove_item_ID});
            this.fileTB_remove_item.Image = ((System.Drawing.Image)(resources.GetObject("fileTB_remove_item.Image")));
            this.fileTB_remove_item.Name = "fileTB_remove_item";
            this.fileTB_remove_item.Size = new System.Drawing.Size(109, 22);
            this.fileTB_remove_item.Text = "Articol";
            // 
            // fileTB_remove_item_all
            // 
            this.fileTB_remove_item_all.Image = global::Auction_Tool.Properties.Resources.all;
            this.fileTB_remove_item_all.Name = "fileTB_remove_item_all";
            this.fileTB_remove_item_all.Size = new System.Drawing.Size(153, 22);
            this.fileTB_remove_item_all.Text = "Toate articolele";
            this.fileTB_remove_item_all.Click += new System.EventHandler(this.fileRemoveAllItems_Click);
            // 
            // fileTB_remove_item_ID
            // 
            this.fileTB_remove_item_ID.Image = global::Auction_Tool.Properties.Resources.by_id;
            this.fileTB_remove_item_ID.Name = "fileTB_remove_item_ID";
            this.fileTB_remove_item_ID.Size = new System.Drawing.Size(153, 22);
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
            this.fileTB_remove_client.Size = new System.Drawing.Size(109, 22);
            this.fileTB_remove_client.Text = "Client";
            // 
            // fileTB_remove_client_all
            // 
            this.fileTB_remove_client_all.Image = global::Auction_Tool.Properties.Resources.all;
            this.fileTB_remove_client_all.Name = "fileTB_remove_client_all";
            this.fileTB_remove_client_all.Size = new System.Drawing.Size(131, 22);
            this.fileTB_remove_client_all.Text = "Toți clienții";
            this.fileTB_remove_client_all.Click += new System.EventHandler(this.fileRemoveClientID_Click);
            // 
            // fileTB_remove_client_ID
            // 
            this.fileTB_remove_client_ID.Image = global::Auction_Tool.Properties.Resources.by_id;
            this.fileTB_remove_client_ID.Name = "fileTB_remove_client_ID";
            this.fileTB_remove_client_ID.Size = new System.Drawing.Size(131, 22);
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
            this.fileTB_edit.Size = new System.Drawing.Size(117, 22);
            this.fileTB_edit.Text = "Editează";
            // 
            // fileTB_edit_item
            // 
            this.fileTB_edit_item.Image = global::Auction_Tool.Properties.Resources.item;
            this.fileTB_edit_item.Name = "fileTB_edit_item";
            this.fileTB_edit_item.Size = new System.Drawing.Size(109, 22);
            this.fileTB_edit_item.Text = "Articol";
            this.fileTB_edit_item.Click += new System.EventHandler(this.fileEditItem_Click);
            // 
            // fileTB_edit_client
            // 
            this.fileTB_edit_client.Image = global::Auction_Tool.Properties.Resources.bidder;
            this.fileTB_edit_client.Name = "fileTB_edit_client";
            this.fileTB_edit_client.Size = new System.Drawing.Size(109, 22);
            this.fileTB_edit_client.Text = "Client";
            this.fileTB_edit_client.Click += new System.EventHandler(this.fileEditClient_Click);
            // 
            // itemsToolbar
            // 
            this.itemsToolbar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemTB_load});
            this.itemsToolbar.ForeColor = System.Drawing.Color.White;
            this.itemsToolbar.Name = "itemsToolbar";
            this.itemsToolbar.Size = new System.Drawing.Size(60, 20);
            this.itemsToolbar.Text = "Articole";
            this.itemsToolbar.DropDownClosed += new System.EventHandler(this.itemsToolbar_DropDownClosed);
            this.itemsToolbar.Click += new System.EventHandler(this.itemsToolbar_Click);
            this.itemsToolbar.MouseLeave += new System.EventHandler(this.itemsToolbar_MouseLeave);
            this.itemsToolbar.MouseHover += new System.EventHandler(this.itemsToolbar_MouseHover);
            // 
            // itemTB_load
            // 
            this.itemTB_load.Image = ((System.Drawing.Image)(resources.GetObject("itemTB_load.Image")));
            this.itemTB_load.Name = "itemTB_load";
            this.itemTB_load.Size = new System.Drawing.Size(184, 26);
            this.itemTB_load.Text = "Încarcă";
            // 
            // auctionToolbar
            // 
            this.auctionToolbar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.auctionTB_stop,
            this.auctionTB_reset});
            this.auctionToolbar.ForeColor = System.Drawing.Color.White;
            this.auctionToolbar.Name = "auctionToolbar";
            this.auctionToolbar.Size = new System.Drawing.Size(60, 20);
            this.auctionToolbar.Text = "Licitație";
            // 
            // auctionTB_stop
            // 
            this.auctionTB_stop.Name = "auctionTB_stop";
            this.auctionTB_stop.Size = new System.Drawing.Size(125, 22);
            this.auctionTB_stop.Text = "Termină";
            this.auctionTB_stop.Click += new System.EventHandler(this.auctionTB_stop_Click);
            // 
            // auctionTB_reset
            // 
            this.auctionTB_reset.Name = "auctionTB_reset";
            this.auctionTB_reset.Size = new System.Drawing.Size(125, 22);
            this.auctionTB_reset.Text = "Resetează";
            this.auctionTB_reset.Click += new System.EventHandler(this.auctionTB_reset_Click);
            // 
            // auctionItemName
            // 
            this.auctionItemName.AutoSize = true;
            this.auctionItemName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.auctionItemName.Location = new System.Drawing.Point(3, 39);
            this.auctionItemName.Name = "auctionItemName";
            this.auctionItemName.Size = new System.Drawing.Size(93, 14);
            this.auctionItemName.TabIndex = 2;
            this.auctionItemName.Text = "Denumire articol:";
            // 
            // auctionItemName_out
            // 
            this.auctionItemName_out.AutoSize = true;
            this.auctionItemName_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auctionItemName_out.Location = new System.Drawing.Point(95, 39);
            this.auctionItemName_out.Name = "auctionItemName_out";
            this.auctionItemName_out.Size = new System.Drawing.Size(59, 13);
            this.auctionItemName_out.TabIndex = 3;
            this.auctionItemName_out.Text = "Indisponibil";
            // 
            // basePrice
            // 
            this.basePrice.AutoSize = true;
            this.basePrice.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basePrice.Location = new System.Drawing.Point(3, 22);
            this.basePrice.Name = "basePrice";
            this.basePrice.Size = new System.Drawing.Size(71, 14);
            this.basePrice.TabIndex = 6;
            this.basePrice.Text = "Preț de bază:";
            // 
            // basePrice_out
            // 
            this.basePrice_out.AutoSize = true;
            this.basePrice_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basePrice_out.Location = new System.Drawing.Point(72, 22);
            this.basePrice_out.Name = "basePrice_out";
            this.basePrice_out.Size = new System.Drawing.Size(59, 13);
            this.basePrice_out.TabIndex = 7;
            this.basePrice_out.Text = "Indisponibil";
            // 
            // highestBid
            // 
            this.highestBid.AutoSize = true;
            this.highestBid.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highestBid.Location = new System.Drawing.Point(3, 39);
            this.highestBid.Name = "highestBid";
            this.highestBid.Size = new System.Drawing.Size(114, 14);
            this.highestBid.TabIndex = 8;
            this.highestBid.Text = "Sumă propusă curent:";
            // 
            // highestBid_out
            // 
            this.highestBid_out.AutoSize = true;
            this.highestBid_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highestBid_out.Location = new System.Drawing.Point(114, 39);
            this.highestBid_out.Name = "highestBid_out";
            this.highestBid_out.Size = new System.Drawing.Size(59, 13);
            this.highestBid_out.TabIndex = 9;
            this.highestBid_out.Tag = 0F;
            this.highestBid_out.Text = "Indisponibil";
            // 
            // topBidderNo
            // 
            this.topBidderNo.AutoSize = true;
            this.topBidderNo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topBidderNo.Location = new System.Drawing.Point(3, 56);
            this.topBidderNo.Name = "topBidderNo";
            this.topBidderNo.Size = new System.Drawing.Size(105, 14);
            this.topBidderNo.TabIndex = 10;
            this.topBidderNo.Text = "Număr client în top:";
            // 
            // topBidderNo_out
            // 
            this.topBidderNo_out.AutoSize = true;
            this.topBidderNo_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topBidderNo_out.Location = new System.Drawing.Point(106, 56);
            this.topBidderNo_out.Name = "topBidderNo_out";
            this.topBidderNo_out.Size = new System.Drawing.Size(59, 13);
            this.topBidderNo_out.TabIndex = 11;
            this.topBidderNo_out.Text = "Indisponibil";
            // 
            // generalInfo_pan
            // 
            this.generalInfo_pan.Controls.Add(this.auctionItemID);
            this.generalInfo_pan.Controls.Add(this.auctionItemID_out);
            this.generalInfo_pan.Controls.Add(this.generalInfo_title);
            this.generalInfo_pan.Controls.Add(this.auctionItemDesc_link);
            this.generalInfo_pan.Controls.Add(this.auctionItemDesc);
            this.generalInfo_pan.Controls.Add(this.auctionItemName);
            this.generalInfo_pan.Controls.Add(this.auctionItemName_out);
            this.generalInfo_pan.Location = new System.Drawing.Point(34, 238);
            this.generalInfo_pan.Name = "generalInfo_pan";
            this.generalInfo_pan.Size = new System.Drawing.Size(229, 86);
            this.generalInfo_pan.TabIndex = 13;
            // 
            // auctionItemID
            // 
            this.auctionItemID.AutoSize = true;
            this.auctionItemID.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.auctionItemID.Location = new System.Drawing.Point(3, 23);
            this.auctionItemID.Name = "auctionItemID";
            this.auctionItemID.Size = new System.Drawing.Size(55, 14);
            this.auctionItemID.TabIndex = 15;
            this.auctionItemID.Text = "ID articol:";
            // 
            // auctionItemID_out
            // 
            this.auctionItemID_out.AutoSize = true;
            this.auctionItemID_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auctionItemID_out.Location = new System.Drawing.Point(55, 23);
            this.auctionItemID_out.Name = "auctionItemID_out";
            this.auctionItemID_out.Size = new System.Drawing.Size(59, 13);
            this.auctionItemID_out.TabIndex = 16;
            this.auctionItemID_out.Text = "Indisponibil";
            // 
            // generalInfo_title
            // 
            this.generalInfo_title.AutoSize = true;
            this.generalInfo_title.Font = new System.Drawing.Font("Calibri", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generalInfo_title.Location = new System.Drawing.Point(3, 2);
            this.generalInfo_title.Name = "generalInfo_title";
            this.generalInfo_title.Size = new System.Drawing.Size(120, 17);
            this.generalInfo_title.TabIndex = 14;
            this.generalInfo_title.Text = "Informații generale";
            // 
            // auctionItemDesc_link
            // 
            this.auctionItemDesc_link.AutoSize = true;
            this.auctionItemDesc_link.Cursor = System.Windows.Forms.Cursors.Hand;
            this.auctionItemDesc_link.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auctionItemDesc_link.ForeColor = System.Drawing.Color.DodgerBlue;
            this.auctionItemDesc_link.Location = new System.Drawing.Point(92, 56);
            this.auctionItemDesc_link.Name = "auctionItemDesc_link";
            this.auctionItemDesc_link.Size = new System.Drawing.Size(57, 13);
            this.auctionItemDesc_link.TabIndex = 13;
            this.auctionItemDesc_link.Text = "Vizualizare";
            this.auctionItemDesc_link.Click += new System.EventHandler(this.auctionItemDescription_link_Click);
            // 
            // auctionItemDesc
            // 
            this.auctionItemDesc.AutoSize = true;
            this.auctionItemDesc.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.auctionItemDesc.Location = new System.Drawing.Point(3, 56);
            this.auctionItemDesc.Name = "auctionItemDesc";
            this.auctionItemDesc.Size = new System.Drawing.Size(91, 14);
            this.auctionItemDesc.TabIndex = 12;
            this.auctionItemDesc.Text = "Descriere articol:";
            // 
            // itemInfo_pan
            // 
            this.itemInfo_pan.BackColor = System.Drawing.Color.LightGray;
            this.itemInfo_pan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemInfo_pan.Controls.Add(this.auctionInfo_pan);
            this.itemInfo_pan.Controls.Add(this.itemImage_pb);
            this.itemInfo_pan.Controls.Add(this.generalInfo_pan);
            this.itemInfo_pan.Location = new System.Drawing.Point(0, 24);
            this.itemInfo_pan.Name = "itemInfo_pan";
            this.itemInfo_pan.Size = new System.Drawing.Size(305, 430);
            this.itemInfo_pan.TabIndex = 14;
            // 
            // auctionInfo_pan
            // 
            this.auctionInfo_pan.Controls.Add(this.auctionInfo_title);
            this.auctionInfo_pan.Controls.Add(this.basePrice);
            this.auctionInfo_pan.Controls.Add(this.highestBid);
            this.auctionInfo_pan.Controls.Add(this.topBidderNo);
            this.auctionInfo_pan.Controls.Add(this.basePrice_out);
            this.auctionInfo_pan.Controls.Add(this.highestBid_out);
            this.auctionInfo_pan.Controls.Add(this.topBidderNo_out);
            this.auctionInfo_pan.Location = new System.Drawing.Point(34, 327);
            this.auctionInfo_pan.Name = "auctionInfo_pan";
            this.auctionInfo_pan.Size = new System.Drawing.Size(229, 83);
            this.auctionInfo_pan.TabIndex = 14;
            // 
            // auctionInfo_title
            // 
            this.auctionInfo_title.AutoSize = true;
            this.auctionInfo_title.Font = new System.Drawing.Font("Calibri", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auctionInfo_title.Location = new System.Drawing.Point(3, 5);
            this.auctionInfo_title.Name = "auctionInfo_title";
            this.auctionInfo_title.Size = new System.Drawing.Size(111, 17);
            this.auctionInfo_title.TabIndex = 15;
            this.auctionInfo_title.Text = "Informații licitație";
            // 
            // itemImage_pb
            // 
            this.itemImage_pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemImage_pb.Image = global::Auction_Tool.Properties.Resources.no_image;
            this.itemImage_pb.Location = new System.Drawing.Point(48, 18);
            this.itemImage_pb.Name = "itemImage_pb";
            this.itemImage_pb.Size = new System.Drawing.Size(203, 210);
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
            this.clientSearch_tb.Location = new System.Drawing.Point(14, 7);
            this.clientSearch_tb.Margin = new System.Windows.Forms.Padding(0);
            this.clientSearch_tb.Name = "clientSearch_tb";
            this.clientSearch_tb.Size = new System.Drawing.Size(418, 13);
            this.clientSearch_tb.TabIndex = 15;
            this.clientSearch_tb.TabStop = false;
            this.clientSearch_tb.Text = "Caută ID client..";
            this.clientSearch_tb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clientSearch_tb_MouseClick);
            this.clientSearch_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.clientSearch_tb_KeyPress);
            this.clientSearch_tb.Leave += new System.EventHandler(this.clientSearch_tb_Leave);
            this.clientSearch_tb.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.clientSearch_tb_MouseDoubleClick);
            this.clientSearch_tb.MouseLeave += new System.EventHandler(this.clientSearch_tb_MouseLeave);
            // 
            // preItemSelect1
            // 
            this.preItemSelect1.AutoSize = true;
            this.preItemSelect1.Location = new System.Drawing.Point(30, 11);
            this.preItemSelect1.Name = "preItemSelect1";
            this.preItemSelect1.Size = new System.Drawing.Size(322, 13);
            this.preItemSelect1.TabIndex = 16;
            this.preItemSelect1.Text = "Selectează un articol din categoria \"Articole\" înainte de a continua";
            // 
            // preItemSelect_pan
            // 
            this.preItemSelect_pan.BackColor = System.Drawing.Color.White;
            this.preItemSelect_pan.Controls.Add(this.preItemSelect1);
            this.preItemSelect_pan.Controls.Add(this.preItemSelect2);
            this.preItemSelect_pan.Location = new System.Drawing.Point(349, 199);
            this.preItemSelect_pan.Name = "preItemSelect_pan";
            this.preItemSelect_pan.Size = new System.Drawing.Size(387, 58);
            this.preItemSelect_pan.TabIndex = 18;
            // 
            // preItemSelect2
            // 
            this.preItemSelect2.AutoSize = true;
            this.preItemSelect2.Location = new System.Drawing.Point(12, 27);
            this.preItemSelect2.Name = "preItemSelect2";
            this.preItemSelect2.Size = new System.Drawing.Size(353, 13);
            this.preItemSelect2.TabIndex = 17;
            this.preItemSelect2.Text = "Dacă nu sunt articole de selectat, creează unul folosind categoria \"Fișier\"";
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
            this.tableIndexNo.Location = new System.Drawing.Point(7, 11);
            this.tableIndexNo.Name = "tableIndexNo";
            this.tableIndexNo.Size = new System.Drawing.Size(18, 13);
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
            this.clientListHeader_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.65919F));
            this.clientListHeader_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.60987F));
            this.clientListHeader_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.34783F));
            this.clientListHeader_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.86957F));
            this.clientListHeader_tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.6087F));
            this.clientListHeader_tlp.Controls.Add(this.tableClientBudget, 6, 0);
            this.clientListHeader_tlp.Controls.Add(this.tableClientBidAmount, 5, 0);
            this.clientListHeader_tlp.Controls.Add(this.tableClientLastName, 4, 0);
            this.clientListHeader_tlp.Controls.Add(this.tableClientFirstName, 3, 0);
            this.clientListHeader_tlp.Controls.Add(this.tableClientID, 1, 0);
            this.clientListHeader_tlp.Controls.Add(this.tableIndexNo, 0, 0);
            this.clientListHeader_tlp.Controls.Add(this.tableAuctionID, 2, 0);
            this.clientListHeader_tlp.Location = new System.Drawing.Point(304, 24);
            this.clientListHeader_tlp.Name = "clientListHeader_tlp";
            this.clientListHeader_tlp.RowCount = 1;
            this.clientListHeader_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.clientListHeader_tlp.Size = new System.Drawing.Size(460, 36);
            this.clientListHeader_tlp.TabIndex = 19;
            // 
            // tableClientBudget
            // 
            this.tableClientBudget.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableClientBudget.ForeColor = System.Drawing.SystemColors.Control;
            this.tableClientBudget.Location = new System.Drawing.Point(389, 5);
            this.tableClientBudget.Name = "tableClientBudget";
            this.tableClientBudget.Size = new System.Drawing.Size(56, 26);
            this.tableClientBudget.TabIndex = 25;
            this.tableClientBudget.Text = "Sumă\r\ndisponibilă";
            this.tableClientBudget.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableClientBidAmount
            // 
            this.tableClientBidAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableClientBidAmount.ForeColor = System.Drawing.SystemColors.Control;
            this.tableClientBidAmount.Location = new System.Drawing.Point(334, 5);
            this.tableClientBidAmount.Name = "tableClientBidAmount";
            this.tableClientBidAmount.Size = new System.Drawing.Size(31, 26);
            this.tableClientBidAmount.TabIndex = 24;
            this.tableClientBidAmount.Text = "Preț licitat";
            this.tableClientBidAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableClientLastName
            // 
            this.tableClientLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableClientLastName.ForeColor = System.Drawing.SystemColors.Control;
            this.tableClientLastName.Location = new System.Drawing.Point(230, 11);
            this.tableClientLastName.Name = "tableClientLastName";
            this.tableClientLastName.Size = new System.Drawing.Size(77, 13);
            this.tableClientLastName.TabIndex = 23;
            this.tableClientLastName.Text = "Prenume client";
            this.tableClientLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableClientFirstName
            // 
            this.tableClientFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableClientFirstName.ForeColor = System.Drawing.SystemColors.Control;
            this.tableClientFirstName.Location = new System.Drawing.Point(139, 11);
            this.tableClientFirstName.Name = "tableClientFirstName";
            this.tableClientFirstName.Size = new System.Drawing.Size(63, 13);
            this.tableClientFirstName.TabIndex = 22;
            this.tableClientFirstName.Text = "Nume client";
            this.tableClientFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableClientID
            // 
            this.tableClientID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableClientID.ForeColor = System.Drawing.SystemColors.Control;
            this.tableClientID.Location = new System.Drawing.Point(37, 5);
            this.tableClientID.Name = "tableClientID";
            this.tableClientID.Size = new System.Drawing.Size(32, 26);
            this.tableClientID.TabIndex = 20;
            this.tableClientID.Text = "ID\r\nclient";
            this.tableClientID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableAuctionID
            // 
            this.tableAuctionID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableAuctionID.ForeColor = System.Drawing.SystemColors.Control;
            this.tableAuctionID.Location = new System.Drawing.Point(82, 5);
            this.tableAuctionID.Name = "tableAuctionID";
            this.tableAuctionID.Size = new System.Drawing.Size(39, 26);
            this.tableAuctionID.TabIndex = 21;
            this.tableAuctionID.Text = "Număr\r\nlicitație";
            this.tableAuctionID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.searchIconBG_pan.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.clientElement_ctx.Size = new System.Drawing.Size(156, 82);
            // 
            // cli_ctx_remove
            // 
            this.cli_ctx_remove.Image = global::Auction_Tool.Properties.Resources.remove;
            this.cli_ctx_remove.Name = "cli_ctx_remove";
            this.cli_ctx_remove.Size = new System.Drawing.Size(155, 26);
            this.cli_ctx_remove.Text = "Elimină";
            this.cli_ctx_remove.Click += new System.EventHandler(this.contextRemoveItem_Click);
            // 
            // cli_ctx_edit
            // 
            this.cli_ctx_edit.Image = global::Auction_Tool.Properties.Resources.edit;
            this.cli_ctx_edit.Name = "cli_ctx_edit";
            this.cli_ctx_edit.Size = new System.Drawing.Size(155, 26);
            this.cli_ctx_edit.Text = "Editează";
            this.cli_ctx_edit.Click += new System.EventHandler(this.contextEditItem_Click);
            // 
            // cli_ctx_bet
            // 
            this.cli_ctx_bet.Name = "cli_ctx_bet";
            this.cli_ctx_bet.Size = new System.Drawing.Size(155, 26);
            this.cli_ctx_bet.Text = "Propune sumă";
            this.cli_ctx_bet.Click += new System.EventHandler(this.contextBet_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(764, 450);
            this.Controls.Add(this.itemInfo_pan);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.preItemSelect_pan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Licitații (.NET Form Designer App)";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.generalInfo_pan.ResumeLayout(false);
            this.generalInfo_pan.PerformLayout();
            this.itemInfo_pan.ResumeLayout(false);
            this.auctionInfo_pan.ResumeLayout(false);
            this.auctionInfo_pan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemImage_pb)).EndInit();
            this.preItemSelect_pan.ResumeLayout(false);
            this.preItemSelect_pan.PerformLayout();
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
        public System.Windows.Forms.ToolStripMenuItem itemTB_load;
        private ToolTip toolTip1;
        public Panel clientList_panel;
        private Label tableIndexNo;
        public TableLayoutPanel clientListHeader_tlp;
        private Label tableClientID;
        private Label tableAuctionID;
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
    }
}

