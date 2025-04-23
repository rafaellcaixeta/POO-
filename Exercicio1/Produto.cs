using System;

class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public int QuantidadeTotal { get; private set; }

    public void AdicionarEstoque(int Quantidade)
    {
        if (Quantidade > 0)
        {
            QuantidadeTotal += Quantidade;
            Console.WriteLine($"{Quantidade} unidade(s) adicionada(s).");
        }
    }
    public void RemoverEstoque(int Quantidade)
    {
        if (Quantidade > 0 && Quantidade <= QuantidadeTotal)
        {
            QuantidadeTotal -= Quantidade;
            Console.WriteLine($"{Quantidade} unidade(s) removida(s).");
        }
        else
        {
            Console.WriteLine("Estoque insuficiente ou valor inválido.");
        }
    }
    public double ValorTotalEmEstoque()
    {
        return Preco * QuantidadeTotal;
    }
}
