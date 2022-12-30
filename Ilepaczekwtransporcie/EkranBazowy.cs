namespace Transport;
public class EkranBazowy : IEkran
{
    public void WyświetlEkran()
    {
        Console.WriteLine("[1] - Dodaj paczkę");
         if (StanAplikacji.Ładownia == null)
          Console.WriteLine("[2] - Podaj wymiary  ladowni");
        Console.WriteLine("[3] - Sprawdź ile wejdzie paczek");
        Console.WriteLine("[4] - Sprawdź ile wejdzie paczek 2  rozne wymiary");
    }

    public void WykonajKomende(ConsoleKey key)
    {
        switch (key)
            {
                case ConsoleKey.D1:
                StanAplikacji.ListaPaczek.Add(new StanPaczek());

                    break;
                case ConsoleKey.D2:
                    if (StanAplikacji.Ładownia == null)
                    {
                    StanAplikacji.Ładownia = new Paczka();
                    break;
                    }
                    break;
                case ConsoleKey.D3:
                    StanAplikacji.Ładownia.OptymalneUłożenie(StanAplikacji.ListaPaczek[0].Paczka);
                    break;
                case ConsoleKey.D4:
                    StanAplikacji.Ładownia.Ilezmieszczę(StanAplikacji.małaPaczka, StanAplikacji.średniaPaczka);
                    return;
                default:

                    break;
            }
    }
}


