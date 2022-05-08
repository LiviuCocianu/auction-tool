using System;
using System.Windows.Forms;

namespace Auction_Tool {
    public partial class EditByIdForm : Form, ISubmitter {
        private MainForm main;
        private For tip;
        private Action<Articol> postSubmitArt;
        private Action<ClientLicitatie> postSubmitClient;

        private int selectedID;

        public EditByIdForm(MainForm main, For tip) {
            InitializeComponent();
            this.main = main;
            this.tip = tip;
            selectedID = 0;

            switch (tip) {
                case For.Articol:
                    Text = "Caută articol";
                    search_title.Text = "Caută articol după ID";
                    cauta_lv_nume.Text = "Nume articol";
                    search_btn.Text = "Caută articol";

                    foreach(Articol art in Articol.deserializeaza()) {
                        cauta_lv.Items.Add(new ListViewItem(new string[] {
                            art.Id.ToString(), art.Nume
                        }));
                    }
                    break;
                case For.ClientLicitatie:
                    Text = "Caută client";
                    search_title.Text = "Caută client după ID";
                    cauta_lv_nume.Text = "Nume client";
                    search_btn.Text = "Caută client";

                    foreach (ClientLicitatie cli in ClientLicitatie.deserializeaza()) {
                        cauta_lv.Items.Add(new ListViewItem(new string[] {
                            cli.Id.ToString(), $"{cli.Nume} {cli.Prenume}"
                        }));
                    }
                    break;
            }
        }

        /**
         * Folosește delegatul Action pentru a executa o acțiune cu articolul pasat
         * ulterior după ce s-a dat submit
         */
        public EditByIdForm(MainForm main, Action<Articol> afterSubmition) : this(main, For.Articol) {
            postSubmitArt = afterSubmition;
        }

        public EditByIdForm(MainForm main, Action<ClientLicitatie> afterSubmition) : this(main, For.ClientLicitatie) {
            postSubmitClient = afterSubmition;
        }

        public bool checkValidity() {
            return true;
        }

        public void Submit() {
            if(checkValidity()) {
                switch(tip) {
                    case For.Articol:
                        postSubmitArt.Invoke(Articol.gasesteArticol(selectedID));
                        break;
                    case For.ClientLicitatie:
                        postSubmitClient.Invoke(ClientLicitatie.gasesteClient(selectedID));
                        break;
                }

                Close();
            }
        }

        private void search_btn_Click(object sender, EventArgs e) {
            Submit();
        }

        private void cauta_lv_Click(object sender, EventArgs e) {
            selectedID = int.Parse(cauta_lv.SelectedItems[0].SubItems[0].Text);
            selectedId.Text = $"ID selectat: {selectedID}";
        }
    }
}
