using System;
using System.Text;



class Program
{
    static void Main(string[] args)
    {
        Ekran.Zapełnij();
        while (Ekran.przerwanie == false)
        {
            var keyInfo = Console.ReadKey();
            Ekran.RuchPotwora(keyInfo.Key);
            Ekran.WyświetlEkran();
        }
    }
}