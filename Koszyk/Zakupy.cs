namespace Koszyk
{



    public class EkranZakupu : EkranBazowy, IEkran
    {
        private Magazyn magazyn;
        public List<RekordRachunku> lista = new List<RekordRachunku>();
        
        


        public EkranZakupu(Magazyn magazyn)
        {
            this.magazyn = magazyn;
        }

        public void PokażZakupy()
        {
            foreach (var item in lista)
            {   
                Console.WriteLine(item.produkt.nazwa + "  x " + item.ilość);
                
            }
        }
        public override void WyświetlEkran()
        {
            
            Console.WriteLine("Oto za ile i co możesz u nas kupić :) ");
            magazyn.PowiedzZaIle();
            Console.WriteLine("");
            
            
            
           
            
            
            var key = Console.ReadKey();
            this.WykonajKomendę(key.Key);




        }

        
       

        public override void WykonajKomendę(ConsoleKey key)
        {
            try
            {
            switch(key)
            {
                case ConsoleKey.D1:
                Console.WriteLine(magazyn.PozycjaXNazwa(1));
                magazyn.UsuńiKup(1, lista);
                
                break;
                case ConsoleKey.D2:
                Console.WriteLine(magazyn.PozycjaXNazwa(2));
                magazyn.UsuńiKup(2, lista);
                break;
                case ConsoleKey.D3:
                Console.WriteLine(magazyn.PozycjaXNazwa(3));
                magazyn.UsuńiKup(3, lista);
                break;
                case ConsoleKey.D4:
                Console.WriteLine(magazyn.PozycjaXNazwa(4));
                magazyn.UsuńiKup(4, lista);
                break;
                case ConsoleKey.D5:
                Console.WriteLine(magazyn.PozycjaXNazwa(5));
                magazyn.UsuńiKup(5, lista);
                break;
                case ConsoleKey.D6:
                Console.WriteLine(magazyn.PozycjaXNazwa(6));
                magazyn.UsuńiKup(6, lista);
                break;
                case ConsoleKey.D7:
                Console.WriteLine(magazyn.PozycjaXNazwa(7));
                magazyn.UsuńiKup(7, lista);
                break;
                case ConsoleKey.D8:
                Console.WriteLine(magazyn.PozycjaXNazwa(8));
                magazyn.UsuńiKup(8, lista);
                break;
                case ConsoleKey.D9:
                ObsługaEkranów.NowyEkran(new EkranBazowy());
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
