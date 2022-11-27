namespace Koszyk
{
    public class EkranBazowy : EkranBase
    {





        public EkranBazowy()
        {

        }

        public override void WyświetlEkran()
        {
            Console.WriteLine("");
            Console.WriteLine("[1] - Kup produkt");
            Console.WriteLine("[2] - Sprawdź co jest na magazynie");
            Console.WriteLine("[3] - Sprawdź listę zakupów");
            Console.WriteLine("[4] - Policz cene");
            Console.WriteLine("[9] - Wyjdź");

        }

        public override void WykonajKomendę(ConsoleKey key)
        {


            switch (key)
            {
                case ConsoleKey.D1:
                    ObsługaEkranów.NowyEkran(new EkranZakupu());
                    break;
                case ConsoleKey.D2:
                    ObsługaEkranów.NowyEkran(new EkranMagazynu(StanAplikacji.Magazyn));
                    Console.WriteLine("---------------");
                    break;
                case ConsoleKey.D3:
                    StanAplikacji.PokażZakupy();
                    break;
                case ConsoleKey.D4:
                StanAplikacji.PoliczCenę();
                    return;
                default:
                    base.WykonajKomendę(key);
                    break;
            }

        }
    }
}