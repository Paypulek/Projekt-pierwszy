using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
namespace Kalkulator;

class Program
{
    static void Main(string[] args)
    {
        int poruszanieSie;
        List<Klient> ListaKlientów = new List<Klient>();
        do
        {
            
            poruszanieSie = Menu();
            switch (poruszanieSie)
            {
                case 1:
                    DodajKlienta(ListaKlientów);
                    break;
                case 2:
                    //OdejmijKlienta();
                    break;
                case 3:
                    ListaKlientów[0].OdczytajKlientow();
                    break;
                case 4:
                    // SprawdźStanMagazynu();
                    break;
                default:
                    return;

            }
        } while (true);


    }
    static void DodajKlienta(List<Klient> ListaKlientow)
    {


        Console.WriteLine("Podaj imię i nazwisko (ogólnie nazwę) Klienta\n");
        string imieNazwisk = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Podaj miasto, wraz z adresem w jednej linijce\n");
        string miast = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Podaj ilość stóp\n");
        int stop = int.Parse(Console.ReadLine());
        Console.WriteLine("Podaj ilość ramek\n");
        int ramk = int.Parse(Console.ReadLine());
        Console.WriteLine("Podaj ilość podestów drewnianych\n");
        int podestyDre = int.Parse(Console.ReadLine());
        Console.WriteLine("Podaj ilość podestów komunikacyjnych\n");
        int podestyKom = int.Parse(Console.ReadLine());
        Console.WriteLine("Podaj ilość stężenia\n");
        int stężen = int.Parse(Console.ReadLine());
        Console.WriteLine("Podaj ilość barierek\n");
        int barier = int.Parse(Console.ReadLine());
        Console.WriteLine("Podaj ilość słupków do barierek\n");
        int słupkiDoBar = int.Parse(Console.ReadLine());

        ListaKlientow.Add(new Klient(imieNazwisk, miast, stop, ramk, podestyDre, podestyKom, stężen, barier, słupkiDoBar));
        XmlSerializer serializer = new XmlSerializer(typeof(List<Klient>));
        using (Stream s = File.Create("Klienci.xml"))
        {
        serializer.Serialize(s, ListaKlientow);
        s.Close();
        }



    }

    static int Menu()
    {
        Console.WriteLine("[1] - Dodaj Klienta - wraz z liczbą wynajętych elementów");
        Console.WriteLine("[2] - Zakończ wynajem");
        Console.WriteLine("[3] - Sprawdź liczbę aktualnie wynajmujących");
        Console.WriteLine("[4] - Sprawdź stan magazynu");
        Console.WriteLine("[5] - Zakończ działanie programu");
        var przycisk = Console.ReadKey();
        switch (przycisk.Key)
        {
            case ConsoleKey.D1:
                return 1;
            case ConsoleKey.D2:
                return 2;
            case ConsoleKey.D3:
                return 3;
            case ConsoleKey.D4:
                return 4;
            default:
                return 5;

        }
    }

}
