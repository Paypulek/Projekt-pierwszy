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
    public static Gra pierwszaGra = new Gra(0);
    public static Gra drugaGra = new Gra(60);
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
                //   if (ileGraczy == LiczbaGraczy.JedenGracz)
                //  {

                //      pierwszaGra.odpalGre();
                //   }
                //   else
                //   {
                  //    Thread wyswietlanie = new Thread(StanAplikacji.WyświetlDwieGry);
                      Thread sterowanie = new Thread(StanAplikacji.przekażGuzik);
                  //    Thread aktualizacja1 = new Thread(MenuWyboru.pierwszaGra.AktualizacjaGry);
                  //    Thread aktualizacja2 = new Thread(MenuWyboru.drugaGra.AktualizacjaGry);

                      sterowanie.Start();
                 //     aktualizacja1.Start();
                 //    aktualizacja2.Start();
                 //     wyswietlanie.Start();
                // }

                while (!MenuWyboru.gameOver)
                {
                    Console.Clear();
                    StanAplikacji.WyświetlDwieGry();
                    MenuWyboru.pierwszaGra.AktualizacjaGry();
                    MenuWyboru.drugaGra.AktualizacjaGry();
                }
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

public static class StanAplikacji
{
    public static ConsoleKeyInfo klawiszOgólny = new ConsoleKeyInfo();
    public static ConsoleKey klawiszGracza1 = new ConsoleKey();
    public static ConsoleKey klawiszGracza2 = new ConsoleKey();

    public static void WyświetlDwieGry()
    {
        // while (!MenuWyboru.gameOver)
        {
            MenuWyboru.pierwszaGra.WyświetlGre();
            MenuWyboru.drugaGra.WyświetlGre();
            StanAplikacji.WyswietlPunkty();
            Thread.Sleep(10);
            //  }
        }
    }

    public static void WyswietlPunkty()
    {
        Console.SetCursorPosition(40,5);
        Console.Write("Dlugosc Lewaka:" + MenuWyboru.pierwszaGra.waz.liczbaPunktów );
        Console.SetCursorPosition(40,6);
        Console.Write("Dlugosc Prawaka:" + MenuWyboru.drugaGra.waz.liczbaPunktów);
    }
    public static void przekażGuzik()
    {
        while (!MenuWyboru.gameOver)
        {
            klawiszOgólny = Console.ReadKey();

            switch (klawiszOgólny.Key)
            {
                case ConsoleKey.A:
                    klawiszGracza2 = ConsoleKey.LeftArrow;
                    break;
                case ConsoleKey.W:
                    klawiszGracza2 = ConsoleKey.UpArrow;
                    break;
                case ConsoleKey.D:
                    klawiszGracza2 = ConsoleKey.RightArrow;
                    break;
                case ConsoleKey.S:
                    klawiszGracza2 = ConsoleKey.DownArrow;
                    break;
                case ConsoleKey.UpArrow:
                    klawiszGracza1 = klawiszOgólny.Key;
                    break;
                case ConsoleKey.DownArrow:
                    klawiszGracza1 = klawiszOgólny.Key;
                    break;
                case ConsoleKey.LeftArrow:
                    klawiszGracza1 = klawiszOgólny.Key;
                    break;
                case ConsoleKey.RightArrow:
                    klawiszGracza1 = klawiszOgólny.Key;
                    break;
                default:
                    break;

            }
            MenuWyboru.pierwszaGra.PrzekażKlawiszDoGry(klawiszGracza1);
            MenuWyboru.drugaGra.PrzekażKlawiszDoGry(klawiszGracza2);
        }

    }

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
    ConsoleKey key = new ConsoleKey();
    public static int zmiennikGryLicznik;
    public Kierunek kierunekWeza;
    public Kierunek _kierunekWeza = Kierunek.Góra;
    public bool GameOver = false;
    public static int x;
    public Snake waz;
    public int zmiennikPrzesuniecia;

    public double Tempo = 150;

    public void Szybciej(double n) => Tempo /= n;
    private Jabłko nagroda;
    public Gra(int przesuniecie)
    {
        key = ConsoleKey.UpArrow;
        zmiennikPrzesuniecia = przesuniecie;
        nagroda = new Jabłko(zmiennikPrzesuniecia);
        waz = new Snake(new Pozycja(10, 10 + zmiennikPrzesuniecia), 1, zmiennikPrzesuniecia);

    }

    public void odpalGre()
    {
        Thread t = new Thread(this.WyświetlGre);
        Thread t1 = new Thread(this.AktualizacjaGry);
        t.Start();
        t1.Start();
    }

    public void PrzekażKlawiszDoGry(ConsoleKey Key)
    {
        key = Key;
    }

    public void CzyZjadłNagrode()
    {
        if (waz.Głowa.Equals(nagroda.MiejsceJablka))
        {
            nagroda.losujPozycje();
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



    public void zmianaKierunku()
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
        // do
        // {
        //Console.Clear();
        this.wyswietlRamki();
        waz.wyswietl();
        nagroda.wyswietl();

        // } while (!GameOver);
    }

    
    public void AktualizacjaGry()
    {
        // do
        //  {
        // var keyInfo = Console.ReadKey(true);
        // while (Console.KeyAvailable == false)
        // {
        waz.Ruch(_kierunekWeza);
        this.CzyZjadłNagrode();
        this.zmianaKierunku();
        Thread.Sleep((int)Tempo);
        // }


        // } while (!GameOver);
    }
    public void wyswietlRamki()
    {
        int gora = 15;
        int lewo = 30 + zmiennikPrzesuniecia;
        Console.ForegroundColor = ConsoleColor.Green;
        for (int i = 0 ; i <= lewo; i++)
        {
            if (i <= gora)
            {
                Console.SetCursorPosition(zmiennikPrzesuniecia, i);
                Console.Write("*");
                Console.SetCursorPosition(lewo, i);
                Console.Write("*");
            }
            Console.SetCursorPosition(i, 0);
            Console.Write("*");
            Console.SetCursorPosition(i, gora);
            Console.Write("*");
        }
    }
}
public class Jabłko
{
    public int ZmiennikPrzesuniecia;
    public Pozycja MiejsceJablka;
    public Jabłko(int zmiennikPrzesuniecia)
    {
        ZmiennikPrzesuniecia = zmiennikPrzesuniecia;
        Random gen = new Random();
        Pozycja zwróć = new Pozycja(gen.Next(15), gen.Next(ZmiennikPrzesuniecia, ZmiennikPrzesuniecia + 30));
        MiejsceJablka = zwróć;
    }

    public void wyswietl()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(MiejsceJablka.Lewo, MiejsceJablka.Góra);
        Console.Write("x");
    }

    public void losujPozycje()
    {
        Random gen = new Random();
        Pozycja zwróć = new Pozycja(gen.Next(15), gen.Next(ZmiennikPrzesuniecia, ZmiennikPrzesuniecia + 30));
        this.MiejsceJablka = zwróć;
    }
}
public class Snake
{
    int zmiennikPrzesuniecia;
    public int liczbaPunktów;

    private List<Pozycja> ciało;
    public int Długosc;
    public bool Śmierć;


    public Snake(Pozycja pozycjaPoczatkowa, int poczatkowaDlugosc, int ZmiennikPrzesuniecia)
    {
        zmiennikPrzesuniecia = ZmiennikPrzesuniecia;
        ciało = new List<Pozycja> { pozycjaPoczatkowa };
        Długosc = Math.Max(0, poczatkowaDlugosc);
        Śmierć = false;
    }
    public Pozycja Głowa => ciało.First();

    private bool PozycjaZla(Pozycja pozycja) =>
    pozycja.Góra >= 0 && pozycja.Lewo >= (0 + zmiennikPrzesuniecia) && pozycja.Góra <= 15 && pozycja.Lewo <= (30 + zmiennikPrzesuniecia);

    public void Rosnij()
    {
        Długosc++;
        liczbaPunktów++;
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


