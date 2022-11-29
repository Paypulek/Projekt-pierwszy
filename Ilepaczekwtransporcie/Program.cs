


namespace Transport;

class Program
{
    public static void Main()
    {
        Paczka Ładownia = new Paczka(180,150, 200);
        Paczka Duża = new Paczka(80, 90, 100);
        Paczka Średnia = new Paczka(29, 50, 33);
        Paczka Mniejsza = new Paczka(10, 15, 20);
        Console.ReadLine();
        Duża.OptymalneUłożenie(Ładownia);
        Średnia.OptymalneUłożenie(Duża);
        Mniejsza.OptymalneUłożenie(Średnia);
        int ileWejdzie = Duża.IleWejdzie(Ładownia) * Średnia.IleWejdzie(Duża) * Mniejsza.IleWejdzie(Średnia);
        Console.WriteLine(Duża.IleWejdzie(Ładownia) + " <-- Duża w ładowni" + Średnia.IleWejdzie(Duża) + "<-- Średnia w dużej " + Mniejsza.IleWejdzie(Średnia) + " <---Mała w średniej");
        Console.WriteLine(ileWejdzie);
        Console.WriteLine(Średnia.IleWejdzie(Ładownia) + "Średnia w ładowni bez ułożenia");
        Średnia.PokażMojeZmienne();
        Średnia.OptymalneUłożenie(Ładownia);
        Średnia.PokażMojeZmienne();
        Console.WriteLine(Średnia.IleWejdzie(Ładownia)+ " Średnia ile wejdzie po ułożeniu");
        Console.WriteLine(Mniejsza.IleWejdzie(Ładownia));
        Mniejsza.OptymalneUłożenie(Ładownia);
        Console.WriteLine(Mniejsza.IleWejdzie(Ładownia));


    }
}
