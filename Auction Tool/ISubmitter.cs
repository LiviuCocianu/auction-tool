using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction_Tool {
    interface ISubmitter {
        void Submit();
        bool checkValidity();
    }
}
