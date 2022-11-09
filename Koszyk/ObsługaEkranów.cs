namespace Koszyk
{
    public static class ObsługaEkranów
    {
        public static void PoprzedniEkran()
        {
        }

        public static void NowyEkran(IEkran ekran)
        {
            ekran.WyświetlEkran();

            var wybór = Console.ReadKey();

            ekran.WykonajKomendę(wybór.Key);
        }
    }
}