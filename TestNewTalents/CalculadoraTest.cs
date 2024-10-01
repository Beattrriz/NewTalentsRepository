using NewTalents;
using System;
using Xunit;

namespace TestNewTalents
{
    public class CalculadoraTest
    {

        public Calculadora ConstruirClasse()
        {
            string data = null;
            Calculadora calc = new Calculadora(data);
            return calc;
        }

        [Theory]
        [InlineData (1,2, 3)]
        [InlineData (4, 5, 9)]
        public void TestSoma_RetornaSomaDosNumeros(int num1, int num2, int resultado)
        {
            Calculadora calc = ConstruirClasse();

            int resultadoCalculadora = calc.Somar(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(7, 2, 5)]
        [InlineData(9, 5, 4)]
        public void TestSubtracao_RetornaSubtracaoDosNumeros(int num1, int num2, int resultado)
        {
            Calculadora calc = ConstruirClasse();

            int resultadoCalculadora = calc.Subtrair(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(45, 5, 9)]
        public void TestDividir_RetornaDivisãoDosNumeros(int num1, int num2, int resultado)
        {
            Calculadora calc = ConstruirClasse();

            int resultadoCalculadora = calc.Dividir(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TestMultiplicacao_RetornaMultiplicacaoDosNumeros(int num1, int num2, int resultado)
        {
            Calculadora calc = ConstruirClasse();

            int resultadoCalculadora = calc.Multiplicar(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
        public void TestDivisaoPorZero()
        {
            Calculadora calc = ConstruirClasse();

            Assert.Throws<DivideByZeroException>(
                () => calc.Dividir(3, 0));
        }

        [Fact]
        public void TestHistorico()
        {
            Calculadora calc = ConstruirClasse();

            calc.Somar(1, 2);
            calc.Somar(5, 2);
            calc.Somar(15, 2);
            calc.Somar(10, 2);

            var lista = calc.Historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}
