﻿using System;
using System.Text;
using System.Threading;



class Program
{
    static void Main(string[] args)
    {
        Ekran.Zapełnij();
        while (Ekran.przerwanie == false)
        {
            var keyInfo = Console.ReadKey(true);
            while (Console.KeyAvailable == false)
            {
                Thread.Sleep(250); // Loop until input is entered.
                Ekran.RuchPotwora(keyInfo.Key);
                Ekran.WyświetlEkran();
            }

        }
    }
}