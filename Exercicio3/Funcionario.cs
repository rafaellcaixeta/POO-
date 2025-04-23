using System;
using System.Globalization;

public class Funcionario
{
    public string NomeCompleto;
    public double Salario;

    public virtual void ExibirDados()
    {
        string[] partesNome = NomeCompleto.Split(' ');
        string ultimoSobrenome = partesNome[partesNome.Length - 1].ToUpper();

        string salarioFormatado = Salario.ToString("C", new CultureInfo("pt-BR"));

        Console.WriteLine("\nÚltimo sobrenome: " + ultimoSobrenome);
        Console.WriteLine("Salário: " + salarioFormatado);
    }
}
