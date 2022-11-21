namespace Koszyk
{



    public class EkranZakupu : EkranBase, IEkran
    {
        private Magazyn magazyn;
        private List<Produkt> lista = new List<Produkt>();
        private RekordRachunku Lista = new RekordRachunku();
        


        public EkranZakupu(Magazyn magazyn)
        {
            this.magazyn = magazyn;
        }
        public override void WyświetlEkran()
        {
            
            Console.WriteLine("Oto za ile i co możesz u nas kupić :) ");
            magazyn.PowiedzZaIle();
            Console.WriteLine("Napisz numer produktu");
            var numerProduktu = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Napisz ilość");
            var ilość = Convert.ToInt32(Console.ReadLine());
            
           
            
            
            var key = Console.ReadKey();
            base.WykonajKomendę(key.Key);




        }

        
       

        public override void WykonajKomendę(ConsoleKey key)
        {


            // obsługa co jeśli ktoś wybierze produkt

            base.WykonajKomendę(key);
        }
    }

    
}
