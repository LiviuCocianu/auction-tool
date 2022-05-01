using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Auction_Tool {
    partial class MainForm {
        private void cereWorkPath() {
            FolderBrowserDialog dial = new FolderBrowserDialog();
            dial.Description = "Înainte de a folosi aplicația, selectează locația unde vrei să salvezi datele." +
                " Vei fi rugat să faci acest lucru de fiecare dată când deschizi aplicația!";

            DialogResult res = dial.ShowDialog();
            if (res == DialogResult.OK) {
                WorkPath = dial.SelectedPath;
            }
        }

        private void seteazaArticoleToolbar() {
            if (File.Exists($"{WorkPath}\\items.dat")) {
                List<Articol> articole = Articol.deserialize();

                if (articole.Count() > 0) {
                    for (int i = 0; i < articole.Count; i++) {
                        Articol articol = articole.ElementAt(i);
                        adaugaOptiuneArticol(articol);
                    }
                }

                Articol.Cache.Articole.AddRange(articole);
            }
        }

        public void seteazaListaClienti() {
            if (File.Exists($"{WorkPath}\\clients.dat")) {
                List<ClientLicitatie> clienti = ClientLicitatie.deserialize();

                if (clienti.Count() > 0) {
                    for (int i = clienti.Count - 1; i >= 0; i--) {
                        ClientLicitatie client = clienti.ElementAt(i);
                        adaugaElementClient(i + 1, client);
                    }
                }

                ClientLicitatie.Cache.Clienti.AddRange(clienti);
            }
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
