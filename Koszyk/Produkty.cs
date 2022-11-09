namespace Koszyk;
public class Produkt
{



    public int ID { get; set; }
    public int cena;
    string nazwa;
    public Produkt(int Cena, string Nazwa, int iD)
    {
        cena = Cena;
        nazwa = Nazwa;
        ID = iD;

    }
    
    public void OdczytajNazwe()
    {
        Console.WriteLine(cena + " zł " + " - " + nazwa);
    }

    public void OdczytajID()
    {
        Console.WriteLine("[" + ID + "] - " + nazwa);
    }

}




