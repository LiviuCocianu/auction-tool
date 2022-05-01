using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction_Tool {
    /**
     * Pentru clase cu câmpuri ID-uri unice
     */
    public interface IIdentifiable {
        int Id { get; set; }
    }
}
