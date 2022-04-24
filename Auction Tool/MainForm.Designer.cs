
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Proiect_PAW {
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
            this.clientElement1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip.SuspendLayout();
            this.infoGen_pan.SuspendLayout();
            this.infoArticol_pan.SuspendLayout();
            this.infoLic_pan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoArticol_pb)).BeginInit();
            this.preItemSelect_pan.SuspendLayout();
            this.clientList_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Black;
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolbar,
            this.itemToolbar});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // editToolbar
            // 
            this.editToolbar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editTB_create,
            this.editTB_remove});
            this.editToolbar.ForeColor = System.Drawing.Color.White;
            this.editToolbar.Name = "editToolbar";
            this.editToolbar.Size = new System.Drawing.Size(55, 20);
            this.editToolbar.Text = "Editare";
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
            this.editTB_create.Image = global::Proiect_PAW.Properties.Resources.add;
            this.editTB_create.Name = "editTB_create";
            this.editTB_create.Size = new System.Drawing.Size(115, 22);
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
            this.editTB_create_client.Image = global::Proiect_PAW.Properties.Resources.bidder;
            this.editTB_create_client.Name = "editTB_create_client";
            this.editTB_create_client.Size = new System.Drawing.Size(109, 22);
            this.editTB_create_client.Text = "Client";
            // 
            // editTB_remove
            // 
            this.editTB_remove.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editTB_remove_item,
            this.editTB_remove_client});
            this.editTB_remove.Image = global::Proiect_PAW.Properties.Resources.remove;
            this.editTB_remove.Name = "editTB_remove";
            this.editTB_remove.Size = new System.Drawing.Size(115, 22);
            this.editTB_remove.Text = "Elimină";
            // 
            // editTB_remove_item
            // 
            this.editTB_remove_item.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editTB_remove_item_all,
            this.editTB_remove_item_ID});
            this.editTB_remove_item.Image = ((System.Drawing.Image)(resources.GetObject("editTB_remove_item.Image")));
            this.editTB_remove_item.Name = "editTB_remove_item";
            this.editTB_remove_item.Size = new System.Drawing.Size(109, 22);
            this.editTB_remove_item.Text = "Articol";
            // 
            // editTB_remove_item_all
            // 
            this.editTB_remove_item_all.Name = "editTB_remove_item_all";
            this.editTB_remove_item_all.Size = new System.Drawing.Size(153, 22);
            this.editTB_remove_item_all.Text = "Toate articolele";
            // 
            // editTB_remove_item_ID
            // 
            this.editTB_remove_item_ID.Name = "editTB_remove_item_ID";
            this.editTB_remove_item_ID.Size = new System.Drawing.Size(153, 22);
            this.editTB_remove_item_ID.Text = "După ID";
            // 
            // editTB_remove_client
            // 
            this.editTB_remove_client.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editTB_remove_client_all,
            this.editTB_remove_client_ID});
            this.editTB_remove_client.Image = global::Proiect_PAW.Properties.Resources.bidder;
            this.editTB_remove_client.Name = "editTB_remove_client";
            this.editTB_remove_client.Size = new System.Drawing.Size(109, 22);
            this.editTB_remove_client.Text = "Client";
            // 
            // editTB_remove_client_all
            // 
            this.editTB_remove_client_all.Name = "editTB_remove_client_all";
            this.editTB_remove_client_all.Size = new System.Drawing.Size(131, 22);
            this.editTB_remove_client_all.Text = "Toți clienții";
            // 
            // editTB_remove_client_ID
            // 
            this.editTB_remove_client_ID.Name = "editTB_remove_client_ID";
            this.editTB_remove_client_ID.Size = new System.Drawing.Size(131, 22);
            this.editTB_remove_client_ID.Text = "După ID";
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
            this.fotoArticol_pb.Image = global::Proiect_PAW.Properties.Resources.no_image;
            this.fotoArticol_pb.InitialImage = global::Proiect_PAW.Properties.Resources.no_image;
            this.fotoArticol_pb.Location = new System.Drawing.Point(48, 18);
            this.fotoArticol_pb.Name = "fotoArticol_pb";
            this.fotoArticol_pb.Size = new System.Drawing.Size(203, 210);
            this.fotoArticol_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoArticol_pb.TabIndex = 1;
            this.fotoArticol_pb.TabStop = false;
            // 
            // clientSearch_tb
            // 
            this.clientSearch_tb.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.clientSearch_tb.Location = new System.Drawing.Point(304, 24);
            this.clientSearch_tb.Name = "clientSearch_tb";
            this.clientSearch_tb.Size = new System.Drawing.Size(498, 20);
            this.clientSearch_tb.TabIndex = 15;
            this.clientSearch_tb.Text = "Caută ID client..";
            this.clientSearch_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clientSearch_tb.Leave += new System.EventHandler(this.textBox1_Leave);
            this.clientSearch_tb.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseDoubleClick);
            this.clientSearch_tb.MouseEnter += new System.EventHandler(this.textBox1_MouseEnter);
            this.clientSearch_tb.MouseLeave += new System.EventHandler(this.textBox1_MouseLeave);
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
            this.preItemSelect_pan.Controls.Add(this.preItemSelect1);
            this.preItemSelect_pan.Controls.Add(this.preItemSelect2);
            this.preItemSelect_pan.Location = new System.Drawing.Point(362, 213);
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
            this.clientList_panel.Controls.Add(this.clientElement1);
            this.clientList_panel.Location = new System.Drawing.Point(304, 43);
            this.clientList_panel.Name = "clientList_panel";
            this.clientList_panel.Size = new System.Drawing.Size(498, 411);
            this.clientList_panel.TabIndex = 19;
            // 
            // clientElement1
            // 
            this.clientElement1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.clientElement1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.clientElement1.ColumnCount = 2;
            this.clientElement1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.2249F));
            this.clientElement1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.7751F));
            this.clientElement1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clientElement1.Dock = System.Windows.Forms.DockStyle.Top;
            this.clientElement1.Location = new System.Drawing.Point(0, 0);
            this.clientElement1.Name = "clientElement1";
            this.clientElement1.RowCount = 1;
            this.clientElement1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.clientElement1.Size = new System.Drawing.Size(498, 42);
            this.clientElement1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.preItemSelect_pan);
            this.Controls.Add(this.clientSearch_tb);
            this.Controls.Add(this.infoArticol_pan);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Licitații (.NET Form Designer App)";
            this.Load += new System.EventHandler(this.Form1_Load);
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
            this.clientList_panel.ResumeLayout(false);
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
        private System.Windows.Forms.Label idArticol_out;
        public System.Windows.Forms.ToolStripMenuItem itemTB_load;
        #endregion

        private void cereWorkPath() {
            FolderBrowserDialog dial = new FolderBrowserDialog();
            dial.Description = "Înainte de a folosi aplicația, selectează locația unde vrei să salvezi datele." +
                " Vei fi rugat să faci acest lucru de fiecare dată când deschizi aplicația!";

            DialogResult res = dial.ShowDialog();
            if (res == DialogResult.OK) {
                WorkPath = dial.SelectedPath;
            }
        }

        private void seteazaArticoleToolbar() {
            if (File.Exists($"{WorkPath}\\items.dat")) {
                List<Articol> articole = Articol.deserialize();

                if (articole.Count() > 0) {
                    for (int i = 0; i < articole.Count; i++) {
                        Articol articol = articole.ElementAt(i);
                        ToolStripMenuItem art = creeazaOptiuneArticol(i+1, articol);
                        itemTB_load.DropDownItems.Add(art);
                    }
                }

                Articol.Cache.Articole.AddRange(articole);
            }
        }

        public ToolStripMenuItem creeazaOptiuneArticol(int index, Articol articol) {
            ToolStripMenuItem art = new ToolStripMenuItem();
            art.Name = $"itemTB_item{index}";
            art.Text = $"{index}. {articol.Nume}";
            art.ForeColor = Color.Black;
            art.Size = new Size(180, 22);
            art.Image = global::Proiect_PAW.Properties.Resources.individual_load;
            art.Tag = articol;
            art.Click += new EventHandler(itemTB_itemn_Click);

            return art;
        }

        private void arataListaClienti() {
            if (!Controls.ContainsKey("clientList_panel")) {
                clientList_panel.SuspendLayout();
                Controls.Add(clientList_panel);
                clientList_panel.ResumeLayout(false);

                preItemSelect_pan.Visible = false;
            }
        }

        private void ascundeListaClienti() {
            if (Controls.ContainsKey("clientList_panel")) {
                clientList_panel.SuspendLayout();
                Controls.Remove(clientList_panel);
                clientList_panel.ResumeLayout(false);

                preItemSelect_pan.Visible = true;
            }
        }

        private ToolTip toolTip1;
        private Panel clientList_panel;
        private TableLayoutPanel clientElement1;
    }
}

