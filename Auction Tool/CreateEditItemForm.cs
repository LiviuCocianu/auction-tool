using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Auction_Tool {
    class CreateEditItemForm : Form, ISubmitter {
        private Label numeArticol;
        private Panel numeArt_pan;
        private TextBox numeArticol_tb;
        private Label descArticol;
        private TextBox descArticol_tb;
        private Label pretBaza;
        private TextBox urlFoto_tb;
        private Label URLfoto;
        private Panel urlFoto_pan;
        private Panel pretBaza_pan;
        private Panel descArt_pan;
        private System.ComponentModel.IContainer components;
        private ErrorProvider errorProvider;
        private Button submit_btn;
        private TextBox pretBaza_tb;
        private Label title;

        private MainForm main;
        private Operatie op;
        private Articol toEdit;

        private CreateEditItemForm(MainForm main) {
            InitializeComponent();
            this.main = main;
        }

        public CreateEditItemForm(MainForm main, Operatie op) : this(main) {
            this.op = op;

            switch(op) {
                case Operatie.Creare:
                    title.Text = "Creează un articol nou";
                    submit_btn.Text = "Creează";
                    break;
                case Operatie.Editare:
                    title.Text = "Editează articol";
                    submit_btn.Text = "Editează";
                    break;
            }
        }

        public CreateEditItemForm(MainForm main, Articol toEdit) : this(main, Operatie.Editare) {
            this.toEdit = toEdit;
            numeArticol_tb.Text = toEdit.Nume;
            descArticol_tb.Text = toEdit.Descriere;
            pretBaza_tb.Text = toEdit.PretBaza.ToString();
            urlFoto_tb.Text = toEdit.URLfoto;
        }

        public void Submit() {
            if(checkValidity()) {
                switch (op) {
                    case Operatie.Creare:
                        string nume = numeArticol_tb.Text;
                        string descriere = descArticol_tb.Text;
                        float.TryParse(pretBaza_tb.Text, out float pretBaza);
                        string URL = urlFoto_tb.Text;

                        Articol item = new Articol(nume, descriere, pretBaza, URL);
                        item.serializeaza();

                        main.adaugaOptiuneArticol(item);
                        Articol.Cache.Articole.Add(item);

                        DialogResult res = MessageBox.Show(
                            "Articolul a fost salvat cu succes!",
                            "Articol creat",
                            MessageBoxButtons.OK, MessageBoxIcon.Information
                        );

                        if (res == DialogResult.OK || res == DialogResult.Cancel)
                            Close();
                        break;
                    case Operatie.Editare:
                        nume = numeArticol_tb.Text;
                        descriere = descArticol_tb.Text;
                        float.TryParse(pretBaza_tb.Text, out pretBaza);
                        URL = urlFoto_tb.Text;

                        item = new Articol(nume, descriere, pretBaza, URL) {
                            Id = toEdit.Id
                        };

                        Articol.Cache.Articole = item.seteazaArticol();

                        res = MessageBox.Show(
                            "Articolul a fost editat cu succes!",
                            "Articol editat",
                            MessageBoxButtons.OK, MessageBoxIcon.Information
                        );

                        if (res == DialogResult.OK || res == DialogResult.Cancel) {
                            main.refreshArticoleToolbar();
                            if (main.esteAfisatCurent(item))
                                main.afiseazaArticol(item);
                            Close();
                        }
                        break;
                }
            }
        }

        #region CreareComponente
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateEditItemForm));
            this.title = new System.Windows.Forms.Label();
            this.numeArticol = new System.Windows.Forms.Label();
            this.numeArt_pan = new System.Windows.Forms.Panel();
            this.numeArticol_tb = new System.Windows.Forms.TextBox();
            this.urlFoto_tb = new System.Windows.Forms.TextBox();
            this.URLfoto = new System.Windows.Forms.Label();
            this.pretBaza = new System.Windows.Forms.Label();
            this.descArticol_tb = new System.Windows.Forms.TextBox();
            this.descArticol = new System.Windows.Forms.Label();
            this.urlFoto_pan = new System.Windows.Forms.Panel();
            this.pretBaza_pan = new System.Windows.Forms.Panel();
            this.pretBaza_tb = new System.Windows.Forms.TextBox();
            this.descArt_pan = new System.Windows.Forms.Panel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.submit_btn = new System.Windows.Forms.Button();
            this.numeArt_pan.SuspendLayout();
            this.urlFoto_pan.SuspendLayout();
            this.pretBaza_pan.SuspendLayout();
            this.descArt_pan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(19, 14);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(161, 19);
            this.title.TabIndex = 0;
            this.title.Text = "Creează un articol nou";
            // 
            // numeArticol
            // 
            this.numeArticol.AutoSize = true;
            this.numeArticol.Location = new System.Drawing.Point(3, 5);
            this.numeArticol.Name = "numeArticol";
            this.numeArticol.Size = new System.Drawing.Size(66, 13);
            this.numeArticol.TabIndex = 1;
            this.numeArticol.Text = "Nume articol";
            // 
            // numeArt_pan
            // 
            this.numeArt_pan.Controls.Add(this.numeArticol_tb);
            this.numeArt_pan.Controls.Add(this.numeArticol);
            this.numeArt_pan.Location = new System.Drawing.Point(17, 45);
            this.numeArt_pan.Name = "numeArt_pan";
            this.numeArt_pan.Size = new System.Drawing.Size(371, 47);
            this.numeArt_pan.TabIndex = 2;
            // 
            // numeArticol_tb
            // 
            this.numeArticol_tb.Location = new System.Drawing.Point(6, 21);
            this.numeArticol_tb.Name = "numeArticol_tb";
            this.numeArticol_tb.Size = new System.Drawing.Size(336, 20);
            this.numeArticol_tb.TabIndex = 2;
            // 
            // urlFoto_tb
            // 
            this.urlFoto_tb.Location = new System.Drawing.Point(6, 20);
            this.urlFoto_tb.Name = "urlFoto_tb";
            this.urlFoto_tb.Size = new System.Drawing.Size(336, 20);
            this.urlFoto_tb.TabIndex = 8;
            // 
            // URLfoto
            // 
            this.URLfoto.AutoSize = true;
            this.URLfoto.Location = new System.Drawing.Point(3, 2);
            this.URLfoto.Name = "URLfoto";
            this.URLfoto.Size = new System.Drawing.Size(153, 13);
            this.URLfoto.TabIndex = 7;
            this.URLfoto.Text = "URL fotografie articol (opțional)\r\n";
            this.URLfoto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pretBaza
            // 
            this.pretBaza.AutoSize = true;
            this.pretBaza.Location = new System.Drawing.Point(3, 5);
            this.pretBaza.Name = "pretBaza";
            this.pretBaza.Size = new System.Drawing.Size(99, 13);
            this.pretBaza.TabIndex = 5;
            this.pretBaza.Text = "Preț de bază (în lei)";
            // 
            // descArticol_tb
            // 
            this.descArticol_tb.Location = new System.Drawing.Point(6, 19);
            this.descArticol_tb.Multiline = true;
            this.descArticol_tb.Name = "descArticol_tb";
            this.descArticol_tb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descArticol_tb.Size = new System.Drawing.Size(336, 45);
            this.descArticol_tb.TabIndex = 4;
            // 
            // descArticol
            // 
            this.descArticol.AutoSize = true;
            this.descArticol.Location = new System.Drawing.Point(3, 3);
            this.descArticol.Name = "descArticol";
            this.descArticol.Size = new System.Drawing.Size(83, 13);
            this.descArticol.TabIndex = 3;
            this.descArticol.Text = "Descriere articol\r\n";
            this.descArticol.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // urlFoto_pan
            // 
            this.urlFoto_pan.Controls.Add(this.URLfoto);
            this.urlFoto_pan.Controls.Add(this.urlFoto_tb);
            this.urlFoto_pan.Location = new System.Drawing.Point(17, 211);
            this.urlFoto_pan.Name = "urlFoto_pan";
            this.urlFoto_pan.Size = new System.Drawing.Size(371, 46);
            this.urlFoto_pan.TabIndex = 9;
            // 
            // pretBaza_pan
            // 
            this.pretBaza_pan.Controls.Add(this.pretBaza_tb);
            this.pretBaza_pan.Controls.Add(this.pretBaza);
            this.pretBaza_pan.Location = new System.Drawing.Point(17, 164);
            this.pretBaza_pan.Name = "pretBaza_pan";
            this.pretBaza_pan.Size = new System.Drawing.Size(371, 48);
            this.pretBaza_pan.TabIndex = 10;
            // 
            // pretBaza_tb
            // 
            this.pretBaza_tb.Location = new System.Drawing.Point(6, 22);
            this.pretBaza_tb.Name = "pretBaza_tb";
            this.pretBaza_tb.Size = new System.Drawing.Size(336, 20);
            this.pretBaza_tb.TabIndex = 6;
            // 
            // descArt_pan
            // 
            this.descArt_pan.Controls.Add(this.descArticol_tb);
            this.descArt_pan.Controls.Add(this.descArticol);
            this.descArt_pan.Location = new System.Drawing.Point(17, 91);
            this.descArt_pan.Name = "descArt_pan";
            this.descArt_pan.Size = new System.Drawing.Size(371, 74);
            this.descArt_pan.TabIndex = 11;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // submit_btn
            // 
            this.submit_btn.Location = new System.Drawing.Point(23, 267);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(336, 23);
            this.submit_btn.TabIndex = 12;
            this.submit_btn.Text = "Creează";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.creeaza_btn_Click);
            // 
            // CreateEditItemForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 308);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.descArt_pan);
            this.Controls.Add(this.pretBaza_pan);
            this.Controls.Add(this.urlFoto_pan);
            this.Controls.Add(this.numeArt_pan);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CreateEditItemForm";
            this.numeArt_pan.ResumeLayout(false);
            this.numeArt_pan.PerformLayout();
            this.urlFoto_pan.ResumeLayout(false);
            this.urlFoto_pan.PerformLayout();
            this.pretBaza_pan.ResumeLayout(false);
            this.pretBaza_pan.PerformLayout();
            this.descArt_pan.ResumeLayout(false);
            this.descArt_pan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private void creeaza_btn_Click(object sender, EventArgs e) {
            Submit();
        }

        public bool checkValidity() {
            return numeArticolValid() && descriereValid() && pretBazaValid() && URLvalid();
        }

        private bool numeArticolValid() {
            const int nameCharLimit = 50;

            if (string.IsNullOrEmpty(numeArticol_tb.Text)) {
                errorProvider.SetError(numeArticol_tb, "Acest câmp nu poate fi lăsat gol");
                return false;
            } else if (numeArticol_tb.Text.Length > nameCharLimit) {
                errorProvider.SetError(numeArticol_tb, $"Numele articolului nu poate depăși {nameCharLimit} caractere");
                return false;
            } else {
                if (File.Exists($"{MainForm.WorkPath}\\items.dat")) {
                    List<Articol> articole = Articol.deserializeaza();

                    if (articole.Count > 0) {
                        foreach (Articol art in articole) {
                            if (art.Nume == numeArticol_tb.Text) {
                                if (op == Operatie.Editare && numeArticol_tb.Text == toEdit.Nume) return true;

                                errorProvider.SetError(numeArticol_tb, $"Acest nume aparține deja altui articol");
                                return false;
                            }
                        }
                    }
                }

                errorProvider.SetError(numeArticol_tb, null);
                return true;
            }
        }

        private bool descriereValid() {
            const int descCharLimit = 200;

            if (string.IsNullOrEmpty(descArticol_tb.Text)) {
                errorProvider.SetError(descArticol_tb, "Acest câmp nu poate fi lăsat gol");
                return false;
            } else if (descArticol_tb.Text.Length > descCharLimit) {
                errorProvider.SetError(descArticol_tb, $"Descrierea articolului nu poate depăși {descCharLimit} caractere");
                return false;
            } else {
                errorProvider.SetError(descArticol_tb, null);
                return true;
            }
        }

        private bool pretBazaValid() {
            float pret;
            bool converted = float.TryParse(pretBaza_tb.Text, out pret);

            if(!converted || float.IsNaN(pret) || float.IsInfinity(pret)) {
                errorProvider.SetError(pretBaza_tb, "Acest câmp nu conține un număr rațional pozitiv");
                return false;
            } else if (pret <= 0) {
                errorProvider.SetError(pretBaza_tb, "Prețul de bază nu poate fi mai mic sau egal cu 0");
                return false;
            } else {
                errorProvider.SetError(pretBaza_tb, null);
                return true;
            }
        }

        private bool URLvalid() {
            if (!string.IsNullOrEmpty(urlFoto_tb.Text)) {
                Uri URL;
                Uri.TryCreate(urlFoto_tb.Text, UriKind.Absolute, out URL);

                if (Uri.IsWellFormedUriString(urlFoto_tb.Text, UriKind.Absolute)) {
                    if (URL.Scheme != Uri.UriSchemeHttp && URL.Scheme != Uri.UriSchemeHttps) {
                        errorProvider.SetError(urlFoto_tb, "Acest URL nu este de forma HTTP sau HTTPS");
                        return false;
                    } else {
                        errorProvider.SetError(urlFoto_tb, null);
                        return true;
                    }
                } else {
                    errorProvider.SetError(urlFoto_tb, "Textul introdus nu are forma unui URL valid");
                    return false;
                }
            } else {
                errorProvider.SetError(urlFoto_tb, null);
                return true;
            }
        }
    }
}
