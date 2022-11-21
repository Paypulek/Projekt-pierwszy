namespace Koszyk;

public class RekordRachunku
{
    public List<RekordRachunku> ListaZakupów = new List<RekordRachunku>();
   
    
        public void Dodaj(int numer, int stan,Magazyn magazyn)
    {
        
        ListaZakupów.Add(new RekordRachunku(produkt, stan));
    }
    
    

    int ilość{get;set;}

}



