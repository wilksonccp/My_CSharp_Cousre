using System.Globalization;
namespace ExercicioDeFixacao;

internal class Conta
{
    internal string Titular{ get; set;}
    internal int Numero { get; set;}
    internal double Saldo { get; set;}

    internal Conta(string titular, int numero)
    {
        Titular = titular;
        Numero = numero;
    }
    internal Conta(string titular, int numero, double saldo) : this(titular, numero)
    {
        Deposito(saldo);
    }
    internal Conta ()
    {
        Titular = null;
        Numero = 0000;
        Saldo = 0.0;
        
    }
    internal void Deposito(double valor)
    {
        Saldo += valor;
    }
    internal void Saque(double valor)
    {
        Saldo -= valor+5.00;
    }
    public override string ToString()
    {
        CultureInfo cultura = CultureInfo.InvariantCulture;
        return $"Conta {Numero}, Titular: {Titular}, Saldo: R$ {Saldo.ToString("f2", cultura)} ";
    }


}
