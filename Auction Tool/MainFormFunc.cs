using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace Auction_Tool {
    partial class MainForm {
        private bool promptWorkpath() {
            LocaleJSON = Utils.getJsonLang(defaultLang, LocaleFileName);

            while (true) {
                FolderBrowserDialog dial = new FolderBrowserDialog();
                dial.Description = LocaleJSON["prompt_workpath_message"];

                DialogResult choice = dial.ShowDialog();

                if (choice == DialogResult.OK) {
                    WorkPath = dial.SelectedPath;
                    return true;
                } else if (choice == DialogResult.Cancel) {
                    DialogResult errChoice = MessageBox.Show(LocaleJSON["required_workpath_error"],
                        LocaleJSON["dialog_error"], MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                    if (errChoice == DialogResult.Cancel) {
                        return false;
                    }
                }
            }
        }

        public bool workpathProvided() {
            return !string.IsNullOrEmpty(WorkPath);
        }

        public void displayNoItem() {
            auctionItemID_out.Text = LocaleJSON["info_unavailable"];
            auctionItemName_out.Text = LocaleJSON["info_unavailable"];
            auctionItemDesc_link.Tag = null;
            basePrice_out.Text = LocaleJSON["info_unavailable"];
            highestBid_out.Text = LocaleJSON["info_unavailable"];
            highestBid_out.Tag = 0f;
            topBidderNo_out.Text = LocaleJSON["info_unavailable"];
            topBidderNo_out.Tag = null;

            toolTip1.RemoveAll();

            hideClientList();
            hideAuctionTimer();

            itemImage_pb.Image = Properties.Resources.no_image;
            itemImage_pb.InitialImage = Properties.Resources.no_image;
        }

        public AuctionItem getDisplayedItem() {
            if (auctionItemDesc_link.Tag == null) return null;
            return (AuctionItem)auctionItemDesc_link.Tag;
        }

        public void displayItem(AuctionItem art) {
            auctionItemID_out.Text = art.Id.ToString();
            auctionItemName_out.Text = 
                $"{(art.Name.Length > 16 ? art.Name.Substring(0, 16 + 1) : art.Name)}" +
                $"{(art.Name.Length > 16 ? "..." : "")}";
            auctionItemDesc_link.Tag = art;
            basePrice_out.Text = $"{art.BasePrice} {LocaleJSON["currency_unit"]}";
            highestBid_out.Text = $"0 {LocaleJSON["currency_unit"]}";
            topBidderNo_out.Text = LocaleJSON["info_soon"];
            toolTip1.SetToolTip(auctionItemName_out, art.Name);
            if (art.Description.Length < 65)
                toolTip1.SetToolTip(auctionItemDesc_link, art.Description);

            showClientList();
            showAuctionTimer();

            if (!string.IsNullOrEmpty(art.ImageURL)) {
                var request = WebRequest.Create(art.ImageURL);
                try {
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream()) {
                        itemImage_pb.Image = Image.FromStream(stream);
                    }
                } catch (WebException) {
                    MessageBox.Show(LocaleJSON["load_item_without_internet"],
                        LocaleJSON["dialog_warning"], MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } else {
                itemImage_pb.Image = Properties.Resources.no_image;
            }
        }

        private void updateToolbarItems() {
            if (File.Exists($"{WorkPath}\\items.dat")) {
                List<AuctionItem> articole = AuctionItem.deserialize();

                if (articole.Count() > 0) {
                    for (int i = 0; i < articole.Count; i++) {
                        AuctionItem articol = articole.ElementAt(i);
                        addItemToToolbar(articol);
                    }
                }

                AuctionItem.Cache.Collection.AddRange(articole);
            }
        }

        public void refreshToolbarItems() {
            itemsTB_load.DropDownItems.Clear();
            updateToolbarItems();
        }

        public void addItemToToolbar(AuctionItem item) {
            ToolStripMenuItem tsmItem = new ToolStripMenuItem();
            int index = itemsTB_load.DropDownItems.Count + 1;

            tsmItem.Name = $"itemTB_item{index}";
            tsmItem.Text = $"{index}. {item.Name}";
            tsmItem.ForeColor = Color.Black;
            tsmItem.Size = new Size(180, 22);
            tsmItem.Image = Properties.Resources.individual_load;
            tsmItem.Tag = item;
            tsmItem.Click += new EventHandler(toolbarItemElement_Click);

            itemsTB_load.DropDownItems.Add(tsmItem);
        }

        public bool isItemDisplayed(AuctionItem articol) {
            if (auctionItemDesc_link.Tag == null) return false;
            return ((AuctionItem)auctionItemDesc_link.Tag).Id == articol.Id;
        }

        public bool isAnyItemDisplayed() {
            return auctionItemDesc_link.Tag != null;
        }

        /*
         * RO:
         * Seteaza clienții în lista din dreapta
         * 
         * cache - Dacă clienții vor fi luați din cache sau din fișier
         *      Dacă este false, clienții din fișier vor fi resetați în cache
         *      Dacă este true, se va citi din cache fără alte acțiuni
         * 
         * EN:
         * Updates the client list on the right
         * 
         * cache - If the clients are read from cache or from the database
         *      If false, the file clients will be updated in cache
         *      If true, clients will be read from cache and nothing else
         */
        public void updateClientList(bool cache) {
            List<AuctionClient> clients;

            if (!cache) {
                if (File.Exists($"{WorkPath}\\clients.dat")) {
                    clients = AuctionClient.deserialize();

                    if (clients.Count() > 0) {
                        for (int i = clients.Count - 1; i >= 0; i--) {
                            AuctionClient client = clients.ElementAt(i);
                            addClientToList(i + 1, client);
                        }
                    }

                    AuctionClient.Cache.Collection.AddRange(clients);
                }
            } else {
                clients = AuctionClient.Cache.Collection;

                if (clients.Count() > 0) {
                    for (int i = clients.Count - 1; i >= 0; i--) {
                        AuctionClient client = clients.ElementAt(i);
                        addClientToList(i + 1, client);
                    }
                }
            }
        }

        public void refreshClientList(bool cache) {
            clientList_panel.Controls.Clear();
            updateClientList(cache);
        }

        public void showClientSearchResults(string searchText) {
            clientList_panel.Controls.Clear();

            AuctionClient.Cache.Collection.ForEach(client => {
                if(client.AuctionNumber.ToString().Contains(searchText)) {
                    addClientToList(client);
                }
            });
        }

        public void addClientToList(AuctionClient client) {
            addClientToList(clientList_panel.Controls.Count + 1, client);
        }

        public void addClientToList(int index, AuctionClient client) {
            TableLayoutPanel elem = new TableLayoutPanel {
                BackColor = Color.WhiteSmoke,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
            };

            elem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, clientElemPercs[0]));
            elem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, clientElemPercs[1]));
            elem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, clientElemPercs[2]));
            elem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, clientElemPercs[3]));
            elem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, clientElemPercs[4]));
            elem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, clientElemPercs[5]));
            elem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, clientElemPercs[6]));

            elem.Controls.Add(new Label() {
                Name = $"clientIndexElem{index}",
                Text = $"{index}",
                Anchor = AnchorStyles.None,
                TextAlign = ContentAlignment.MiddleCenter
            });

            elem.Controls.Add(new Label() {
                Name = $"clientIdElem{index}",
                Text = $"{client.Id}",
                Anchor = AnchorStyles.None,
                TextAlign = ContentAlignment.MiddleCenter
            });

            elem.Controls.Add(new Label() {
                Name = $"clientNoElem{index}",
                Text = $"{client.AuctionNumber}",
                Anchor = AnchorStyles.None,
                TextAlign = ContentAlignment.MiddleCenter
            });

            elem.Controls.Add(new Label() {
                Name = $"clientFirstNameElem{index}",
                Text = $"{client.FirstName}",
                Anchor = AnchorStyles.None,
                TextAlign = ContentAlignment.MiddleCenter
            });

            elem.Controls.Add(new Label() {
                Name = $"clientLastNameElem{index}",
                Text = $"{client.LastName}",
                Anchor = AnchorStyles.None,
                TextAlign = ContentAlignment.MiddleCenter
            });

            elem.Controls.Add(new Label() {
                Name = $"clientBidPriceElem{index}",
                Text = $"{client.BidPrice}",
                Anchor = AnchorStyles.None,
                TextAlign = ContentAlignment.MiddleCenter
            });

            elem.Controls.Add(new Label() {
                Name = $"clientBudgetElem{index}",
                Text = $"{(client.AuctionBudget == float.MaxValue ? "-" : client.AuctionBudget.ToString())}",
                Anchor = AnchorStyles.None,
                TextAlign = ContentAlignment.MiddleCenter
            });

            elem.ColumnCount = elem.ColumnStyles.Count;
            elem.Dock = DockStyle.Top;
            elem.Location = new Point(0, 0);
            elem.Name = $"clientElement{index}";
            elem.RowCount = 1;
            elem.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            elem.Size = new Size(498, 32);
            elem.TabIndex = 0;

            Label clientIdLabel = (Label) elem.Controls.Find($"clientIdElem{index}", false)[0];
            clientIdLabel.MouseEnter += new EventHandler(clientElementn_MouseEnter);
            clientIdLabel.MouseLeave += new EventHandler(clientElementn_MouseLeave);
            clientIdLabel.ContextMenuStrip = clientElement_ctx;
            clientIdLabel.Tag = client;
            clientIdLabel.Cursor = Cursors.Hand;

            clientList_panel.Controls.Add(elem);
        }

        public void showAuctionTimer() {
            auctionTimer.Show();
        }

        public void hideAuctionTimer() {
            auctionTimer.Hide();
        }

        public void showClientList() {
            if (!isClientListVisible()) {
                clientListHeader_tlp.SuspendLayout();
                Controls.Add(clientListHeader_tlp);
                clientListHeader_tlp.ResumeLayout(false);

                clientList_panel.SuspendLayout();
                Controls.Add(clientList_panel);
                clientList_panel.ResumeLayout(false);

                clientSearch_tlp.SuspendLayout();
                Controls.Add(clientSearch_tlp);
                clientSearch_tlp.ResumeLayout(false);

                preItemSelect_pan.Visible = false;
            }
        }

        public void hideClientList() {
            if (isClientListVisible()) {
                clientListHeader_tlp.SuspendLayout();
                Controls.Remove(clientListHeader_tlp);
                clientListHeader_tlp.ResumeLayout(false);

                clientList_panel.SuspendLayout();
                Controls.Remove(clientList_panel);
                clientList_panel.ResumeLayout(false);

                clientSearch_tlp.SuspendLayout();
                Controls.Remove(clientSearch_tlp);
                clientSearch_tlp.ResumeLayout(false);

                preItemSelect_pan.Visible = true;
            }
        }

        public bool isClientListVisible() {
            return Controls.ContainsKey("clientList_panel");
        }

        /*
         * RO: Trece limba întregii aplicații la limba dată prin parametru
         * EN: Shifts the application language to the given lang
         */
        public void shiftAllLocalesTo(Lang lang) {
            defaultLang = lang;
            foreach(ILocalizable locale in LocalizedForms) {
                // RO: Preia translațiile pentru noua limbă
                // EN: Load the translations for the new language
                locale.LocaleJSON = Utils.getJsonLang(lang, locale.LocaleFileName);
                locale.localize();
            }
        }

        public void localize() {
            Text = LocaleJSON["app_title"];
            // File toolbar translation
            fileToolbar.Text = LocaleJSON["toolbar_file"];
            fileTB_create.Text = LocaleJSON["toolbar_file_create"];
            fileTB_create_item.Text = LocaleJSON["toolbar_file_item"];
            fileTB_create_client.Text = LocaleJSON["toolbar_file_client"];
            fileTB_remove.Text = LocaleJSON["toolbar_file_remove"];
            fileTB_remove_item.Text = LocaleJSON["toolbar_file_item"];
            fileTB_remove_client.Text = LocaleJSON["toolbar_file_client"];
            fileTB_remove_item_all.Text = LocaleJSON["toolbar_file_remove_all_items"];
            fileTB_remove_item_ID.Text = LocaleJSON["toolbar_file_remove_by_id"];
            fileTB_remove_client_all.Text = LocaleJSON["toolbar_file_remove_all_clients"];
            fileTB_remove_client_ID.Text = LocaleJSON["toolbar_file_remove_by_id"];
            fileTB_edit.Text = LocaleJSON["toolbar_file_edit"];
            fileTB_edit_item.Text = LocaleJSON["toolbar_file_item"];
            fileTB_edit_client.Text = LocaleJSON["toolbar_file_client"];
            langToolbar.Text = LocaleJSON["toolbar_language"];
            langTB_RO.Text = LocaleJSON["toolbar_language_ro"];
            langTB_EN.Text = LocaleJSON["toolbar_language_en"];

            // Context menu text
            cli_ctx_remove.Text = LocaleJSON["context_remove"];
            cli_ctx_edit.Text = LocaleJSON["context_edit"];
            cli_ctx_bid.Text = LocaleJSON["context_bid"];

            // Items toolbar translation
            itemsToolbar.Text = LocaleJSON["toolbar_items"];
            itemsTB_load.Text = LocaleJSON["toolbar_items_load"];

            // Auction toolbar translation
            auctionToolbar.Text = LocaleJSON["toolbar_auction"];
            auctionTB_stop.Text = LocaleJSON["toolbar_auction_stop"];
            auctionTB_reset.Text = LocaleJSON["toolbar_auction_reset"];
            auctionTB_finish.Text = LocaleJSON["toolbar_auction_finish"];

            // Info panels translation
            generalInfo_title.Text = LocaleJSON["general_info_title"];
            auctionItemID.Text = $"{LocaleJSON["general_info_item_id"]}:";
            auctionItemName.Text = $"{LocaleJSON["general_info_item_name"]}:";
            auctionItemDesc.Text = $"{LocaleJSON["general_info_item_description"]}:";
            auctionItemDesc_link.Text = LocaleJSON["info_view"];
            auctionInfo_title.Text = LocaleJSON["auction_info_title"];
            basePrice.Text = $"{LocaleJSON["auction_info_base_price"]}:";
            highestBid.Text = $"{LocaleJSON["auction_info_highest_bid"]}:";
            topBidderNo.Text = $"{LocaleJSON["auction_info_top_client"]}:";

            if(!isAnyItemDisplayed()) {
                auctionItemID_out.Text = LocaleJSON["info_unavailable"];
                auctionItemName_out.Text = LocaleJSON["info_unavailable"];
                basePrice_out.Text = LocaleJSON["info_unavailable"];
                highestBid_out.Text = LocaleJSON["info_unavailable"];
                topBidderNo_out.Text = LocaleJSON["info_unavailable"];
            }

            // Item selection guide translation
            preItemSelect1.Text = LocaleJSON["item_preselectMessage1"];
            preItemSelect2.Text = LocaleJSON["item_preselectMessage2"];

            // Client list translation
            clientSearch_tb.Text = LocaleJSON["client_searchbox_placeholder"];
            searchPlaceholder = LocaleJSON["client_searchbox_placeholder"];
            tableIndexNo.Text = LocaleJSON["client_list_index"];
            tableClientID.Text = LocaleJSON["client_list_id"];
            tableAuctionNumber.Text = LocaleJSON["client_list_auction_number"];
            tableClientFirstName.Text = LocaleJSON["client_list_first_name"];
            tableClientLastName.Text = LocaleJSON["client_list_last_name"];
            tableClientBidAmount.Text = LocaleJSON["client_list_bid_amount"];
            tableClientBudget.Text = LocaleJSON["client_list_budget"];

            if(!LocalizedForms.Contains(this))
                LocalizedForms.Add(this);
        }
    }
}
