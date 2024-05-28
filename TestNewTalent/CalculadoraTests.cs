using NewTalents;

namespace TestNewTalent
{
    public class CalculadoraTests
    {
        public Calculadora ConstruirClasse()
        {
            DateTime data = DateTime.Now;
            Calculadora calculadora = new Calculadora(data);

            return calculadora;
        }

        [Theory]
        [InlineData(7, 2, 9)]
        [InlineData(4, 3, 7)]
        public void TesteSomar(int num1, int num2, int resultado)
        {
            Calculadora calc = ConstruirClasse();

            int resultadoCalculadora = calc.Somar(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(5, 2, 3)]
        [InlineData(3, 2, 1)]
        public void TesteSubtrair(int num1, int num2, int resultado)
        {
            Calculadora calc = ConstruirClasse();

            int resultadoCalculadora = calc.Subtrair(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(3, 3, 9)]
        [InlineData(2, 5, 10)]
        public void TesteMultiplicar(int num1, int num2, int resultado)
        {
            Calculadora calc = ConstruirClasse();

            int resultadoCalculadora = calc.Multiplicar(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);
        }


        [Theory]
        [InlineData(6, 3, 2)]
        [InlineData(6, 6, 1)]
        public void TesteDividir(int num1, int num2, int resultado)
        {
            Calculadora calc = ConstruirClasse();

            int resultadoCalculadora = calc.Dividir(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calc = ConstruirClasse();

            Assert.Throws<DivideByZeroException>(
                () => calc.Dividir(3, 0)
            );
        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = ConstruirClasse();

            calc.Somar(1, 9);
            calc.Somar(2, 8);
            calc.Somar(3, 7);
            calc.Somar(4, 6);

            var lista = calc.Historico();

            Assert.NotEmpty(calc.Historico());
            Assert.Equal(3, lista.Count);
        }
    }
}