
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
            this.editToolbar = new System.Windows.Forms.ToolStripMenuItem();
            this.editTB_create = new System.Windows.Forms.ToolStripMenuItem();
            this.editTB_create_item = new System.Windows.Forms.ToolStripMenuItem();
            this.editTB_create_client = new System.Windows.Forms.ToolStripMenuItem();
            this.editTB_remove = new System.Windows.Forms.ToolStripMenuItem();
            this.editTB_remove_item = new System.Windows.Forms.ToolStripMenuItem();
            this.editTB_remove_item_all = new System.Windows.Forms.ToolStripMenuItem();
            this.editTB_remove_item_ID = new System.Windows.Forms.ToolStripMenuItem();
            this.editTB_remove_client = new System.Windows.Forms.ToolStripMenuItem();
            this.editTB_remove_client_all = new System.Windows.Forms.ToolStripMenuItem();
            this.editTB_remove_client_ID = new System.Windows.Forms.ToolStripMenuItem();
            this.editeazăToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemToolbar = new System.Windows.Forms.ToolStripMenuItem();
            this.itemTB_load = new System.Windows.Forms.ToolStripMenuItem();
            this.denumArticol = new System.Windows.Forms.Label();
            this.denumArticol_out = new System.Windows.Forms.Label();
            this.pretBaza = new System.Windows.Forms.Label();
            this.pretBaza_out = new System.Windows.Forms.Label();
            this.pretCurent = new System.Windows.Forms.Label();
            this.pretCurent_out = new System.Windows.Forms.Label();
            this.nrClientTop = new System.Windows.Forms.Label();
            this.nrClientTop_out = new System.Windows.Forms.Label();
            this.infoGen_pan = new System.Windows.Forms.Panel();
            this.idArticol = new System.Windows.Forms.Label();
            this.idArticol_out = new System.Windows.Forms.Label();
            this.infoGen_title = new System.Windows.Forms.Label();
            this.descArticol_link = new System.Windows.Forms.Label();
            this.descArticol = new System.Windows.Forms.Label();
            this.infoArticol_pan = new System.Windows.Forms.Panel();
            this.infoLic_pan = new System.Windows.Forms.Panel();
            this.infoLicitatie_title = new System.Windows.Forms.Label();
            this.fotoArticol_pb = new System.Windows.Forms.PictureBox();
            this.clientSearch_tb = new System.Windows.Forms.TextBox();
            this.preItemSelect1 = new System.Windows.Forms.Label();
            this.preItemSelect_pan = new System.Windows.Forms.Panel();
            this.preItemSelect2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.clientList_panel = new System.Windows.Forms.Panel();
            this.nrOrdineTable = new System.Windows.Forms.Label();
            this.clientListHeader_tlp = new System.Windows.Forms.TableLayoutPanel();
            this.sumaDispTable = new System.Windows.Forms.Label();
            this.pretLicTable = new System.Windows.Forms.Label();
            this.prenumeClientTable = new System.Windows.Forms.Label();
            this.numeClientTable = new System.Windows.Forms.Label();
            this.idClientTable = new System.Windows.Forms.Label();
            this.nrLicitatieTable = new System.Windows.Forms.Label();
            this.clientSearch_tlp = new System.Windows.Forms.TableLayoutPanel();
            this.searchIconBG_pan = new System.Windows.Forms.Panel();
            this.searchIcon_pb = new System.Windows.Forms.PictureBox();
            this.clientElement_context = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stergereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.infoGen_pan.SuspendLayout();
            this.infoArticol_pan.SuspendLayout();
            this.infoLic_pan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoArticol_pb)).BeginInit();
            this.preItemSelect_pan.SuspendLayout();
            this.clientListHeader_tlp.SuspendLayout();
            this.clientSearch_tlp.SuspendLayout();
            this.searchIconBG_pan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon_pb)).BeginInit();
            this.clientElement_context.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Black;
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolbar,
            this.itemToolbar});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(764, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // editToolbar
            // 
            this.editToolbar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editTB_create,
            this.editTB_remove,
            this.editeazăToolStripMenuItem});
            this.editToolbar.ForeColor = System.Drawing.Color.White;
            this.editToolbar.Name = "editToolbar";
            this.editToolbar.Size = new System.Drawing.Size(46, 20);
            this.editToolbar.Text = "Fișier";
            this.editToolbar.DropDownClosed += new System.EventHandler(this.testToolStripMenuItem_DropDownClosed);
            this.editToolbar.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            this.editToolbar.MouseLeave += new System.EventHandler(this.testToolStripMenuItem_MouseLeave);
            this.editToolbar.MouseHover += new System.EventHandler(this.testToolStripMenuItem_MouseHover);
            // 
            // editTB_create
            // 
            this.editTB_create.BackColor = System.Drawing.Color.White;
            this.editTB_create.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editTB_create_item,
            this.editTB_create_client});
            this.editTB_create.ForeColor = System.Drawing.Color.Black;
            this.editTB_create.Image = global::Auction_Tool.Properties.Resources.add;
            this.editTB_create.Name = "editTB_create";
            this.editTB_create.Size = new System.Drawing.Size(184, 26);
            this.editTB_create.Text = "Creează";
            // 
            // editTB_create_item
            // 
            this.editTB_create_item.Image = ((System.Drawing.Image)(resources.GetObject("editTB_create_item.Image")));
            this.editTB_create_item.Name = "editTB_create_item";
            this.editTB_create_item.Size = new System.Drawing.Size(109, 22);
            this.editTB_create_item.Text = "Articol";
            this.editTB_create_item.Click += new System.EventHandler(this.itemToolStripMenuItem_Click_1);
            // 
            // editTB_create_client
            // 
            this.editTB_create_client.Image = global::Auction_Tool.Properties.Resources.bidder;
            this.editTB_create_client.Name = "editTB_create_client";
            this.editTB_create_client.Size = new System.Drawing.Size(109, 22);
            this.editTB_create_client.Text = "Client";
            this.editTB_create_client.Click += new System.EventHandler(this.editTB_create_client_Click);
            // 
            // editTB_remove
            // 
            this.editTB_remove.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editTB_remove_item,
            this.editTB_remove_client});
            this.editTB_remove.Image = global::Auction_Tool.Properties.Resources.remove;
            this.editTB_remove.Name = "editTB_remove";
            this.editTB_remove.Size = new System.Drawing.Size(184, 26);
            this.editTB_remove.Text = "Elimină";
            // 
            // editTB_remove_item
            // 
            this.editTB_remove_item.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editTB_remove_item_all,
            this.editTB_remove_item_ID});
            this.editTB_remove_item.Image = ((System.Drawing.Image)(resources.GetObject("editTB_remove_item.Image")));
            this.editTB_remove_item.Name = "editTB_remove_item";
            this.editTB_remove_item.Size = new System.Drawing.Size(184, 26);
            this.editTB_remove_item.Text = "Articol";
            // 
            // editTB_remove_item_all
            // 
            this.editTB_remove_item_all.Image = global::Auction_Tool.Properties.Resources.all;
            this.editTB_remove_item_all.Name = "editTB_remove_item_all";
            this.editTB_remove_item_all.Size = new System.Drawing.Size(184, 26);
            this.editTB_remove_item_all.Text = "Toate articolele";
            this.editTB_remove_item_all.Click += new System.EventHandler(this.editTB_remove_item_all_Click);
            // 
            // editTB_remove_item_ID
            // 
            this.editTB_remove_item_ID.Image = global::Auction_Tool.Properties.Resources.by_id;
            this.editTB_remove_item_ID.Name = "editTB_remove_item_ID";
            this.editTB_remove_item_ID.Size = new System.Drawing.Size(184, 26);
            this.editTB_remove_item_ID.Text = "După ID";
            this.editTB_remove_item_ID.Click += new System.EventHandler(this.editTB_remove_item_ID_Click);
            // 
            // editTB_remove_client
            // 
            this.editTB_remove_client.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editTB_remove_client_all,
            this.editTB_remove_client_ID});
            this.editTB_remove_client.Image = global::Auction_Tool.Properties.Resources.bidder;
            this.editTB_remove_client.Name = "editTB_remove_client";
            this.editTB_remove_client.Size = new System.Drawing.Size(184, 26);
            this.editTB_remove_client.Text = "Client";
            // 
            // editTB_remove_client_all
            // 
            this.editTB_remove_client_all.Image = global::Auction_Tool.Properties.Resources.all;
            this.editTB_remove_client_all.Name = "editTB_remove_client_all";
            this.editTB_remove_client_all.Size = new System.Drawing.Size(184, 26);
            this.editTB_remove_client_all.Text = "Toți clienții";
            this.editTB_remove_client_all.Click += new System.EventHandler(this.editTB_remove_client_all_Click);
            // 
            // editTB_remove_client_ID
            // 
            this.editTB_remove_client_ID.Image = global::Auction_Tool.Properties.Resources.by_id;
            this.editTB_remove_client_ID.Name = "editTB_remove_client_ID";
            this.editTB_remove_client_ID.Size = new System.Drawing.Size(184, 26);
            this.editTB_remove_client_ID.Text = "După ID";
            this.editTB_remove_client_ID.Click += new System.EventHandler(this.editTB_remove_client_ID_Click);
            // 
            // editeazăToolStripMenuItem
            // 
            this.editeazăToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articolToolStripMenuItem,
            this.clientToolStripMenuItem});
            this.editeazăToolStripMenuItem.Image = global::Auction_Tool.Properties.Resources.edit;
            this.editeazăToolStripMenuItem.Name = "editeazăToolStripMenuItem";
            this.editeazăToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.editeazăToolStripMenuItem.Text = "Editează";
            // 
            // articolToolStripMenuItem
            // 
            this.articolToolStripMenuItem.Image = global::Auction_Tool.Properties.Resources.item;
            this.articolToolStripMenuItem.Name = "articolToolStripMenuItem";
            this.articolToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.articolToolStripMenuItem.Text = "Articol";
            this.articolToolStripMenuItem.Click += new System.EventHandler(this.articolToolStripMenuItem_Click);
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.Image = global::Auction_Tool.Properties.Resources.bidder;
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.clientToolStripMenuItem.Text = "Client";
            // 
            // itemToolbar
            // 
            this.itemToolbar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemTB_load});
            this.itemToolbar.ForeColor = System.Drawing.Color.White;
            this.itemToolbar.Name = "itemToolbar";
            this.itemToolbar.Size = new System.Drawing.Size(60, 20);
            this.itemToolbar.Text = "Articole";
            this.itemToolbar.DropDownClosed += new System.EventHandler(this.itemToolStripMenuItem_DropDownClosed);
            this.itemToolbar.Click += new System.EventHandler(this.itemToolStripMenuItem_Click);
            this.itemToolbar.MouseLeave += new System.EventHandler(this.itemToolStripMenuItem_MouseLeave);
            this.itemToolbar.MouseHover += new System.EventHandler(this.itemToolStripMenuItem_MouseHover);
            // 
            // itemTB_load
            // 
            this.itemTB_load.Image = ((System.Drawing.Image)(resources.GetObject("itemTB_load.Image")));
            this.itemTB_load.Name = "itemTB_load";
            this.itemTB_load.Size = new System.Drawing.Size(112, 22);
            this.itemTB_load.Text = "Încarcă";
            // 
            // denumArticol
            // 
            this.denumArticol.AutoSize = true;
            this.denumArticol.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.denumArticol.Location = new System.Drawing.Point(3, 39);
            this.denumArticol.Name = "denumArticol";
            this.denumArticol.Size = new System.Drawing.Size(93, 14);
            this.denumArticol.TabIndex = 2;
            this.denumArticol.Text = "Denumire articol:";
            // 
            // denumArticol_out
            // 
            this.denumArticol_out.AutoSize = true;
            this.denumArticol_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.denumArticol_out.Location = new System.Drawing.Point(95, 39);
            this.denumArticol_out.Name = "denumArticol_out";
            this.denumArticol_out.Size = new System.Drawing.Size(59, 13);
            this.denumArticol_out.TabIndex = 3;
            this.denumArticol_out.Text = "Indisponibil";
            // 
            // pretBaza
            // 
            this.pretBaza.AutoSize = true;
            this.pretBaza.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pretBaza.Location = new System.Drawing.Point(3, 22);
            this.pretBaza.Name = "pretBaza";
            this.pretBaza.Size = new System.Drawing.Size(71, 14);
            this.pretBaza.TabIndex = 6;
            this.pretBaza.Text = "Preț de bază:";
            // 
            // pretBaza_out
            // 
            this.pretBaza_out.AutoSize = true;
            this.pretBaza_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pretBaza_out.Location = new System.Drawing.Point(72, 22);
            this.pretBaza_out.Name = "pretBaza_out";
            this.pretBaza_out.Size = new System.Drawing.Size(59, 13);
            this.pretBaza_out.TabIndex = 7;
            this.pretBaza_out.Text = "Indisponibil";
            // 
            // pretCurent
            // 
            this.pretCurent.AutoSize = true;
            this.pretCurent.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pretCurent.Location = new System.Drawing.Point(3, 39);
            this.pretCurent.Name = "pretCurent";
            this.pretCurent.Size = new System.Drawing.Size(100, 14);
            this.pretCurent.TabIndex = 8;
            this.pretCurent.Text = "Preț propus curent:";
            // 
            // pretCurent_out
            // 
            this.pretCurent_out.AutoSize = true;
            this.pretCurent_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pretCurent_out.Location = new System.Drawing.Point(101, 39);
            this.pretCurent_out.Name = "pretCurent_out";
            this.pretCurent_out.Size = new System.Drawing.Size(59, 13);
            this.pretCurent_out.TabIndex = 9;
            this.pretCurent_out.Text = "Indisponibil";
            // 
            // nrClientTop
            // 
            this.nrClientTop.AutoSize = true;
            this.nrClientTop.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nrClientTop.Location = new System.Drawing.Point(3, 56);
            this.nrClientTop.Name = "nrClientTop";
            this.nrClientTop.Size = new System.Drawing.Size(105, 14);
            this.nrClientTop.TabIndex = 10;
            this.nrClientTop.Text = "Număr client în top:";
            // 
            // nrClientTop_out
            // 
            this.nrClientTop_out.AutoSize = true;
            this.nrClientTop_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nrClientTop_out.Location = new System.Drawing.Point(106, 56);
            this.nrClientTop_out.Name = "nrClientTop_out";
            this.nrClientTop_out.Size = new System.Drawing.Size(59, 13);
            this.nrClientTop_out.TabIndex = 11;
            this.nrClientTop_out.Text = "Indisponibil";
            // 
            // infoGen_pan
            // 
            this.infoGen_pan.Controls.Add(this.idArticol);
            this.infoGen_pan.Controls.Add(this.idArticol_out);
            this.infoGen_pan.Controls.Add(this.infoGen_title);
            this.infoGen_pan.Controls.Add(this.descArticol_link);
            this.infoGen_pan.Controls.Add(this.descArticol);
            this.infoGen_pan.Controls.Add(this.denumArticol);
            this.infoGen_pan.Controls.Add(this.denumArticol_out);
            this.infoGen_pan.Location = new System.Drawing.Point(34, 238);
            this.infoGen_pan.Name = "infoGen_pan";
            this.infoGen_pan.Size = new System.Drawing.Size(229, 86);
            this.infoGen_pan.TabIndex = 13;
            // 
            // idArticol
            // 
            this.idArticol.AutoSize = true;
            this.idArticol.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.idArticol.Location = new System.Drawing.Point(3, 23);
            this.idArticol.Name = "idArticol";
            this.idArticol.Size = new System.Drawing.Size(55, 14);
            this.idArticol.TabIndex = 15;
            this.idArticol.Text = "ID articol:";
            // 
            // idArticol_out
            // 
            this.idArticol_out.AutoSize = true;
            this.idArticol_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idArticol_out.Location = new System.Drawing.Point(55, 23);
            this.idArticol_out.Name = "idArticol_out";
            this.idArticol_out.Size = new System.Drawing.Size(59, 13);
            this.idArticol_out.TabIndex = 16;
            this.idArticol_out.Text = "Indisponibil";
            // 
            // infoGen_title
            // 
            this.infoGen_title.AutoSize = true;
            this.infoGen_title.Font = new System.Drawing.Font("Calibri", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoGen_title.Location = new System.Drawing.Point(3, 2);
            this.infoGen_title.Name = "infoGen_title";
            this.infoGen_title.Size = new System.Drawing.Size(120, 17);
            this.infoGen_title.TabIndex = 14;
            this.infoGen_title.Text = "Informații generale";
            // 
            // descArticol_link
            // 
            this.descArticol_link.AutoSize = true;
            this.descArticol_link.Cursor = System.Windows.Forms.Cursors.Hand;
            this.descArticol_link.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descArticol_link.ForeColor = System.Drawing.Color.DodgerBlue;
            this.descArticol_link.Location = new System.Drawing.Point(92, 56);
            this.descArticol_link.Name = "descArticol_link";
            this.descArticol_link.Size = new System.Drawing.Size(57, 13);
            this.descArticol_link.TabIndex = 13;
            this.descArticol_link.Text = "Vizualizare";
            this.descArticol_link.Click += new System.EventHandler(this.descArticol_link_Click);
            // 
            // descArticol
            // 
            this.descArticol.AutoSize = true;
            this.descArticol.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.descArticol.Location = new System.Drawing.Point(3, 56);
            this.descArticol.Name = "descArticol";
            this.descArticol.Size = new System.Drawing.Size(91, 14);
            this.descArticol.TabIndex = 12;
            this.descArticol.Text = "Descriere articol:";
            // 
            // infoArticol_pan
            // 
            this.infoArticol_pan.BackColor = System.Drawing.Color.LightGray;
            this.infoArticol_pan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoArticol_pan.Controls.Add(this.infoLic_pan);
            this.infoArticol_pan.Controls.Add(this.fotoArticol_pb);
            this.infoArticol_pan.Controls.Add(this.infoGen_pan);
            this.infoArticol_pan.Location = new System.Drawing.Point(0, 24);
            this.infoArticol_pan.Name = "infoArticol_pan";
            this.infoArticol_pan.Size = new System.Drawing.Size(305, 430);
            this.infoArticol_pan.TabIndex = 14;
            // 
            // infoLic_pan
            // 
            this.infoLic_pan.Controls.Add(this.infoLicitatie_title);
            this.infoLic_pan.Controls.Add(this.pretBaza);
            this.infoLic_pan.Controls.Add(this.pretCurent);
            this.infoLic_pan.Controls.Add(this.nrClientTop);
            this.infoLic_pan.Controls.Add(this.pretBaza_out);
            this.infoLic_pan.Controls.Add(this.pretCurent_out);
            this.infoLic_pan.Controls.Add(this.nrClientTop_out);
            this.infoLic_pan.Location = new System.Drawing.Point(34, 327);
            this.infoLic_pan.Name = "infoLic_pan";
            this.infoLic_pan.Size = new System.Drawing.Size(229, 83);
            this.infoLic_pan.TabIndex = 14;
            // 
            // infoLicitatie_title
            // 
            this.infoLicitatie_title.AutoSize = true;
            this.infoLicitatie_title.Font = new System.Drawing.Font("Calibri", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLicitatie_title.Location = new System.Drawing.Point(3, 5);
            this.infoLicitatie_title.Name = "infoLicitatie_title";
            this.infoLicitatie_title.Size = new System.Drawing.Size(111, 17);
            this.infoLicitatie_title.TabIndex = 15;
            this.infoLicitatie_title.Text = "Informații licitație";
            // 
            // fotoArticol_pb
            // 
            this.fotoArticol_pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fotoArticol_pb.Image = global::Auction_Tool.Properties.Resources.no_image;
            this.fotoArticol_pb.Location = new System.Drawing.Point(48, 18);
            this.fotoArticol_pb.Name = "fotoArticol_pb";
            this.fotoArticol_pb.Size = new System.Drawing.Size(203, 210);
            this.fotoArticol_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoArticol_pb.TabIndex = 1;
            this.fotoArticol_pb.TabStop = false;
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
            this.preItemSelect2.Size = new System.Drawing.Size(362, 13);
            this.preItemSelect2.TabIndex = 17;
            this.preItemSelect2.Text = "Dacă nu sunt articole de selectat, creează unul folosind categoria \"Editare\"";
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
            // nrOrdineTable
            // 
            this.nrOrdineTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nrOrdineTable.ForeColor = System.Drawing.SystemColors.Control;
            this.nrOrdineTable.Location = new System.Drawing.Point(7, 11);
            this.nrOrdineTable.Name = "nrOrdineTable";
            this.nrOrdineTable.Size = new System.Drawing.Size(18, 13);
            this.nrOrdineTable.TabIndex = 0;
            this.nrOrdineTable.Text = "Nr";
            this.nrOrdineTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.clientListHeader_tlp.Controls.Add(this.sumaDispTable, 6, 0);
            this.clientListHeader_tlp.Controls.Add(this.pretLicTable, 5, 0);
            this.clientListHeader_tlp.Controls.Add(this.prenumeClientTable, 4, 0);
            this.clientListHeader_tlp.Controls.Add(this.numeClientTable, 3, 0);
            this.clientListHeader_tlp.Controls.Add(this.idClientTable, 1, 0);
            this.clientListHeader_tlp.Controls.Add(this.nrOrdineTable, 0, 0);
            this.clientListHeader_tlp.Controls.Add(this.nrLicitatieTable, 2, 0);
            this.clientListHeader_tlp.Location = new System.Drawing.Point(304, 24);
            this.clientListHeader_tlp.Name = "clientListHeader_tlp";
            this.clientListHeader_tlp.RowCount = 1;
            this.clientListHeader_tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.clientListHeader_tlp.Size = new System.Drawing.Size(460, 36);
            this.clientListHeader_tlp.TabIndex = 19;
            // 
            // sumaDispTable
            // 
            this.sumaDispTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sumaDispTable.ForeColor = System.Drawing.SystemColors.Control;
            this.sumaDispTable.Location = new System.Drawing.Point(389, 5);
            this.sumaDispTable.Name = "sumaDispTable";
            this.sumaDispTable.Size = new System.Drawing.Size(56, 26);
            this.sumaDispTable.TabIndex = 25;
            this.sumaDispTable.Text = "Sumă\r\ndisponibilă";
            this.sumaDispTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pretLicTable
            // 
            this.pretLicTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pretLicTable.ForeColor = System.Drawing.SystemColors.Control;
            this.pretLicTable.Location = new System.Drawing.Point(334, 5);
            this.pretLicTable.Name = "pretLicTable";
            this.pretLicTable.Size = new System.Drawing.Size(31, 26);
            this.pretLicTable.TabIndex = 24;
            this.pretLicTable.Text = "Preț licitat";
            this.pretLicTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prenumeClientTable
            // 
            this.prenumeClientTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prenumeClientTable.ForeColor = System.Drawing.SystemColors.Control;
            this.prenumeClientTable.Location = new System.Drawing.Point(230, 11);
            this.prenumeClientTable.Name = "prenumeClientTable";
            this.prenumeClientTable.Size = new System.Drawing.Size(77, 13);
            this.prenumeClientTable.TabIndex = 23;
            this.prenumeClientTable.Text = "Prenume client";
            this.prenumeClientTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numeClientTable
            // 
            this.numeClientTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numeClientTable.ForeColor = System.Drawing.SystemColors.Control;
            this.numeClientTable.Location = new System.Drawing.Point(139, 11);
            this.numeClientTable.Name = "numeClientTable";
            this.numeClientTable.Size = new System.Drawing.Size(63, 13);
            this.numeClientTable.TabIndex = 22;
            this.numeClientTable.Text = "Nume client";
            this.numeClientTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // idClientTable
            // 
            this.idClientTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idClientTable.ForeColor = System.Drawing.SystemColors.Control;
            this.idClientTable.Location = new System.Drawing.Point(37, 5);
            this.idClientTable.Name = "idClientTable";
            this.idClientTable.Size = new System.Drawing.Size(32, 26);
            this.idClientTable.TabIndex = 20;
            this.idClientTable.Text = "ID\r\nclient";
            this.idClientTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nrLicitatieTable
            // 
            this.nrLicitatieTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nrLicitatieTable.ForeColor = System.Drawing.SystemColors.Control;
            this.nrLicitatieTable.Location = new System.Drawing.Point(82, 5);
            this.nrLicitatieTable.Name = "nrLicitatieTable";
            this.nrLicitatieTable.Size = new System.Drawing.Size(39, 26);
            this.nrLicitatieTable.TabIndex = 21;
            this.nrLicitatieTable.Text = "Număr\r\nlicitație";
            this.nrLicitatieTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.searchIcon_pb.Location = new System.Drawing.Point(3, 3);
            this.searchIcon_pb.Margin = new System.Windows.Forms.Padding(0);
            this.searchIcon_pb.Name = "searchIcon_pb";
            this.searchIcon_pb.Padding = new System.Windows.Forms.Padding(3);
            this.searchIcon_pb.Size = new System.Drawing.Size(20, 20);
            this.searchIcon_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.searchIcon_pb.TabIndex = 19;
            this.searchIcon_pb.TabStop = false;
            // 
            // clientElement_context
            // 
            this.clientElement_context.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.clientElement_context.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stergereToolStripMenuItem,
            this.editareToolStripMenuItem});
            this.clientElement_context.Name = "clientElement_context";
            this.clientElement_context.Size = new System.Drawing.Size(114, 48);
            // 
            // stergereToolStripMenuItem
            // 
            this.stergereToolStripMenuItem.Name = "stergereToolStripMenuItem";
            this.stergereToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.stergereToolStripMenuItem.Text = "Elimină";
            this.stergereToolStripMenuItem.Click += new System.EventHandler(this.stergereToolStripMenuItem_Click);
            // 
            // editareToolStripMenuItem
            // 
            this.editareToolStripMenuItem.Name = "editareToolStripMenuItem";
            this.editareToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.editareToolStripMenuItem.Text = "Editare";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(764, 450);
            this.Controls.Add(this.infoArticol_pan);
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
            this.infoGen_pan.ResumeLayout(false);
            this.infoGen_pan.PerformLayout();
            this.infoArticol_pan.ResumeLayout(false);
            this.infoLic_pan.ResumeLayout(false);
            this.infoLic_pan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoArticol_pb)).EndInit();
            this.preItemSelect_pan.ResumeLayout(false);
            this.preItemSelect_pan.PerformLayout();
            this.clientListHeader_tlp.ResumeLayout(false);
            this.clientSearch_tlp.ResumeLayout(false);
            this.clientSearch_tlp.PerformLayout();
            this.searchIconBG_pan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon_pb)).EndInit();
            this.clientElement_context.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        #region declarari
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem editToolbar;
        private System.Windows.Forms.ToolStripMenuItem editTB_create;
        private System.Windows.Forms.ToolStripMenuItem editTB_create_item;
        private System.Windows.Forms.ToolStripMenuItem editTB_remove;
        private System.Windows.Forms.ToolStripMenuItem editTB_remove_item;
        private System.Windows.Forms.ToolStripMenuItem itemToolbar;
        private System.Windows.Forms.PictureBox fotoArticol_pb;
        private System.Windows.Forms.ToolStripMenuItem editTB_create_client;
        private System.Windows.Forms.ToolStripMenuItem editTB_remove_client;
        private System.Windows.Forms.Label denumArticol;
        private System.Windows.Forms.Label denumArticol_out;
        private System.Windows.Forms.Label pretBaza;
        private System.Windows.Forms.Label pretBaza_out;
        private System.Windows.Forms.Label pretCurent;
        private System.Windows.Forms.Label pretCurent_out;
        private System.Windows.Forms.Label nrClientTop;
        private System.Windows.Forms.Label nrClientTop_out;
        private System.Windows.Forms.Panel infoGen_pan;
        private System.Windows.Forms.Panel infoArticol_pan;
        private System.Windows.Forms.Label descArticol;
        private System.Windows.Forms.Label descArticol_link;
        private System.Windows.Forms.Label infoGen_title;
        private System.Windows.Forms.Panel infoLic_pan;
        private System.Windows.Forms.Label infoLicitatie_title;
        private System.Windows.Forms.TextBox clientSearch_tb;
        private System.Windows.Forms.Label preItemSelect1;
        private System.Windows.Forms.Panel preItemSelect_pan;
        private System.Windows.Forms.Label preItemSelect2;
        private System.Windows.Forms.ToolStripMenuItem editTB_remove_item_all;
        private System.Windows.Forms.ToolStripMenuItem editTB_remove_item_ID;
        private System.Windows.Forms.ToolStripMenuItem editTB_remove_client_all;
        private System.Windows.Forms.ToolStripMenuItem editTB_remove_client_ID;
        private System.Windows.Forms.Label idArticol;
        public System.Windows.Forms.Label idArticol_out;
        public System.Windows.Forms.ToolStripMenuItem itemTB_load;
        private ToolTip toolTip1;
        public Panel clientList_panel;
        private Label nrOrdineTable;
        public TableLayoutPanel clientListHeader_tlp;
        private Label idClientTable;
        private Label nrLicitatieTable;
        private Label numeClientTable;
        private Label prenumeClientTable;
        private Label pretLicTable;
        private Label sumaDispTable;
        private TableLayoutPanel clientSearch_tlp;
        private PictureBox searchIcon_pb;
        private Panel searchIconBG_pan;
        private ContextMenuStrip clientElement_context;
        private ToolStripMenuItem stergereToolStripMenuItem;
        private ToolStripMenuItem editareToolStripMenuItem;
        #endregion

        private ToolStripMenuItem editeazăToolStripMenuItem;
        private ToolStripMenuItem articolToolStripMenuItem;
        private ToolStripMenuItem clientToolStripMenuItem;
    }
}

