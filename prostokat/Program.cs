using System;
namespace PodstawowaSkladniaProstokątay
{
    class Program
    {
        static void Main(string[] args)
        {
            Prostokat r = new Prostokat(); // pobaw sie i sprawdz co robi new
            r.AkceptujDetale();
            r.WyswietlCoWiesz();
            Console.ReadKey(); // poczekam az nacisniesz guzik
        }
    }
    //definicja klasyt prostokata
    class Prostokat
    {
        //tworzymy zmienne
        double a;
        double b;
        public void AkceptujDetale()
        {
            a = 20;
            b = 45;
        }
        //liczenie powierzchnie
        public double P()
        {return a*b;
        }
        //Wyświetlenie danych
        public void WyswietlCoWiesz()
        {
            Console.WriteLine("Długość: {0}", b);
            Console.WriteLine("szerokosc: {0}", a);
            Console.WriteLine("Pole: {0}", P());
        }
    }
}