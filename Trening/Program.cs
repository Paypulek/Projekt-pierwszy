using System;
using System.Text;


public static class Trenuj
{
    public static void Main()
    {
        Console.WriteLine("Siema");
        EkranMenu _ekran = new EkranMenu();
        List<Figura> lista = new List<Figura>();
        while(true)
        {
        _ekran.WyświetlEkran();
        var znak = Console.ReadKey();
        _ekran.WykonajKomendę(znak.Key, lista);
        }
        


    }
}

public class EkranMenu

{
    public void WykonajKomendę(ConsoleKey znak, List<Figura> lista)
    {
        switch(znak)
        {
            case ConsoleKey.D1:
            lista.Add(new Prostokat());
            break;
            case ConsoleKey.D2:
            lista.Add(new Trojkot());
            break;
            case ConsoleKey.D3:
            break;
            case ConsoleKey.D4:
            break;
             case ConsoleKey.D5:
             foreach (var item in lista)
             {
                item.ObliczPole();
             }
            break;
            default:
            return;
            break;

        }
        

    }
    public void WyświetlEkran()
    {
        Console.WriteLine("[1] - Dodaj Prostokat");
        Console.WriteLine("[2] - Dodaj Trojkat");
        Console.WriteLine("[3] - Dodaj Koło");
        Console.WriteLine("[4] - Dodaj rąb");
        Console.WriteLine("[5] - Policz pola obiektów");
    }

}

public class Trojkot : Figura
{
    int wysokosc;
    int podstawa;

    public Trojkot()
    {
        Console.WriteLine("Podaj podstawe");
        this.podstawa = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Podaj wysokosc");
        this.wysokosc = Convert.ToInt32(Console.ReadLine());
    }
    public override void ObliczPole()
    {
        Console.WriteLine("Pole wynosi " + (wysokosc*podstawa/2));
    }
}

public abstract class Figura
{
    public abstract void ObliczPole();
}

public class Prostokat : Figura
{
    double dlugosc;
    double szerokosc;
    public Prostokat()
    {
        
        
            Console.WriteLine("Podaj bok a");
            this.dlugosc = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj bok b");
            this.szerokosc = Convert.ToDouble(Console.ReadLine());
        
       
    }

    public override void ObliczPole()
    {
        Console.WriteLine("Pole jest równe  " + (dlugosc*szerokosc));
    }
}