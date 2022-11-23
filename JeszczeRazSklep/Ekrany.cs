namespace Nowy
{
    public class EkranGłówny : IEkran
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

        public override void WykonajKomende()
        {

        }

    }
    public class EkranZakupy : IEkran
    {

    }

    public class EkranMagazynu : IEkran
    {

    }

    interface IEkran
    {
        void WyświetlEkran();
        void WykonajKomende();
    }
}