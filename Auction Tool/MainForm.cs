using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Auction_Tool {
    public partial class MainForm : Form {
        private float[] clientElemPercs;

        private const string searchPlaceholder = "Caută ID client..";

        private static string workPath = "";
        public static string WorkPath {
            get { return workPath; }
            set { workPath = value; }
        }

        private ClientLicitatie clientSelectat;

        public MainForm() {
            bool succes = cereWorkPath();

            InitializeComponent();

            // Coloanele de tabel din elementele listei de clienti se vor
            // ajusta după lățimea capului de tabel al listei
            clientElemPercs = new float[7] {
                    clientListHeader_tlp.ColumnStyles[0].Width,
                    clientListHeader_tlp.ColumnStyles[1].Width,
                    clientListHeader_tlp.ColumnStyles[2].Width,
                    clientListHeader_tlp.ColumnStyles[3].Width,
                    clientListHeader_tlp.ColumnStyles[4].Width,
                    clientListHeader_tlp.ColumnStyles[5].Width,
                    clientListHeader_tlp.ColumnStyles[6].Width,
                };

            seteazaArticoleToolbar();
            seteazaListaClienti();

            toolTip1.SetToolTip(denumArticol_out, "Indisponibil");

            if (!succes) Close();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e) {
            this.editToolbar.ForeColor = Color.Black;
        }

        private void testToolStripMenuItem_DropDownClosed(object sender, EventArgs e) {
            this.editToolbar.ForeColor = Color.White;
        }

        private void testToolStripMenuItem_MouseLeave(object sender, EventArgs e) {
            this.editToolbar.ForeColor = Color.White;
        }

        private void testToolStripMenuItem_MouseHover(object sender, EventArgs e) {
            this.editToolbar.ForeColor = Color.Black;
        }

        private void itemToolStripMenuItem_Click(object sender, EventArgs e) {
            this.itemToolbar.ForeColor = Color.Black;
        }

        private void itemToolStripMenuItem_DropDownClosed(object sender, EventArgs e) {
            this.itemToolbar.ForeColor = Color.White;
        }

        private void itemToolStripMenuItem_MouseLeave(object sender, EventArgs e) {
            this.itemToolbar.ForeColor = Color.White;
        }

        private void itemToolStripMenuItem_MouseHover(object sender, EventArgs e) {
            this.itemToolbar.ForeColor = Color.Black;
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

        private void itemToolStripMenuItem_Click_1(object sender, EventArgs e) {
            CreateEditItemForm create = new CreateEditItemForm(this, Operatie.Creare);
            create.Show();
        }

        public void itemTB_itemn_Click(object sender, EventArgs e) {
            ToolStripMenuItem clicked = (ToolStripMenuItem)sender;

            if (clicked.Tag != null) {
                Articol art = (Articol)(clicked.Tag);
                afiseazaArticol(art);
            }
        }

        private void descArticol_link_Click(object sender, EventArgs e) {
            Label clicked = (Label)sender;
            if (clicked.Tag != null) {
                Articol curent = (Articol)clicked.Tag;
                MessageBox.Show(curent.Descriere, "Descriere", MessageBoxButtons.OK);
            }
        }

        private void editTB_create_client_Click(object sender, EventArgs e) {
            CreateClientForm ccf = new CreateClientForm(this);
            ccf.Show();
        }

        private void clientSearch_tb_KeyPress(object sender, KeyPressEventArgs e) {
            if (clientSearch_tb.Text.Equals(searchPlaceholder)) {
                clientSearch_tb.Text = "";
            }
        }

        private void editTB_remove_item_ID_Click(object sender, EventArgs e) {
            DeleteByIdForm del = new DeleteByIdForm(this, For.Articol);
            del.Show();
        }

        private void editTB_remove_item_all_Click(object sender, EventArgs e) {
            DialogResult alegere = MessageBox.Show("Sigur vrei să elimini toate articolele? Odată eliminate, nu vor " +
                "mai putea fi recuperate", "Avertisment", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (alegere == DialogResult.Yes) {
                if(!File.Exists($"{WorkPath}\\items.dat")) {
                    MessageBox.Show("Nu există articole de eliminat", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Articol.stergeTot();

                DialogResult res = MessageBox.Show("Toate articolele au fost eliminate!", "Articole eliminate",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (res == DialogResult.OK || res == DialogResult.Cancel) {
                    refreshArticoleToolbar();
                    reseteazaAfisareArticol();
                }
            }
        }

        private void editTB_remove_client_ID_Click(object sender, EventArgs e) {
            DeleteByIdForm del = new DeleteByIdForm(this, For.ClientLicitatie);
            del.Show();
        }

        private void editTB_remove_client_all_Click(object sender, EventArgs e) {
            DialogResult alegere = MessageBox.Show("Sigur vrei să elimini toate datele clienților? Odată eliminate, nu vor " +
                "mai putea fi recuperate", "Avertisment", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (alegere == DialogResult.Yes) {
                if (!File.Exists($"{WorkPath}\\clients.dat")) {
                    MessageBox.Show("Nu există clienți de eliminat", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ClientLicitatie.stergeTot();

                DialogResult res = MessageBox.Show("Toate datele clienților au fost eliminate!", "Date clienți eliminate",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (res == DialogResult.OK || res == DialogResult.Cancel) {
                    refreshListaClienti();
                }
            }
        }

        private void clientElementn_MouseEnter(object sender, EventArgs e) {
            Control con = (Control)sender;
            clientSelectat = (ClientLicitatie) con.Tag;
            con.BackColor = Color.PaleTurquoise;
        }

        private void clientElementn_MouseLeave(object sender, EventArgs e) {
            Control con = (Control)sender;
            con.BackColor = Color.WhiteSmoke;
        }

        private void stergereToolStripMenuItem_Click(object sender, EventArgs e) {
            ClientLicitatie.stergeClient(clientSelectat.Id);

            DialogResult res = MessageBox.Show($"Clientul " +
                $"cu ID-ul {clientSelectat.Id} a fost eliminat", "Client eliminat",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (res == DialogResult.OK || res == DialogResult.Cancel) {
                refreshListaClienti();
            }
        }

        private void articolToolStripMenuItem_Click(object sender, EventArgs e) {
            /*
             * Apeleaza această funcție lambda după ce utilizatorul a introdus
             * ID-ul articolului și a trecut prin validări
             */
            Action<Articol> after = (art) => {
                CreateEditItemForm edit = new CreateEditItemForm(this, art);
                edit.Show();
            };

            // Solicită ID-ul articolului care va urma să fie editat
            EditByIdForm requestID = new EditByIdForm(this, after);
            requestID.Show();
        }
    }
}
