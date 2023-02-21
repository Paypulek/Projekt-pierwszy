public static class Ekran
{
    public static ConsoleKey KeyInfo = new ConsoleKey();
    public static ConsoleKey OldKeyInfo = new ConsoleKey();
    public static char[,] piksel = new char[20, 20];
    static int[,] waz = new int[20, 20];
    static int DługoscWęża = 2;
    static int WążX = 10;
    static int WążY = 10;
    public static bool przerwanie = false;
    static Random gen = new Random();
    public static bool[,] jedzenie = new bool[20, 20];

    public static void RuchPotwora(ConsoleKey klawisz)
    {
        switch (klawisz)
        {
            case ConsoleKey.UpArrow:
                WążX--;
                OldKeyInfo = klawisz;
                break;
            case ConsoleKey.DownArrow:
                WążX++;
                OldKeyInfo = klawisz;
                break;
            case ConsoleKey.RightArrow:
                WążY++;
                OldKeyInfo = klawisz;
                break;
            case ConsoleKey.LeftArrow:
                WążY--;
                OldKeyInfo = klawisz;
                break;
            default:
            przerwanie = true;
           break;
        }
    }
    public static void DopasujPiksele()
    {
        for (int i = 0; i < 20; i++)
        {
            for (int k = 0; k < 20; k++)
            {
                if (waz[i, k] > 0)
                    piksel[i, k] = '*';
                if (waz[i,k] ==0)
                    piksel[i,k] = ' ';
                if (jedzenie[i, k] == true)
                    piksel[i, k] = 'X';

            }
        }

    }

    public static void MatrycaWeza()
    {
        waz[WążX, WążY] = DługoscWęża;

        for (int i = 0; i < 20; i++)
        {
            for (int k = 0; k < 20; k++)
            {
                waz[i, k]--;
                if (waz[i, k] <= 0)
                    waz[i, k] = 0;
            }

        }
    }

    public static void SprawdźZjedzenie()
    {
        for (int i = 0; i < 20; i++)
        {
            for (int k = 0; k < 20; k++)
            {
                if (jedzenie[i, k] == true)
                    piksel[i, k] = 'X';
                if (jedzenie[i, k] == true && WążX == i && WążY == k)
                {
                    jedzenie[i, k] = false;
                    DługoscWęża++;
                    jedzenie[gen.Next(19), gen.Next(19)] = true;
                }
            }
        }
    }
    public static void Zapełnij()
    {
        for (int i = 0; i < 20; i++)
        {
            for (int k = 0; k < 20; k++)
            {
                piksel[i, k] = ' ';
                waz[i, k] = 0;
                jedzenie[i, k] = false;
            }
        }
        waz[WążX,WążY] = DługoscWęża;
        jedzenie[gen.Next(19), gen.Next(19)] = true;
    }

    public static void WyświetlEkran()
    {
        Console.WriteLine();
        MatrycaWeza();
        SprawdźZjedzenie();
        DopasujPiksele();
        int i = 0;
        foreach (var item in piksel)
        {

            Console.Write(item);
            i++;
            if (i == 20)
            {
                Console.Write("|");
                Console.WriteLine(" ");
                i = 0;
            }
        }
    }

}
