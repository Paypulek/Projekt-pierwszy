namespace Koszyk;
public class Produkt
{
    public int ID { get; set; }
    public int cena;
    public string nazwa;
    public Paczka rodzajOpakowania;
    public Produkt(int Cena, string Nazwa, Paczka RodzajOpakowania)
    {
        cena = Cena;
        nazwa = Nazwa;
        rodzajOpakowania = RodzajOpakowania;
    }

   
    
  
}

  public enum Paczka 
    { 
        CyfrowyProdukt = 0,
        MałaPaczka = 10,
        ŚredniaPaczka = 20,
        DużaPaczka = 40,
    }






