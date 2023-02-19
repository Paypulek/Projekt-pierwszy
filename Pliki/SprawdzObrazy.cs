using System.Drawing;
namespace Pliki
{
    public static class Obrazy
    {
        public static void StwórzObrazy(int ile)
        {
            Console.ReadKey();
            for (int k = 0; k < ile; k++)
            {
                int h, h1, w, w1;
                Random generator = new Random();
             h = ((generator.Next())%400);
             h1 =((generator.Next())%400);
             w=((generator.Next())%600);
             w1=((generator.Next())%600);

                Bitmap NowyObraz = new Bitmap(600, 400);
                using (Graphics g = Graphics.FromImage(NowyObraz))
                {
                    g.Clear(Color.White);
                    g.DrawLine(Pens.Blue,h,w,h1,w1);
                }
                string Ścieżka = @"C:\tutorials\";
                string rozszerzenie = ".png";
                string licznik = Convert.ToString(k);
                Ścieżka = Ścieżka + licznik + rozszerzenie;
                NowyObraz.Save(Ścieżka);

            }
        }

        public static List<Bitmap> Lista = new List<Bitmap>();
        public static void ZaładujListe(string[] ścieżki)
        {

            foreach (var item in ścieżki)
            {
                Bitmap d = new Bitmap(item);
                Lista.Add(d);
            }

        }

        public static void SprawdźPiksele(ref List<Bitmap> Lista)
        {
            foreach (var item in Lista)
            {
                int LiczbaNieBiałych = 0;

                for (int i = 0; i < item.Width; i++)
                {
                    for (int j = 0; j < item.Height; j++)
                    {
                        var ColorPixel = item.GetPixel(i, j);
                        if (ColorPixel != Color.FromArgb(255, 255, 255))
                        {
                            LiczbaNieBiałych++;
                        }
                    }
                }
                if (LiczbaNieBiałych != 0)
                    Console.WriteLine("Liczba brudnego w tym obrazie to:" + LiczbaNieBiałych);
                else
                    Console.WriteLine("Ten jest czysty");


            }
        }
    }
}