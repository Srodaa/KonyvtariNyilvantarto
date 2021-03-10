using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace KonyvtariNyilvantarto
{
    class Kolcsonzes
    {
        public int KolcsonzesID { get; set; }
        public int KolcsonzesEID { get; set; }
        public int KolcsonzesKID { get; set; }
        public string KolcsonzesKezdete { get; set; }
        public string KolcsonzesVege { get; set; }

        public Kolcsonzes(string a)
        {
            try
            {
                string[] kolcsonzes = a.Split(';');
                KolcsonzesID = int.Parse(kolcsonzes[0]);
                KolcsonzesEID = int.Parse(kolcsonzes[1]);
                KolcsonzesKID = int.Parse(kolcsonzes[2]);
                KolcsonzesKezdete = kolcsonzes[3];
                KolcsonzesVege = kolcsonzes[4];
            }
            catch (Exception)
            {

                return;
            
            }
        }
    }
}
