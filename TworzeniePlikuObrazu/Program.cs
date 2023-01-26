
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
            Figura.StwórzObraz(@"C:\tutorials\blank_640_480.png");
            using (Bitmap b = new Bitmap(640,480))
            {
                using (Graphics g = Graphics.FromImage(b))
                {
                    g.Clear(Color.White);
					g.DrawLine(Pens.Red, 5, 5, 100, 100);
                    g.DrawLine(Pens.Blue,100,100,100,300);
                    g.DrawString("KURA Nioska", SystemFonts.DialogFont, Brushes.Blue ,25,20);
                    PointF[] Punkcik = new PointF[]{new PointF(200,250), new PointF(100,270)};
                    g.DrawCurve(Pens.Cyan, Punkcik, 20);
                    Punkcik = new PointF[]{new PointF(500,300), new PointF(150,100), new PointF(233,340)};
                    g.DrawPolygon(Pens.Gold,Punkcik);

                }
                b.Save(@"C:\tutorials\blank_640_480.png");
                
            
                
                
                int LiczbaNieBiałych =0;

                for (int i = 0; i<640; i++)
                {
                    for (int j = 0; j <480; j++)
                    {
                        var ColorPixel = b.GetPixel(i,j);
                       if( ColorPixel != Color.FromArgb(255,255,255))
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

