namespace Nowy
{
    public class EkranGłówny : EkranBase
    {
        public EkranGłówny()
        {



        }
        public override void WyświetlEkran()
        {
            Console.WriteLine("[1] - Zobacz liste do kupienia");
            Console.WriteLine("[2] - Zobacz co kupiłeś");
            Console.WriteLine("[3] - Policz koszt wysyłki");
        }

        public override void WykonajKomende(ConsoleKey key)
        {

        }

    }
    public class EkranZakupy : EkranBase
    {
        public override void WyświetlEkran()
        {
            Console.WriteLine("[1] - Zobacz liste do kupienia");
            Console.WriteLine("[2] - Zobacz co kupiłeś");
            Console.WriteLine("[3] - Policz koszt wysyłki");
        }

        public override void WykonajKomende(ConsoleKey key)
        {
            switch (key)
            {

            }
        }

    }

    public class EkranMagazynu : EkranBase
    {
        public override void WyświetlEkran()
        {
            Console.WriteLine("[1] - Zobacz liste do kupienia");
            Console.WriteLine("[2] - Zobacz co kupiłeś");
            Console.WriteLine("[3] - Policz koszt wysyłki");
        }

        public override void WykonajKomende(ConsoleKey key)
        {

        }
    }

    interface IEkran
    {
        public void WyświetlEkran();
        public void WykonajKomende(ConsoleKey key);
    }
     public abstract class EkranBase : IEkran
    {
        public virtual void WykonajKomendę(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.Escape:
                    ObsługaEkranów.PoprzedniEkran();
                    break;
                default:
                    ObsługaEkranów.NowyEkran(this);
                    break;
            }
        }

        public abstract void WyświetlEkran(ConsoleKey key);
    }




    public static class ObsługaEkranów
    {
        public static void PoprzedniEkran()
        {

        }

        public static void NowyEkran(IEkran ekran)
        {
            ekran.WyświetlEkran();

            var wybór = Console.ReadKey();

            ekran.WykonajKomende(wybór.Key);
        }


    }
}