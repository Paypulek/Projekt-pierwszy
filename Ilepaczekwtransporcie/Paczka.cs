public class Paczka
{
    int wysokość, szerokość, długość;
    public Paczka(int wysokość, int szerokość, int długość) { this.wysokość = wysokość; this.szerokość = szerokość; this.długość = długość; }

    public void UłóżDwaRodzaje()
    {
        
    }

    public void OptymalneUłożenie(Paczka Mniejsza)
    {
        int IlePaczek;
        Paczka NajlepszeUłożenie;
       if (IlePaczek< this.IleWejdzie(Mniejsza)) {IlePaczek=this.IleWejdzie(Mniejsza); NajlepszeUłożenie = this;}
        Mniejsza.ObróćPionowo();
       if (IlePaczek< this.IleWejdzie(Mniejsza)) {IlePaczek=this.IleWejdzie(Mniejsza); NajlepszeUłożenie = this;}
        Mniejsza.ObróćPoziomo();
       if (IlePaczek< this.IleWejdzie(Mniejsza)) {IlePaczek=this.IleWejdzie(Mniejsza); NajlepszeUłożenie = this;}
        Mniejsza.ObróćPionowo();
       if (IlePaczek< this.IleWejdzie(Mniejsza)) {IlePaczek=this.IleWejdzie(Mniejsza); NajlepszeUłożenie = this;}
        Mniejsza.ObróćPoziomo();
       if (IlePaczek< this.IleWejdzie(Mniejsza)) {IlePaczek=this.IleWejdzie(Mniejsza); NajlepszeUłożenie = this;}
        Mniejsza.ObróćPionowo();
       if (IlePaczek< this.IleWejdzie(Mniejsza)) {IlePaczek=this.IleWejdzie(Mniejsza); NajlepszeUłożenie = this;}

       if (NajlepszeUłożenie != null) this=NajlepszeUłożenie;
       else 
            Console.WriteLine("Nic z tym nie zrobisz");
    }

    public int IleWejdzie(Paczka MniejszaPaczka)
    {
        int ileNaWysokość = wysokość / MniejszaPaczka.wysokość;
        int ileNaSzerokość = szerokość / MniejszaPaczka.szerokość;
        int ileNaDługość = długość / MniejszaPaczka.długość;
        int ilośćPaczek = ileNaDługość * ileNaSzerokość * ileNaWysokość;
        return ilośćPaczek;
    }

    public void ObróćPoziomo()
    {
        int i = this.długość;
        this.długość = this.szerokość;
        this.szerokość = i;
    }

    public void ObróćPionowo()
    {
        int i = this.wysokość;
        this.wysokość = this.długość;
        this.długość = i;
    }
}