public class Klient
{
    public Klient(string IN, string M, int Stopy, int Ramki, int PodestyD, int PodestKom, int Stężenie, int Barierki, int SłupkiDoBar )
    {
            imieNazwisko = IN;
            miasto=M;
            stopy=Stopy;
            ramki=Ramki;
            podestyDrewniane=PodestyD;
            podestKomunikacyjny=PodestKom;
            stężenie=Stężenie;
            barierki=Barierki;
            słupkiDoBarierek=SłupkiDoBar;
            Console.WriteLine("Dodałem nowego wynajmującego!");
    }
    public string imieNazwisko{get;}
    public string miasto
    {get;}

    public int stopy {get;}
    public int ramki {get;}
    public int podestyDrewniane {get;}
    public int podestKomunikacyjny {get;}
    public int stężenie {get;}
    public int barierki {get;}
    public int słupkiDoBarierek {get;}

    public void OdczytajKlientow()
    {
        Console.WriteLine(imieNazwisko);
        Console.WriteLine(miasto);
        Console.WriteLine("Liczba stóp: " + stopy);
        Console.WriteLine("Liczba ramek: " + ramki);
        Console.WriteLine("Liczba podestów drewnianych: " + podestyDrewniane);
        Console.WriteLine("Liczba podestów komunikacyjnych: " + podestKomunikacyjny);
        Console.WriteLine("Liczba stężenia: " + stężenie);
        Console.WriteLine("Liczba barierk: " + barierki);
        Console.WriteLine("Liczba słupków do barierek: " + słupkiDoBarierek);
    }
}