using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Auction_Tool {
    class CreateEditItemForm : Form, ISubmitter {
        private Label itemName;
        private Panel itemName_pan;
        private TextBox itemName_tb;
        private Label itemDesc;
        private TextBox itemDesc_tb;
        private Label basePrice;
        private TextBox imageUrl_tb;
        private Label imageUrl;
        private Panel imageUrl_pan;
        private Panel basePrice_pan;
        private TextBox basePrice_tb;
        private Panel itemDesc_pan;
        private System.ComponentModel.IContainer components;
        private ErrorProvider errorProvider;
        private Button submit_btn;
        private Label title;

        private MainForm main;
        private Operation op;
        private AuctionItem toEdit;

        private CreateEditItemForm(MainForm main) {
            InitializeComponent();
            this.main = main;
        }

        public CreateEditItemForm(MainForm main, Operation op) : this(main) {
            this.op = op;

            switch(op) {
                case Operation.Create:
                    title.Text = "Creează un articol nou";
                    submit_btn.Text = "Creează";
                    break;
                case Operation.Edit:
                    title.Text = "Editează articol";
                    submit_btn.Text = "Editează";
                    break;
            }
        }

        public CreateEditItemForm(MainForm main, AuctionItem toEdit) : this(main, Operation.Edit) {
            this.toEdit = toEdit;
            itemName_tb.Text = toEdit.Name;
            itemDesc_tb.Text = toEdit.Description;
            basePrice_tb.Text = toEdit.BasePrice.ToString();
            imageUrl_tb.Text = toEdit.ImageURL;
        }

        public void Submit() {
            if(checkValidity()) {
                switch (op) {
                    case Operation.Create:
                        string name = itemName_tb.Text;
                        string description = itemDesc_tb.Text;
                        float.TryParse(basePrice_tb.Text, out float basePrice);
                        string imageUrl = imageUrl_tb.Text;

                        AuctionItem item = new AuctionItem(name, description, basePrice, imageUrl);
                        item.serialize();

                        main.addItemToToolbar(item);
                        AuctionItem.Cache.Collection.Add(item);

                        DialogResult choice = MessageBox.Show(
                            "Articolul a fost salvat cu succes!",
                            "Articol creat",
                            MessageBoxButtons.OK, MessageBoxIcon.Information
                        );

                        if (choice == DialogResult.OK || choice == DialogResult.Cancel)
                            Close();
                        break;
                    case Operation.Edit:
                        name = itemName_tb.Text;
                        description = itemDesc_tb.Text;
                        float.TryParse(basePrice_tb.Text, out basePrice);
                        imageUrl = imageUrl_tb.Text;

                        item = new AuctionItem(name, description, basePrice, imageUrl) {
                            Id = toEdit.Id
                        };

                        AuctionItem.Cache.Collection = item.saveThis();

                        choice = MessageBox.Show(
                            "Articolul a fost editat cu succes!",
                            "Articol editat",
                            MessageBoxButtons.OK, MessageBoxIcon.Information
                        );

                        if (choice == DialogResult.OK || choice == DialogResult.Cancel) {
                            main.refreshToolbarItems();
                            if (main.isItemDisplayed(item))
                                main.displayItem(item);
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
            this.title = new Label();
            this.itemName = new Label();
            this.itemName_pan = new Panel();
            this.itemName_tb = new TextBox();
            this.imageUrl_tb = new TextBox();
            this.imageUrl = new Label();
            this.basePrice = new Label();
            this.itemDesc_tb = new TextBox();
            this.itemDesc = new Label();
            this.imageUrl_pan = new Panel();
            this.basePrice_pan = new Panel();
            this.basePrice_tb = new TextBox();
            this.itemDesc_pan = new Panel();
            this.errorProvider = new ErrorProvider(this.components);
            this.submit_btn = new Button();
            this.itemName_pan.SuspendLayout();
            this.imageUrl_pan.SuspendLayout();
            this.basePrice_pan.SuspendLayout();
            this.itemDesc_pan.SuspendLayout();
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
            // itemName
            // 
            this.itemName.AutoSize = true;
            this.itemName.Location = new System.Drawing.Point(3, 5);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(66, 13);
            this.itemName.TabIndex = 1;
            this.itemName.Text = "Nume articol";
            // 
            // itemName_pan
            // 
            this.itemName_pan.Controls.Add(this.itemName_tb);
            this.itemName_pan.Controls.Add(this.itemName);
            this.itemName_pan.Location = new System.Drawing.Point(17, 45);
            this.itemName_pan.Name = "itemName_pan";
            this.itemName_pan.Size = new System.Drawing.Size(371, 47);
            this.itemName_pan.TabIndex = 2;
            // 
            // itemName_tb
            // 
            this.itemName_tb.Location = new System.Drawing.Point(6, 21);
            this.itemName_tb.Name = "itemName_tb";
            this.itemName_tb.Size = new System.Drawing.Size(336, 20);
            this.itemName_tb.TabIndex = 2;
            // 
            // imageUrl_tb
            // 
            this.imageUrl_tb.Location = new System.Drawing.Point(6, 20);
            this.imageUrl_tb.Name = "imageUrl_tb";
            this.imageUrl_tb.Size = new System.Drawing.Size(336, 20);
            this.imageUrl_tb.TabIndex = 8;
            // 
            // imageUrl
            // 
            this.imageUrl.AutoSize = true;
            this.imageUrl.Location = new System.Drawing.Point(3, 2);
            this.imageUrl.Name = "imageUrl";
            this.imageUrl.Size = new System.Drawing.Size(153, 13);
            this.imageUrl.TabIndex = 7;
            this.imageUrl.Text = "imageUrl fotografie articol (opțional)\r\n";
            this.imageUrl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // basePrice
            // 
            this.basePrice.AutoSize = true;
            this.basePrice.Location = new System.Drawing.Point(3, 5);
            this.basePrice.Name = "basePrice";
            this.basePrice.Size = new System.Drawing.Size(99, 13);
            this.basePrice.TabIndex = 5;
            this.basePrice.Text = "Preț de bază (în lei)";
            // 
            // itemDesc_tb
            // 
            this.itemDesc_tb.Location = new System.Drawing.Point(6, 19);
            this.itemDesc_tb.Multiline = true;
            this.itemDesc_tb.Name = "itemDesc_tb";
            this.itemDesc_tb.ScrollBars = ScrollBars.Vertical;
            this.itemDesc_tb.Size = new System.Drawing.Size(336, 45);
            this.itemDesc_tb.TabIndex = 4;
            // 
            // itemDesc
            // 
            this.itemDesc.AutoSize = true;
            this.itemDesc.Location = new System.Drawing.Point(3, 3);
            this.itemDesc.Name = "itemDesc";
            this.itemDesc.Size = new System.Drawing.Size(83, 13);
            this.itemDesc.TabIndex = 3;
            this.itemDesc.Text = "Descriere articol\r\n";
            this.itemDesc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // imageUrl_pan
            // 
            this.imageUrl_pan.Controls.Add(this.imageUrl);
            this.imageUrl_pan.Controls.Add(this.imageUrl_tb);
            this.imageUrl_pan.Location = new System.Drawing.Point(17, 211);
            this.imageUrl_pan.Name = "imageUrl_pan";
            this.imageUrl_pan.Size = new System.Drawing.Size(371, 46);
            this.imageUrl_pan.TabIndex = 9;
            // 
            // basePrice_pan
            // 
            this.basePrice_pan.Controls.Add(this.basePrice_tb);
            this.basePrice_pan.Controls.Add(this.basePrice);
            this.basePrice_pan.Location = new System.Drawing.Point(17, 164);
            this.basePrice_pan.Name = "basePrice_pan";
            this.basePrice_pan.Size = new System.Drawing.Size(371, 48);
            this.basePrice_pan.TabIndex = 10;
            // 
            // basePrice_tb
            // 
            this.basePrice_tb.Location = new System.Drawing.Point(6, 22);
            this.basePrice_tb.Name = "basePrice_tb";
            this.basePrice_tb.Size = new System.Drawing.Size(336, 20);
            this.basePrice_tb.TabIndex = 6;
            // 
            // itemDesc_pan
            // 
            this.itemDesc_pan.Controls.Add(this.itemDesc_tb);
            this.itemDesc_pan.Controls.Add(this.itemDesc);
            this.itemDesc_pan.Location = new System.Drawing.Point(17, 91);
            this.itemDesc_pan.Name = "itemDesc_pan";
            this.itemDesc_pan.Size = new System.Drawing.Size(371, 74);
            this.itemDesc_pan.TabIndex = 11;
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
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // CreateEditItemForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 308);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.itemDesc_pan);
            this.Controls.Add(this.basePrice_pan);
            this.Controls.Add(this.imageUrl_pan);
            this.Controls.Add(this.itemName_pan);
            this.Controls.Add(this.title);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CreateEditItemForm";
            this.itemName_pan.ResumeLayout(false);
            this.itemName_pan.PerformLayout();
            this.imageUrl_pan.ResumeLayout(false);
            this.imageUrl_pan.PerformLayout();
            this.basePrice_pan.ResumeLayout(false);
            this.basePrice_pan.PerformLayout();
            this.itemDesc_pan.ResumeLayout(false);
            this.itemDesc_pan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private void submit_btn_Click(object sender, EventArgs e) {
            Submit();
        }

        public bool checkValidity() {
            return itemNameValid() && descriptionValid() && basePriceValid() && imageUrlValid();
        }

        private bool itemNameValid() {
            const int nameCharLimit = 50;

            if (string.IsNullOrEmpty(itemName_tb.Text)) {
                errorProvider.SetError(itemName_tb, "Acest câmp nu poate fi lăsat gol");
                return false;
            } else if (itemName_tb.Text.Length > nameCharLimit) {
                errorProvider.SetError(itemName_tb, $"Numele articolului nu poate depăși {nameCharLimit} caractere");
                return false;
            } else {
                if (File.Exists($"{MainForm.WorkPath}\\items.dat")) {
                    List<AuctionItem> articole = AuctionItem.deserialize();

                    if (articole.Count > 0) {
                        foreach (AuctionItem art in articole) {
                            if (art.Name == itemName_tb.Text) {
                                if (op == Operation.Edit && itemName_tb.Text == toEdit.Name) return true;

                                errorProvider.SetError(itemName_tb, $"Acest name aparține deja altui articol");
                                return false;
                            }
                        }
                    }
                }

                errorProvider.SetError(itemName_tb, null);
                return true;
            }
        }

        private bool descriptionValid() {
            const int descCharLimit = 200;

            if (string.IsNullOrEmpty(itemDesc_tb.Text)) {
                errorProvider.SetError(itemDesc_tb, "Acest câmp nu poate fi lăsat gol");
                return false;
            } else if (itemDesc_tb.Text.Length > descCharLimit) {
                errorProvider.SetError(itemDesc_tb, $"Descrierea articolului nu poate depăși {descCharLimit} caractere");
                return false;
            } else {
                errorProvider.SetError(itemDesc_tb, null);
                return true;
            }
        }

        private bool basePriceValid() {
            float price;
            bool converted = float.TryParse(basePrice_tb.Text, out price);

            if(!converted || float.IsNaN(price) || float.IsInfinity(price)) {
                errorProvider.SetError(basePrice_tb, "Acest câmp nu conține un număr rațional pozitiv");
                return false;
            } else if (price <= 0) {
                errorProvider.SetError(basePrice_tb, "Prețul de bază nu poate fi mai mic sau egal cu 0");
                return false;
            } else {
                errorProvider.SetError(basePrice_tb, null);
                return true;
            }
        }

        private bool imageUrlValid() {
            if (!string.IsNullOrEmpty(imageUrl_tb.Text)) {
                Uri URL;
                Uri.TryCreate(imageUrl_tb.Text, UriKind.Absolute, out URL);

                if (Uri.IsWellFormedUriString(imageUrl_tb.Text, UriKind.Absolute)) {
                    if (URL.Scheme != Uri.UriSchemeHttp && URL.Scheme != Uri.UriSchemeHttps) {
                        errorProvider.SetError(imageUrl_tb, "Acest imageUrl nu este de forma HTTP sau HTTPS");
                        return false;
                    } else {
                        errorProvider.SetError(imageUrl_tb, null);
                        return true;
                    }
                } else {
                    errorProvider.SetError(imageUrl_tb, "Textul introdus nu are forma unui imageUrl valid");
                    return false;
                }
            } else {
                errorProvider.SetError(imageUrl_tb, null);
                return true;
            }
        }
    }
}
