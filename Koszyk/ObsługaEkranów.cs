namespace Koszyk
{
    public static class ObsługaEkranów
    {
        public static void PoprzedniEkran()
        {

        }

        public static void NowyEkran(IEkran ekran)
        {
            while(true)
            {
            ekran.WyświetlEkran();

            var wybór = Console.ReadKey();
            if (wybór.Key == ConsoleKey.D9)
            break;

            ekran.WykonajKomendę(wybór.Key);
            }
        }


    }
}