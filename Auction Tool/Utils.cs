using System;
using System.Collections.Generic;

namespace Auction_Tool {
    enum For {
        Articol, ClientLicitatie
    }

    class Utils {
        public static int genereazaIdUnic(For obj, int max) {
            Random ran = new Random();
            int random = ran.Next(1, max + 1);

            // Generam un ID unic
            while (true) {
                int check = random;
                List<object> objs = new List<object>();

                switch(obj) {
                    case For.Articol:
                        objs.AddRange(Articol.Cache.Articole);
                        break;
                    case For.ClientLicitatie:
                        objs.AddRange(ClientLicitatie.Cache.Clienti);
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
    }
}
