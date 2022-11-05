
namespace Koszyk;
   class Magazyn 
  {
      public int[] StanMagazynowy = new int [5];
      
   

      public void Dodaj(int j, int ileNaMagazynie)
      {
        StanMagazynowy[j] = ileNaMagazynie;
      }

      public void Usuń(int ID, int ilość)
      {
        --ID;
        StanMagazynowy[ID] = StanMagazynowy[ID] - ilość;
      }


  }