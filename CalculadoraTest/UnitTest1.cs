using Calculadora;
using Xunit;

namespace CalculadoraTest;

public class UnitTest1
{
    [Fact]
    public void Somar_ComNumerosInteiros_DeveSomarCorretamente()
    {
        //Arrange
        var valor1 = 1;
        var valor2 = 2;
        var resultadoEsperado = 3;

        var calculadora = new CalculadoraService();

        //Act

        var resultado = calculadora.Somar(valor1, valor2);

        //Assert
        Assert.Equal(resultadoEsperado, resultado);

    }

    [Fact]
    public void Subtracao_ComNumerosInteiros_DeveSubtrairCorretamente()
    {
        //Arrange
        var valor1 = 5;
        var valor2 = 5;
        var resultadoEsperado = 0;

        var calculadora = new CalculadoraService();

        //Act
        var resultado = calculadora.Subtrair(valor1, valor2);

        //Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void Multiplicao_ComNumerosInteiros_DeveMultiplicarCorretamente()
    {
        //Arrange
        var valor1 = 3;
        var valor2 = 2;
        var resultadoEsperado = 6;

        var calculadora = new CalculadoraService();

        //Act
        var resultado = calculadora.Multiplicar(valor1, valor2);

        //Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void Dividir_ComNumerosInteiros_DeveDividirCorretamente()
    {
        //Arrange
        var valor1 = 3;
        var valor2 = 3;
        var resultadoEsperado = 1;

        //Act
        var calculadora = new CalculadoraService();

        //Assert
        var resultado = calculadora.Dividir(valor1, valor2);
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Theory]

    [InlineData(2, true)]
    [InlineData(4, true)]
    [InlineData(5, false)]
    public void Par_ComNumerosInteiros_DeveRetornarParCorretamente(int valor, bool resultadoEsperado)
    {
        //Arrange
        var calculadora = new CalculadoraService();

        //Act
        var resultado = calculadora.EhPar(valor);

        //Assert
        Assert.Equal(resultadoEsperado, resultado);
    }
}