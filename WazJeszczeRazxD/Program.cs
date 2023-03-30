using System;
using System.Collections.Generic;

public static class Program
{
    public static void Main()
    {



        MenuWyboru.wyświetl();
        var key = Console.ReadKey();
        MenuWyboru.WykonajKomende(key.Key);

    }
}
public static class MenuWyboru
{
    public static bool gameOver = false;
    public static LiczbaGraczy ileGraczy;
    public static void wyświetl()
    {
        Console.Clear();
        Console.SetCursorPosition(20, 10);
        if (ileGraczy == LiczbaGraczy.JedenGracz)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Jeden Gracz");
            Console.SetCursorPosition(20, 11);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Dwoch Graczy");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Jeden Gracz");
            Console.SetCursorPosition(20, 6);
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
            Console.CursorVisible=false;
                Gra pierwsza = new Gra();
                pierwsza.PetlaGry();
                break;
            case ConsoleKey.Escape:
                MenuWyboru.gameOver = true;
                break;


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



public class Gra
{

    public Kierunek kierunekWeza;
    public Kierunek _kierunekWeza = Kierunek.Góra;
    public bool GameOver = false;
    public Snake waz = new Snake(new Pozycja(10,10),1);
    private int numerGry { get; }
    public Gra()
    {
        liczbaGier++;
    }
    private static int liczbaGier = 0;

     private static Kierunek RuchWSiebie(Kierunek direction)
    {
        switch (direction)
        {
            case Kierunek.Góra: return Kierunek.Dół;
            case Kierunek.Lewo: return Kierunek.Prawo;
            case Kierunek.Prawo: return Kierunek.Lewo;
            case Kierunek.Dół: return Kierunek.Góra;
            default: throw new ArgumentOutOfRangeException();
        }
    }

    public void zmianaKierunku(ConsoleKey key)
    {
        switch(key)
        {
            case ConsoleKey.UpArrow:
            kierunekWeza = Kierunek.Góra;
            break;
            case ConsoleKey.DownArrow:
            kierunekWeza = Kierunek.Dół;
            break;
            case ConsoleKey.LeftArrow:
            kierunekWeza = Kierunek.Lewo;
            break;
            case ConsoleKey.RightArrow:
            kierunekWeza = Kierunek.Prawo;
            break;
            default:
            return;
        }

        if (kierunekWeza == RuchWSiebie(_kierunekWeza))
        {
            return;
        }

        _kierunekWeza=kierunekWeza;
    }
    public void PetlaGry()
    {
        do
        {
            var keyInfo=Console.ReadKey(true);
            while (Console.KeyAvailable==false)
            {
            
        Console.Clear();
        this.wyswietlRamki(30,15);
        waz.wyswietl();
        waz.Ruch(_kierunekWeza);
        this.zmianaKierunku(keyInfo.Key);
        Thread.Sleep(250);
            }


        } while (!GameOver);
    }
    public void wyswietlRamki(int lewo, int gora)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        for (int i = 0; i <= lewo; i++)
        {
            if (i <= gora)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("*");
                Console.SetCursorPosition(lewo, i);
                Console.Write("*");
            }
            Console.SetCursorPosition(i, 0);
            Console.Write("*");
            Console.SetCursorPosition(i, gora);
            Console.Write("*");
        }
        Console.ReadKey();
    }

}

public enum Kierunek
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

    private static bool PozycjaZla(Pozycja pozycja) =>
    pozycja.Góra>=0&&pozycja.Lewo>=0&&pozycja.Góra<=15&&pozycja.Lewo<=30;



    public void Ruch(Kierunek kierunek)
    {
        if (Śmierć) throw new InvalidOperationException();
        Pozycja kolejnaPozycja;
        switch (kierunek)
        {
            case Kierunek.Dół:
                kolejnaPozycja = Głowa.wDólO(1);
                break;
                case Kierunek.Góra:
                 kolejnaPozycja = Głowa.wDólO(-1);
                break;
                case Kierunek.Lewo:
                kolejnaPozycja = Głowa.wPrawoO(-1);
                break;
                case Kierunek.Prawo:
                kolejnaPozycja = Głowa.wPrawoO(1);
                break;
                default:
                throw new ArgumentOutOfRangeException();
        }
                
                if (ciało.Contains(kolejnaPozycja)||!PozycjaZla(kolejnaPozycja))
        {
            Śmierć = true;
            return;
        }

        ciało.Insert(0, kolejnaPozycja);

        if (Długosc > 0)
        {
            Długosc--;
        }
        else
        {
            ciało.RemoveAt(ciało.Count - 1);
        }

        

    }

    public void wyswietl()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
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


