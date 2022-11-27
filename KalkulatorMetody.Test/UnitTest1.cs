using Kalkulator;
namespace KalkulatorMetody.Test;


public class UnitTest1
{
    [Theory]
[InlineData(2,'+',2,4)]
[InlineData(5,'/',2,2)]
    public void Test1(int LiczbaPierwsza, char znak, int LiczbaDruga, int OczekiwanyWynik)
    {
        
        var Wynik = Kalkulator.Kalkulator.Oblicz(LiczbaPierwsza, znak, LiczbaDruga);
        Assert.Equal(OczekiwanyWynik,Wynik);
            

    }
}