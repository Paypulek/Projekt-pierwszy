namespace Koszyk;
class Produkt : InfoOProdukcie
{
    static int KosztProduktów;
    int cenaProduktu;
    public string Nazwa="produkt";

    int ilość;

    public void Nazwij(string Tytuł)
    {
        Nazwa = Tytuł;
    }

    public void Wyceń(int Cena)
    {
        cenaProduktu = Cena;
    }

    public void Ile(int a)
    {
        ilość = a;
    }


    public void OdczytajNazwe()
    {
        Console.WriteLine(Nazwa, cenaProduktu);
    }

    public int Cena()
    {
        return cenaProduktu;
    }
    public int IleMam()
    {
        return ilość;
    }
}

interface InfoOProdukcie
{
    int Cena();

    int IleMam();
}

