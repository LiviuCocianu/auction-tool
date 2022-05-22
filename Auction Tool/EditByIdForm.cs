using System;
using System.Windows.Forms;

namespace Auction_Tool {
    public partial class EditByIdForm : Form, ISubmitter {
        private MainForm main;
        private For type;
        private Action<AuctionItem> postSubmitItem;
        private Action<AuctionClient> postSubmitClient;

        private int selectedID;

        public EditByIdForm(MainForm main, For type) {
            InitializeComponent();

            this.main = main;
            this.type = type;
            selectedID = 0;

            switch (type) {
                case For.AuctionItem:
                    Text = "Caută articol";
                    searchTitle.Text = "Caută articol după ID";
                    searchElem_lv_name.Text = "Nume articol";
                    search_btn.Text = "Caută articol";

                    foreach(AuctionItem item in AuctionItem.deserialize()) {
                        searchElem_lv.Items.Add(new ListViewItem(new string[] {
                            item.Id.ToString(), item.Name
                        }));
                    }
                    break;
                case For.AuctionClient:
                    Text = "Caută client";
                    searchTitle.Text = "Caută client după ID";
                    searchElem_lv_name.Text = "Nume client";
                    search_btn.Text = "Caută client";

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
            selectedId.Text = $"ID selectat: {selectedID}";
        }
    }
}
