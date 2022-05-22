using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auction_Tool {
    public partial class ClientBetForm : Form, ISubmitter {
        private MainForm main;
        private ClientLicitatie client;

        public ClientBetForm(MainForm main, ClientLicitatie client) {
            this.main = main;
            this.client = client;
            InitializeComponent();

            currentSum.Text = $"Sumă propusă anterior: {client.PretLicitat} lei";
            sumaDisp.Text = $"Sumă disponibilă (buget): {client.SumaDisponibila} lei";
        }

        public void Submit() {
            if(checkValidity()) {
                float sumaNoua = float.Parse(sumaNoua_tb.Text);
                client.PretLicitat = sumaNoua;
                client.seteazaClientCache();
                main.refreshListaClienti(true);

                main.Licitatie.seteazaSumaTop(sumaNoua);
                main.Licitatie.seteazaClientTop(client);

                Close();
            }
        }

        public bool checkValidity() {
            return sumaValid();
        }

        private bool sumaValid() {
            float suma;
            bool converted = float.TryParse(sumaNoua_tb.Text, out suma);

            if (!converted || float.IsNaN(suma) || float.IsInfinity(suma)) {
                errorProvider.SetError(sumaNoua_tb, "Acest câmp nu conține un număr rațional pozitiv");
                return false;
            } else if (suma < 0) {
                errorProvider.SetError(sumaNoua_tb, "Suma nouă nu poate fi mai mică decât 0");
                return false;
            } else if (suma <= main.articolAfisat().PretBaza) {
                errorProvider.SetError(sumaNoua_tb, "Suma nouă trebuie să fie mai mare decat prețul de bază al articolului");
                return false;
            } else if (suma <= client.PretLicitat) {
                errorProvider.SetError(sumaNoua_tb, "Suma nouă trebuie să fie mai mare decât suma propriu propusă anterior");
                return false;
            } else if (suma <= main.Licitatie.sumaPropusaTop()) {
                errorProvider.SetError(sumaNoua_tb, "Suma nouă trebuie să fie mai mare decât suma propusă de ceilalți clienți");
                return false;
            } else if (suma > client.SumaDisponibila) {
                errorProvider.SetError(sumaNoua_tb, "Suma nouă nu se află în bugetul clientului");
                return false;
            } else {
                errorProvider.SetError(sumaNoua_tb, null);
                return true;
            }
        }

        private void submit_btn_Click(object sender, EventArgs e) {
            Submit();
        }
    }
}
