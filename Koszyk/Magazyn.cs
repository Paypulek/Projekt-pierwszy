
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

   
    public void PowiedzZaIle()
    {
        int i =0;
        Console.WriteLine("");
        Console.WriteLine("Cena podana obok");
        foreach (StanProduktu item in _produkty)
        {
            ++i;
            Console.WriteLine("["+ i +"] -" +item.Produkt.cena + "zł " + item.Produkt.nazwa);
            
        }

    }

    public void Dodaj(Produkt produkt, int stan)
    {
        _produkty.Add(new StanProduktu(produkt, stan));
    }

    public void Usuń(Produkt produkt, int liczba)
    {
        StanProduktu? stanProduktu = PobierzStanProduktu(produkt);

        if (stanProduktu.Stan < liczba)
            throw new Exception("Za mało produktów na stanie");
        else
            stanProduktu.Stan = stanProduktu.Stan - liczba;
    }

    private StanProduktu? PobierzStanProduktu(Produkt produkt)
    {
        return _produkty.SingleOrDefault(p => p.Produkt.ID == produkt.ID);
    }

    public void PobierzStanMagazynu()
    {
        Console.WriteLine("");
        Console.WriteLine("Na Magazynie mamy");
        foreach (StanProduktu item in _produkty)
        {
            
            Console.WriteLine( +item.Stan + " x " + item.Produkt.nazwa);
        }
    }
}