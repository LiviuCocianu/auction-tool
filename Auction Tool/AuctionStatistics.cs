using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction_Tool {
    public class AuctionStatistics {
        private DateTime auctionStart;
        private DateTime auctionEnd;
        private int auctionItemID;
        private int totalClients;
        private float activityRate;
        private float highestBet;
        private float totalBiddingMoney;
        private float bidStandardDeviation;

        public DateTime AuctionStart { get => auctionStart; set => auctionStart = value; }
        public DateTime AuctionEnd { get => auctionEnd; set => auctionEnd = value; }
        public int AuctionItemID { get => auctionItemID; set => auctionItemID = value; }
        public int TotalClients { get => totalClients; set => totalClients = value; }
        public float ActivityRate { get => activityRate; set => activityRate = value; }
        public float HighestBet { get => highestBet; set => highestBet = value; }
        public float TotalBiddingMoney { get => totalBiddingMoney; set => totalBiddingMoney = value; }
        public float BidStandardDeviation { get => bidStandardDeviation; set => bidStandardDeviation = value; }

        private AuctionStatistics(
                DateTime auctionStart,
                int auctionItemID,
                int totalClients,
                float activityRate,
                float highestBet,
                float totalBiddingMoney,
                float bidStandardDeviation
            ) {
            this.AuctionStart = auctionStart;
            this.AuctionEnd = DateTime.Now;
            this.AuctionItemID = auctionItemID;
            this.TotalClients = totalClients;
            this.ActivityRate = activityRate;
            this.HighestBet = highestBet;
            this.TotalBiddingMoney = totalBiddingMoney;
            this.BidStandardDeviation = bidStandardDeviation;
        }

        public static AuctionStatistics generateStatistics(Auction instance) {
            IEnumerable<AuctionClient> activeClients = AuctionClient.Cache.Collection.Where(cl => cl.BidPrice > 0);

            int auctionItemID = instance.MainInstance.getDisplayedItem().Id;
            int totalClients = AuctionClient.Cache.Collection.Count;
            float activityRate = totalClients == 0 ? 0 : activeClients.Count() / totalClients;
            float highestBet = instance.HighestBet;
            float totalBiddingMoney = activeClients.Aggregate(0f, (a, b) => a + b.BidPrice);
            float bidStdDev = Utils.stdDev(AuctionClient.Cache.Collection.Select(cl => cl.BidPrice).ToArray());

            return new AuctionStatistics(
                    instance.AuctionStartTime,
                    auctionItemID,
                    totalClients,
                    activityRate,
                    highestBet,
                    totalBiddingMoney,
                    bidStdDev
                );
        }
    }
}
