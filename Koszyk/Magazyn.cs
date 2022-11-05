namespace Koszyk;
   class Magazyn 
  {
       public int[] StanMagazynowy = new int [100];
      
   

      public void Dodaj(int j, int ileNaMagazynie)
      {
        StanMagazynowy[j] = ileNaMagazynie;
      }


  }