namespace Koszyk
{
    public class EkranBazowy : EkranBase
    {
        private Magazyn _magazyn = new Magazyn();

        public EkranBazowy podstawoy = new EkranBazowy();


        public EkranBazowy()
        {
            _magazyn.Dodaj(new Produkt(20, "Książka"), 10);
            _magazyn.Dodaj(new Produkt(15, "Piłka"), 20);
            _magazyn.Dodaj(new Produkt(30, "Koszulka"), 14);
            _magazyn.Dodaj(new Produkt(120, "Zacisk Hamulcowy"), 17);
            _magazyn.Dodaj(new Produkt(100, "Łuk"), 18);
        }

        public override void WyświetlEkran()
        {
            Console.WriteLine("");
            Console.WriteLine("[1] - Kup produkt");
            Console.WriteLine("[2] - Sprawdź co jest na magazynie");
            Console.WriteLine("[3] - Sprawdź listę zakupów");
            Console.WriteLine("[4] - Policz cene");
            Console.WriteLine("[Esc] - Wyjdź");

        }

        public override void WykonajKomendę(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.D1:
                    ObsługaEkranów.NowyEkran(new EkranZakupu(_magazyn));
                    break;
                case ConsoleKey.D2:
                    ObsługaEkranów.NowyEkran(new EkranMagazynu(_magazyn));
                    Console.WriteLine("---------------");
                    break;
                case ConsoleKey.D3:
                    break;
                case ConsoleKey.D9:
                    return;
                default:
                    base.WykonajKomendę(key);
                    break;
            }
        }
    }
}