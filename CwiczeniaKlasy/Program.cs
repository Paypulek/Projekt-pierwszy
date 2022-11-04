using System;
namespace Klasy
{
    class Program
    {
        static void Main(string[] args)
        {
            // W momencie tworzenia nowego obiektu dojdzie do wywołania konstruktora
            KlasaZKonstruktorem kzk = new KlasaZKonstruktorem();
        
            Console.ReadKey();
        }
    }
    class KlasaZKonstruktorem
    {
        private string tekst;
        public KlasaZKonstruktorem()
        {
            tekst = "Wywołanie konstruktora klasy";
            Console.WriteLine(tekst);
        }
    }
}