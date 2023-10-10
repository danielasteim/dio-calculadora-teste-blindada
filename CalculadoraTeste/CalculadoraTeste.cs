namespace CalculadoraTeste;
using Calculadora.Models;

public class CalculadoraTeste
{
    private Calculadora _calculadora = new Calculadora("10/10/2023");

    [Theory]
    [InlineData (1, 2, 3)]
    [InlineData (4, 5, 9)]
    public void TesteSomar(int valor1, int valor2, int resultadEsperado)
    {
        int resultadoCalculadora = _calculadora.Somar(valor1, valor2);

        Assert.Equal(resultadEsperado, resultadoCalculadora);
    }

    [Theory]
    [InlineData (1, 2, 2)]
    [InlineData (4, 5, 20)]
    public void TesteMultiplicar(int valor1, int valor2, int resultadEsperado)
    {
        int resultadoCalculadora = _calculadora.Multiplicar(valor1, valor2);

        Assert.Equal(resultadEsperado, resultadoCalculadora);
    }

    
    [Theory]
    [InlineData (6, 2, 6)]
    [InlineData (5, 5, 1)]
    public void TesteDividir(int valor1, int valor2, int resultadEsperado)
    {
        int resultadoCalculadora = _calculadora.Dividir(valor1, valor2);

        Assert.Equal(resultadEsperado, resultadoCalculadora);
    }

    
    [Theory]
    [InlineData (6, 2, 4)]
    [InlineData (5, 5, 0)]
    public void TesteSubtrair(int valor1, int valor2, int resultadEsperado)
    {
        int resultadoCalculadora = _calculadora.Subtrair(valor1, valor2);

        Assert.Equal(resultadEsperado, resultadoCalculadora);
    }

    [Fact]
    public void TestarDivisaoPor0()
    {
        Assert.Throws<DivideByZeroException>(
            () => _calculadora.Dividir(3, 0)
        );
    }

    [Fact]
    public void TestarHistorico()
    {   _calculadora.Somar(1, 2);
        _calculadora.Somar(2, 8);
        _calculadora.Somar(3, 7);
        _calculadora.Somar(4, 1);

        var lista = _calculadora.Historico();
        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }

}