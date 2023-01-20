using CalculadoraDigital;
using Xunit;

namespace CalculadoraDigitalTest;

public class CalculadoraTest
{
    [Fact]
    public void AddTest()
    {
        Calculadora calc = new Calculadora();
        int resultado =  calc.Add(3,3);
        Assert.Equal(6, resultado);
    }
}