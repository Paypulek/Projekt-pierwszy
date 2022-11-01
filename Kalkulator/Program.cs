using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Kalkulator;

     class Program
    {
        static int Main(string[] args)
        {

            Console.WriteLine("Hej możesz tutaj wykonywać proste działania matematyczne");
            bool czySukces;
            char zerownik;
            do
            {

                Console.WriteLine("wprowadź liczbę całkowitą na której chcesz wykonać operacje");
                Console.WriteLine("a jak mnie nie będziesz słuchać to się wyłącze");

                czySukces = int.TryParse(Console.ReadLine(), out int liczba);



                if (czySukces)
                {
                    do
                    {

                        Console.WriteLine("wpisz znak działania jakie chcesz wykonać (/ * - +) z liczbą {0} ", liczba);

                        czySukces = char.TryParse(Console.ReadLine(), out char znak);
                        if (czySukces == false)
                            return 0;

                        Console.WriteLine(" wpisz sobie teraz liczbę drugą");

                        czySukces = int.TryParse(Console.ReadLine(), out int liczba1);
                        if (czySukces == false)
                            return 0;


                        switch (znak)
                        {
                            case '/':
                                {
                                    if (liczba1 == 0)
                                    {
                                        Console.WriteLine("Za te zero to też mi sie już nie chce działać nara");
                                        return 0;
                                    }

                                    liczba = liczba / liczba1;
                                    break;
                                }

                            case '*':
                                liczba = liczba * liczba1;
                                break;
                            case '+':
                                liczba = liczba + liczba1;
                                break;
                            case '-':
                                liczba = liczba - liczba1;
                                break;

                        }
                        Console.WriteLine("Wynik to {0}", liczba);
                        Console.WriteLine("jak mam sie wyzerować to wpisz \"t\"");
                        czySukces = char.TryParse(Console.ReadLine(), out zerownik);
                        if (!czySukces)
                            return 0;

                        if (zerownik == 't')
                            liczba = 0;



                    } while (zerownik != 't');
                }


                else
                {
                    Console.WriteLine("Foch");
                    return 0;
                }

            } while (czySukces);
            return 0;
        }
    }