namespace Koszyk;

class Program
{

    static void Main(string[] args)
    {
        Produkt ksiazka = new Produkt();
        ksiazka.Nazwij("Ksiazka");
        ksiazka.Wyceń(13);
        ksiazka.OdczytajNazwe();

        Produkt piłka = new Produkt();
        piłka.Nazwij("Piłka");
        piłka.Wyceń(45);

        Produkt rower = new Produkt();
        rower.Nazwij("Rower");
        rower.Wyceń(1200);


        Console.WriteLine("Dzien dobry witam w moim sklepie /n Poruszanie się w tym sklepie odbywa się za pomocą cyfr w kwadratowych nawiasach");
        Menu();

    }

    static void Menu()
    {

        do
        {
            Console.WriteLine("[1] Dodaj produkt /n [2] Usuń produkt /n [3] Lista zakupów /n [4] Policz cene za zakupy");
            bool czySukces = int.TryParse(Console.ReadLine(), out int Wybór);
            if (!czySukces)
                continue;

            switch (Wybór)
            {
                case 1:
                    DodajProdukt();
                    break;
               /* case 2:
                    UsuńProdukt();
                    break;
                case 3:
                    ListaZakupów();
                    break;
                case 4:
                    PoliczCene();
                    break;*/

            }




        } while (true);

       void DodajProdukt()
        {
            Console.WriteLine("[1]"); 
            ksiazka.OdczytajNazwe();
             bool czySukces = int.TryParse(Console.ReadLine(), out int Wybór);
            /*if (!czySukces)
                continue;

            switch (Wybór)
            {
                case 1:*/

            }
        }
    }




    

