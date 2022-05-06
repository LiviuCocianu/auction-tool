using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Auction_Tool {
    public partial class DeleteByIdForm : Form, ISubmitter {
        private MainForm main;
        private For tip;

        public DeleteByIdForm(MainForm main, For tip) {
            InitializeComponent();
            this.main = main;
            this.tip = tip;

            switch(tip) {
                case For.Articol:
                    this.Text = "Elimină articol";
                    deleteTitle.Text = "Elimină articol după ID";
                    idLabel.Text = "ID articol";
                    delete_btn.Text = "Elimină articol";
                    break;
                case For.ClientLicitatie:
                    this.Text = "Elimină client";
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

                if (tip == For.Articol)
                    Articol.stergeArticol(id);
                else if (tip == For.ClientLicitatie)
                    ClientLicitatie.stergeClient(id);

                DialogResult res = MessageBox.Show($"{(tip == For.Articol ? "Articolul" : "Clientul")} " +
                    $"cu ID-ul {id} a fost eliminat", tip == For.Articol ? "Articol eliminat" : "Client eliminat",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (res == DialogResult.OK || res == DialogResult.Cancel) {
                    this.Close();

                    if(tip == For.Articol) {
                        main.refreshArticoleToolbar();

                        // Dacă articolul dat spre ștergere era în mod curent pe ecran
                        // atunci resetăm câmpurile cu informații
                        if (int.Parse(main.idArticol_out.Text) == id)
                            main.reseteazaAfisareArticol();
                    } else if(tip == For.ClientLicitatie) {
                        main.refreshListaClienti();
                    }
                }
            }
        }

        private bool idValid() {
            string filePath = tip == For.Articol ? "items.dat" : "clients.dat";

            if (File.Exists($"{MainForm.WorkPath}\\{filePath}")) {
                List<IIdentifiable> elemente;

                if(tip == For.Articol) {
                    elemente = Articol.deserializeaza().ConvertAll(el => (IIdentifiable) el);
                } else {
                    elemente = ClientLicitatie.deserializeaza().ConvertAll(el => (IIdentifiable)el);
                }

                if (elemente.Count > 0) {
                    bool found = false;

                    foreach (IIdentifiable el in elemente) {
                        if (el.Id == id_num.Value) {
                            found = true;
                            break;
                        }
                    }

                    if(!found) {
                        errorProvider.SetError(id_num, $"Acest ID nu aparține niciunui {(tip == For.Articol ? "articol" : "client")}");
                        return false;
                    }
                }
            }

            errorProvider.SetError(id_num, null);
            return true;
        }

        private void button1_Click(object sender, EventArgs e) {
            Submit();
        }
    }
}
