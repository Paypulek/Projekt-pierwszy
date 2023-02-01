using System.Drawing;

namespace ConsoleApplication1;
    public static class Figura
    {
       public static void StwórzObraz(string ścieżka,int wysokość, int szerokość)
        {
            using (Bitmap b = new Bitmap(wysokość,szerokość))
            {
                
                using (Graphics g = Graphics.FromImage(b))
                {
                    g.Clear(Color.White);
                    PointF[] Punkcik = new PointF[]{new PointF((b.Height/2),b.Width/2), new PointF((b.Height/3),b.Width/3), new PointF((wysokość-20),szerokość-40)};
                    g.DrawPolygon(Pens.Gold,Punkcik);

                }
                b.Save(ścieżka);
            }
        }
    }
    