
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();

            using (Bitmap b = new Bitmap(640, 480))
            {
                using (Graphics g = Graphics.FromImage(b))
                {
                    g.Clear(Color.FromArgb(230,1,1,1));
					g.DrawLine(Pens.Red, 10, 10, 100, 100);

                }
                
                b.Save(@"C:\tutorials\blank_640_480.png");
                int LiczbaNieBiałych =0;

                for (int i = 0; i<640; i++)
                {
                    for (int j = 0; j <480; j++)
                    {
                        var ColorPixel = b.GetPixel(i,j);
                       if( ColorPixel != Color.FromArgb(230,1,1,1))
                       {
                         LiczbaNieBiałych++;
                       }
                    }
                }
                Console.WriteLine("Liczba nie białych pixeli jest równa " + LiczbaNieBiałych);
                
            }
        }
    }
}

