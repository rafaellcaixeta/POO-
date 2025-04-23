using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o número da vaga: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o tipo de veículo que deseja estacionar (Carro, Moto ou Caminhão): ");
        string tipo = Console.ReadLine();

        VagaEstacionamento vaga = new VagaEstacionamento(numero, tipo);

        vaga.OcuparVaga();
        vaga.AlterarTipoVeiculo("Moto");
        vaga.LiberarVaga();
        vaga.AlterarTipoVeiculo("Moto");
        vaga.ExibirInformacoes();
    }
}
