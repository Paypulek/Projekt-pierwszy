namespace Nowy
{
    class Program
    {
        public static void Main()
        {
            Magazyn _magazyn = new Magazyn();
            _magazyn.DodajNaMagazyn(new Produkt("Telefon", 150, 1));
            _magazyn.DodajNaMagazyn(new Produkt("UsługaPowiadomieniaOBurzy", 50, 0));
            _magazyn.DodajNaMagazyn(new Produkt(TV, 125, 2));
            _magazyn.DodajNaMagazyn(new Produkt(Rower, 250, 3));
            _magazyn.DodajNaMagazyn(new Produkt(Latarka, 50, 1));
            _magazyn.DodajNaMagazyn(new Produkt(Mikrofalówka, 75, 2));
            _magazyn.DodajNaMagazyn(new Produkt(PanelFotowoltaiczny, 350, 3));
            ObsługaEkranu.NowyEkran(new EkranGłówny());

        }
    }
}