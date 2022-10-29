using System;
using System.Text;
namespace Sprawdzarka
{
    class Program
    {
        static void Main(string[] args)
        {
            int zmienna;

            Console.WriteLine("Wprowadź liczbe, a odpowiem czy jest parzysta");
            var czySukces = int.TryParse(Console.ReadLine(), out var liczba);

            if (czySukces)
            {
                zmienna = liczba % 2;
                if (zmienna == 0)
                {
                    Console.WriteLine("To jest parzysta");
                }
                else
                {
                    Console.WriteLine("to jest nieparzysta");
                }
            }
            else
                Console.WriteLine("daj spokój");

            Console.ReadKey();

        }
    }
}