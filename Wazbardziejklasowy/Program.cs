using System;
using System.Text;
using System.Threading;
namespace Wazbardziejklasowy;
class Program
{
    static void Main(string[] args)
    {
        StanAplikacji.wylosujCukierek();
        Ekran.Inicjalizacja();
        while (StanAplikacji.przerwanie != true)
        {
            var cki = Console.ReadKey(true);
            while (Console.KeyAvailable == false)
            {
                Thread.Sleep(250); // Loop until input is entered.
                Ekran.Inicjalizacja();
                StanAplikacji.zmij.RuchPotwora(cki.Key);
                StanAplikacji.zmij.PorzadkowanieRuchuSegmentów();
                Ekran.AktualizujObraz();
                Ekran.WczytajObraz();
            }

        }
    }
} bvgyv