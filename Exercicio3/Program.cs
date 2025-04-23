
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Qual cargo você deseja cadastrar: (1) Funcionário ou (2) Gerente?");
        string opcao = Console.ReadLine();

        if (opcao == "1")
        {
            Funcionario f = new Funcionario();
            Console.Write("Nome completo: ");
            f.NomeCompleto = Console.ReadLine();
            Console.Write("Salário: ");
            f.Salario = Convert.ToDouble(Console.ReadLine());
            f.ExibirDados();
        }
        else if (opcao == "2")
        {
            Gerente g = new Gerente();
            Console.Write("Nome completo: ");
            g.NomeCompleto = Console.ReadLine();
            Console.Write("Salário: ");
            g.Salario = Convert.ToDouble(Console.ReadLine());
            Console.Write("Departamento: ");
            g.Departamento = Console.ReadLine();
            g.ExibirDados();
        }
        else
        {
            Console.WriteLine("Opção inválida.");
        }
    }
}
