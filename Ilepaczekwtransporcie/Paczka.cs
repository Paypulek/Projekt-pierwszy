public class Paczka
{
    int wysokość, szerokość, długość;
    public Paczka(int wysokość, int szerokość, int długość) { this.wysokość = wysokość; this.szerokość = szerokość; this.długość = długość; }

    public void UłóżDwaRodzaje()
    {

    }

    public void OptymalneUłożenie(Paczka Większa)
    {
        int IlePaczek = 0;
        Paczka NajlepszeUłożenie = null;
        for(int i = 0; i>=3;i++)
        if (IlePaczek < this.IleWejdzie(Większa)) { IlePaczek = this.IleWejdzie(Większa); NajlepszeUłożenie = new Paczka (this.wysokość, this.szerokość, this.długość); }
        this.ObróćPionowo();
        if (IlePaczek < this.IleWejdzie(Większa)) { IlePaczek = this.IleWejdzie(Większa); NajlepszeUłożenie = new Paczka (this.wysokość, this.szerokość, this.długość); }
        this.ObróćPoziomo();
        if (IlePaczek < this.IleWejdzie(Większa)) { IlePaczek = this.IleWejdzie(Większa); NajlepszeUłożenie = new Paczka (this.wysokość, this.szerokość, this.długość); }
        this.ObróćPionowo();
        if (IlePaczek < this.IleWejdzie(Większa)) { IlePaczek = this.IleWejdzie(Większa); NajlepszeUłożenie = new Paczka (this.wysokość, this.szerokość, this.długość); }
        this.ObróćPoziomo();
        if (IlePaczek < this.IleWejdzie(Większa)) { IlePaczek = this.IleWejdzie(Większa); NajlepszeUłożenie = new Paczka (this.wysokość, this.szerokość, this.długość); }
        this.ObróćPionowo();
        if (IlePaczek < this.IleWejdzie(Większa)) { IlePaczek = this.IleWejdzie(Większa); NajlepszeUłożenie = new Paczka (this.wysokość, this.szerokość, this.długość); }

        if (NajlepszeUłożenie != null)
        {
            this.długość = NajlepszeUłożenie.długość;
            this.wysokość = NajlepszeUłożenie.wysokość;
            this.szerokość = NajlepszeUłożenie.szerokość;
        }
        else
            Console.WriteLine("Nic z tym nie zrobisz");
    }

    public int IleWejdzie(Paczka Większa)
    {
        int ileNaWysokość = Większa.wysokość / this.wysokość;
        int ileNaSzerokość = Większa.szerokość / this.szerokość;
        int ileNaDługość = Większa.długość / this.długość;
        int ilośćPaczek = ileNaDługość * ileNaSzerokość * ileNaWysokość;
        return ilośćPaczek;
    }

    private void ObróćPoziomo()
    {
        int i = this.długość;
        this.długość = this.szerokość;
        this.szerokość = i;
    }

    private void ObróćPionowo()
    {
        int i = this.wysokość;
        this.wysokość = this.długość;
        this.długość = i;
    }

    public void PokażMojeZmienne()
    {
        Console.WriteLine(this.długość + " " + this.szerokość + " " + this.wysokość);
    }
}