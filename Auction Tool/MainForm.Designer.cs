
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
            this.nrOrdineTable = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.prenumeClientTable = new System.Windows.Forms.Label();
            this.numeClientTable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nrLicitatieTable = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.infoGen_pan.SuspendLayout();
            this.infoArticol_pan.SuspendLayout();
            this.infoLic_pan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoArticol_pb)).BeginInit();
            this.preItemSelect_pan.SuspendLayout();
            this.clientList_panel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.menuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(1067, 28);
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
            this.editToolbar.Size = new System.Drawing.Size(70, 24);
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
            this.editTB_create.Size = new System.Drawing.Size(145, 26);
            this.editTB_create.Text = "Creează";
            // 
            // editTB_create_item
            // 
            this.editTB_create_item.Image = ((System.Drawing.Image)(resources.GetObject("editTB_create_item.Image")));
            this.editTB_create_item.Name = "editTB_create_item";
            this.editTB_create_item.Size = new System.Drawing.Size(136, 26);
            this.editTB_create_item.Text = "Articol";
            this.editTB_create_item.Click += new System.EventHandler(this.itemToolStripMenuItem_Click_1);
            // 
            // editTB_create_client
            // 
            this.editTB_create_client.Image = global::Proiect_PAW.Properties.Resources.bidder;
            this.editTB_create_client.Name = "editTB_create_client";
            this.editTB_create_client.Size = new System.Drawing.Size(136, 26);
            this.editTB_create_client.Text = "Client";
            this.editTB_create_client.Click += new System.EventHandler(this.editTB_create_client_Click);
            // 
            // editTB_remove
            // 
            this.editTB_remove.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editTB_remove_item,
            this.editTB_remove_client});
            this.editTB_remove.Image = global::Proiect_PAW.Properties.Resources.remove;
            this.editTB_remove.Name = "editTB_remove";
            this.editTB_remove.Size = new System.Drawing.Size(145, 26);
            this.editTB_remove.Text = "Elimină";
            // 
            // editTB_remove_item
            // 
            this.editTB_remove_item.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editTB_remove_item_all,
            this.editTB_remove_item_ID});
            this.editTB_remove_item.Image = ((System.Drawing.Image)(resources.GetObject("editTB_remove_item.Image")));
            this.editTB_remove_item.Name = "editTB_remove_item";
            this.editTB_remove_item.Size = new System.Drawing.Size(136, 26);
            this.editTB_remove_item.Text = "Articol";
            // 
            // editTB_remove_item_all
            // 
            this.editTB_remove_item_all.Name = "editTB_remove_item_all";
            this.editTB_remove_item_all.Size = new System.Drawing.Size(195, 26);
            this.editTB_remove_item_all.Text = "Toate articolele";
            // 
            // editTB_remove_item_ID
            // 
            this.editTB_remove_item_ID.Name = "editTB_remove_item_ID";
            this.editTB_remove_item_ID.Size = new System.Drawing.Size(195, 26);
            this.editTB_remove_item_ID.Text = "După ID";
            // 
            // editTB_remove_client
            // 
            this.editTB_remove_client.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editTB_remove_client_all,
            this.editTB_remove_client_ID});
            this.editTB_remove_client.Image = global::Proiect_PAW.Properties.Resources.bidder;
            this.editTB_remove_client.Name = "editTB_remove_client";
            this.editTB_remove_client.Size = new System.Drawing.Size(136, 26);
            this.editTB_remove_client.Text = "Client";
            // 
            // editTB_remove_client_all
            // 
            this.editTB_remove_client_all.Name = "editTB_remove_client_all";
            this.editTB_remove_client_all.Size = new System.Drawing.Size(165, 26);
            this.editTB_remove_client_all.Text = "Toți clienții";
            // 
            // editTB_remove_client_ID
            // 
            this.editTB_remove_client_ID.Name = "editTB_remove_client_ID";
            this.editTB_remove_client_ID.Size = new System.Drawing.Size(165, 26);
            this.editTB_remove_client_ID.Text = "După ID";
            // 
            // itemToolbar
            // 
            this.itemToolbar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemTB_load});
            this.itemToolbar.ForeColor = System.Drawing.Color.White;
            this.itemToolbar.Name = "itemToolbar";
            this.itemToolbar.Size = new System.Drawing.Size(75, 24);
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
            this.itemTB_load.Size = new System.Drawing.Size(139, 26);
            this.itemTB_load.Text = "Încarcă";
            // 
            // denumArticol
            // 
            this.denumArticol.AutoSize = true;
            this.denumArticol.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.denumArticol.Location = new System.Drawing.Point(4, 48);
            this.denumArticol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.denumArticol.Name = "denumArticol";
            this.denumArticol.Size = new System.Drawing.Size(116, 18);
            this.denumArticol.TabIndex = 2;
            this.denumArticol.Text = "Denumire articol:";
            // 
            // denumArticol_out
            // 
            this.denumArticol_out.AutoSize = true;
            this.denumArticol_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.denumArticol_out.Location = new System.Drawing.Point(127, 48);
            this.denumArticol_out.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.denumArticol_out.Name = "denumArticol_out";
            this.denumArticol_out.Size = new System.Drawing.Size(78, 17);
            this.denumArticol_out.TabIndex = 3;
            this.denumArticol_out.Text = "Indisponibil";
            // 
            // pretBaza
            // 
            this.pretBaza.AutoSize = true;
            this.pretBaza.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pretBaza.Location = new System.Drawing.Point(4, 27);
            this.pretBaza.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pretBaza.Name = "pretBaza";
            this.pretBaza.Size = new System.Drawing.Size(88, 18);
            this.pretBaza.TabIndex = 6;
            this.pretBaza.Text = "Preț de bază:";
            // 
            // pretBaza_out
            // 
            this.pretBaza_out.AutoSize = true;
            this.pretBaza_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pretBaza_out.Location = new System.Drawing.Point(96, 27);
            this.pretBaza_out.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pretBaza_out.Name = "pretBaza_out";
            this.pretBaza_out.Size = new System.Drawing.Size(78, 17);
            this.pretBaza_out.TabIndex = 7;
            this.pretBaza_out.Text = "Indisponibil";
            // 
            // pretCurent
            // 
            this.pretCurent.AutoSize = true;
            this.pretCurent.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pretCurent.Location = new System.Drawing.Point(4, 48);
            this.pretCurent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pretCurent.Name = "pretCurent";
            this.pretCurent.Size = new System.Drawing.Size(127, 18);
            this.pretCurent.TabIndex = 8;
            this.pretCurent.Text = "Preț propus curent:";
            // 
            // pretCurent_out
            // 
            this.pretCurent_out.AutoSize = true;
            this.pretCurent_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pretCurent_out.Location = new System.Drawing.Point(135, 48);
            this.pretCurent_out.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pretCurent_out.Name = "pretCurent_out";
            this.pretCurent_out.Size = new System.Drawing.Size(78, 17);
            this.pretCurent_out.TabIndex = 9;
            this.pretCurent_out.Text = "Indisponibil";
            // 
            // nrClientTop
            // 
            this.nrClientTop.AutoSize = true;
            this.nrClientTop.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nrClientTop.Location = new System.Drawing.Point(4, 69);
            this.nrClientTop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nrClientTop.Name = "nrClientTop";
            this.nrClientTop.Size = new System.Drawing.Size(131, 18);
            this.nrClientTop.TabIndex = 10;
            this.nrClientTop.Text = "Număr client în top:";
            // 
            // nrClientTop_out
            // 
            this.nrClientTop_out.AutoSize = true;
            this.nrClientTop_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nrClientTop_out.Location = new System.Drawing.Point(141, 69);
            this.nrClientTop_out.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nrClientTop_out.Name = "nrClientTop_out";
            this.nrClientTop_out.Size = new System.Drawing.Size(78, 17);
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
            this.infoGen_pan.Location = new System.Drawing.Point(45, 293);
            this.infoGen_pan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.infoGen_pan.Name = "infoGen_pan";
            this.infoGen_pan.Size = new System.Drawing.Size(305, 106);
            this.infoGen_pan.TabIndex = 13;
            // 
            // idArticol
            // 
            this.idArticol.AutoSize = true;
            this.idArticol.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.idArticol.Location = new System.Drawing.Point(4, 28);
            this.idArticol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idArticol.Name = "idArticol";
            this.idArticol.Size = new System.Drawing.Size(67, 18);
            this.idArticol.TabIndex = 15;
            this.idArticol.Text = "ID articol:";
            // 
            // idArticol_out
            // 
            this.idArticol_out.AutoSize = true;
            this.idArticol_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idArticol_out.Location = new System.Drawing.Point(73, 28);
            this.idArticol_out.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idArticol_out.Name = "idArticol_out";
            this.idArticol_out.Size = new System.Drawing.Size(78, 17);
            this.idArticol_out.TabIndex = 16;
            this.idArticol_out.Text = "Indisponibil";
            // 
            // infoGen_title
            // 
            this.infoGen_title.AutoSize = true;
            this.infoGen_title.Font = new System.Drawing.Font("Calibri", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoGen_title.Location = new System.Drawing.Point(4, 2);
            this.infoGen_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.infoGen_title.Name = "infoGen_title";
            this.infoGen_title.Size = new System.Drawing.Size(146, 21);
            this.infoGen_title.TabIndex = 14;
            this.infoGen_title.Text = "Informații generale";
            // 
            // descArticol_link
            // 
            this.descArticol_link.AutoSize = true;
            this.descArticol_link.Cursor = System.Windows.Forms.Cursors.Hand;
            this.descArticol_link.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descArticol_link.ForeColor = System.Drawing.Color.DodgerBlue;
            this.descArticol_link.Location = new System.Drawing.Point(123, 69);
            this.descArticol_link.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descArticol_link.Name = "descArticol_link";
            this.descArticol_link.Size = new System.Drawing.Size(77, 17);
            this.descArticol_link.TabIndex = 13;
            this.descArticol_link.Text = "Vizualizare";
            this.descArticol_link.Click += new System.EventHandler(this.descArticol_link_Click);
            // 
            // descArticol
            // 
            this.descArticol.AutoSize = true;
            this.descArticol.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.descArticol.Location = new System.Drawing.Point(4, 69);
            this.descArticol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descArticol.Name = "descArticol";
            this.descArticol.Size = new System.Drawing.Size(113, 18);
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
            this.infoArticol_pan.Location = new System.Drawing.Point(0, 30);
            this.infoArticol_pan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.infoArticol_pan.Name = "infoArticol_pan";
            this.infoArticol_pan.Size = new System.Drawing.Size(406, 529);
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
            this.infoLic_pan.Location = new System.Drawing.Point(45, 402);
            this.infoLic_pan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.infoLic_pan.Name = "infoLic_pan";
            this.infoLic_pan.Size = new System.Drawing.Size(305, 102);
            this.infoLic_pan.TabIndex = 14;
            // 
            // infoLicitatie_title
            // 
            this.infoLicitatie_title.AutoSize = true;
            this.infoLicitatie_title.Font = new System.Drawing.Font("Calibri", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLicitatie_title.Location = new System.Drawing.Point(4, 6);
            this.infoLicitatie_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.infoLicitatie_title.Name = "infoLicitatie_title";
            this.infoLicitatie_title.Size = new System.Drawing.Size(136, 21);
            this.infoLicitatie_title.TabIndex = 15;
            this.infoLicitatie_title.Text = "Informații licitație";
            // 
            // fotoArticol_pb
            // 
            this.fotoArticol_pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fotoArticol_pb.Image = global::Proiect_PAW.Properties.Resources.no_image;
            this.fotoArticol_pb.InitialImage = global::Proiect_PAW.Properties.Resources.no_image;
            this.fotoArticol_pb.Location = new System.Drawing.Point(64, 22);
            this.fotoArticol_pb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fotoArticol_pb.Name = "fotoArticol_pb";
            this.fotoArticol_pb.Size = new System.Drawing.Size(270, 258);
            this.fotoArticol_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoArticol_pb.TabIndex = 1;
            this.fotoArticol_pb.TabStop = false;
            // 
            // clientSearch_tb
            // 
            this.clientSearch_tb.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.clientSearch_tb.Location = new System.Drawing.Point(405, 30);
            this.clientSearch_tb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clientSearch_tb.Name = "clientSearch_tb";
            this.clientSearch_tb.Size = new System.Drawing.Size(663, 22);
            this.clientSearch_tb.TabIndex = 15;
            this.clientSearch_tb.TabStop = false;
            this.clientSearch_tb.Text = "Caută ID client..";
            this.clientSearch_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clientSearch_tb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clientSearch_tb_MouseClick);
            this.clientSearch_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.clientSearch_tb_KeyPress);
            this.clientSearch_tb.Leave += new System.EventHandler(this.clientSearch_tb_Leave);
            this.clientSearch_tb.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.clientSearch_tb_MouseDoubleClick);
            this.clientSearch_tb.MouseLeave += new System.EventHandler(this.clientSearch_tb_MouseLeave);
            // 
            // preItemSelect1
            // 
            this.preItemSelect1.AutoSize = true;
            this.preItemSelect1.Location = new System.Drawing.Point(40, 14);
            this.preItemSelect1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.preItemSelect1.Name = "preItemSelect1";
            this.preItemSelect1.Size = new System.Drawing.Size(395, 16);
            this.preItemSelect1.TabIndex = 16;
            this.preItemSelect1.Text = "Selectează un articol din categoria \"Articole\" înainte de a continua";
            // 
            // preItemSelect_pan
            // 
            this.preItemSelect_pan.Controls.Add(this.preItemSelect1);
            this.preItemSelect_pan.Controls.Add(this.preItemSelect2);
            this.preItemSelect_pan.Location = new System.Drawing.Point(483, 262);
            this.preItemSelect_pan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.preItemSelect_pan.Name = "preItemSelect_pan";
            this.preItemSelect_pan.Size = new System.Drawing.Size(516, 71);
            this.preItemSelect_pan.TabIndex = 18;
            // 
            // preItemSelect2
            // 
            this.preItemSelect2.AutoSize = true;
            this.preItemSelect2.Location = new System.Drawing.Point(16, 33);
            this.preItemSelect2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.preItemSelect2.Name = "preItemSelect2";
            this.preItemSelect2.Size = new System.Drawing.Size(448, 16);
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
            // nrOrdineTable
            // 
            this.nrOrdineTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nrOrdineTable.AutoSize = true;
            this.nrOrdineTable.Location = new System.Drawing.Point(7, 14);
            this.nrOrdineTable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nrOrdineTable.Name = "nrOrdineTable";
            this.nrOrdineTable.Size = new System.Drawing.Size(28, 16);
            this.nrOrdineTable.TabIndex = 0;
            this.nrOrdineTable.Text = "No.";
            this.nrOrdineTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.175667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.167819F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.5584F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.10262F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.54125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.00402F));
            this.tableLayoutPanel1.Controls.Add(this.prenumeClientTable, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.numeClientTable, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.nrOrdineTable, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.nrLicitatieTable, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(405, 52);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(664, 44);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // prenumeClientTable
            // 
            this.prenumeClientTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prenumeClientTable.AutoSize = true;
            this.prenumeClientTable.Location = new System.Drawing.Point(309, 14);
            this.prenumeClientTable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prenumeClientTable.Name = "prenumeClientTable";
            this.prenumeClientTable.Size = new System.Drawing.Size(95, 16);
            this.prenumeClientTable.TabIndex = 23;
            this.prenumeClientTable.Text = "Prenume client";
            this.prenumeClientTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numeClientTable
            // 
            this.numeClientTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numeClientTable.AutoSize = true;
            this.numeClientTable.Location = new System.Drawing.Point(183, 14);
            this.numeClientTable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numeClientTable.Name = "numeClientTable";
            this.numeClientTable.Size = new System.Drawing.Size(77, 16);
            this.numeClientTable.TabIndex = 22;
            this.numeClientTable.Text = "Nume client";
            this.numeClientTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 32);
            this.label1.TabIndex = 20;
            this.label1.Text = "ID\r\nclient";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nrLicitatieTable
            // 
            this.nrLicitatieTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nrLicitatieTable.AutoSize = true;
            this.nrLicitatieTable.Location = new System.Drawing.Point(106, 6);
            this.nrLicitatieTable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nrLicitatieTable.Name = "nrLicitatieTable";
            this.nrLicitatieTable.Size = new System.Drawing.Size(48, 32);
            this.nrLicitatieTable.TabIndex = 21;
            this.nrLicitatieTable.Text = "Număr\r\nlicitație";
            this.nrLicitatieTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.infoArticol_pan);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.preItemSelect_pan);
            this.Controls.Add(this.clientSearch_tb);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.clientList_panel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
                        adaugaOptiuneArticol(articol);
                    }
                }

                Articol.Cache.Articole.AddRange(articole);
            }
        }

        public void adaugaOptiuneArticol(Articol articol) {
            ToolStripMenuItem art = new ToolStripMenuItem();
            int index = itemTB_load.DropDownItems.Count + 1;

            art.Name = $"itemTB_item{index}";
            art.Text = $"{index}. {articol.Nume}";
            art.ForeColor = Color.Black;
            art.Size = new Size(180, 22);
            art.Image = global::Proiect_PAW.Properties.Resources.individual_load;
            art.Tag = articol;
            art.Click += new EventHandler(itemTB_itemn_Click);

            itemTB_load.DropDownItems.Add(art);
        }

        public void adaugaElementClient(ClientLicitatie client) {
            TableLayoutPanel elem = new TableLayoutPanel();

            elem.BackColor = System.Drawing.Color.WhiteSmoke;
            elem.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            elem.ColumnCount = 2;
            elem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.2249F));
            elem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.7751F));
            elem.Cursor = System.Windows.Forms.Cursors.Hand;
            elem.Dock = System.Windows.Forms.DockStyle.Top;
            elem.Location = new System.Drawing.Point(0, 0);
            elem.Name = $"clientElement{clientList_panel.Controls.Count + 1}";
            elem.RowCount = 1;
            elem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            elem.Size = new System.Drawing.Size(498, 42);
            elem.TabIndex = 0;

            clientList_panel.Controls.Add(elem);
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
        private Label nrOrdineTable;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label nrLicitatieTable;
        private Label numeClientTable;
        private Label prenumeClientTable;
    }
}

