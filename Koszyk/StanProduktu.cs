namespace Koszyk
{
    public class StanProduktu
    {
        public StanProduktu(Produkt produkt, int stan)
        {
            this.Produkt = produkt;
            this.Stan = stan;
        }

        public Produkt Produkt { get; }
        public int Stan { get; set; }
    }
}