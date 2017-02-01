using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht1
{
    class Noppa
    {
        public int luku;
        public void ThrowNoppa()
        {
            Random rnd = new Random();
            luku = rnd.Next(1, 7);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int heittokerrat;
            int heittoSumma = 0;
            int keskiarvo = 1;
            List<int> heitot = new List<int>();
            Noppa nop = new Noppa();
            nop.ThrowNoppa();
            Console.WriteLine("Noppaa on heitetty. Nopan luku on "
                               + nop.luku + ".");
            Console.WriteLine("Monta kertaa noppaa heitetään? ");
            heittokerrat = System.Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < heittokerrat; i++)
            {
                nop.ThrowNoppa();
                heitot.Add(nop.luku);
            }
            foreach(int heitto in heitot)
            {
                heittoSumma = heittoSumma + heitto;
            }
            keskiarvo = heittoSumma / heittokerrat;
            Console.WriteLine("\nNoppaa heitettiin " + heittokerrat + " kertaa.\n" +
                               "Heittojen keskiarvo on " + keskiarvo + ".");
            Console.ReadKey();

        }
    }
}
