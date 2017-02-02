using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht3
{
    class Kala
    {
        public string kalastaja_id;
        public string kalapaikka_id;
        public string laji;
        public double pituus;
        public double paino;
    }
    class Kalastaja
    {
        public string kalastaja_id;
        public string nimi;
        public string puhnro;
    }
    class Kalapaikka
    {
        public string kalapaikka_id;
        public string nimi;
        public string sijainti;
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Kalastaja> kalastajat = new List<Kalastaja>();
            kalastajat.Add(new Kalastaja { kalastaja_id = "01", nimi = "Tuhka Ketsuppi", puhnro = "04516447894" });

            List<Kalapaikka> kalapaikat = new List<Kalapaikka>();
            kalapaikat.Add(new Kalapaikka { kalapaikka_id = "01", nimi = "Satama", sijainti = "Jyväskylä"});

            List<Kala> kalat = new List<Kala>();
            kalat.Add(new Kala { kalastaja_id = "01", kalapaikka_id = "01", laji = "kuha", pituus = 25.72, paino = 0.578 });
            kalat.Add(new Kala { kalastaja_id = "01", kalapaikka_id = "01", laji = "ahven", pituus = 12.20, paino = 0.241 });


        }
    }
}
