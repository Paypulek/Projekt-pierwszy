public static class Programator
{
    public static void Main()
    {

        List<StanMagazynu> Lista2 = new List<StanMagazynu>();
       
        Magazyn Magazyn = new Magazyn();
        Magazyn.Dodaj(new Produkty("piłka", 12),10);
        Magazyn.Dodaj(new Produkty("diłka", 14),11);
        Magazyn.Dodaj(new Produkty("miłka", 18),12);
        Magazyn.Dodaj(new Produkty("fiłka", 16),13);
        Magazyn.OdczytajProdukty();
        Magazyn.OdczytajProdukty();
        Produkty Piłka = new Produkty("Piłka", 13);
        Produkty Książka = new Produkty("Książka", 10);

        Lista2.Add(new StanMagazynu(Piłka, 10));
        Lista2.Add(new StanMagazynu(Książka, 2));
        foreach (StanMagazynu item in Lista2)
        {
            
            if (item.produkt == Piłka)
            item.ilość-= 2;

            Console.WriteLine(item.produkt.nazwa + "Ilość" + item.ilość);
        }
   

        
    }
}
public class Magazyn
{
    public List<StanMagazynu> _magazyn = new List<StanMagazynu>();
    public void Dodaj(Produkty produkt, int ilość)
    {
        _magazyn.Add(new StanMagazynu(produkt, ilość));
    }
    public void Usuń(Produkty produkt, int ilość)
    {
        _magazyn.Remove(new StanMagazynu(produkt, ilość));
    }
    public void OdczytajProdukty()
    {
        foreach (StanMagazynu  item in _magazyn)
        {
            Console.WriteLine( item.produkt.nazwa  + " " + item.produkt.cena + " " + item.ilość);
        }
    }

}
public class StanMagazynu
{
    public StanMagazynu(Produkty produkt, int ilość)
    {
        this.produkt = produkt;
        this.ilość = ilość;
    }
   public  Produkty produkt;
   public int ilość;
}
public class Produkty
{
    public Produkty(string nazwa, int cena)
    {
        this.nazwa = nazwa;
        this.cena = cena;
    }
    public string nazwa;
    public int cena;
}
