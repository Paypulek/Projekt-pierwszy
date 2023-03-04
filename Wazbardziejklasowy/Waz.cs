namespace Wazbardziejklasowy;
public class Waz
{
    public int wazX = (StanAplikacji.ekran.Length / 2);
    public int wazY = (StanAplikacji.ekran.Rank / 2);
    public List<SegmentCiała> Ciało = new List<SegmentCiała>();

    public void SprawdzCzyZjadl()
    {
        if (wazX == StanAplikacji.cukierekX && wazY == StanAplikacji.cukierekY)
        this.Ciało.Add(new SegmentCiała());
            
    }

    public void RuchPotwora(ConsoleKey klawisz)
    {
        int x;
        int y;
        foreach (var item in StanAplikacji.zmij.Ciało)
        {
            x = item.X;
            y = item.Y;
            

        }

        switch (klawisz)
        {
            case ConsoleKey.UpArrow:
                wazX--;
                StanAplikacji.OldKeyInfo = klawisz;
                break;
            case ConsoleKey.DownArrow:
                wazX++;
                StanAplikacji.OldKeyInfo = klawisz;
                break;
            case ConsoleKey.RightArrow:
                wazY++;
                StanAplikacji.OldKeyInfo = klawisz;
                break;
            case ConsoleKey.LeftArrow:
                wazY--;
                StanAplikacji.OldKeyInfo = klawisz;
                break;
            default:
                StanAplikacji.przerwanie = true;
                break;
        }
    }

    public class SegmentCiała
    {
        public int X;
        public int Y;

    }
}