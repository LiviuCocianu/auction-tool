using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Auction_Tool {
    public partial class MainForm : Form, ILocalizable {
        private float[] clientElemPercs;

        // Class-specific variables
        private static List<ILocalizable> localizedForms = new List<ILocalizable>();
        private string searchPlaceholder;
        private static string workPath = "";
        private Auction auctionInstance;

        // Locale-specific variables
        private Lang defaultLang;
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

        public string LocaleFileName { get => "main_form"; }

        public Dictionary<string, string> LocaleJSON {
            get { return langJson; }
            set { langJson = value; }
        }

        public List<ILocalizable> LocalizedForms {
            get { return localizedForms; }
            set { localizedForms = value; }
        }

        private AuctionClient selectedClient;

        public MainForm(Lang lang) : base() {
            DefaultLang = lang;
        }

        public MainForm() {
            DefaultLang = Lang.EN;

            // RO: Verificăm dacă localele sunt sincronizate
            // EN: Check if locales are in sync
            Tuple<bool, string> validation = Utils.areLocalesInSync();
            if (!validation.Item1) {
                throw new Exception($"Language file paths for file '{validation.Item2}' are not equal to each other." +
                    $"\nCheck all language folders for this file and if their JSON keys are equal");
            }

            bool succes = promptWorkpath();
            AuctionInstance = new Auction(this);
            
            InitializeComponent();

            // RO: Tradu textele din aplicație în limba implicită
            // EN: Translate the app texts in the default language 
            localize();

            searchPlaceholder = LocaleJSON["client_searchbox_placeholder"];

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

            toolTip1.SetToolTip(auctionItemName_out, LocaleJSON["info_unavailable"]);

            if (!succes) Close();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            bool pressed = false;

            switch(keyData) {
                case (Keys.Shift | Keys.S):
                    pressed = true;
                    if (isAnyItemDisplayed())
                        AuctionInstance.stop();
                    else
                        MessageBox.Show(LocaleJSON["dialog_no_auction"], LocaleJSON["dialog_error"],
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case (Keys.Shift | Keys.R):
                    pressed = true;
                    if (isAnyItemDisplayed())
                        AuctionInstance.reset();
                    else
                        MessageBox.Show(LocaleJSON["dialog_no_auction"], LocaleJSON["dialog_error"],
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case (Keys.Shift | Keys.F):
                    pressed = true;
                    if (isAnyItemDisplayed())
                        AuctionInstance.finish();
                    else
                        MessageBox.Show(LocaleJSON["dialog_no_auction"], LocaleJSON["dialog_error"],
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            return pressed;
        }

        // File toolbar text colors
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

        // Items toolbar text colors
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

        // Auction toolbar text colors
        private void auctionToolbar_Click(object sender, EventArgs e) {
            this.auctionToolbar.ForeColor = Color.Black;
        }

        private void auctionToolbar_DropDownClosed(object sender, EventArgs e) {
            this.auctionToolbar.ForeColor = Color.White;
        }

        private void auctionToolbar_MouseLeave(object sender, EventArgs e) {
            this.auctionToolbar.ForeColor = Color.White;
        }

        private void auctionToolbar_MouseHover(object sender, EventArgs e) {
            this.auctionToolbar.ForeColor = Color.Black;
        }

        // Language toolbar text colors
        private void langToolbar_Click(object sender, EventArgs e) {
            this.langToolbar.ForeColor = Color.Black;
        }

        private void langToolbar_DropDownClosed(object sender, EventArgs e) {
            this.langToolbar.ForeColor = Color.White;
        }

        private void langToolbar_MouseLeave(object sender, EventArgs e) {
            this.langToolbar.ForeColor = Color.White;
        }

        private void langToolbar_MouseHover(object sender, EventArgs e) {
            this.langToolbar.ForeColor = Color.Black;
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
                AuctionInstance.start();
            }
        }

        private void auctionItemDescription_link_Click(object sender, EventArgs e) {
            Label clicked = (Label)sender;

            if (clicked.Tag != null) {
                AuctionItem curent = (AuctionItem)clicked.Tag;
                MessageBox.Show(curent.Description, LocaleJSON["dialog_description_title"], MessageBoxButtons.OK);
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
            DialogResult choice = MessageBox.Show(LocaleJSON["dialog_remove_all_items"],
                LocaleJSON["dialog_warning"], MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (choice == DialogResult.Yes) {
                if(!File.Exists($"{WorkPath}\\items.dat")) {
                    MessageBox.Show(LocaleJSON["dialog_no_items_remove"], LocaleJSON["dialog_error"],
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                AuctionItem.deleteAll();

                DialogResult res = MessageBox.Show(LocaleJSON["dialog_items_removed"], LocaleJSON["dialog_info"],
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
            DialogResult choice = MessageBox.Show(LocaleJSON["dialog_remove_all_clients"],
                LocaleJSON["dialog_warning"], MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (choice == DialogResult.Yes) {
                if (!File.Exists($"{WorkPath}\\clients.dat")) {
                    MessageBox.Show(LocaleJSON["dialog_no_clients_remove"], LocaleJSON["dialog_error"],
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                AuctionClient.deleteAll();

                DialogResult choiceTwo = MessageBox.Show(LocaleJSON["dialog_clients_removed"], LocaleJSON["dialog_info"],
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
                LocaleJSON["dialog_client_removed_id"].Replace("%id%", selectedClient.Id.ToString()),
                LocaleJSON["dialog_info"],
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
            if (isAnyItemDisplayed())
                AuctionInstance.stop();
            else
                MessageBox.Show(LocaleJSON["dialog_no_auction"], LocaleJSON["dialog_error"],
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void auctionTB_reset_Click(object sender, EventArgs e) {
            if (isAnyItemDisplayed())
                AuctionInstance.reset();
            else
                MessageBox.Show(LocaleJSON["dialog_no_auction"], LocaleJSON["dialog_error"],
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void auctionTB_finish_Click(object sender, EventArgs e) {
            if (isAnyItemDisplayed())
                AuctionInstance.finish();
            else
                MessageBox.Show(LocaleJSON["dialog_no_auction"], LocaleJSON["dialog_error"],
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void langTB_RO_Click(object sender, EventArgs e) {
            shiftAllLocalesTo(Lang.RO);

            MessageBox.Show(LocaleJSON["language_changed"], LocaleJSON["dialog_info"],
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void langTB_EN_Click(object sender, EventArgs e) {
            shiftAllLocalesTo(Lang.EN);

            MessageBox.Show(LocaleJSON["language_changed"], LocaleJSON["dialog_info"],
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void clientSearch_tb_TextChanged(object sender, EventArgs e) {
            if(string.IsNullOrEmpty(clientSearch_tb.Text)) {
                refreshClientList(true);
                return;
            }

            bool converted = int.TryParse(clientSearch_tb.Text, out int num);
            if (!converted) return;

            showClientSearchResults(num.ToString());
        }
    }
}
