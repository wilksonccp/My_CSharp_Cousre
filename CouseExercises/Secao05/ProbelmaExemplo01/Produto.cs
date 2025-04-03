using System.Globalization;

namespace ProblemaExemplo02;

public class Produto
{
    public string Nome;
    public double Preco;
    public int Quantidade;

    public Produto(string nome, double preco, int quantidade)
    {
        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;

    }

    public Produto(string nome, double preco)
    {
        Nome = nome;
        Preco = preco;
        Quantidade = 8;
    } 


    public double ValorTotalEmEstoque()
    {
        return Preco * Quantidade;
    }
    public void AdicionaProduto(int quantidade)
    {
        Quantidade += quantidade;
    }
    public void RemoveProduto(int quantidade)
    {
        Quantidade -= quantidade;
    }

    public override string ToString()
    {
        CultureInfo cultura = CultureInfo.InvariantCulture;
        return $"Dados do Produto: {Nome}, R$ {Preco.ToString("f2", cultura)}, {Quantidade} unidades, Total R$ {ValorTotalEmEstoque().ToString("f2", cultura)}";
    }
}
