namespace Koszyk;
public static class StanAplikacji
{
    public static Magazyn Magazyn {get;} = new Magazyn();
    public static List<RekordRachunku> ListaZakupowa {get;} = new List<RekordRachunku>();
     private static List<StanProduktu> _produkty = new List<StanProduktu>();
     
     public static void InicjujProdukty()
     {
        StanAplikacji.Magazyn.Dodaj(new Produkt(20, "Książka", Paczka.MałaPaczka), 10);
            StanAplikacji.Magazyn.Dodaj(new Produkt(15, "Piłka",Paczka.ŚredniaPaczka), 20);
            StanAplikacji.Magazyn.Dodaj(new Produkt(30, "Koszulka",Paczka.MałaPaczka), 14);
            StanAplikacji.Magazyn.Dodaj(new Produkt(120, "Rower", Paczka.DużaPaczka), 17);
            StanAplikacji.Magazyn.Dodaj(new Produkt(100, "SuperGra",Paczka.CyfrowyProdukt), 18);
     }

     public static void PokażZakupy()
        {
            Console.WriteLine("");
            foreach (var item in ListaZakupowa)
            {
                
                Console.WriteLine(item.produkt.nazwa + "  x " + item.ilość + " Lączna cena wynosi: " + (item.produkt.cena * item.ilość));

            }
        }
        public static void PokażCene()
        {
            Console.WriteLine("");
            Console.WriteLine("Cena wynosi :" + PoliczCenę());
        }


        public static int PoliczCenę()
        {
            Console.WriteLine("");
            int cena =0;
            foreach (var item in ListaZakupowa)
            {
                 cena += item.produkt.cena * item.ilość;
            }
            Console.WriteLine("Cena zamówienia przy odbiorze osobistym wynosi: " + cena);
            return cena;

        }

        public static void PokażCeneWysyłki()
        {
            int cena = PoliczCenę();
            foreach (var item in ListaZakupowa)
            {
                cena += ((int)item.produkt.rodzajOpakowania* item.ilość);
            }

            Console.WriteLine("Cena całego zamówienia wraz z wysyłką wynosi: " + cena);

        }
     

    
}