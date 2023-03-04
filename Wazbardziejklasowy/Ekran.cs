namespace Wazbardziejklasowy;
public static class Ekran
{
    public static void AktualizujObraz()
    {
        if (StanAplikacji.zmij.wazX == StanAplikacji.cukierekX && StanAplikacji.zmij.wazY == StanAplikacji.cukierekY)
        StanAplikacji.zmij.Ciało.Add(new Waz.SegmentCiała());

        foreach (var item in StanAplikacji.zmij.Ciało)
        {   
            StanAplikacji.ekran[item.X, item.Y] = 'ᶲ';

        }
            StanAplikacji.ekran[StanAplikacji.zmij.wazX, StanAplikacji.zmij.wazY] = '۞';

    }
    public static void WczytajObraz()
    {
        for (int i = 0; i < StanAplikacji.ekran.Length; i++)
        {
            Console.WriteLine("");
            for (int j = 0; i < StanAplikacji.ekran.Rank; i++)
            {
               Console.Write(StanAplikacji.ekran[i,j]);
            }
        }


    }
    public static void Inicjalizacja()
    {
        for (int i = 0; i < StanAplikacji.ekran.Length; i++)
        {
            for (int j = 0; i < StanAplikacji.ekran.Rank; i++)
            {
                StanAplikacji.ekran[i,j] = ' ';
            }
        }

    }
}