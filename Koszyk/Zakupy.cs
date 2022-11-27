namespace Koszyk
{



    public class EkranZakupu : EkranBazowy, IEkran
    {
        private Magazyn magazyn = StanAplikacji.Magazyn;
        public List<RekordRachunku> lista = StanAplikacji.ListaZakupowa;




       

        
        public override void WyświetlEkran()
        {
            
                Console.WriteLine("Oto za ile i co możesz u nas kupić :) ");
                magazyn.PowiedzZaIle();
                Console.WriteLine("wciskajac [9] cofniesz sie spowrotem");
                

        }
        public override void WykonajKomendę(ConsoleKey key)
        {
             try
            {
            switch (key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine(magazyn.PozycjaXNazwa(1));
                    magazyn.UsuńiKup(magazyn.ObiektXnaLiscie(1), this.lista);

                    break;
                case ConsoleKey.D2:
                    Console.WriteLine(magazyn.PozycjaXNazwa(2));
                    magazyn.UsuńiKup(magazyn.ObiektXnaLiscie(2),  this.lista);
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine(magazyn.PozycjaXNazwa(3));
                    magazyn.UsuńiKup(magazyn.ObiektXnaLiscie(3),  this.lista);
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine(magazyn.PozycjaXNazwa(4));
                    magazyn.UsuńiKup(magazyn.ObiektXnaLiscie(4), this.lista);
                    break;
                case ConsoleKey.D5:
                    Console.WriteLine(magazyn.PozycjaXNazwa(5));
                    magazyn.UsuńiKup(magazyn.ObiektXnaLiscie(5),  this.lista);
                    break;
                case ConsoleKey.D6:
                    Console.WriteLine(magazyn.PozycjaXNazwa(6));
                    magazyn.UsuńiKup(magazyn.ObiektXnaLiscie(6), lista);
                    break;
                case ConsoleKey.D7:
                    Console.WriteLine(magazyn.PozycjaXNazwa(7));
                    magazyn.UsuńiKup(magazyn.ObiektXnaLiscie(7), lista);
                    break;
                case ConsoleKey.D8:
                    Console.WriteLine(magazyn.PozycjaXNazwa(8));
                    magazyn.UsuńiKup(magazyn.ObiektXnaLiscie(8), lista);
                    break;

                default:
                    base.WykonajKomendę(key);
                    break;
            }
            }
             catch
             {
                 Console.WriteLine("Sprawdz czy jest taki produkt idiotko!");
             }





        }
    }


}
