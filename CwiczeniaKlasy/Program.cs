using System;
namespace Klasy
{
    class Program
    {
        static void Main(string[] args)
        {
            Pudelko pudelko1 = new Pudelko(); // definicja obiektu1 typu Pudelko
            Pudelko pudelko2 = new Pudelko(); // definicja obiektu2 typu Pudelko
            // spefyfikacja 1
            pudelko1.dlugosc = 5.5;
            pudelko1.wysokosc = 6.0;
            pudelko1.szerokosc = 3.0;
            // spefyfikaja 2
            pudelko2.dlugosc = 3.5;
            pudelko2.wysokosc = 2.0;
            pudelko2.szerokosc = 1.0;
            // Objetosc 1
            double obj1 = pudelko1.ObliczObjetosc(pudelko1.dlugosc, pudelko1.szerokosc, pudelko1.wysokosc);
            Console.WriteLine("Objetość pudełka nr 1: {0}", obj1);
            // Objetosc 2
            // Obliczenie bez użycia powyższej metody
            double obj2 = pudelko2.dlugosc * pudelko2.szerokosc * pudelko2.wysokosc;
            Console.WriteLine("Objetość pudełka nr 2: {0}", obj2);
            Console.ReadKey();
            // Wynik działania programu
            //Objetosc pudelka nr 1: 99
            //Objetosc pudelka nr 2: 7
        }
    }
    class Pudelko
    {
        public double dlugosc;
        public double szerokosc;
        public double wysokosc;
        // Metoda do obliczania objetosci zdefinowa jaka skladowa klasy
        public double ObliczObjetosc(double dl, double szer, double wys)
        {
            return dl * szer * wys;
        }
    }
}