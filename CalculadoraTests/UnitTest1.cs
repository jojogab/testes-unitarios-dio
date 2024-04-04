using Calculadora;

namespace CalculadoraTests;

public class UnitTest1
{
    public Calculador construirClasse()
    {
        string data = "04/04/2024";
        Calculador calc = new Calculador(data);

        return calc;
    }

    [Theory]
    [InlineData (1, 2, 3)]
    [InlineData (4, 5, 9)]
    public void TestSoma(int val1, int val2, int esperado)
    {
        Calculador calc = construirClasse();

        int resultado = calc.somar(val1, val2);

        Assert.Equal(esperado, resultado);
    }

    [Theory]
    [InlineData (2, 2, 0)]
    [InlineData (4, 5, -1)]
    public void TestSubtrair(int val1, int val2, int esperado)
    {
        Calculador calc = construirClasse();

        int resultado = calc.subtrair(val1, val2);

        Assert.Equal(esperado, resultado);
    }

    [Theory]
    [InlineData (1, 2, 2)]
    [InlineData (4, 5, 20)]
    public void TestMultiplicar(int val1, int val2, int esperado)
    {
        Calculador calc = construirClasse();

        int resultado = calc.multiplicar(val1, val2);

        Assert.Equal(esperado, resultado);
    }

    [Theory]
    [InlineData (6, 2, 3)]
    [InlineData (4, 2, 2)]
    public void TestDividir(int val1, int val2, int esperado)
    {
        Calculador calc = construirClasse();

        int resultado = calc.dividir(val1, val2);

        Assert.Equal(esperado, resultado);
    }

    [Fact]
    public void TestarDivisaoPor0()
    {
        Calculador calc = construirClasse();

        Assert.Throws<DivideByZeroException>(
            () => calc.dividir(3,0)
        );
    }

    [Fact]
    public void TestarHistorico()
    {
        Calculador calc = construirClasse();

        calc.somar(1, 9);
        calc.somar(2, 6);
        calc.somar(3, 7);
        calc.somar(4, 5);

        var lista = calc.historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}