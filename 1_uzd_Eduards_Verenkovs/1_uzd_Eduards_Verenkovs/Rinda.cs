using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_uzd_Eduards_Verenkovs
{
    public class Rinda
    {
        private string kods;
        private int summa;
        public Rinda(string aKods, int aSumma)
        {
            Kods = aKods;
            Summa = aSumma;
        }

        public string Kods
        {
            get { return kods; }
            set { kods = value; }
        }
        public int Summa
        {
            get { return summa; }
            set { summa = value; }
        }
    }
}
