using CalculadoraDigital;

namespace Test
{
    public class CalculadoraTest
    {
        [Fact]
        public void AddTest()
        {
            Calculadora calc = new Calculadora();
            var resultado = calc.Add(3, 3);
            Assert.Equal(6, resultado);
        }
    }
}