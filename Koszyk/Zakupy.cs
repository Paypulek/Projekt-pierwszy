namespace Koszyk
{



    public class EkranZakupu : EkranBase, IEkran
    {
        private Magazyn magazyn;
        public List<RekordRachunku> lista = new List<RekordRachunku>();
        
        


        public EkranZakupu(Magazyn magazyn)
        {
            this.magazyn = magazyn;
        }
        public override void WyświetlEkran()
        {
            
            Console.WriteLine("Oto za ile i co możesz u nas kupić :) ");
            magazyn.PowiedzZaIle();
            
            
            
           
            
            
            var key = Console.ReadKey();
            this.WykonajKomendę(key.Key);




        }

        
       

        public override void WykonajKomendę(ConsoleKey key)
        {
            int ilość;
            try
            {
            switch(key)
            {
                case ConsoleKey.D1:
                Console.WriteLine(magazyn.PozycjaXNazwa(1));
                Console.WriteLine("Wpisz ile chcesz towaru");
                ilość = Convert.ToInt32(Console.ReadKey());

                magazyn.Usuń(magazyn.ObiektXnaLiscie(1), ilość);
                lista.Add(magazyn.ObiektXnaLiscie(1), ilość);
                break;
                case ConsoleKey.D2:
                Console.WriteLine(magazyn.PozycjaXNazwa(2));
                break;
                case ConsoleKey.D3:
                Console.WriteLine(magazyn.PozycjaXNazwa(3));
                break;
                case ConsoleKey.D4:
                Console.WriteLine(magazyn.PozycjaXNazwa(4));
                break;
                case ConsoleKey.D5:
                Console.WriteLine(magazyn.PozycjaXNazwa(5));
                break;
                case ConsoleKey.D6:
                Console.WriteLine(magazyn.PozycjaXNazwa(6));
                break;
                case ConsoleKey.D7:
                Console.WriteLine(magazyn.PozycjaXNazwa(7));
                break;
                case ConsoleKey.D8:
                Console.WriteLine(magazyn.PozycjaXNazwa(8));
                break;
                case ConsoleKey.D9:
                Console.WriteLine(magazyn.PozycjaXNazwa(9));
                break;
                default:
                base.WykonajKomendę(key);
                return;
            }
            }
            catch
            {
                Console.WriteLine("Sprawdz czy jest taki produkt idiotko!");
            }
                

            

            
        }
    }

    
}
