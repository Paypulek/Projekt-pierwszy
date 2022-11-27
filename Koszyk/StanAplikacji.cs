namespace Koszyk;
public static class StanAplikacji
{
    public static Magazyn Magazyn {get;} = new Magazyn();
    public static List<RekordRachunku> ListaZakupowa {get;} = new List<RekordRachunku>();
     private static List<StanProduktu> _produkty = new List<StanProduktu>();
     
     public static void InicjujProdukty()
     {
        StanAplikacji.Magazyn.Dodaj(new Produkt(20, "Książka"), 10);
            StanAplikacji.Magazyn.Dodaj(new Produkt(15, "Piłka"), 20);
            StanAplikacji.Magazyn.Dodaj(new Produkt(30, "Koszulka"), 14);
            StanAplikacji.Magazyn.Dodaj(new Produkt(120, "Zacisk Hamulcowy"), 17);
            StanAplikacji.Magazyn.Dodaj(new Produkt(100, "Łuk"), 18);
     }
     

    
}