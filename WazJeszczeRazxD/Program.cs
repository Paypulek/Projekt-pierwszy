using System;
using System.Collections.Generic;

public static class Program
{
    public static void Main()
    {

        MenuWyboru.wyświetl();
        var key = Console.ReadKey();
        MenuWyboru.WykonajKomende(key.Key);
        MenuWyboru.wyświetl();
    }
}
public static class MenuWyboru
{
    public static LiczbaGraczy ileGraczy;
    public static void wyświetl()
    {
        Console.Clear();
        Console.SetCursorPosition(5, 5);
        if (ileGraczy == LiczbaGraczy.JedenGracz)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Jeden Gracz");
            Console.SetCursorPosition(5, 6);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Dwoch Graczy");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Jeden Gracz");
            Console.SetCursorPosition(5, 6);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Dwoch Graczy");
        }
    }

    public static void WykonajKomende(ConsoleKey Key)
    {
        switch (Key)
        {
            case ConsoleKey.UpArrow:
                ileGraczy++;
                break;
            case ConsoleKey.DownArrow:
                ileGraczy--;
                break;
            case ConsoleKey.Enter:


            default:
                break;
        }

    }

}
public enum LiczbaGraczy
{
    JedenGracz,
    DwochGraczy
}

public struct Pozycja
{
    public int Lewo;
    public int Góra;

    public Pozycja(int góra, int lewo)
    {
        Lewo = lewo;
        Góra = góra;
    }

    public Pozycja wPrawoO(int n) => new Pozycja(Góra, Lewo + n);
    public Pozycja wDólO(int n) => new Pozycja(Góra + n, Lewo);

}



public class Gra : IWyswietlanie
{
    public void wyswietlRamki(int góra, int lewo)
    {
        
    }

}

enum Kierunek
{
    Góra,
    Dół,
    Prawo,
    Lewo

}

public class Snake : IWyswietlanie
{
    private List<Pozycja> ciało;
    private int Długosc;
    public bool Śmierć;

    public Snake(Pozycja pozycjaPoczatkowa, int poczatkowaDlugosc)
    {
        ciało = new List<Pozycja> { pozycjaPoczatkowa };
        Długosc = Math.Max(0, poczatkowaDlugosc);
        Śmierć = false;
    }
    private Pozycja Głowa => ciało.First();

    public void Ruch(Kierunek kierunek)
    {
        if (Śmierć) throw new InvalidOperationException();
        Pozycja kolejnaPozycja;
        switch (kierunek)
        {
            case Kierunek.Dół:
                kolejnaPozycja = Głowa.wDólO(1);
                break;
        }

    }

    public void wyswietl()
    {
        Console.SetCursorPosition(Głowa.Lewo, Głowa.Góra);
        Console.Write("◉");

        foreach (var position in ciało)
        {
            Console.SetCursorPosition(position.Lewo, position.Góra);
            Console.Write("■");
        }

    }

}


interface IEkran
{
    public void wyswietl();
    public void wykonajKomende(ConsoleKey key);
}

public interface IWyswietlanie
{
    public void wyswietl();
}


