using System;

public class VagaEstacionamento
{
    private int numeroVaga;
    private bool ocupada;
    private string tipoVeiculo;

    public int NumeroVaga => numeroVaga;

    public string TipoVeiculo
    {
        get => tipoVeiculo;
        private set
        {
            if (value == "Carro" || value == "Moto" || value == "Caminhão")
                tipoVeiculo = value;
            else
                Console.WriteLine("Esse veículo não é permitido");
        }
    }

    public bool Ocupada
    {
        get => ocupada;
        private set => ocupada = value;
    }

    public VagaEstacionamento(int numero, string tipo)
    {
        numeroVaga = numero;
        TipoVeiculo = tipo;
        Ocupada = false;
    }

    public void OcuparVaga()
    {
        Ocupada = true;
        Console.WriteLine("Vaga ocupada.");
    }

    public void LiberarVaga()
    {
        Ocupada = false;
        Console.WriteLine("Vaga liberada.");
    }

    public void AlterarTipoVeiculo(string novoTipo)
    {
        if (Ocupada)
        {
            Console.WriteLine("Não é possível fazer essa alteração.");
        }
        else
        {
            TipoVeiculo = novoTipo;
        }
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"\nNúmero da Vaga: {NumeroVaga}");
        Console.WriteLine($"Tipo de Veículo: {TipoVeiculo}");
        Console.WriteLine($"Status: {(Ocupada ? "Ocupada" : "Livre")}");
    }
}
