namespace Transport;
public class StanPaczek
{
        public Paczka Paczka { get; }
        public int Stan { get;}
        public StanPaczek() {this.Paczka=new Paczka();
        Console.WriteLine("Podaj ilość paczek");
        int stan = Convert.ToInt32(Console.ReadLine()); this.Stan=stan;}
        

}