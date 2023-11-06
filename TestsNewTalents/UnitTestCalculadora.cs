using NewTalents;
using System;
using Xunit;

namespace TestsNewTalents
{
    public class UnitTestCalculadora
    {
        private Calculadora Construir()
        {
            string data = "05/11/2023";
            return new Calculadora(data);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TesteSomar(int num1, int num2, int resultado)
        {
            Calculadora calc = Construir();

            int resultadoCalculadora = calc.Somar(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(5, 2, 3)]
        [InlineData(6, 0, 6)]
        [InlineData(10, 10, 0)]
        public void TesteSubtrair(int num1, int num2, int resultado)
        {
            Calculadora calc = Construir();

            int resultadoCalculadora = calc.Subtrair(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(10, 2, 20)]
        [InlineData(6, 2, 12)]
        public void TesteMultiplicar(int num1, int num2, int resultado)
        {
            Calculadora calc = Construir();

            int resultadoCalculadora = calc.Multiplicar(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(6, 2, 3)]
        public void TesteDividir(int num1, int num2, int resultado)
        {
            Calculadora calc = Construir();

            int resultadoCalculadora = calc.Dividir(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calc = Construir();

            Assert.Throws<DivideByZeroException>(() => calc.Dividir(3, 0));
        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = Construir();

            calc.Somar(1, 2);
            calc.Somar(2, 8);
            calc.Somar(3, 7);
            calc.Somar(4, 1);

            var lista = calc.Historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }

        [Fact]
        public void TestarHistoricoComMenosQueTresHistoricos()
        {
            Calculadora calc = Construir();

            calc.Somar(1, 2);
            calc.Somar(2, 8);

            var lista = calc.Historico();

            Assert.NotEmpty(lista);
            Assert.Equal(2, lista.Count);
        }
    }
}
