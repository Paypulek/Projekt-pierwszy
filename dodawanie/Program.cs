using System;
using System.Text;
namespace ogolne
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b=0;
            Console.WriteLine("Podawaj liczby a bede dodawać az nie wpiszesz 0");
            do 
            {
              a = Convert.ToInt32(Console.ReadLine());
             b = b +a;
             Console.WriteLine("Suma {0})", b);
            }
            while(a != 0);

        }
    }
}