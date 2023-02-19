namespace Pliki{
public static class Plik
{

public static void ZwróćŚcieżki(string ścieżka, string nazwa, out string[] ścieżki)
{
    ścieżki = Directory.GetFiles(ścieżka, nazwa);  
}

}
}