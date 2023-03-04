namespace Wazbardziejklasowy;
public static class StanAplikacji
{
    public static Waz zmij = new Waz();
    public static bool przerwanie;
    public static ConsoleKey OldKeyInfo = new ConsoleKey();
    public static Random gen = new Random();
    public static int cukierekX;
    public static int cukierekY;
    public static int wazX =10;
    public static int wazY=10;
    public static char[,] ekran = new char[20,20];

    public static void wylosujCukierek()
    {
        cukierekX = gen.Next(20);
        cukierekY = gen.Next(20);

    }
}
