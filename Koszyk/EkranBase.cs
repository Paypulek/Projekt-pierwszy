namespace Koszyk
{
    public abstract class EkranBase : IEkran
    {
        public virtual void WykonajKomendę(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.Escape:
                    ObsługaEkranów.PoprzedniEkran();
                    break;
                default:
                    ObsługaEkranów.NowyEkran(this);
                    break;
            }
        }

        public abstract void WyświetlEkran();
    }
}