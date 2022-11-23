namespace Koszyk
{
    public class EkranMagazynu : EkranBase
    {
        
        private Magazyn magazyn;
        

        public EkranMagazynu(Magazyn magazyn)
        {
            this.magazyn = magazyn;
        }

        public override void WykonajKomendę(ConsoleKey key)
        {
            // obsługa co jeśli ktoś wybierze produkt

            base.WykonajKomendę(key);
        }

        public override void WyświetlEkran()
        {
             magazyn.PobierzStanMagazynu();
             Console.ReadKey();
             ObsługaEkranów.NowyEkran(new EkranBazowy());
             
        }
    }
}