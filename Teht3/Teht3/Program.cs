﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht3
{
    class Kala
    {
        public int kala_id;
        public int kalastaja_id;
        public int kalapaikka_id;
        public string laji;
        public double pituus;
        public double paino;
    }
    class Kalastaja
    {
        public int kalastaja_id;
        public string nimi;
        public string puhnro;
    }
    class Kalapaikka
    {
        public int kalapaikka_id;
        public string kpaikka;
        public string sijainti;
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Kalastaja> kalastajat = new List<Kalastaja>();
            kalastajat.Add(new Kalastaja { kalastaja_id = 01, nimi = "Tuhka Ketsuppi", puhnro = "04516447894" });
            for (int i = kalastajat.Count()-1; i < kalastajat.Count(); i++)
            {
                Console.WriteLine("Lisätty kalastaja : " + kalastajat[i].kalastaja_id + " " + kalastajat[i].nimi + " " + kalastajat[i].puhnro);
            }

            List<Kalapaikka> kalapaikat = new List<Kalapaikka>();
            kalapaikat.Add(new Kalapaikka { kalapaikka_id = 01, kpaikka = "Satama", sijainti = "Jyväskylä"});
            for(int i = kalapaikat.Count()-1; i < kalapaikat.Count(); i++)
            {
                Console.WriteLine("Lisätty kalapaikka : " + kalapaikat[i].kalapaikka_id + " " + kalapaikat[i].kpaikka + " " + kalapaikat[i].sijainti);
            }
            //tyhjärivi
            Console.WriteLine();

            List<Kala> kalat = new List<Kala>();

            kalat.Add(new Kala { kala_id = 01, kalastaja_id = 01, kalapaikka_id = 01, laji = "kuha", pituus = 25.72, paino = 0.578 });
            //x etsitään viimeisin kala x muuttujaam kalan tietoihin pääsemiseksi kalastajaa etsiessä
            int x = 3;
            for (int i = kalat.Count() - 1; i < kalat.Count(); i++)
            {
                x = i;
            }
            string kalastajaNimi = "nimi";
            for (int i = kalastajat.Count() - 1; i < kalastajat.Count(); i++)
            {
                if(kalastajat[i].kalastaja_id == kalat[x].kalastaja_id)
                {
                    //tallenna kalastajan nimi muuttujaan
                    kalastajaNimi = kalastajat[i].nimi;
                }
            }
            for (int i = kalat.Count()-1; i < kalat.Count(); i ++)
            {
                Console.WriteLine("Kalastaja " + kalastajaNimi + " sai kalan:\n -" + kalat[i].laji + " " + kalat[i].pituus + "cm " + kalat[i].paino + "kg");
            }


            kalat.Add(new Kala { kala_id = 02, kalastaja_id = 01, kalapaikka_id = 01, laji = "ahven", pituus = 12.20, paino = 0.241 });
            //x kalan tietoihin pääsemiseksi kalastajaa etsiessä
            //int x = 3;
            for (int i = kalat.Count() - 1; i < kalat.Count(); i++)
            {
                x = i;
            }
            //string kalastajaNimi = "nimi";
            for (int i = kalastajat.Count() - 1; i < kalastajat.Count(); i++)
            {
                if (kalastajat[i].kalastaja_id == kalat[x].kalastaja_id)
                {
                    //tallenna kalastajan nimi muuttujaan
                    kalastajaNimi = kalastajat[i].nimi;
                }
            }
            for (int i = kalat.Count() - 1; i < kalat.Count(); i++)
            {
                Console.WriteLine("Kalastaja " + kalastajaNimi + " sai kalan:\n -" + kalat[i].laji + " " + kalat[i].pituus + "cm " + kalat[i].paino + "kg");
            }

            //käy läpi for kalastajat
            //if  kalastajat[].kalastaja_id == kala[].kalastaja_id , print kala[x].*
            Console.ReadKey();
        }
    }
}
