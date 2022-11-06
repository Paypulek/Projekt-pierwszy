namespace Koszyk;
class Produkt
{



    int ID;
     int cena;
     string nazwa;
    public Produkt(int Cena, string Nazwa, int iD)
    {
        cena = Cena;
        nazwa = Nazwa;
        ID = iD;

    }





    public void OdczytajNazwe()
    {
        Console.WriteLine(cena + " zł " + " - " + nazwa );
    }

    public void StanMagazynu(Magazyn Hala)
    {
        Console.WriteLine("["+ Hala.StanMagazynowy[(ID-1)] + "]" + nazwa);
    }

    public void StanZakupów(Zakupy Torba)
    {
        Console.WriteLine("["+ Torba.Lista[(ID-1)] + "]" + nazwa);
    }
    public void OdczytajID()
    {
        Console.WriteLine("["+ID+"] - " + nazwa );
    }

}




