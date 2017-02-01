using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht2
{
    class Tuote
    {
        public string nimi;
        public double hinta;
        public string Nimi { get; set; }
        public Tuote()
        {
        }
        public Tuote(string Nimi, double Hinta)
        {
            Nimi = nimi;
            Hinta = hinta;
        }
        //ToString...jotain
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Tuote> ostokset = new List<Tuote>();
            ostokset.Add(new Tuote { nimi = "leikkele", hinta = 1.20 });
            ostokset.Add(new Tuote { nimi = "voi", hinta = 0.80 });
            int ostosLukumaara = ostokset.Count();
            Console.WriteLine("Ostoskärryn sisältö:");
            //foreach ratkaisukin on?
            for(int i = 0; i < ostosLukumaara; i++)
            {
                Console.WriteLine(ostokset[i].nimi + " " + ostokset[i].hinta + "e");
            }
            Console.ReadKey();
        }
    }
}
