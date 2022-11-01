
using System;
using System.Text;




public class Kalkulator
{

    static void Main(string[] args)
    {   
        var zdanie = Wprowadzzdanie();
        
        Console.WriteLine($"{zdanie}");

    }
    static string Wprowadzzdanie()
    {
        string zdanie = "czy ta metoda dziala";
        return zdanie;
    }
    
}