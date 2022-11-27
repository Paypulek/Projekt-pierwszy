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

     public static void PokażZakupy()
        {
            foreach (var item in ListaZakupowa)
            {
                Console.WriteLine(item.produkt.nazwa + "  x " + item.ilość + " Lączna cena wynosi: " + (item.produkt.cena * item.ilość));

            }
        }

        public static void PoliczCenę()
        {
            int cena =0;
            foreach (var item in ListaZakupowa)
            {
                 cena =+ item.produkt.cena * item.ilość;
            }
            Console.WriteLine("Cena wynosi" + cena);

        }
     

    
}