using System;
using System.Text;
using System.Threading;
namespace Wazbardziejklasowy;
class Program
{
    static void Main(string[] args)
    {

        Ekran.Inicjalizacja();
        while (StanAplikacji.przerwanie = !true)
        {
            var cki = Console.ReadKey(true);
            while (Console.KeyAvailable == false)
            {
                Thread.Sleep(250); // Loop until input is entered.
                Ekran.WczytajObraz();
                StanAplikacji.zmij.RuchPotwora(cki.Key);
            }

        }
    }
}