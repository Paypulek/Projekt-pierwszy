using System;
using System.Text;
namespace Wyszukiwarka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj zdanie a poszukam ile razy wystepuje tam literka \"a\"");
            string zdanie = Console.ReadLine()!;
            int dlugosc = zdanie.Length;
            
            
              int ppow = 0;
            for(int a = 0; a< dlugosc; a++)
            {
                if(zdanie[a]== 'a')
                ppow++;
                


            }
            Console.WriteLine("Literka a wystapila {0}", ppow ,"razy");


        }
 
    }
}