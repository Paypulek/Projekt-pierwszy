namespace Nowy
{
    public static class ObslugaEkranu
    {

        public static void NowyEkran(IEkran ekran)
        {
            ekran.WyświetlEkran();

            var wybór = Console.ReadKey();

            ekran.WykonajKomende(wybór.Key);
        }


    }
}