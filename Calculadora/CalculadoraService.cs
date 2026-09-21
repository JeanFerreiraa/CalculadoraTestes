namespace Calculadora;

public class CalculadoraService
{
    public decimal Somar(decimal valor1, decimal valor2)
    {
        return (int)valor1 + (int)valor2;
    }

    public decimal Subtrair(decimal valor1, decimal valor2)
    {
        return (int)valor1 - (int)valor2;
    }

    public decimal Multiplicar(decimal valor1, decimal valor2)
    {
        return (int)valor1 * (int)valor2;
    }

    public decimal Dividir(decimal valor1, decimal valor2)
    {
        return (int)valor1 / (int)valor2;
    }
    public bool EhPar(decimal valor)
    {
        return valor % 2 == 0;
    }

}