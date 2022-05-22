using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Auction_Tool {
    public partial class DeleteByIdForm : Form, ISubmitter {
        private MainForm main;
        private For type;

        public DeleteByIdForm(MainForm main, For type) {
            InitializeComponent();
            this.main = main;
            this.type = type;

            switch(type) {
                case For.AuctionItem:
                    Text = "Elimină articol";
                    deleteTitle.Text = "Elimină articol după ID";
                    idLabel.Text = "ID articol";
                    delete_btn.Text = "Elimină articol";
                    break;
                case For.AuctionClient:
                    Text = "Elimină client";
                    deleteTitle.Text = "Elimină client după ID";
                    idLabel.Text = "ID client";
                    delete_btn.Text = "Elimină client";
                    break;
            }
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

                DialogResult res = MessageBox.Show($"{(type == For.AuctionItem ? "Articolul" : "Clientul")} " +
                    $"cu ID-ul {id} a fost eliminat", type == For.AuctionItem ? "Articol eliminat" : "Client eliminat",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (res == DialogResult.OK || res == DialogResult.Cancel) {
                    this.Close();

                    if(type == For.AuctionItem) {
                        main.refreshToolbarItems();

                        // Dacă articolul dat spre ștergere era în mod curent pe ecran
                        // atunci resetăm câmpurile cu informații
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
                        errorProvider.SetError(id_num, $"Acest ID nu aparține niciunui {(type == For.AuctionItem ? "articol" : "client")}");
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
    }
}
