namespace Koszyk;

class Program
{

    static void Main(string[] args)
    {
        Magazyn Hala = new Magazyn();
        Zakupy Torba = new Zakupy();
        List<Produkt> ListaProduktów = new List<Produkt>();
        ListaProduktów.Add(new Produkt(20, "Książka", 1));
        Hala.Dodaj(1, 10);
        ListaProduktów.Add(new Produkt(15, "Piłka", 2));
        Hala.Dodaj(2, 20);
        ListaProduktów.Add(new Produkt(30, "Koszulka", 3));
        Hala.Dodaj(3, 14);
        ListaProduktów.Add(new Produkt(120, "Zacisk Hamulcowy", 4));
        Hala.Dodaj(4, 17);
        ListaProduktów.Add(new Produkt(100, "Łuk", 5));
        Hala.Dodaj(5, 18);

        do
        {
            int liczbaZMenu = Menu(ListaProduktów, Hala, Torba);
            switch (liczbaZMenu)
            {
                case 1:
                    DodajDoKoszyka(ListaProduktów, Hala, Torba);
                    break;
                case 2:
                    Console.WriteLine("Na Magazynie mamy");
                    foreach (Produkt item in ListaProduktów)
                    {
                        item.StanMagazynu(Hala);
                    }

                    Console.WriteLine("---------------");
                    break;
                case 3:
                    Console.WriteLine("W koszyku mamy");
                    foreach (Produkt item in ListaProduktów)
                    {
                        item.StanZakupów(Torba);
                    }
                    Console.WriteLine("---------------");
                    break;
                case 4:
                    PoliczCene(ListaProduktów, Hala, Torba);
                    break;
                case 5:
                    return;
            }

        } while (true);


    }
    static void PoliczCene(List<Produkt> Lista, Magazyn Hala, Zakupy Torba)
    {

    }
    static void DodajDoKoszyka(List<Produkt> Lista, Magazyn Hala, Zakupy Torba)
    {
        int ID = -1;
        Console.WriteLine("Wybierz ID produktu i napisz ilość jaką chcesz kupić");
        foreach (Produkt item in Lista)
        {
            item.OdczytajID();
        }
        var cyferka = Console.ReadKey();
        Console.WriteLine("");
        switch (cyferka.Key)
        {
            case ConsoleKey.D1:
                ID = 1;
                break;
            case ConsoleKey.D2:
                ID = 2;
                break;
            case ConsoleKey.D3:
                ID = 3;
                break;
            case ConsoleKey.D4:
                ID = 4;
                break;
            case ConsoleKey.D5:
                ID = 5;
                break;
            default:
                break;

        }
        int.TryParse(Console.ReadLine(), out int ilośćZakupiona);
        if (Hala.SprawdźCzyMamy(ID, ilośćZakupiona))
        {
            Torba.DodajNaListe(ID, ilośćZakupiona);
            Hala.DodajNaListe(ID, ilośćZakupiona);
        }
        else
        {
            Console.WriteLine("Nie mamy tyle na magazynie");
            Console.WriteLine("--------------");
        }


    }
    static int Menu(List<Produkt> Lista, Magazyn Hala, Zakupy Torba)
    {

        /* Console.WriteLine("Dzień dobry witam w sklepie oto lista produktów z ceną");

         foreach (Produkt item in Lista)
         {
             item.OdczytajNazwe();
         }*/


        Console.WriteLine("[1] - Dodaj produkt do koszyka");
        Console.WriteLine("[2] - Sprawdź co jest na magazynie");
        Console.WriteLine("[3] - Sprawdź listę zakupów");
        Console.WriteLine("[4] - Policz cene");
        Console.WriteLine("[5] - Wyjdź");
        var cyferka = Console.ReadKey();
        Console.WriteLine("");
        switch (cyferka.Key)
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






