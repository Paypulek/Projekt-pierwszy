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


        int liczbaZMenu = Menu(ListaProduktów, Hala, Torba);
        switch(liczbaZMenu)
        {
            case 1:
            //DodajDoKoszyka();
            break;
            case 2:
            //UsuńZKoszyka();
            break;
            case 3:
            Console.WriteLine("W koszyku mamy");
            foreach (Produkt item in ListaProduktów)
            {
                item.StanZakupów(Torba);
            }
            break;
        }
        

    }

    static int Menu(List<Produkt> Lista, Magazyn Hala, Zakupy Torba)
    {
        do
        {
            Console.WriteLine("Dzień dobry witam w sklepie oto lista produktów z ceną");

            foreach (Produkt item in Lista)
            {
                item.OdczytajNazwe();
            }


            Console.WriteLine("[1] - Dodaj produkt do koszyka");
            Console.WriteLine("[2] - Usuń produkt z listy");
            Console.WriteLine("[3] - Sprawdź listę zakupów");
            Console.WriteLine("[4] - Policz cene");
            Console.WriteLine("[5] - Wyjdź");
            var cyferka = Console.ReadKey();
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
                default :
                    return 5;

            }


            Console.WriteLine("Na Magazynie mamy");
            foreach (Produkt item in Lista)
            {
                item.StanMagazynu(Hala);
            }

            Console.WriteLine("W koszyku mamy");
            foreach (Produkt item in Lista)
            {
                item.StanZakupów(Torba);
            }

        } while (true);


    }
}






