using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Auction_Tool {
    public partial class DeleteByIdForm : Form, ISubmitter, ILocalizable {
        private MainForm main;
        private For type;
        private Dictionary<string, string> localeJSON;

        public string LocaleFileName => "delete_form";

        public Dictionary<string, string> LocaleJSON { get => localeJSON; set => localeJSON = value; }

        public DeleteByIdForm(MainForm main, For type) {
            InitializeComponent();
            this.main = main;
            this.type = type;

            LocaleJSON = Utils.getJsonLang(main.DefaultLang, LocaleFileName);
            localize();
        }

        public bool checkValidity() {
            return idValid();
        }

        public void Submit() {
            if (checkValidity()) {
                int id = (int) id_num.Value;

                if (type == For.AuctionItem)
                    AuctionItem.delete(id);
                else if (type == For.AuctionClient)
                    AuctionClient.delete(id);

                string txt = type == For.AuctionItem
                    ? LocaleJSON["dialog_item_removed"].Replace("%id%", id.ToString())
                    : LocaleJSON["dialog_client_removed"].Replace("%id%", id.ToString());

                DialogResult res = MessageBox.Show(txt, main.LocaleJSON["dialog_info"],
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (res == DialogResult.OK || res == DialogResult.Cancel) {
                    Close();

                    if(type == For.AuctionItem) {
                        main.refreshToolbarItems();

                        /*
                         * RO: Dacă articolul dat spre ștergere era în mod curent pe ecran
                         *     atunci resetăm câmpurile cu informații
                         * EN: If the removed item was displayed on the screen
                         *     then we reset the info fields
                         */
                        if (int.Parse(main.auctionItemID_out.Text) == id)
                            main.displayNoItem();
                    } else if(type == For.AuctionClient) {
                        main.refreshClientList(false);
                    }
                }
            }
        }

        private bool idValid() {
            string filePath = type == For.AuctionItem ? "items.dat" : "clients.dat";

            if (File.Exists($"{MainForm.WorkPath}\\{filePath}")) {
                List<IIdentifiable> elements;

                if(type == For.AuctionItem) {
                    elements = AuctionItem.deserialize().ConvertAll(el => (IIdentifiable) el);
                } else {
                    elements = AuctionClient.deserialize().ConvertAll(el => (IIdentifiable)el);
                }

                if (elements.Count > 0) {
                    bool found = false;

                    foreach (IIdentifiable el in elements) {
                        if (el.Id == id_num.Value) {
                            found = true;
                            break;
                        }
                    }

                    if(!found) {
                        if(type == For.AuctionItem)
                            errorProvider.SetError(id_num, LocaleJSON["error_item_id_not_exists"]);
                        else
                            errorProvider.SetError(id_num, LocaleJSON["error_client_id_not_exists"]);
                        return false;
                    }
                }
            }

            errorProvider.SetError(id_num, null);
            return true;
        }

        private void delete_btn_Click(object sender, EventArgs e) {
            Submit();
        }

        public void localize() {
            switch (type) {
                case For.AuctionItem:
                    deleteTitle.Text = LocaleJSON["item_form_title"];
                    idLabel.Text = LocaleJSON["item_id_label"];
                    break;
                case For.AuctionClient:
                    deleteTitle.Text = LocaleJSON["client_form_title"];
                    idLabel.Text = LocaleJSON["client_id_title"];
                    break;
            }

            submit_btn.Text = LocaleJSON["submit_button"];

            if (!main.LocalizedForms.Contains(this))
                main.LocalizedForms.Add(this);
        }
    }
}
