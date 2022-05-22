using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auction_Tool {
    public class Auction {
        private MainForm main;

        public Auction(MainForm main) { 
            this.main = main;
        }

        public void start() {
            MessageBox.Show("Licitația a început!", "Licitație", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void stop() {

        }

        public void reset() {

        }

        public void seteazaSumaTop(float sum) {
            main.sumaCurenta_out.Text = $"{sum} lei";
            main.sumaCurenta_out.Tag = sum;
        }

        public float sumaPropusaTop() {
            return (float)main.sumaCurenta_out.Tag;
        }

        public void seteazaClientTop(ClientLicitatie client) {
            main.nrClientTop_out.Text = client.Numar.ToString();
            main.nrClientTop_out.Tag = client;
        }

        public ClientLicitatie getClientTop() {
            if (main.nrClientTop_out.Tag == null) return null;
            return (ClientLicitatie)main.nrClientTop_out.Tag;
        }
    }
}
