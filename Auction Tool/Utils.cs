using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace Auction_Tool {
    public enum For {
        AuctionItem, AuctionClient
    }

    public enum Operation {
        Create, Edit
    }

    public enum Lang {
        RO, EN
    }

    class Utils {
        public static int generateUniqueID(For obj, int max) {
            Random ran = new Random();
            int random = ran.Next(1, max + 1);

            // RO: Generam un ID unic de aici
            // EN: We generate an unique ID here
            while (true) {
                int check = random;
                List<object> objs = new List<object>();

                switch(obj) {
                    case For.AuctionItem:
                        objs.AddRange(AuctionItem.Cache.Collection);
                        break;
                    case For.AuctionClient:
                        objs.AddRange(AuctionClient.Cache.Collection);
                        break;
                }

                foreach (object ob in objs) {
                    IIdentifiable iden = (IIdentifiable)ob;

                    if (iden.Id == random) {
                        random = ran.Next(1, max + 1);
                        break;
                    }
                }

                if (check == random) break;
            }

            return random;
        } 

        /*
         * RO: Returnează JSON-ul cu localizările sub formă de dictionar
         * EN: Returns the localization JSON as a dictionary
         */
        public static Dictionary<string, string> getJsonLang(Lang lang, string file) {
            string cpy = file.Replace(".json", "");

            Stream stream = Assembly.GetExecutingAssembly()
                .GetManifestResourceStream($"Auction_Tool.lang.{lang.ToString().ToLower()}.{cpy}.json");

            if(stream == null) {
                throw new Exception($"Couldn't create stream for file '{file}'");
            }

            StreamReader sr = new StreamReader(stream);
            Dictionary<string, string> json = JsonConvert
                .DeserializeObject<Dictionary<string, string>>(sr.ReadToEnd());


            return json;
        }
    }
}
