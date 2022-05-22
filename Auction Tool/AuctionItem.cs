using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Auction_Tool {
    [Serializable]
    public class AuctionItem : IIdentifiable {
        private int id;
        private string name;
        private string description;
        private float basePrice;
        private string imageUrl;

        public AuctionItem(string name, string description, float basePrice, string imageUrl) {
            Id = Utils.generateUniqueID(For.AuctionItem, 10000);
            Name = name;
            Description = description;
            BasePrice = basePrice;
            ImageURL = imageUrl;
        }

        public int Id {
            get { return id; }
            set { id = value; }
        }

        public string Name {
            get { return name; }
            set { name = value; }
        }

        public string Description {
            get { return description; }
            set { description = value; }
        }

        public float BasePrice {
            get { return basePrice; }
            set {
                if (value > 0) basePrice = value;
            }
        }

        public string ImageURL {
            get { return imageUrl; }
            set {
                if(value != null) imageUrl = value; 
            }
        }

        public void serialize() {
            BinaryFormatter bf = new BinaryFormatter();
            List<AuctionItem> list = deserialize();

            using (Stream stream = new FileStream(
                $"{MainForm.WorkPath}\\items.dat",
                FileMode.OpenOrCreate, FileAccess.Write,
                FileShare.None)
            ) {
                list.Add(this);
                bf.Serialize(stream, list);
            }
        }

        public static void serializeBulk(List<AuctionItem> list) {
            BinaryFormatter bf = new BinaryFormatter();

            using (Stream stream = new FileStream(
                $"{MainForm.WorkPath}\\items.dat",
                FileMode.OpenOrCreate, FileAccess.Write,
                FileShare.None)
            ) {
                bf.Serialize(stream, list);
            }
        }

        public static List<AuctionItem> deserialize() {
            BinaryFormatter bf = new BinaryFormatter();
            List<AuctionItem> list = new List<AuctionItem>();

            using (Stream stream = new FileStream(
                $"{MainForm.WorkPath}\\items.dat",
                FileMode.OpenOrCreate, FileAccess.Read,
                FileShare.Read)
            ) {
                if (stream.Length > 0) {
                    list = (List<AuctionItem>)bf.Deserialize(stream);
                }
            }

            return list;
        }

        public static AuctionItem find(int id) {
            if (Cache.Collection.Count > 0) {
                foreach (AuctionItem art in Cache.Collection) {
                    if (art.Id == id) 
                        return art;
                }

                return null;
            } else return null;
        }

        public static void delete(int id) {
            List<AuctionItem> articole = deserialize();

            if (articole.Count > 0) {
                foreach (AuctionItem art in articole) {
                    if (art.Id == id) {
                        Cache.Collection.RemoveAt(articole.IndexOf(art));
                        articole.Remove(art);
                        
                        break;
                    }
                }

                serializeBulk(articole);
            }
        }

        /*
         * RO:
         * Setează acest articol la același indice din fișierul serializat,
         * numit și "baza de date".
         * Returnează lista de articole cu schimbarea.
         * 
         * Articolul TREBUIE să-și aibă existența verificată în baza de date.
         * Funcția nu va face nimic dacă articolul nu există în aceasta
         * 
         * EN:
         * Sets this item at the same serialized file index,
         * also known as "the database".
         * Returns the item list containing the changes.
         * 
         * The item MUST be existence-checked in the database.
         * The function won't do anything if the item doesn't exist in it
         */
        public List<AuctionItem> saveThis() {
            List<AuctionItem> articole = deserialize();

            if (articole.Count > 0) {
                bool found = false;

                for (int i = 0; i < articole.Count; i++) {
                    if (articole[i].Id == Id) {
                        found = true;
                        articole[i] = this;
                        break;
                    }
                }

                if(found) serializeBulk(articole);
            }

            return articole;
        }

        public static void deleteAll() {
            string path = $"{MainForm.WorkPath}\\items.dat";

            if (File.Exists(path)) {
                File.Delete(path);
            }

            Cache.Collection.Clear();
        }

        public static class Cache {
            private static List<AuctionItem> items = new List<AuctionItem>();

            public static List<AuctionItem> Collection {
                get { return items; }
                set { items = value; }
            }
        }
    }
}
