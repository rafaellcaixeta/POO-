
public class Calculadora
{
    double ValorA, ValorB;
    Calculo calculo = new Calculo();

    public void ExecutarCalculadora()
    {
        LerValores();

        Console.WriteLine("\nEscolha uma operação:");
        Console.WriteLine("1. Soma");
        Console.WriteLine("2. Subtração");
        Console.WriteLine("3. Multiplicação");
        Console.WriteLine("4. Maior valor");
        Console.WriteLine("5. Somar Geral");
        Console.Write("Opção: ");
        string opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                calculo.CalcularSoma(ValorA, ValorB);
                break;
            case "2":
                calculo.CalcularSubtracao(ValorA, ValorB);
                break;
            case "3":
                calculo.CalcularMultiplicacao(ValorA, ValorB);
                break;
            case "4":
                Console.WriteLine("Maior valor: " + calculo.RetornarMaior(ValorA, ValorB));
                return;
            case "5":
                Console.Write("Digite um terceiro valor: ");
                double v3 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Soma geral: " + calculo.SomarGeral(ValorA, ValorB, v3));
                return;
            default:
                Console.WriteLine("Opção inválida.");
                return;
        }

        ImprimirResultado();
    }

    void LerValores()
    {
        Console.Write("Digite o primeiro valor: ");
        ValorA = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo valor: ");
        ValorB = Convert.ToDouble(Console.ReadLine());
    }

    void ImprimirResultado()
    {
        Console.WriteLine("Resultado: " + calculo.Resultado);
    }
}
