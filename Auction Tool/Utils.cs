using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
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
                .GetManifestResourceStream($"Auction_Tool.locale.{lang.ToString().ToLower()}.{cpy}.json");

            if(stream == null) {
                throw new Exception($"Couldn't create stream for file '{cpy}' in {lang}. Check if it exists");
            }

            StreamReader sr = new StreamReader(stream);
            Dictionary<string, string> json = JsonConvert
                .DeserializeObject<Dictionary<string, string>>(sr.ReadToEnd());


            return json;
        }

        /*
         * RO: Returnează un tuplu cu:
         * - bool valid - Dacă validarea a avut succes
         * - string fileName - În cazul în care valid=false, va fi localul invalid, altfel un string gol
         * 
         * EN: Returns a tuple containing:
         * - bool valid - If the validation succeeds
         * - string fileName - If valid=false, this will be the name of the invalid locale, else an empty string
         */
        public static Tuple<bool, string> areLocalesInSync() {
            string[] fileNames = { "main_form", "bet_form", "client_form", "item_form",
                "delete_form", "edit_form" };

            foreach (string fileName in fileNames) {
                List<Dictionary<string, string>> files = new List<Dictionary<string, string>>();

                // RO: Colectăm localele în JSON pentru toate limbile într-o listă
                // EN: We collect the JSON locales for all languages in a list
                foreach (Lang lang in Enum.GetValues(typeof(Lang))) {
                    files.Add(getJsonLang(lang, fileName));
                }

                if(files.Any(el => files.First().Count != el.Count)) {
                    return new Tuple<bool, string>(false, fileName);
                }

                // RO: Dacă unul din locale nu are cheile egale cu celelalte
                // EN: If one of the locales doesn't match keys with the others
                if (files.Any(el => !files.First().Keys.SequenceEqual(el.Keys))) {
                    return new Tuple<bool, string>(false, fileName);
                }
            }

            return new Tuple<bool, string>(true, "");
        }

        public static float stdDev(float[] x) {
            float ret = 0;
            float mean = x.Aggregate(0f, (a, b) => a + b) / x.Length;
            float squareSum = 0;

            for (int i = 0; i < x.Length; i++) {
                squareSum += (float) Math.Pow(x[i] - mean, 2);
            }

            return (float) Math.Sqrt(squareSum/x.Length);
        }

        public static Image resizeImage(Image imgToResize, Size size) {
            int sourceWidth = imgToResize.Width;
            int sourceHeight = imgToResize.Height;

            float nPercent;
            float nPercentW;
            float nPercentH;

            nPercentW = ((float)size.Width / (float)sourceWidth);
            nPercentH = ((float)size.Height / (float)sourceHeight);

            if (nPercentH < nPercentW)
                nPercent = nPercentH;
            else
                nPercent = nPercentW;

            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage(b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();

            return b;
        }

        public static string secondsToTimestamp(string format, int s) {
            string replaced = (string) format.Clone();
            int seconds, minutes, hours;

            if(s < 60) {
                seconds = s;
                string sConv = seconds < 10 ? "0" + seconds : seconds.ToString();

                replaced = replaced.Replace("HH", "00")
                    .Replace("mm", "00")
                    .Replace("ss", sConv);
            } else {
                minutes = s / 60;
                seconds = s % 60;

                string mConv = minutes < 10 ? "0" + minutes : minutes.ToString();
                string sConv = seconds < 10 ? "0" + seconds : seconds.ToString();

                if (minutes < 60) {
                    replaced = replaced.Replace("HH", "00")
                        .Replace("mm", mConv)
                        .Replace("ss", sConv);
                } else {
                    hours = minutes / 60;
                    minutes = minutes % 60;

                    string hConv = hours < 10 ? "0" + hours : hours.ToString();
                    mConv = minutes < 10 ? "0" + minutes : minutes.ToString();

                    replaced = replaced.Replace("HH", hConv)
                        .Replace("mm", mConv)
                        .Replace("ss", sConv);
                }
            }

            return replaced;
        }
    }
}
