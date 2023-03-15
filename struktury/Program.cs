using System;
using System.Threading;
public static class Program
{
    static void Main()
    {
        Thread t = new Thread(Go);
        t.Start();
        t.Join();
        Console.WriteLine("WątektZostał zakonczony");

    }
    static void Go() { for (int i = 0; i<1000;i++) Console.WriteLine("y");}
}







