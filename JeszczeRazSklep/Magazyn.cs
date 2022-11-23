namespace Nowy
{
    public static class Magazyn
    {

        List<StanMagazynowy> ListaMagazynu = new List<StanMagazynowy>();
        List<RekordRachunku> ListaZakupów = new List<RekordRachunku>();


        public void DodajNaMagazyn(Produkt Produkt, int Ilosc)
        {
            ListaMagazynu.Add(Produkt, Ilosc);
        }

    }

    public class StanMagazynowy
    {
        public StanMagazynowy(Produkt Produkt, int Ilosc)
        {
            this.produkt = Produkt;
            this.ilosc = Ilosc;
        }
        Produkt produkt;
        int ilosc;
    }

    public class RekordRachunku
    {
        Produkt produkt;
        int ilosc;
    }

    public class Produkt
    {
        public Produkt(string Nazwa, int Cena, Opakowania RodzajOpakowania)
        {
            this.nazwa = Nazwa;
            this.cena = Cena;
            this.rodzajOpakowania = RodzajOpakowania;
        }
        string nazwa;
        int cena;
        Opakowania rodzajOpakowania;
    }

    enum Opakowania
    {
        ProduktCyfrowy,
        Opakowanie1,
        Opakowanie2,
        Opakowanie3,
    }
}

