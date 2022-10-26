using _1_uzd_Eduards_Verenkovs;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_uzd_Eduards_Verenkovs
{
    public class Dokument
    {
        private string numurs;
        public static int maxSumma = 100;
        private DateTime datums;
        private List<Rinda> rindas;

        public Dokument(string aNumurs, List<Rinda> aList)
        {
            Numurs = aNumurs;
            Rindas = aList;
        }

        public string Numurs
        {
            get { return numurs; }
            set { numurs = value; }
        }

        public DateTime Datums
        {
            get { return datums; }
            set { datums = value; }
        }

        public List<Rinda> Rindas
        {
            get { return rindas; }
            set { rindas = value; }
        }



        static DateTime GetNextWeekday()
        {
            DayOfWeek d = DayOfWeek.Monday;
            DateTime result = DateTime.Now.AddDays(1);
            while (result.DayOfWeek != d)
                result = result.AddDays(1);
            return result;
        }

        public void printDoc(int kSum)
        {
            Console.WriteLine(" ");
            Datums = GetNextWeekday();
            string dts = Datums.ToShortDateString();
            Console.WriteLine("Datums: " + dts);

            Console.WriteLine("Dokumenta nr: " + Numurs);

            double maxSummaD = (double)maxSumma;
            Console.WriteLine("Maksimālā summa: " + maxSummaD.ToString("F2") + " EUR");

            int lin = 0;
            int notS = 0;
            Console.WriteLine("Rindas: ");
            foreach (Rinda rinda in Rindas)
            {
                double rinSD = (double)rinda.Summa;
                string k = rinda.Kods;
                string rinSDtS = rinSD.ToString("F2") + " EUR";
                Console.WriteLine("\t {0, -15} {1, 10}", k, rinSDtS);
                lin++;
                notS = rinda.Summa;
            }

            Console.WriteLine("Rindu skaits: " + lin);

            double kSumD = (double)kSum;
            double notSD = (double)notS;

            Console.WriteLine(("Kopējā summa: " + (kSum - notSD).ToString("F2") + " EUR"));

            Console.WriteLine("Nepievienotās rindas summa: " + notS.ToString("F2") + " EUR");

            Console.WriteLine("Pārsniegtā summa: " + kSumD.ToString("F2") + " EUR");
        }
    }
}

