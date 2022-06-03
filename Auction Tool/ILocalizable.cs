using System.Collections.Generic;

namespace Auction_Tool {
    public interface ILocalizable {
        string LocaleFileName { get; }
        Dictionary<string, string> LocaleJSON { get; set; }
        void localize();
    }
}
