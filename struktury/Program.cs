using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Struktury
{
    class Program
    {
        struct Ksiazka
        {
            public string tytul;
            public string autor;
            public string tematyka;
            public int id_ksiazki;
        }
        static void Main(string[] args)
        {
            // Deklaracja książek typu "Ksiazka"
            Ksiazka ksiazka_1;
            Ksiazka ksiazka_2;
            // Specyfikacja pierwszej ksiazki
            ksiazka_1.tytul = "Programowanie w języku C#";
            ksiazka_1.autor = "Imię Nazwisko";
            ksiazka_1.tematyka = "Programowanie";
            ksiazka_1.id_ksiazki = 32;
            // Specyfikacja drugiej ksiazki
            ksiazka_2.tytul = "Wielka księga samochodów";
            ksiazka_2.autor = "Imię Nazwisko";
            ksiazka_2.tematyka = "Motoryzacja";
            ksiazka_2.id_ksiazki = 1;
            // Przykładowe wypisanie interesujących danych
            Console.WriteLine("Tytuł 1 ksiązki: {0}", ksiazka_1.tytul);
            Console.WriteLine("Tematyka 2 ksiązki: {0}", ksiazka_2.tematyka);
            Console.ReadKey();
        }
    }
}