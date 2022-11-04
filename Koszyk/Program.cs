namespace Koszyk;

class Program
{
     
    static void Main(string[] args)
    {
        

        Console.WriteLine("Dzien dobry witam w moim sklepie \n Poruszanie się w tym sklepie odbywa się za pomocą cyfr w kwadratowych nawiasach");
        Menu();

    }
    

    static void Menu()
    {
        var ksiazka = new Produkt();
        ksiazka.Nazwij("Ksiazka");
        ksiazka.Wyceń(13);
        

        var piłka = new Produkt();
        piłka.Nazwij("Piłka");
        piłka.Wyceń(45);

        var rower = new Produkt();
        rower.Nazwij("Rower");
        rower.Wyceń(1200);

        do
        {  
            Console.WriteLine("\n\n\n[1] Dodaj produkt \n[2] Lista zakupów \n[3] Policz cene za zakupy");
            bool czySukces = int.TryParse(Console.ReadLine(), out int Wybór);
            if (!czySukces)
                break;

            
            switch (Wybór)
            {
                case 1:
                    DodajProdukt(ksiazka, piłka, rower);
                    break;
                case 2:
                    ListaZakupów(ksiazka, piłka, rower);
                    break;
                case 3:
                    PoliczCene(ksiazka, piłka, rower);
                    break;

            }
       } while (true);
        void PoliczCene(Produkt a, Produkt b, Produkt c)
        {
            int Cena = a.IleMam()*a.Cena()+b.IleMam()*b.Cena()+c.IleMam()*c.Cena();
            Console.WriteLine("Cena za wszystko: " + Cena);
        }

       void ListaZakupów(Produkt a, Produkt b, Produkt c)
       {
            Console.WriteLine("\n\n\nMasz "+ a.IleMam()+ " książek  ");
            Console.WriteLine("Masz "+b.IleMam()+ " piłek  " );
            Console.WriteLine("Masz "+c.IleMam()+ " rowerów  " );
       }

         void DodajProdukt(Produkt a, Produkt b, Produkt c)
        {
            Console.WriteLine("\n\n\n[1]"); 
            a.OdczytajNazwe();
            Console.WriteLine("[2]"); 
            b.OdczytajNazwe();
            Console.WriteLine("[3]"); 
            c.OdczytajNazwe();
             bool czySukces = int.TryParse(Console.ReadLine(), out int Wybór);
            if (!czySukces)
                return;
            Console.WriteLine("Napisz ilość");
                  czySukces = int.TryParse(Console.ReadLine(), out int ile);
            if (!czySukces)
                return;

            

            

            switch (Wybór)
            {
                 case 1:
                 a.Ile(ile);
                 break;
                 case 2:
                 b.Ile(ile);
                 break;
                 case 3:
                 c.Ile(ile);
                 break;

                 default:
                    break;

            }
            Console.WriteLine("\n\n\nMasz "+ a.IleMam()+ " książek  ");
            Console.WriteLine("Masz "+b.IleMam()+ " piłek  " );
            Console.WriteLine("Masz "+c.IleMam()+ " rowerów  " );
            
        }
         

    }
}




    

