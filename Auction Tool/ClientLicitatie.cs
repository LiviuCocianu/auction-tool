using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Auction_Tool {
    [Serializable]
    public class ClientLicitatie : IIdentifiable {
        private int id;
        private string nume;
        private string prenume;
        private int numar;
        private float sumaDisponibila;
        private IstoricClient istoricLicitatii;
        private bool salveazaIstoric;
        [NonSerialized]
        private float pretLicitat;

        public int Id { get => id; set => id = value; }
        public string Nume { get => nume; set => nume = value; }
        public string Prenume { get => prenume; set => prenume = value; }
        public int Numar { get => numar; set => numar = value; }
        public float SumaDisponibila { get => sumaDisponibila; set => sumaDisponibila = value; }
        public IstoricClient IstoricLicitatii { get => istoricLicitatii; set => istoricLicitatii = value; }
        public bool SalveazaIstoric { get => salveazaIstoric; set => salveazaIstoric = value; }
        public float PretLicitat { get => pretLicitat; set => pretLicitat = value; }

        public ClientLicitatie(string nume, string prenume, int nrLicitatie, float sumaDisp, IstoricClient istoric) {
            Id = Utils.genereazaIdUnic(For.ClientLicitatie, 10000);
            Nume = nume;
            Prenume = prenume;
            Numar = nrLicitatie;
            SumaDisponibila = sumaDisp;
            IstoricLicitatii = istoric;
            SalveazaIstoric = istoric != null; 
        }

        public void serializeaza() {
            BinaryFormatter bf = new BinaryFormatter();
            List<ClientLicitatie> list = deserializeaza();

            using (Stream stream = new FileStream(
                $"{MainForm.WorkPath}\\clients.dat",
                FileMode.OpenOrCreate, FileAccess.Write,
                FileShare.None)
            ) {
                list.Add(this);
                bf.Serialize(stream, list);
            }
        }

        public static List<ClientLicitatie> deserializeaza() {
            BinaryFormatter bf = new BinaryFormatter();
            List<ClientLicitatie> list = new List<ClientLicitatie>();

            using (Stream stream = new FileStream(
                $"{MainForm.WorkPath}\\clients.dat",
                FileMode.OpenOrCreate, FileAccess.Read,
                FileShare.Read)
            ) {
                if (stream.Length > 0) {
                    list = (List<ClientLicitatie>) bf.Deserialize(stream);
                }
            }

            return list;
        }

        public static void serializeazaTot(List<ClientLicitatie> list) {
            BinaryFormatter bf = new BinaryFormatter();

            using (Stream stream = new FileStream(
                $"{MainForm.WorkPath}\\clients.dat",
                FileMode.OpenOrCreate, FileAccess.Write,
                FileShare.None)
            ) {
                bf.Serialize(stream, list);
            }
        }

        public static ClientLicitatie gasesteClient(int id) {
            if (Cache.Clienti.Count > 0) {
                foreach (ClientLicitatie cli in Cache.Clienti) {
                    if (cli.Id == id)
                        return cli;
                }

                return null;
            } else return null;
        }

        public static void stergeClient(int id) {
            List<ClientLicitatie> clienti = deserializeaza();

            if (clienti.Count > 0) {
                foreach (ClientLicitatie cli in clienti) {
                    if (cli.Id == id) {
                        Cache.Clienti.RemoveAt(clienti.IndexOf(cli));
                        clienti.Remove(cli);

                        break;
                    }
                }

                serializeazaTot(clienti);
            }
        }

        public static void stergeTot() {
            string path = $"{MainForm.WorkPath}\\clients.dat";

            if (File.Exists(path)) {
                File.Delete(path);
            }

            Cache.Clienti.Clear();
        }


        public static class Cache {
            private static List<ClientLicitatie> clienti = new List<ClientLicitatie>();

            public static List<ClientLicitatie> Clienti {
                get { return clienti; }
                set { clienti = value; }
            }
        }
    }
}
