
namespace Transport;

public class Paczka
{
    int wysokość, szerokość, długość;
    public Paczka()
    {
        Console.WriteLine("Podaj wysokość:");
        int wysokość = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Podaj szerkość:");
        int szerokość = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Podaj długość:");
        int długość = Convert.ToInt32(Console.ReadLine());
        this.wysokość = wysokość;
        this.szerokość = szerokość;
        this.długość = długość;
    }

    public Paczka(int Wysokość, int Szerokość, int Długość)
    {
        this.wysokość = Wysokość;
        this.szerokość = Szerokość;
        this.długość = Długość;
    }

    public void UłóżDwaRodzaje()
    {

    }

    public void OptymalneUłożenie(Paczka Większa)
    {
        int IlePaczek = 0;
        Paczka NajlepszeUłożenie = null;
        if (IlePaczek < this.IleWejdzie(Większa)) { IlePaczek = this.IleWejdzie(Większa); NajlepszeUłożenie = new Paczka(this.wysokość, this.szerokość, this.długość); }
        this.ObróćPionowo();
        if (IlePaczek < this.IleWejdzie(Większa)) { IlePaczek = this.IleWejdzie(Większa); NajlepszeUłożenie = new Paczka(this.wysokość, this.szerokość, this.długość); }
        this.ObróćPoziomo();
        if (IlePaczek < this.IleWejdzie(Większa)) { IlePaczek = this.IleWejdzie(Większa); NajlepszeUłożenie = new Paczka(this.wysokość, this.szerokość, this.długość); }
        this.ObróćPionowo();
        if (IlePaczek < this.IleWejdzie(Większa)) { IlePaczek = this.IleWejdzie(Większa); NajlepszeUłożenie = new Paczka(this.wysokość, this.szerokość, this.długość); }
        this.ObróćPoziomo();
        if (IlePaczek < this.IleWejdzie(Większa)) { IlePaczek = this.IleWejdzie(Większa); NajlepszeUłożenie = new Paczka(this.wysokość, this.szerokość, this.długość); }
        this.ObróćPionowo();
        if (IlePaczek < this.IleWejdzie(Większa)) { IlePaczek = this.IleWejdzie(Większa); NajlepszeUłożenie = new Paczka(this.wysokość, this.szerokość, this.długość); }
        Console.WriteLine("Tej paczki mi wejdzie:" + IlePaczek);
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
        Console.WriteLine("Obracam poziomo paczke");
        int i = this.długość;
        this.długość = this.szerokość;
        this.szerokość = i;
    }

    private void ObróćPionowo()
    {
        Console.WriteLine("Obracam pionowo paczkę");
        int i = this.wysokość;
        this.wysokość = this.długość;
        this.długość = i;
    }

    public void PokażMojeZmienne()
    {
        Console.WriteLine(this.długość + "<--- długosc " + this.szerokość + " <-- szerokosc" + this.wysokość + "<-- wysokosc");
    }

    public void Ilezmieszczę(Paczka mala, Paczka srednia)
    {
        Paczka pusteMiejsce1;
        Paczka pusteMiejsce2;
        Paczka pusteMiejsce3;
        int ilośćPaczek;
        int ilość = 0;

        this.IleWejdzieDoMnie(srednia, out pusteMiejsce1, out pusteMiejsce2, out pusteMiejsce3, out ilośćPaczek);
        ilość += mala.OptymalneUłożenieZwrotInt(pusteMiejsce3);
        ilość += mala.OptymalneUłożenieZwrotInt(pusteMiejsce2);
        ilość += mala.OptymalneUłożenieZwrotInt(pusteMiejsce3);


        Console.WriteLine("Większej Paczki wejdzie maksymalnie " + ilośćPaczek);
        Console.WriteLine("Mniejszej Paczki wcisniesz jeszcze" + ilość);

    }
    public void IleWejdzieDoMnie(Paczka paczka, out Paczka pusteMiejsce1, out Paczka pusteMiejsce2, out Paczka pusteMiejsce3, out int ilośćPaczek)
    {
        int ileNaWysokość = this.wysokość / paczka.wysokość;
        int ileNaSzerokość = this.szerokość / paczka.szerokość;
        int ileNaDługość = this.długość / paczka.długość;
        ilośćPaczek = ileNaDługość * ileNaSzerokość * ileNaWysokość;

        int pustaSzerokość = this.szerokość - paczka.szerokość * ileNaSzerokość;
        int pustaDługość = this.długość - paczka.długość * ileNaSzerokość;
        int pustaWysokość = this.wysokość - paczka.wysokość * ileNaWysokość;

        pusteMiejsce1 = new Paczka(pustaWysokość, pustaSzerokość, pustaDługość);
        pusteMiejsce2 = new Paczka(this.wysokość, pustaSzerokość, this.długość);
        pusteMiejsce3 = new Paczka(this.wysokość, pustaSzerokość, pustaDługość);

    }
    public int OptymalneUłożenieZwrotInt(Paczka Większa)
    {
        int IlePaczek = 0;
        Paczka NajlepszeUłożenie = null;
        if (IlePaczek < this.IleWejdzie(Większa)) { IlePaczek = this.IleWejdzie(Większa); NajlepszeUłożenie = new Paczka(this.wysokość, this.szerokość, this.długość); }
        this.ObróćPionowo();
        if (IlePaczek < this.IleWejdzie(Większa)) { IlePaczek = this.IleWejdzie(Większa); NajlepszeUłożenie = new Paczka(this.wysokość, this.szerokość, this.długość); }
        this.ObróćPoziomo();
        if (IlePaczek < this.IleWejdzie(Większa)) { IlePaczek = this.IleWejdzie(Większa); NajlepszeUłożenie = new Paczka(this.wysokość, this.szerokość, this.długość); }
        this.ObróćPionowo();
        if (IlePaczek < this.IleWejdzie(Większa)) { IlePaczek = this.IleWejdzie(Większa); NajlepszeUłożenie = new Paczka(this.wysokość, this.szerokość, this.długość); }
        this.ObróćPoziomo();
        if (IlePaczek < this.IleWejdzie(Większa)) { IlePaczek = this.IleWejdzie(Większa); NajlepszeUłożenie = new Paczka(this.wysokość, this.szerokość, this.długość); }
        this.ObróćPionowo();
        if (IlePaczek < this.IleWejdzie(Większa)) { IlePaczek = this.IleWejdzie(Większa); NajlepszeUłożenie = new Paczka(this.wysokość, this.szerokość, this.długość); }
        Console.WriteLine("Tej paczki mi wejdzie:" + IlePaczek);
        if (NajlepszeUłożenie != null)
        {
            this.długość = NajlepszeUłożenie.długość;
            this.wysokość = NajlepszeUłożenie.wysokość;
            this.szerokość = NajlepszeUłożenie.szerokość;
            return IlePaczek;
        }
        else
            Console.WriteLine("Nic z tym nie zrobisz");
        return 0;
    }
}