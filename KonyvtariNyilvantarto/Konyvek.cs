using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonyvtariNyilvantarto
{
    class Konyvek
    {
        public int KKonyvID { get; set; }
        public string KIro { get; set; }
        public string KKonyvCime { get; set; }
        public string KKiadasEve { get; set; }
        public string KKiado { get; set; }
        public bool KKolcsonzes { get; set; }
    

        public Konyvek(string a)
        {
            try
            {
                string[] Konyv = a.Split(';');
                KKonyvID = int.Parse(Konyv[0]);
                KIro = Konyv[1];
                KKonyvCime = Konyv[2];
                KKiadasEve = Konyv[3];
                KKiado = Konyv[4];
                KKolcsonzes = bool.Parse(Konyv[5]);
                
            }
            catch (Exception)
            {

                return;
            }
        }
    }
}
