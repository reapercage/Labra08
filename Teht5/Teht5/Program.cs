using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht5
{
    class ArrayCalcs
    {
        public double Yhteenlasku
        {
            get;
            set;
        }

        static double Sum(double[] taulu)
        {
            double summa = 0;
            for(int i = 0; i < taulu.Length; i++)
            {
                summa = summa + taulu[i];
            }
            return summa;
        }
        static void Average()
        {

        }
        static void Min()
        {

        }
        static void Max()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double[] luvut = new double[] { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            ArrayCalcs laskut = new ArrayCalcs();
            //laskut;
            Console.WriteLine(Sum(luvut));
            Console.ReadKey();

        }
        static double Sum(double[] taulu)
        {
            //miten tehdaan, mina syottaa parametrit metodi ja sitten metoti laske
            double sum = 0;
            for (int i = 0; i < taulu.Length; i++)
            {
                sum = sum + taulu[i];
            }
            return sum;
        }
    }
}
