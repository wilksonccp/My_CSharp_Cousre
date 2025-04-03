using System.Globalization;

namespace ProblemaExemplo02;

public class Produto
{
    public string Nome;
    public double Preco;
    public int Quantidade;

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
        return "Dados do Produto: "
        + Nome
        + ", R$ "
        + Preco.ToString("f2", CultureInfo.InvariantCulture)
        + ", "
        + Quantidade
        + " unidades, Total R$ " 
        + ValorTotalEmEstoque().ToString("f2", CultureInfo.InvariantCulture);
    }
}
