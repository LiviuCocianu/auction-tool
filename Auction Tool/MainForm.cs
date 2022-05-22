using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Auction_Tool {
    public partial class MainForm : Form, ILocalizable {
        private float[] clientElemPercs;

        private string searchPlaceholder;

        private static string workPath = "";
        private Auction auctionInstance;
        private Lang defaultLang = Lang.RO;
        private Dictionary<string, string> langJson;

        public static string WorkPath {
            get { return workPath; }
            set { workPath = value; }
        }

        public Auction AuctionInstance {
            get { return auctionInstance; }
            set { auctionInstance = value; }
        }

        public Lang DefaultLang {
            get { return defaultLang; }
            set { defaultLang = value; }
        }

        private Dictionary<string, string> LangJSON {
            get { return langJson; }
            set { langJson = value; }
        }

        private AuctionClient selectedClient;

        public MainForm() {
            bool succes = promptWorkpath();
            AuctionInstance = new Auction(this);

            InitializeComponent();

            // RO: Tradu textele din aplicație în limba implicită
            // EN: Translate the app texts in the default language 
            localize(defaultLang);

            searchPlaceholder = LangJSON["client_searchbox_placeholder"];

            /*
             * RO:
             * Coloanele de tabel din elementele listei de clienti se vor
             * ajusta după lățimea capului de tabel al listei
             * 
             * EN:
             * The client list elements' table columns will adjust
             * relative to the list header's width
             */
            clientElemPercs = new float[7] {
                    clientListHeader_tlp.ColumnStyles[0].Width,
                    clientListHeader_tlp.ColumnStyles[1].Width,
                    clientListHeader_tlp.ColumnStyles[2].Width,
                    clientListHeader_tlp.ColumnStyles[3].Width,
                    clientListHeader_tlp.ColumnStyles[4].Width,
                    clientListHeader_tlp.ColumnStyles[5].Width,
                    clientListHeader_tlp.ColumnStyles[6].Width,
            };

            updateToolbarItems();
            updateClientList(false);

            toolTip1.SetToolTip(auctionItemName_out, LangJSON["info_unavailable"]);

            if (!succes) Close();
        }

        private void fileToolbar_Click(object sender, EventArgs e) {
            this.fileToolbar.ForeColor = Color.Black;
        }

        private void fileToolbar_DropDownClosed(object sender, EventArgs e) {
            this.fileToolbar.ForeColor = Color.White;
        }

        private void fileToolbar_MouseLeave(object sender, EventArgs e) {
            this.fileToolbar.ForeColor = Color.White;
        }

        private void fileToolbar_MouseHover(object sender, EventArgs e) {
            this.fileToolbar.ForeColor = Color.Black;
        }

        private void itemsToolbar_Click(object sender, EventArgs e) {
            this.itemsToolbar.ForeColor = Color.Black;
        }

        private void itemsToolbar_DropDownClosed(object sender, EventArgs e) {
            this.itemsToolbar.ForeColor = Color.White;
        }

        private void itemsToolbar_MouseLeave(object sender, EventArgs e) {
            this.itemsToolbar.ForeColor = Color.White;
        }

        private void itemsToolbar_MouseHover(object sender, EventArgs e) {
            this.itemsToolbar.ForeColor = Color.Black;
        }

        private void clientSearch_tb_MouseClick(object sender, MouseEventArgs e) {
            this.clientSearch_tb.Text = "";
        }

        private void clientSearch_tb_MouseDoubleClick(object sender, MouseEventArgs e) {
            this.clientSearch_tb.Text = "";
        }

        private void clientSearch_tb_Leave(object sender, EventArgs e) {
            this.clientSearch_tb.Text = searchPlaceholder;
        }

        private void clientSearch_tb_MouseLeave(object sender, EventArgs e) {
            if (this.clientSearch_tb.Text.Equals(""))
                this.clientSearch_tb.Text = searchPlaceholder;
        }

        private void clientSearch_tb_MouseEnter(object sender, EventArgs e) {
            if (this.clientSearch_tb.Text.Equals(searchPlaceholder))
                this.clientSearch_tb.Text = "";
        }

        private void fileCreateItem_Click(object sender, EventArgs e) {
            CreateEditItemForm create = new CreateEditItemForm(this, Operation.Create);
            create.Show();
        }

        public void toolbarItemElement_Click(object sender, EventArgs e) {
            ToolStripMenuItem clicked = (ToolStripMenuItem)sender;

            if (clicked.Tag != null) {
                AuctionItem item = (AuctionItem)(clicked.Tag);
                displayItem(item);
            }
        }

        private void auctionItemDescription_link_Click(object sender, EventArgs e) {
            Label clicked = (Label)sender;

            if (clicked.Tag != null) {
                AuctionItem curent = (AuctionItem)clicked.Tag;
                MessageBox.Show(curent.Description, LangJSON["dialog_description_title"], MessageBoxButtons.OK);
            }
        }

        private void fileCreateClient_Click(object sender, EventArgs e) {
            CreateEditClientForm ccf = new CreateEditClientForm(this);
            ccf.Show();
        }

        private void clientSearch_tb_KeyPress(object sender, KeyPressEventArgs e) {
            if (clientSearch_tb.Text.Equals(searchPlaceholder)) {
                clientSearch_tb.Text = "";
            }
        }

        private void fileRemoveItem_Click(object sender, EventArgs e) {
            DeleteByIdForm del = new DeleteByIdForm(this, For.AuctionItem);
            del.Show();
        }

        private void fileRemoveAllItems_Click(object sender, EventArgs e) {
            DialogResult choice = MessageBox.Show(LangJSON["dialog_remove_all_items"],
                LangJSON["dialog_warning"], MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (choice == DialogResult.Yes) {
                if(!File.Exists($"{WorkPath}\\items.dat")) {
                    MessageBox.Show(LangJSON["dialog_no_items_remove"], LangJSON["dialog_error"],
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                AuctionItem.deleteAll();

                DialogResult res = MessageBox.Show(LangJSON["dialog_items_removed"], LangJSON["dialog_info"],
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (res == DialogResult.OK || res == DialogResult.Cancel) {
                    refreshToolbarItems();
                    displayNoItem();
                }
            }
        }

        private void fileRemoveItemID_Click(object sender, EventArgs e) {
            DeleteByIdForm del = new DeleteByIdForm(this, For.AuctionClient);
            del.Show();
        }

        private void fileRemoveClientID_Click(object sender, EventArgs e) {
            DialogResult choice = MessageBox.Show(LangJSON["dialog_remove_all_clients"],
                LangJSON["dialog_warning"], MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (choice == DialogResult.Yes) {
                if (!File.Exists($"{WorkPath}\\clients.dat")) {
                    MessageBox.Show(LangJSON["dialog_no_clients_remove"], LangJSON["dialog_error"],
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                AuctionClient.deleteAll();

                DialogResult choiceTwo = MessageBox.Show(LangJSON["dialog_clients_removed"], LangJSON["dialog_info"],
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (choiceTwo == DialogResult.OK || choiceTwo == DialogResult.Cancel) {
                    refreshClientList(false);
                }
            }
        }

        private void clientElementn_MouseEnter(object sender, EventArgs e) {
            Control con = (Control)sender;
            selectedClient = (AuctionClient) con.Tag;
            con.BackColor = Color.PaleTurquoise;
        }

        private void clientElementn_MouseLeave(object sender, EventArgs e) {
            Control con = (Control)sender;
            con.BackColor = Color.WhiteSmoke;
        }

        private void contextRemoveItem_Click(object sender, EventArgs e) {
            AuctionClient.delete(selectedClient.Id);

            DialogResult choice = MessageBox.Show(
                LangJSON["dialog_client_removed_id"].Replace("%id%", selectedClient.Id.ToString()),
                LangJSON["dialog_info"],
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (choice == DialogResult.OK || choice == DialogResult.Cancel) {
                refreshClientList(false);
            }
        }

        private void fileEditItem_Click(object sender, EventArgs e) {
            /*
             * RO:
             * Apeleaza această acțiune după ce utilizatorul a introdus
             * un ID de articol și a trecut prin validări
             * 
             * EN:
             * Call this action after the user provided an item ID
             * and the validations were successful
             */
            Action<AuctionItem> after = (art) => {
                CreateEditItemForm edit = new CreateEditItemForm(this, art);
                edit.Show();
            };

            // RO: Solicită un ID de articol
            // EN: Prompt an item ID
            EditByIdForm requestID = new EditByIdForm(this, after);
            requestID.Show();
        }

        private void contextEditItem_Click(object sender, EventArgs e) {
            CreateEditClientForm edit = new CreateEditClientForm(this, selectedClient);
            edit.Show();
        }

        private void fileEditClient_Click(object sender, EventArgs e) {
            Action<AuctionClient> after = (cli) => {
                CreateEditClientForm edit = new CreateEditClientForm(this, cli);
                edit.Show();
            };

            EditByIdForm requestID = new EditByIdForm(this, after);
            requestID.Show();
        }

        private void contextBet_Click(object sender, EventArgs e) {
            ClientBetForm bet = new ClientBetForm(this, selectedClient);
            bet.Show();
        }

        private void auctionTB_stop_Click(object sender, EventArgs e) {
            AuctionInstance.stop();
        }

        private void auctionTB_reset_Click(object sender, EventArgs e) {
            AuctionInstance.reset();
        }

        public void localize(Lang lang) {
            Dictionary<string, string> json = Utils.getJsonLang(lang, "main_form");
            LangJSON = json;

            fileToolbar.Text = json["toolbar_file"];
            fileTB_create.Text = json["toolbar_file_create"];
            fileTB_create_item.Text = json["toolbar_file_item"];
            fileTB_create_client.Text = json["toolbar_file_client"];
            fileTB_remove.Text = json["toolbar_file_remove"];
            fileTB_remove_item.Text = json["toolbar_file_item"];
            fileTB_remove_client.Text = json["toolbar_file_client"];
            fileTB_remove_item_all.Text = json["toolbar_file_remove_all_items"];
            fileTB_remove_item_ID.Text = json["toolbar_file_remove_by_id"];
            fileTB_remove_client_all.Text = json["toolbar_file_remove_all_clients"];
            fileTB_remove_client_ID.Text = json["toolbar_file_remove_by_id"];
            fileTB_edit.Text = json["toolbar_file_edit"];
            fileTB_edit_item.Text = json["toolbar_file_item"];
            fileTB_edit_client.Text = json["toolbar_file_client"];
            generalInfo_title.Text = json["general_info_title"];
            auctionItemID.Text = $"{json["general_info_item_id"]}: {json["info_unavailable"]}";
            auctionItemName.Text = $"{json["general_info_item_name"]}: {json["info_unavailable"]}";
            auctionItemDesc.Text = $"{json["general_info_item_description"]}: ";
            auctionItemDesc_link.Text = json["info_view"];
            auctionInfo_title.Text = json["auction_info_title"];
            basePrice.Text = $"{json["auction_info_base_price"]}: {json["info_unavailable"]}";
            highestBid.Text = $"{json["auction_info_highest_bid"]}: {json["info_unavailable"]}";
            topBidderNo.Text = $"{json["auction_info_top_client"]}: {json["info_unavailable"]}";
            preItemSelect1.Text = json["item_preselectMessage1"];
            preItemSelect2.Text = json["item_preselectMessage2"];
        }
    }
}
