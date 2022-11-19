using System;
using System.Text;

public static class Program
{
    public static void Main(string[] args)
    {

        


    }
}
public class Prostokąt
{
    int dlugosc;
    int szerokosc;
    public Prostokąt()
    {
        Console.WriteLine("Podaj bok a");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Podaj bok b");
        int b = Convert.ToInt32(Console.ReadLine());
        this.dlugosc = a;
        this.szerokosc = b;
    }

    public void PoliczPole()
    {
        Console.WriteLine("Pole jest równe   = " + (dlugosc * szerokosc));
    }
}