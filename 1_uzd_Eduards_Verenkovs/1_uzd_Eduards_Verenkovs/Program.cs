using System;
using System.Globalization;
using System.Reflection.Emit;
using System.Threading.Tasks;

namespace _1_uzd_Eduards_Verenkovs
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Ievadiet dokumenta numuru:");
            string nr = Console.ReadLine();
            List<Rinda> rList = new List<Rinda>();
            Dokument doc = new Dokument(nr, rList);

            int kSum = 0;
            int j = 1;
            while (kSum < Dokument.maxSumma)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Ievadiet " + (j) + ". rindas kodu:");
                string code = Console.ReadLine();
                Console.WriteLine("Ģenerētā " + (j) + ". rindas summa:");
                int maxSumLimit = Dokument.maxSumma / 3;
                int sum = rnd.Next(1, (maxSumLimit + 1));
                Console.WriteLine(sum);
                Rinda rin = new Rinda(code, sum);
                rList.Add(rin);
                kSum = kSum + sum;
                j++;
                Console.WriteLine(" ");
            }
            doc.printDoc(kSum);

        }
    }
}
