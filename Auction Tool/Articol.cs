using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Auction_Tool {
    [Serializable]
    public class Articol : IIdentifiable {
        private int id;
        private string nume;
        private string descriere;
        private float pretBaza;
        private string urlFoto;

        public Articol(string nume, string descriere, float pretBaza, string urlFoto) {
            Id = Utils.genereazaIdUnic(For.Articol, 10000);
            Nume = nume;
            Descriere = descriere;
            PretBaza = pretBaza;
            URLfoto = urlFoto;
        }

        public int Id {
            get { return id; }
            set { id = value; }
        }

        public string Nume {
            get { return nume; }
            set { nume = value; }
        }

        public string Descriere {
            get { return descriere; }
            set { descriere = value; }
        }

        public float PretBaza {
            get { return pretBaza; }
            set {
                if (value > 0) pretBaza = value;
            }
        }

        public string URLfoto {
            get { return urlFoto; }
            set {
                if(value != null) urlFoto = value; 
            }
        }

        public void serializeaza() {
            BinaryFormatter bf = new BinaryFormatter();
            List<Articol> list = deserializeaza();

            using (Stream stream = new FileStream(
                $"{MainForm.WorkPath}\\items.dat",
                FileMode.OpenOrCreate, FileAccess.Write,
                FileShare.None)
            ) {
                list.Add(this);
                bf.Serialize(stream, list);
            }
        }

        public static void serializeazaTot(List<Articol> list) {
            BinaryFormatter bf = new BinaryFormatter();

            using (Stream stream = new FileStream(
                $"{MainForm.WorkPath}\\items.dat",
                FileMode.OpenOrCreate, FileAccess.Write,
                FileShare.None)
            ) {
                bf.Serialize(stream, list);
            }
        }

        public static List<Articol> deserializeaza() {
            BinaryFormatter bf = new BinaryFormatter();
            List<Articol> list = new List<Articol>();

            using (Stream stream = new FileStream(
                $"{MainForm.WorkPath}\\items.dat",
                FileMode.OpenOrCreate, FileAccess.Read,
                FileShare.Read)
            ) {
                if (stream.Length > 0) {
                    list = (List<Articol>)bf.Deserialize(stream);
                }
            }

            return list;
        }

        public static Articol gasesteArticol(int id) {
            if (Cache.Articole.Count > 0) {
                foreach (Articol art in Cache.Articole) {
                    if (art.Id == id) 
                        return art;
                }

                return null;
            } else return null;
        }

        public static void stergeArticol(int id) {
            List<Articol> articole = deserializeaza();

            if (articole.Count > 0) {
                foreach (Articol art in articole) {
                    if (art.Id == id) {
                        Cache.Articole.RemoveAt(articole.IndexOf(art));
                        articole.Remove(art);
                        
                        break;
                    }
                }

                serializeazaTot(articole);
            }
        }

        /*
         * Setează acest articol la același indice din fișierul serializat,
         * numit și "baza de date".
         * Returnează lista de articole cu schimbarea.
         * 
         * Articolul TREBUIE să-și aibă existența verificată în baza de date.
         * Funcția nu va face nimic dacă articolul nu există în aceasta
         */
        public List<Articol> seteazaArticol() {
            List<Articol> articole = deserializeaza();

            if (articole.Count > 0) {
                bool found = false;

                for (int i = 0; i < articole.Count; i++) {
                    if (articole[i].Id == Id) {
                        found = true;
                        articole[i] = this;
                        break;
                    }
                }

                if(found) serializeazaTot(articole);
            }

            return articole;
        }

        public static void stergeTot() {
            string path = $"{MainForm.WorkPath}\\items.dat";

            if (File.Exists(path)) {
                File.Delete(path);
            }

            Cache.Articole.Clear();
        }

        public static class Cache {
            private static List<Articol> articole = new List<Articol>();

            public static List<Articol> Articole {
                get { return articole; }
                set { articole = value; }
            }
        }
    }
}
