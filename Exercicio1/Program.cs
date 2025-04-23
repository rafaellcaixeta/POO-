class Program
{
    static void Main(string[] args)
    {
        Produto produto = new Produto();

        Console.Write("Digite o nome do produto: ");
        produto.Nome = Console.ReadLine();

        Console.Write("Digite o preço do produto: ");
        produto.Preco = double.Parse(Console.ReadLine());

        int opcao;

        do
        {
            Console.WriteLine("\n***** MENU *****");
            Console.WriteLine("1. Adicionar Estoque");
            Console.WriteLine("2. Remover Estoque");
            Console.WriteLine("3. Ver Estoque");
            Console.WriteLine("4. Ver Valor Total em Estoque");
            Console.WriteLine("0. Sair");
            Console.Write("Opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Quantidade que deseja adicionar: ");
                    int adicionar = int.Parse(Console.ReadLine());
                    produto.AdicionarEstoque(adicionar);
                    break;

                case 2:
                    Console.Write("Quantidade que deseja remover: ");
                    int remover = int.Parse(Console.ReadLine());
                    produto.RemoverEstoque(remover);
                    break;

                case 3:
                    Console.WriteLine($"Produto: {produto.Nome}, Quantidade em estoque: {produto.QuantidadeTotal}");
                    break;

                case 4:
                    Console.WriteLine($"Valor total em estoque: R$ {produto.ValorTotalEmEstoque():F2}");
                    break;

                case 0:
                    Console.WriteLine("Encerrando programa.");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

        } while (opcao != 0);
    }
}

