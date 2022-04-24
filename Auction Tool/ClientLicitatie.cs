using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW {
    class ClientLicitatie {
        private int id;
        private string nume;
        private string prenume;
        private int numar;
        private float sumaDisponibila;
        private IstoricClient istoricLicitatii;
        [NonSerialized]
        private float pretLicitat;

        public int Id { get => id; set => id = value; }
        public string Nume { get => nume; set => nume = value; }
        public string Prenume { get => prenume; set => prenume = value; }
        public int Numar { get => numar; set => numar = value; }
        public float SumaDisponibila { get => sumaDisponibila; set => sumaDisponibila = value; }
        public IstoricClient IstoricLicitatii { get => istoricLicitatii; set => istoricLicitatii = value; }
        public float PretLicitat { get => pretLicitat; set => pretLicitat = value; }

        public void serialize() {
            BinaryFormatter bf = new BinaryFormatter();
            List<ClientLicitatie> list = deserialize();

            using (Stream stream = new FileStream(
                $"{MainForm.WorkPath}\\clients.dat",
                FileMode.OpenOrCreate, FileAccess.Write,
                FileShare.None)
            ) {
                list.Add(this);

                bf.Serialize(stream, list);
            }
        }

        public static List<ClientLicitatie> deserialize() {
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
    }
}
