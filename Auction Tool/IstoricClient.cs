using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction_Tool {
    [Serializable]
    public class IstoricClient {
        private string timestamp, numeArticol;
        private float pretMaximLicitat;
        private bool castigat;

        public string Timestamp {
            get { return timestamp; }
            set { timestamp = value; }
        }

        public string NumeArticol {
            get { return numeArticol; }
            set { numeArticol = value; }
        }

        public float PretMaximLicitat {
            get { return pretMaximLicitat; }
            set { pretMaximLicitat = value; }
        }

        public bool aCastigat {
            get { return castigat; }
            set { castigat = value; }
        }
    }
}
