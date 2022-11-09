namespace Koszyk;

class Program
{


    static void Main(string[] args)
    {
        ObsługaEkranów.NowyEkran(new EkranBazowy());
    }
    static void PoliczCene()
    {
        // int licznik = 0;
        // int suma = 0;
        // foreach (Produkt item in Lista)
        // {
        //     suma += item.cena * Torba.Lista[licznik];
        // }
        // Console.WriteLine("---------------");
        // Console.WriteLine("Cena za wszystko = " + suma);
        // Console.WriteLine("---------------");
    }

    static void DodajDoKoszyka()
    {
        // int ID = -1;
        // Console.WriteLine("Wybierz ID produktu i napisz ilość jaką chcesz kupić");
        // foreach (Produkt item in Lista)
        // {
        //     item.OdczytajID();
        // }
        // var cyferka = Console.ReadKey();
        // Console.WriteLine("");
        // switch (cyferka.Key)
        // {
        //     case ConsoleKey.D1:
        //         ID = 1;
        //         break;
        //     case ConsoleKey.D2:
        //         ID = 2;
        //         break;
        //     case ConsoleKey.D3:
        //         ID = 3;
        //         break;
        //     case ConsoleKey.D4:
        //         ID = 4;
        //         break;
        //     case ConsoleKey.D5:
        //         ID = 5;
        //         break;
        //     default:
        //         break;

        // }
        // int.TryParse(Console.ReadLine(), out int ilośćZakupiona);
        // if (Hala.SprawdźCzyMamy(ID, ilośćZakupiona))
        // {
        //     Torba.DodajNaListe(ID, ilośćZakupiona);
        //     Hala.DodajNaListe(ID, ilośćZakupiona);
        // }
        // else
        // {
        //     Console.WriteLine("Nie mamy tyle na magazynie");
        //     Console.WriteLine("--------------");
        // }


    }

    static void WykonajKomendę()
    {
        // var liczbaZMenu = Console.ReadKey();
        // Console.WriteLine("");
        // switch (liczbaZMenu.Key)
        // {
        //     case ConsoleKey.D1:
        //         DodajDoKoszyka();
        //         break;
        //     case ConsoleKey.D2:
        //         Console.WriteLine("Na Magazynie mamy");
        //         foreach (Produkt item in ListaProduktów)
        //         {
        //             item.StanMagazynu(Hala);
        //         }

        //         Console.WriteLine("---------------");
        //         break;
        //     case ConsoleKey.D3:
        //         Console.WriteLine("W koszyku mamy");
        //         foreach (Produkt item in ListaProduktów)
        //         {
        //             item.StanZakupów(Torba);
        //         }
        //         Console.WriteLine("---------------");
        //         break;
        //     case ConsoleKey.D4:
        //         PoliczCene(ListaProduktów, Hala, Torba);
        //         break;
        //     case ConsoleKey.D5:
        //         return;
        // }
    }
}






