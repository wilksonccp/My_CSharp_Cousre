using System;

public interface IPagamento
{
    void ProcessarPagamento(decimal valor);
}
public class PagamentoCartao : IPagamento
{
    public void ProcessarPagamento(decimal valor)
    {
        Console.WriteLine($"Pagamento de {valor} processado com cartão de crédito");
    }
}

public class PagamentoPix : IPagamento
{
    public void ProcessarPagamento(decimal valor)
    {
        Console.WriteLine($"Pagamento de {valor} processado com Pix");
    }
}

public class PagamentoBoleto : IPagamento
{
    public void ProcessarPagamento(decimal valor)
    {
        Console.WriteLine($"Pagamento de {valor} processado com boleto");
    }
}
public class PagamentoService
{
    private readonly IPagamento _pagamento;
    public PagamentoService(IPagamento pagamento)
    {
        _pagamento = pagamento;
    }

    public void RealizarPagamento(decimal valor)
    {
        _pagamento.ProcessarPagamento(valor);
    }
}

class Program
{
    static void Main()
    {
        IPagamento pagamentoCartao = new PagamentoCartao();
        var pagamentoServiceCartao = new PagamentoService(pagamentoCartao);
        pagamentoServiceCartao.RealizarPagamento(100);

        Console.WriteLine();

        IPagamento pagamentoPix = new PagamentoPix();
        var pagamentoServicePix = new PagamentoService(pagamentoPix);
        pagamentoServicePix.RealizarPagamento(100);

        Console.WriteLine();

        IPagamento pagamentoBoleto = new PagamentoBoleto();
        var pagamentoServiceBoleto = new PagamentoService(pagamentoBoleto);
        pagamentoServiceBoleto.RealizarPagamento(100);
    }
}