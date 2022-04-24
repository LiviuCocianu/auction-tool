using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace Proiect_PAW {
    public partial class MainForm : Form {
        private static string workPath;
        public static string WorkPath {
            get { return workPath; }
            set { workPath = value; }
        }

        public MainForm() {
            cereWorkPath();
            InitializeComponent();
            seteazaArticoleToolbar();

            toolTip1.SetToolTip(denumArticol_out, "Indisponibil");
        }

        /*
        var request = WebRequest.Create("http://www.gravatar.com/avatar/6810d91caff032b202c50701dd3af745?d=identicon&r=PG");

        using (var response = request.GetResponse())
        using (var stream = response.GetResponseStream()) {
            pictureBox1.Image = Bitmap.FromStream(stream);
        }
        */

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e) {

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

        private void textBox1_MouseClick(object sender, MouseEventArgs e) {
            this.clientSearch_tb.Text = "";
        }

        private void textBox1_MouseDoubleClick(object sender, MouseEventArgs e) {
            this.clientSearch_tb.Text = "";
        }

        private void textBox1_Leave(object sender, EventArgs e) {
            this.clientSearch_tb.Text = "Caută ID client..";
        }

        private void textBox1_MouseLeave(object sender, EventArgs e) {
            if (this.clientSearch_tb.Text.Equals(""))
                this.clientSearch_tb.Text = "Caută ID client..";
        }

        private void textBox1_MouseEnter(object sender, EventArgs e) {
            if (this.clientSearch_tb.Text.Equals("Caută ID client.."))
                this.clientSearch_tb.Text = "";
        }

        private void itemToolStripMenuItem_Click_1(object sender, EventArgs e) {
            CreateItemForm create = new CreateItemForm(this);
            create.Show();
        }

        public void itemTB_itemn_Click(object sender, EventArgs e) {
            ToolStripMenuItem clicked = (ToolStripMenuItem) sender;

            if (clicked.Tag != null) {
                Articol art = (Articol) (clicked.Tag);
                idArticol_out.Text = art.Id.ToString();
                denumArticol_out.Text = $"{art.Nume.Substring(0, 22)}" +
                    $"{(art.Nume.Length > 22 ? "..." : "")}";
                descArticol_link.Tag = art;
                pretBaza_out.Text = $"{art.PretBaza} lei";
                pretCurent_out.Text = "0 lei";
                nrClientTop_out.Text = "În curând";
                toolTip1.SetToolTip(denumArticol_out, art.Nume);
                if(art.Descriere.Length < 65) 
                    toolTip1.SetToolTip(descArticol_link, art.Descriere);

                arataListaClienti();

                if (!string.IsNullOrEmpty(art.URLfoto)) {
                    var request = WebRequest.Create(art.URLfoto);

                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream()) {
                        fotoArticol_pb.Image = Image.FromStream(stream);
                    }
                }
            }
        }

        private void descArticol_link_Click(object sender, EventArgs e) {
            Label clicked = (Label)sender;
            if(clicked.Tag != null) {
                Articol curent = (Articol)clicked.Tag;
                MessageBox.Show(curent.Descriere, "Descriere", MessageBoxButtons.OK);
            }
        }
    }
}
