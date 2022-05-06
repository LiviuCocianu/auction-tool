using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace Auction_Tool {
    partial class MainForm {
        private bool cereWorkPath() {
            while(true) {
                FolderBrowserDialog dial = new FolderBrowserDialog();
                dial.Description = "Înainte de a folosi aplicația, selectează locația unde vrei să salvezi datele." +
                    " Vei fi rugat să faci acest lucru de fiecare dată când deschizi aplicația!";

                DialogResult res = dial.ShowDialog();
                if (res == DialogResult.OK) {
                    WorkPath = dial.SelectedPath;
                    return true;
                } else if (res == DialogResult.Cancel) {
                    DialogResult errRes = MessageBox.Show("Aplicația nu poate fi folosită fără o locație pentru date! " +
                        "Vă rugăm să introduceți locația!",
                        "Eroare", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                    if (errRes == DialogResult.Cancel) {
                        return false;
                    }
                }
            }
        }

        public bool areWorkPath() {
            return !string.IsNullOrEmpty(WorkPath);
        }

        public void reseteazaAfisareArticol() {
            idArticol_out.Text = "Indisponibil";
            denumArticol_out.Text = "Indisponibil";
            descArticol_link.Tag = null;
            pretBaza_out.Text = "Indisponibil";
            pretCurent_out.Text = "Indisponibil";
            nrClientTop_out.Text = "Indisponibil";

            toolTip1.RemoveAll();

            ascundeListaClienti();

            fotoArticol_pb.Image = Properties.Resources.no_image;
            fotoArticol_pb.InitialImage = Properties.Resources.no_image;
        }

        public void afiseazaArticol(Articol art) {
            idArticol_out.Text = art.Id.ToString();
            denumArticol_out.Text = 
                $"{(art.Nume.Length > 21 ? art.Nume.Substring(0, 22) : art.Nume)}" +
                $"{(art.Nume.Length > 22 ? "..." : "")}";
            descArticol_link.Tag = art;
            pretBaza_out.Text = $"{art.PretBaza} lei";
            pretCurent_out.Text = "0 lei";
            nrClientTop_out.Text = "În curând";
            toolTip1.SetToolTip(denumArticol_out, art.Nume);
            if (art.Descriere.Length < 65)
                toolTip1.SetToolTip(descArticol_link, art.Descriere);

            arataListaClienti();

            if (!string.IsNullOrEmpty(art.URLfoto)) {
                var request = WebRequest.Create(art.URLfoto);
                try {
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream()) {
                        fotoArticol_pb.Image = Image.FromStream(stream);
                    }
                } catch (WebException) {
                    MessageBox.Show("Nu s-a putut conecta la internet. Articolul va fi încărcat fără imagine",
                        "Avertisment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void seteazaArticoleToolbar() {
            if (File.Exists($"{WorkPath}\\items.dat")) {
                List<Articol> articole = Articol.deserializeaza();

                if (articole.Count() > 0) {
                    for (int i = 0; i < articole.Count; i++) {
                        Articol articol = articole.ElementAt(i);
                        adaugaOptiuneArticol(articol);
                    }
                }

                Articol.Cache.Articole.AddRange(articole);
            }
        }

        public void refreshArticoleToolbar() {
            itemTB_load.DropDownItems.Clear();
            seteazaArticoleToolbar();
        }

        public void adaugaOptiuneArticol(Articol articol) {
            ToolStripMenuItem art = new ToolStripMenuItem();
            int index = itemTB_load.DropDownItems.Count + 1;

            art.Name = $"itemTB_item{index}";
            art.Text = $"{index}. {articol.Nume}";
            art.ForeColor = Color.Black;
            art.Size = new Size(180, 22);
            art.Image = global::Auction_Tool.Properties.Resources.individual_load;
            art.Tag = articol;
            art.Click += new EventHandler(itemTB_itemn_Click);

            itemTB_load.DropDownItems.Add(art);
        }

        public void seteazaListaClienti() {
            if (File.Exists($"{WorkPath}\\clients.dat")) {
                List<ClientLicitatie> clienti = ClientLicitatie.deserializeaza();

                if (clienti.Count() > 0) {
                    for (int i = clienti.Count - 1; i >= 0; i--) {
                        ClientLicitatie client = clienti.ElementAt(i);
                        adaugaElementClient(i + 1, client);
                    }
                }

                ClientLicitatie.Cache.Clienti.AddRange(clienti);
            }
        }

        public void refreshListaClienti() {
            clientList_panel.Controls.Clear();
            seteazaListaClienti();
        }

        public void adaugaElementClient(ClientLicitatie client) {
            adaugaElementClient(clientList_panel.Controls.Count + 1, client);
        }

        public void adaugaElementClient(int index, ClientLicitatie client) {
            TableLayoutPanel elem = new TableLayoutPanel();

            elem.BackColor = Color.WhiteSmoke;
            elem.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

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
                Name = $"clientNrElem{index}",
                Text = $"{client.Numar}",
                Anchor = AnchorStyles.None,
                TextAlign = ContentAlignment.MiddleCenter
            });

            elem.Controls.Add(new Label() {
                Name = $"clientNumeElem{index}",
                Text = $"{client.Nume}",
                Anchor = AnchorStyles.None,
                TextAlign = ContentAlignment.MiddleCenter
            });

            elem.Controls.Add(new Label() {
                Name = $"clientPrenumeElem{index}",
                Text = $"{client.Prenume}",
                Anchor = AnchorStyles.None,
                TextAlign = ContentAlignment.MiddleCenter
            });

            elem.Controls.Add(new Label() {
                Name = $"clientPretElem{index}",
                Text = $"{client.PretLicitat}",
                Anchor = AnchorStyles.None,
                TextAlign = ContentAlignment.MiddleCenter
            });

            elem.Controls.Add(new Label() {
                Name = $"clientSumaElem{index}",
                Text = $"{client.SumaDisponibila}",
                Anchor = AnchorStyles.None,
                TextAlign = ContentAlignment.MiddleCenter
            });

            elem.ColumnCount = elem.ColumnStyles.Count;
            elem.Cursor = Cursors.Hand;
            elem.Dock = DockStyle.Top;
            elem.Location = new Point(0, 0);
            elem.Name = $"clientElement{index}";
            elem.RowCount = 1;
            elem.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            elem.Size = new Size(498, 32);
            elem.TabIndex = 0;

            elem.ContextMenuStrip = clientElement_context;

            clientList_panel.Controls.Add(elem);
        }

        public void arataListaClienti() {
            if (!listaClientiVisibila()) {
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

        public void ascundeListaClienti() {
            if (listaClientiVisibila()) {
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

        public bool listaClientiVisibila() {
            return Controls.ContainsKey("clientList_panel");
        }
    }
}
