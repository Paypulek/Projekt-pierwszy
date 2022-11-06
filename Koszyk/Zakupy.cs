namespace Koszyk;
class Zakupy : Kupowanie
{
  
  
    public int[] Lista = new int[5];

    public void DodajNaListe(int ID, int ileKupione)
    {
      --ID;
        Lista[ID] += ileKupione;
    }

    public void UsuńZListy(int ID, int ilość)
    {
        --ID;
        Lista[ID] -= ilość;
    }
}
interface Kupowanie
{
    void DodajNaListe(int ID, int IleKupione);
    void UsuńZListy(int ID, int ilość);
}


