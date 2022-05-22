using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Auction_Tool {
    [Serializable]
    public class AuctionClient : IIdentifiable {
        private int id;
        private string firstName;
        private string lastName;
        private int auctionNumber;
        private float auctionBudget;
        private ClientHistory auctionHistory;
        private bool savesHistory;
        [NonSerialized]
        private float bidPrice;

        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int AuctionNumber { get => auctionNumber; set => auctionNumber = value; }
        public float AuctionBudget { get => auctionBudget; set => auctionBudget = value; }
        public ClientHistory AuctionHistory { get => auctionHistory; set => auctionHistory = value; }
        public bool SavesHistory { get => savesHistory; set => savesHistory = value; }
        public float BidPrice { get => bidPrice; set => bidPrice = value; }

        public AuctionClient(string firstName, string lastName, int auctionNumber,
            float auctionBudget, ClientHistory auctionHistory) 
        {
            Id = Utils.generateUniqueID(For.AuctionClient, 10000);
            FirstName = firstName;
            LastName = lastName;
            AuctionNumber = auctionNumber;
            AuctionBudget = auctionBudget;
            AuctionHistory = auctionHistory;
            SavesHistory = auctionHistory != null; 
        }

        public void serialize() {
            BinaryFormatter bf = new BinaryFormatter();
            List<AuctionClient> list = deserialize();

            using (Stream stream = new FileStream(
                $"{MainForm.WorkPath}\\clients.dat",
                FileMode.OpenOrCreate, FileAccess.Write,
                FileShare.None)
            ) {
                list.Add(this);
                bf.Serialize(stream, list);
            }
        }

        public static List<AuctionClient> deserialize() {
            BinaryFormatter bf = new BinaryFormatter();
            List<AuctionClient> list = new List<AuctionClient>();

            using (Stream stream = new FileStream(
                $"{MainForm.WorkPath}\\clients.dat",
                FileMode.OpenOrCreate, FileAccess.Read,
                FileShare.Read)
            ) {
                if (stream.Length > 0) {
                    list = (List<AuctionClient>) bf.Deserialize(stream);
                }
            }

            return list;
        }

        public static void serializeBulk(List<AuctionClient> list) {
            BinaryFormatter bf = new BinaryFormatter();

            using (Stream stream = new FileStream(
                $"{MainForm.WorkPath}\\clients.dat",
                FileMode.OpenOrCreate, FileAccess.Write,
                FileShare.None)
            ) {
                bf.Serialize(stream, list);
            }
        }

        public static AuctionClient find(int id) {
            if (Cache.Collection.Count > 0) {
                foreach (AuctionClient cli in Cache.Collection) {
                    if (cli.Id == id)
                        return cli;
                }

                return null;
            } else return null;
        }

        public static void delete(int id) {
            List<AuctionClient> clients = deserialize();

            if (clients.Count > 0) {
                foreach (AuctionClient cli in clients) {
                    if (cli.Id == id) {
                        Cache.Collection.RemoveAt(clients.IndexOf(cli));
                        clients.Remove(cli);

                        break;
                    }
                }

                serializeBulk(clients);
            }
        }

        public List<AuctionClient> saveThis() {
            List<AuctionClient> clients = deserialize();

            if (clients.Count > 0) {
                bool found = false;

                for (int i = 0; i < clients.Count; i++) {
                    if (clients[i].Id == Id) {
                        found = true;
                        clients[i] = this;
                        break;
                    }
                }

                if (found) serializeBulk(clients);
            }

            return clients;
        }

        /*
         * RO:
         * Setează clientul dat la același indice din baza de date după ID. 
         * 
         * Prin urmare, este imposibilă modificarea ID-ului clientului
         * clientului prin această metodă întrucât este necesar pentru
         * a afla indicele din care a provenit modificarea!
         * 
         * EN:
         * Sets this client to the same database index by ID.
         * 
         * Therefore, modifying the client's ID using this method is
         * impossible because it's required for finding the index
         * where the modification originates from!
         */
        public void saveThisInCache() {
            List<AuctionClient> clienti = Cache.Collection;

            if (clienti.Count > 0) {
                bool found = false;

                for (int i = 0; i < clienti.Count; i++) {
                    if (clienti[i].Id == Id) {
                        found = true;
                        clienti[i] = this;
                        break;
                    }
                }

                if (found) Cache.Collection = clienti;
            }
        }

        public static void deleteAll() {
            string path = $"{MainForm.WorkPath}\\clients.dat";

            if (File.Exists(path)) {
                File.Delete(path);
            }

            Cache.Collection.Clear();
        }


        public static class Cache {
            private static List<AuctionClient> clients = new List<AuctionClient>();

            public static List<AuctionClient> Collection {
                get { return clients; }
                set { clients = value; }
            }
        }
    }
}
