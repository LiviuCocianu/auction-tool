using System;

namespace Auction_Tool {
    [Serializable]
    public class ClientHistory {
        private string timestamp, itemName;
        private float highestBid;
        private bool hasWon;

        public string Timestamp {
            get { return timestamp; }
            set { timestamp = value; }
        }

        public string ItemName {
            get { return itemName; }
            set { itemName = value; }
        }

        public float HighestBid {
            get { return highestBid; }
            set { highestBid = value; }
        }

        public bool HasWon {
            get { return hasWon; }
            set { hasWon = value; }
        }
    }
}
