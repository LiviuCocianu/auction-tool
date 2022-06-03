using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Auction_Tool {
    public partial class EditByIdForm : Form, ISubmitter, ILocalizable {
        private MainForm main;
        private For type;
        private Action<AuctionItem> postSubmitItem;
        private Action<AuctionClient> postSubmitClient;
        private Dictionary<string, string> localeJSON;

        private int selectedID;

        public string LocaleFileName => "edit_form";

        public Dictionary<string, string> LocaleJSON { get => localeJSON; set => localeJSON = value; }

        public EditByIdForm(MainForm main, For type) {
            InitializeComponent();

            this.main = main;
            this.type = type;
            selectedID = 0;

            LocaleJSON = Utils.getJsonLang(main.DefaultLang, LocaleFileName);
            localize();

            switch (type) {
                case For.AuctionItem:
                    foreach (AuctionItem item in AuctionItem.deserialize()) {
                        searchElem_lv.Items.Add(new ListViewItem(new string[] {
                            item.Id.ToString(), item.Name
                        }));
                    }
                    break;
                case For.AuctionClient:
                    foreach (AuctionClient cli in AuctionClient.deserialize()) {
                        searchElem_lv.Items.Add(new ListViewItem(new string[] {
                            cli.Id.ToString(), $"{cli.FirstName} {cli.LastName}"
                        }));
                    }
                    break;
            }
        }

        /**
         * RO:
         * Folosește delegatul Action pentru a executa o acțiune cu articolul pasat
         * ulterior după ce s-a dat submit
         * 
         * EN:
         * Uses the Action delegate to execute an action on the later passed item
         * after everything is submitted
         */
        public EditByIdForm(MainForm main, Action<AuctionItem> afterSubmition) : this(main, For.AuctionItem) {
            postSubmitItem = afterSubmition;
        }

        public EditByIdForm(MainForm main, Action<AuctionClient> afterSubmition) : this(main, For.AuctionClient) {
            postSubmitClient = afterSubmition;
        }

        public bool checkValidity() {
            return true;
        }

        public void Submit() {
            switch (type) {
                case For.AuctionItem:
                    postSubmitItem.Invoke(AuctionItem.find(selectedID));
                    break;
                case For.AuctionClient:
                    postSubmitClient.Invoke(AuctionClient.find(selectedID));
                    break;
            }

            Close();
        }

        private void search_btn_Click(object sender, EventArgs e) {
            Submit();
        }

        private void searchElement_lv_Click(object sender, EventArgs e) {
            selectedID = int.Parse(searchElem_lv.SelectedItems[0].SubItems[0].Text);
            selectedId.Text = LocaleJSON["selected_id_label"].Replace("%id%", selectedID.ToString());
        }

        public void localize() {
            switch (type) {
                case For.AuctionItem:
                    searchTitle.Text = LocaleJSON["item_form_title"];
                    searchElem_lv_name.Text = LocaleJSON["item_name_column"];
                    break;
                case For.AuctionClient:
                    searchTitle.Text = LocaleJSON["client_form_title"];
                    searchElem_lv_name.Text = LocaleJSON["client_name_column"];
                    break;
            }

            searchElem_lv_ID.Text = LocaleJSON["id_column"];
            selectedId.Text = LocaleJSON["selected_id_label"].Replace("%id%", selectedID.ToString());
            submit_btn.Text = LocaleJSON["submit_button"];

            if (!main.LocalizedForms.Contains(this))
                main.LocalizedForms.Add(this);
        }
    }
}
