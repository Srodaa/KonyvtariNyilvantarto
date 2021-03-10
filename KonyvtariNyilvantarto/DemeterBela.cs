using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonyvtariNyilvantarto
{
    class DemeterBela
    {
        public int DBID { get; set; }
        public string DBNev { get; set; }
        public string DBSzuletesDatuma { get; set; }
        public string DBIranyitoszam { get; set; }
        public string DBVaros { get; set; }
        public string DBUtca { get; set; }

        public DemeterBela(string a)
        {
            try
            {
                string[] b = a.Split(';');
                DBID = int.Parse(b[0]);
                DBNev = b[1];
                DBSzuletesDatuma = b[2];
                DBIranyitoszam = b[3];
                DBVaros = b[4];
                DBUtca = b[5];
            }
            catch (Exception)
            {

                return;
            }
        }
    }


}
