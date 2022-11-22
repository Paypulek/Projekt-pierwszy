namespace Koszyk;

public class RekordRachunku
{
    
   
    
    public RekordRachunku(Produkt produkt, int ilość)
    {
        this.produkt = produkt;
        this.ilość = ilość;
    }
       
    
    

    public int ilość{get;set;}
    public Produkt produkt{get;}
}



