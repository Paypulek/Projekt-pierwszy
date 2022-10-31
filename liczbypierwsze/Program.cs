using System;
using System.Text;
namespace Sprawdzarka
{
    class Program
    {
        static void Main(string[] args)
        {
            int zmienna;

            Console.WriteLine("Wprowadź liczbe całkowitą dodatnią, a odpowiem czy jest parzysta, a później wypisze wszystkie nieparzyste");
            var czySukces = ushort.TryParse(Console.ReadLine(), out ushort liczba);

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

                for(int i = liczba; i!= 0; i--)
                {
                    zmienna = i % 2;
                    if (zmienna!=0)
                    Console.WriteLine("{0}",i);
                    
                }

                
            }
            else
                Console.WriteLine("daj spokój");

            Console.ReadKey();

        }
    }
}