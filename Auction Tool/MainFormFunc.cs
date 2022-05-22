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
            while(true) {
                FolderBrowserDialog dial = new FolderBrowserDialog();
                dial.Description = "Înainte de a folosi aplicația, selectează locația unde vrei să salvezi datele." +
                    " Vei fi rugat să faci acest lucru de fiecare dată când deschizi aplicația!";

                DialogResult choice = dial.ShowDialog();

                if (choice == DialogResult.OK) {
                    WorkPath = dial.SelectedPath;
                    return true;
                } else if (choice == DialogResult.Cancel) {
                    DialogResult errChoice = MessageBox.Show("Aplicația nu poate fi folosită fără o locație pentru date! " +
                        "Vă rugăm să introduceți locația!",
                        "Eroare", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

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
            auctionItemID_out.Text = "Indisponibil";
            auctionItemName_out.Text = "Indisponibil";
            auctionItemDesc_link.Tag = null;
            basePrice_out.Text = "Indisponibil";
            highestBid_out.Text = "Indisponibil";
            highestBid_out.Tag = 0f;
            topBidderNo_out.Text = "Indisponibil";
            topBidderNo_out.Tag = null;

            toolTip1.RemoveAll();

            hideClientList();

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
                $"{(art.Name.Length > 21 ? art.Name.Substring(0, 22) : art.Name)}" +
                $"{(art.Name.Length > 22 ? "..." : "")}";
            auctionItemDesc_link.Tag = art;
            basePrice_out.Text = $"{art.BasePrice} lei";
            highestBid_out.Text = "0 lei";
            topBidderNo_out.Text = "În curând";
            toolTip1.SetToolTip(auctionItemName_out, art.Name);
            if (art.Description.Length < 65)
                toolTip1.SetToolTip(auctionItemDesc_link, art.Description);

            showClientList();

            if (!string.IsNullOrEmpty(art.ImageURL)) {
                var request = WebRequest.Create(art.ImageURL);
                try {
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream()) {
                        itemImage_pb.Image = Image.FromStream(stream);
                    }
                } catch (WebException) {
                    MessageBox.Show("Nu s-a putut conecta la internet. Articolul va fi încărcat fără imagine",
                        "Avertisment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            AuctionInstance.start();
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
            itemTB_load.DropDownItems.Clear();
            updateToolbarItems();
        }

        public void addItemToToolbar(AuctionItem item) {
            ToolStripMenuItem tsmItem = new ToolStripMenuItem();
            int index = itemTB_load.DropDownItems.Count + 1;

            tsmItem.Name = $"itemTB_item{index}";
            tsmItem.Text = $"{index}. {item.Name}";
            tsmItem.ForeColor = Color.Black;
            tsmItem.Size = new Size(180, 22);
            tsmItem.Image = Properties.Resources.individual_load;
            tsmItem.Tag = item;
            tsmItem.Click += new EventHandler(toolbarItemElement_Click);

            itemTB_load.DropDownItems.Add(tsmItem);
        }

        public bool isItemDisplayed(AuctionItem articol) {
            if (auctionItemDesc_link.Tag == null) return false;
            return ((AuctionItem)auctionItemDesc_link.Tag).Id == articol.Id;
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

        public void adaugaElementClient(AuctionClient client) {
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
    }
}
