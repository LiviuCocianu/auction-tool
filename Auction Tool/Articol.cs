using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Proiect_PAW {
    [Serializable]
    public class Articol {
        private int id;
        private string nume;
        private string descriere;
        private float pretBaza;
        private string urlFoto;

        public Articol(string nume, string descriere, float pretBaza, string urlFoto) {
            Random ran = new Random();
            int random = ran.Next(1, 10001);

            // Generam un ID unic
            while(true) {
                int check = random;

                foreach (Articol art in Cache.Articole) {
                    if (art.Id == random) {
                        random = ran.Next(1, 10001);
                        break;
                    }
                }

                if (check == random) break;
            }

            Id = random;
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

        public void serialize() {
            BinaryFormatter bf = new BinaryFormatter();
            List<Articol> list = deserialize();

            using (Stream stream = new FileStream(
                $"{MainForm.WorkPath}\\items.dat",
                FileMode.OpenOrCreate, FileAccess.Write,
                FileShare.None)
            ) {
                list.Add(this);

                bf.Serialize(stream, list);
            }
        }

        public static List<Articol> deserialize() {
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

        public static Articol gasesteArticol(string nume) {
            List<Articol> articole = deserialize();

            if (articole.Count > 0) {
                foreach (Articol art in articole) {
                    if (art.Nume == nume) 
                        return art;
                }

                return null;
            } else return null;
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
