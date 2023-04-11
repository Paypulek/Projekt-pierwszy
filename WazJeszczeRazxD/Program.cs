﻿using System;
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
    public static int przesuniecie = 60;
    public static int bezprzesuniecia = 0;
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
                Console.CursorVisible = false;
                Gra pierwsza = new Gra(0);
                 Gra druga = new Gra(60);
                pierwsza.odpalGre();
                 druga.odpalGre();
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
    public static int x;
    public Snake waz;
    public int zmiennikPrzesuniecia;

    public double Tempo = 250;

    public void Szybciej(double n) => Tempo /= n;

    private Jabłko nagroda;
    public Gra()
    {}
    public Gra(int zmienna)
    {
        zmiennikPrzesuniecia = zmienna;
        x++;
    }

    public void Inicjuj()
    {
        waz = new Snake(new Pozycja(10, (10 + zmiennikPrzesuniecia)), 1,zmiennikPrzesuniecia);
        nagroda = new Jabłko(zmiennikPrzesuniecia);
        nagroda.losujPozycje(zmiennikPrzesuniecia);
    }

    public void odpalGre()
    {
        this.Inicjuj();
        Thread t = new Thread(this.WyświetlGre);
        Thread t1 = new Thread(this.AktualizacjaGry);
        t.Start();
        t1.Start();
    }

    public void CzyZjadłNagrode()
    {
        if (waz.Głowa.Equals(nagroda.MiejsceJablka))
        {
            nagroda.losujPozycje(zmiennikPrzesuniecia);
            waz.Rosnij();
            this.Szybciej(1.3);
        }
    }

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
        switch (key)
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

        _kierunekWeza = kierunekWeza;
    }

    public void WyświetlGre()
    {
        do
        {
            Console.Clear();
            this.wyswietlRamki();
            waz.wyswietl();
            nagroda.wyswietl();
            Thread.Sleep(100);
        } while (!GameOver);
    }
    public void AktualizacjaGry()
    {
        do
        {
            var keyInfo = Console.ReadKey(true);
            while (Console.KeyAvailable == false)
            {
                waz.Ruch(_kierunekWeza);
                this.CzyZjadłNagrode();
                this.zmianaKierunku(keyInfo.Key);
                Thread.Sleep(200);
            }


        } while (!GameOver);
    }
    public void wyswietlRamki()
    {
        int gora = 15;
        int lewo = 30 + zmiennikPrzesuniecia;
        Console.ForegroundColor = ConsoleColor.Green;
        for (int i = 0; i <= lewo; i++)
        {
            if (i <= gora)
            {
                Console.SetCursorPosition(zmiennikPrzesuniecia, i);
                Console.Write("*");
                Console.SetCursorPosition(lewo, i);
                Console.Write("*");
            }
            if (i >= zmiennikPrzesuniecia)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("*");
                Console.SetCursorPosition(i, gora);
                Console.Write("*");
            }
        }
    }
}
public class Jabłko
{
    public Pozycja MiejsceJablka;
    public int przesuniecie;
    public Jabłko(int Przesuniecie)
    {
        przesuniecie=Przesuniecie;
    }

    public void wyswietl()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(MiejsceJablka.Lewo, MiejsceJablka.Góra);
        Console.Write("x" +  "  x:" + Gra.x + " przes:" + przesuniecie);
    }

    public void losujPozycje(int przesuniecie)
    {
        Random gen = new Random();
        Pozycja zwróć = new Pozycja(gen.Next(15), gen.Next(przesuniecie, (30 + przesuniecie)));
        this.MiejsceJablka = zwróć;
    }
}

public class Snake 
{

    private List<Pozycja> ciało;
    private int Długosc;
    public bool Śmierć;
    public int przesuniecie;


    public Snake(Pozycja pozycjaPoczatkowa, int poczatkowaDlugosc,int Przesuniecie)
    {
        przesuniecie=Przesuniecie;

        ciało = new List<Pozycja> { pozycjaPoczatkowa };
        Długosc = Math.Max(0, poczatkowaDlugosc);
        Śmierć = false;
    }
    public Pozycja Głowa => ciało.First();

    private bool PozycjaZla(Pozycja pozycja) =>
    ((pozycja.Góra >= 0 && (pozycja.Lewo >= (0 + przesuniecie)) && pozycja.Góra <= 15 && (pozycja.Lewo <= (30 + przesuniecie))));

    public void Rosnij()
    {
        Długosc++;
    }


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

        if (ciało.Contains(kolejnaPozycja) || !PozycjaZla(kolejnaPozycja))
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

public enum Kierunek
{
    Góra,
    Dół,
    Prawo,
    Lewo

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


