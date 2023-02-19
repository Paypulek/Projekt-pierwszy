
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Drawing;
namespace Pliki
{
    class Program
    {
        static void Main(string[] args)
        {
            int i =7;
                       string Ścieżka = @"C:\tutorials\";
           string rozszerzenie = ".png";
           string licznik = Convert.ToString(i);
           Ścieżka = Ścieżka + licznik + rozszerzenie;
           Console.WriteLine(Ścieżka);
            string[] ścieżki;
            Plik.ZwróćŚcieżki(@"C:\tutorials\", "*.png", out ścieżki);
            Obrazy.ZaładujListe(ścieżki);
            Obrazy.SprawdźPiksele(ref Obrazy.Lista);
            Obrazy.StwórzObrazy(20);
        }
    }
}
