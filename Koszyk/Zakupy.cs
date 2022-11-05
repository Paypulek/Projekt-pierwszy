namespace Koszyk;
  class Zakupy 
  {
    public int[] Lista = new int[5];

     public void Dodaj(int j, int ileKupione)
      {
       Lista[j] = ileKupione;
      }

      public void Usuń(int ID, int ilość)
      {
        --ID;
        Lista[ID] = Lista[ID] - ilość;
      }
  }