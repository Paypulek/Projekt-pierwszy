
namespace Koszyk;

public class Magazyn
{
    private List<StanProduktu> _produkty = new List<StanProduktu>();


    public bool SprawdźCzyMamyNaStanie(Produkt produkt, int liczbaProduktów)
    {
        var stanProduktu = PobierzStanProduktu(produkt);

        if (stanProduktu.Stan >= liczbaProduktów)
            return true;
        else
            return false;
    }
    public Produkt ObiektXnaLiscie(int x)
    {
        return _produkty[x - 1].Produkt;
    }
    public string PozycjaXNazwa(int x)
    {
        return _produkty[x - 1].Produkt.nazwa;
    }


    public void PowiedzZaIle()
    {
        int i = 0;
        Console.WriteLine("");
        Console.WriteLine("Cena podana obok");
        foreach (StanProduktu item in _produkty)
        {
            ++i;
            Console.WriteLine("[" + i + "] -" + item.Produkt.cena + "zł " + item.Produkt.nazwa);

        }

    }


    public void Dodaj(Produkt produkt, int stan)
    {
        _produkty.Add(new StanProduktu(produkt, stan));
    }

    public void UsuńiKup(Produkt Produkt, List<RekordRachunku> Lista)
    {
        try
        {
        Console.WriteLine("Wpisz ile chcesz towaru");
        int liczba = Convert.ToInt32(Console.ReadLine());
        StanProduktu? stanProduktu = PobierzStanProduktu(Produkt);

        if (stanProduktu.Stan < liczba)
            throw new Exception("Za mało produktów na stanie");
        else
        {   Console.WriteLine(stanProduktu.Stan);
            stanProduktu.Stan = stanProduktu.Stan - liczba;
            Lista.Add(new RekordRachunku(Produkt, liczba));
            Console.WriteLine("Pomyślnie dodano do listy Zakupów");
            Console.WriteLine(stanProduktu.Stan);

        }
        }
        catch{
            Console.WriteLine("cos poszlo nie tak. Zobacz na magazynie czy mamy tyle produktow");
        }

    }

    private StanProduktu? PobierzStanProduktu(Produkt produkt)
    {
        return _produkty.SingleOrDefault(p => p.Produkt == produkt);
    }

    public void PobierzStanMagazynu()
    {
        Console.WriteLine("");
        Console.WriteLine("Na Magazynie mamy");
        foreach (StanProduktu item in _produkty)
        {

            Console.WriteLine(+item.Stan + " x " + item.Produkt.nazwa);
        }
    }
}