using System;
using System.Text;
namespace Sprawdzarka
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczba;
            int zmienna;
            Console.WriteLine("Wprowadź liczbe, a odpowiem czy jest parzysta");
liczba = Convert.ToInt32(Console.ReadLine());
zmienna = liczba%2;
if (zmienna == 0 )
    {Console.WriteLine ("To jest parzysta");
    }
    else
    {
        Console.WriteLine ("to jest nieparzysta");
        }
    Console.ReadKey();

        }
    }
}