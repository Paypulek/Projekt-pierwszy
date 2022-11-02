
using System;
using System.Text;

namespace Kalkulator
{
    class Program
    {

        static void Main(string[] args)
        {

            Program klk = new Program();
            var liczba1 = klk.WprowadźLiczbe();
            while (true)
            {
                var znak = klk.WprowadźOperator(); ;
                var liczba2 = klk.WprowadźLiczbe();

                    liczba1= klk.Oblicz(liczba1, znak, liczba2);
                Console.WriteLine("wynik to {0}", liczba1);
            }
        }

        private int WprowadźLiczbe()
        {
            Console.WriteLine("Proszę wprowadzić liczbę");
            int liczba1 = Convert.ToInt32(Console.ReadLine());
            return liczba1;
        }

        private char WprowadźOperator()
        {
            Console.WriteLine("Proszę wprowadzić znak / * - +");
            char znak = Convert.ToChar(Console.ReadLine());
            return znak;
        }

        private int Oblicz(int liczba, char znak, int liczba1)
        {
            switch (znak)
            {
                case '/':
                    {
                        if (liczba1 == 0)
                        {
                            Console.WriteLine("nie przez zero");
                            return 0;
                        }

                        liczba = liczba / liczba1;
                        return liczba;
                    }

                case '*':
                    liczba = liczba * liczba1;
                    return liczba;
                case '+':
                    liczba = liczba + liczba1;
                    return liczba;
                case '-':
                    liczba = liczba - liczba1;
                    return liczba;

            }
            return 0;

        }


    }
}


