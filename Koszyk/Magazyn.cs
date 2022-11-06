
namespace Koszyk;
   class Magazyn :Kupowanie
  {
      public int[] StanMagazynowy = new int [5];
      
   
      public bool SprawdźCzyMamy(int ID, int ileChceszKupić)
      {
        --ID;
        Console.WriteLine("Liczba na magazynie:" +StanMagazynowy[ID] + "  a chcesz kupic " + ileChceszKupić);
        
        if (StanMagazynowy[ID]>= ileChceszKupić)
        return true;
        else
        return false;
      }
      public void Dodaj(int ID, int ileNaMagazynie)
      {
        --ID;
        StanMagazynowy[ID] = ileNaMagazynie;
      }

      public void DodajNaListe(int ID, int ilość)
      {
        --ID;
        StanMagazynowy[ID] = StanMagazynowy[ID] - ilość;
      }
      public void UsuńZListy(int ID, int ilość)
    {
        --ID;
        StanMagazynowy[ID] += ilość;
    }


  }