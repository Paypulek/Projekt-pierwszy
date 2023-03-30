using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

public static class Program
{
    public static async Task Main(string[] args0)
    {
        var przerwaTykniecia = TimeSpan.FromMilliseconds(100);
        var wazGra = new WążGra();
        Console.ReadKey();

        using (var cts = new CancellationTokenSource()) //przerwanie wykonywania zadania
        {
            async Task MonitorKeyPresses() //zadanie oczekujace na wcisniecie klawisza
            {
                while (!cts.Token.IsCancellationRequested)
                {
                    if (Console.KeyAvailable)
                    {
                        var key = Console.ReadKey(intercept: true).Key;
                        wazGra.WcisniecieKlawisza(key);
                    }

                    await Task.Delay(10);
                }
            }

            var czekanieNaKlawisz = MonitorKeyPresses();

            do
            {
                wazGra.JednaKlatkaGry();
                wazGra.Render();
                await Task.Delay(przerwaTykniecia);
            }while(!wazGra.GameOver);
        }
    }
}

enum Kierunki
{
    Góra,
    Dół,
    Prawo,
    Lewo
}

interface IRenderable
{
    void Render();
}

readonly struct Pozycja
{
    public Pozycja(int góra, int lewo)
    {
        Góra = góra;
        Lewo = lewo;
    }

    public int Góra { get; }
    public int Lewo { get; }

    public Pozycja wPrawo(int n) => new Pozycja(Góra, Lewo + n);
    public Pozycja wDół(int n) => new Pozycja(Góra + n, Lewo);
}

class Cukierek : IRenderable
{
    public Cukierek(Pozycja pozycja)
    {
        Pozycja = pozycja;
    }

    public Pozycja Pozycja { get; }
    public void Render()
    {
        Console.SetCursorPosition(Pozycja.Lewo, Pozycja.Góra);
        Console.Write("O");
    }
}

class Wąż : IRenderable
{
    private List<Pozycja> _ciało;
    private int _iloscSegmentow;

    public Wąż(Pozycja pozycjaStartowa, int inicjalizacjaWzrostu = 1)
    {
        _ciało = new List<Pozycja> { pozycjaStartowa };
        _iloscSegmentow = Math.Max(0, inicjalizacjaWzrostu - 1);
        Śmierć = false;
    }
    public bool Śmierć { get; private set; }
    public Pozycja Głowa => _ciało.First();
    private IEnumerable<Pozycja> Ciało => _ciało.Skip(1);

    public void Ruch(Kierunki kierunek)
    {
        if (Śmierć) throw new InvalidOperationException();
        Pozycja nowaGłowa;

        switch (kierunek)
        {
            case Kierunki.Góra:
                nowaGłowa = Głowa.wDół(-1);
                break;

            case Kierunki.Lewo:
                nowaGłowa = Głowa.wPrawo(-1);
                break;

            case Kierunki.Dół:
                nowaGłowa = Głowa.wDół(1);
                break;

            case Kierunki.Prawo:
                nowaGłowa = Głowa.wPrawo(1);
                break;

            default:
                throw new ArgumentOutOfRangeException();
        }

        if (_ciało.Contains(nowaGłowa) || !PozycjaJestZła(nowaGłowa))
        {
            Śmierć = true;
            return;
        }
        _ciało.Insert(0, nowaGłowa);

        if (_iloscSegmentow > 0)
        {
            _iloscSegmentow--;
        }

        else
        {
            _ciało.RemoveAt(_ciało.Count - 1);
        }
    }

    public void Rośnij()
    {
        if (Śmierć) throw new InvalidOperationException();
        _iloscSegmentow++;
    }

    public void Render()
    {
        Console.SetCursorPosition(Głowa.Lewo, Głowa.Góra);
        Console.Write("x");
        foreach (var pozycja in Ciało)
        {
            Console.SetCursorPosition(pozycja.Lewo, pozycja.Góra);
            Console.Write("0");
        }
    }

    private static bool PozycjaJestZła(Pozycja pozycja) =>
        pozycja.Góra >= 0 && pozycja.Lewo >= 0;
}

class WążGra : IRenderable
{
    private static readonly Pozycja Poczatkowa = new Pozycja(0, 0);

    private Kierunki _aktualnyKierunek;
    private Kierunki _następnyKierunek;
    private Wąż _wąż;
    private Cukierek _cukierek;

    public WążGra()
    {
        _wąż = new Wąż(Poczatkowa, inicjalizacjaWzrostu: 5);
        _cukierek = StwórzCukierek();
        _aktualnyKierunek = Kierunki.Prawo;
        _następnyKierunek = Kierunki.Prawo;
    }

    public bool GameOver => _wąż.Śmierć;

    public void WcisniecieKlawisza(ConsoleKey key)
    {
        Kierunki nowyKierunek;
        switch (key)
        {
            case ConsoleKey.W:
                nowyKierunek = Kierunki.Góra;
                break;

            case ConsoleKey.A:
                nowyKierunek = Kierunki.Lewo;
                break;

            case ConsoleKey.S:
                nowyKierunek = Kierunki.Dół;
                break;

            case ConsoleKey.D:
                nowyKierunek = Kierunki.Prawo;
                break;

            default:
                return;

        }

        if (nowyKierunek == CzyFikołek(_aktualnyKierunek))
        {
            return;
        }
        _następnyKierunek = nowyKierunek;
    }

    public void JednaKlatkaGry()
    {
        if (GameOver) throw new InvalidOperationException();

        _aktualnyKierunek = _następnyKierunek;
        _wąż.Ruch(_aktualnyKierunek);

        if (_wąż.Głowa.Equals(_cukierek.Pozycja))
        {
            _wąż.Rośnij();
            _cukierek = StwórzCukierek();
        }
    }

    public void Render()
    {
        Console.Clear();
        _wąż.Render();
        _cukierek.Render();
        Console.SetCursorPosition(0, 0);
    }

    private static Kierunki CzyFikołek(Kierunki kierunek)
    {

        switch (kierunek)
        {
            case Kierunki.Góra: return Kierunki.Dół;
            case Kierunki.Dół: return Kierunki.Góra;
            case Kierunki.Lewo: return Kierunki.Prawo;
            case Kierunki.Prawo: return Kierunki.Lewo;
            default: throw new ArgumentOutOfRangeException();
        }
    }

    private static Cukierek StwórzCukierek()
    {
        const int liczbaWierszy = 20;
        const int liczbaKolumn = 20;

        var random = new Random();
        var góra = random.Next(0, liczbaWierszy +1);
        var lewo = random.Next(0, liczbaKolumn + 1);
        var pozycja = new Pozycja(góra,lewo);
        var cukierek = new Cukierek(pozycja);

        return cukierek;
    }
}

