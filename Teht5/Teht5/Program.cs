using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht5
{
    class ArrayCalcs
    {
        //
        //public double Sum(double[] taulu)
        public static double Sum(double[] array)
        {
            double sum = 0;
            for(int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
            }
            return sum;
        }
        public static double Average(double[] array)
        {
            double avg = 0;
            double total = 0;
            for (int i = 0; i < array.Length; i++)
            {
                total = total + array[i];
            }
            avg = total / array.Length;
            return avg;
        }
        public static double Min(double[] array)
        {
            double a = array[0];
            for(int i = 0; i < array.Length; i++)
            {
                if (a >= array[i])
                {
                    a = array[i];
                }
            }
            return a;
        }
        public static double Max(double[] array)
        {
            double a = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (a <= array[i])
                {
                    a = array[i];
                }
            }
            return a;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double[] luvut = new double[] { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            Console.WriteLine("Sum = " + ArrayCalcs.Sum(luvut));
            Console.WriteLine("Ave = " + ArrayCalcs.Average(luvut));
            Console.WriteLine("Min = " + ArrayCalcs.Min(luvut));
            Console.WriteLine("Max = " + ArrayCalcs.Max(luvut));
            Console.ReadKey();

            //Erilaisia toteutuksia:
            //
            //ArrayCalcs laskut = new ArrayCalcs();
            //laskut.Yhteenlasku = 5;
            //ArrayCalcs lasku;
            //lasku = new ArrayCalcs();
            //Console.WriteLine(lasku.Sum(luvut));
            //Console.WriteLine(Sum(luvut));
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
