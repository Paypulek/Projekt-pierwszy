
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
}