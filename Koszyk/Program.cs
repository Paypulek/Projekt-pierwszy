namespace Koszyk;

class Program
{

    static void Main(string[] args)
    {
        Magazyn Hala = new Magazyn();
        Zakupy Torba = new Zakupy();
        List<Produkt> ListaProduktów = new List<Produkt>();
        ListaProduktów.Add(new Produkt(20, "Książka", 1));
        Hala.Dodaj(0, 10);
        ListaProduktów.Add(new Produkt(15, "Piłka", 2));
        Hala.Dodaj(1, 20);
        ListaProduktów.Add(new Produkt(30, "Koszulka", 3));
        Hala.Dodaj(2, 14);
        ListaProduktów.Add(new Produkt(120, "Zacisk Hamulcowy", 4));
        Hala.Dodaj(3, 17);
        ListaProduktów.Add(new Produkt(100, "Łuk", 5));
        Hala.Dodaj(4, 18);
        

        Menu(ListaProduktów, Hala, Torba);

    }

    static void Menu(List<Produkt> Lista, Magazyn Hala, Zakupy Torba)
    {   


        Console.WriteLine("Dzień dobry witam w sklepie oto lista produktów (ID produktu jest w kwadratowych nawiasach)");
        foreach (Produkt item in Lista)
        {
            item.OdczytajNazwe();
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

       



        
    }
}






