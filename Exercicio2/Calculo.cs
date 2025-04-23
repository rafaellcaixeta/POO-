public class Calculo
{
    public double Resultado;

    public void CalcularSoma(double a, double b)
    {
        Resultado = a + b;
    }

    public void CalcularSubtracao(double a, double b)
    {
        Resultado = a - b;
    }

    public void CalcularMultiplicacao(double a, double b)
    {
        Resultado = a * b;
    }

    public double RetornarMaior(double a, double b)
    {
        return (a > b) ? a : b;
    }

    public double SomarGeral(double a, double b, double c)
    {
        return a + b + c;
    }
}
