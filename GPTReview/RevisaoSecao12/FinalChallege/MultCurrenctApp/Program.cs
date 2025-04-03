using System;
using System.Collections.Generic;
using MultCurrenctApp.Entities;
using MultCurrenctApp.Interfaces;
namespace InterfaceExercise;

class Program
{
    static void Main()
    {
        Console.WriteLine("       CURRENCY CONVERTER       ");
        Console.WriteLine("================================");

        List<Products> products = Products.GetProducts();

        Console.WriteLine("Escolha a moeda para conversão:");
        Console.WriteLine("1 - Dólar (USD)");
        Console.WriteLine("2 - Euro (EUR)");
        Console.WriteLine("3 - Libra (GBP)");
        Console.Write("Digite a opção desejada: ");

        if (!int.TryParse(Console.ReadLine(), out int option) || option < 1 || option > 3)
        {
            Console.WriteLine("Opção inválida! Encerrando programa.");
            return;
        }

        // ✅ Instanciamos o conversor correto com polimorfismo
        ICurrencyConverter converter = option switch
        {
            1 => new USDConverter(),
            2 => new EURConverter(),
            3 => new GBPConverter(),
            _ => throw new InvalidOperationException("Opção inválida!") // Nunca deve acontecer
        };

        // ✅ Aplicamos a conversão
        Console.WriteLine("\nProdutos convertidos:");
        foreach (var product in products)
        {
            double convertedPrice = converter.Convert(product.Price);
            Console.WriteLine($"{product.Name} - {convertedPrice:F2} {GetCurrencySymbol(option)}");
        }
    }

    static string GetCurrencySymbol(int option)
    {
        return option switch
        {
            1 => "USD",
            2 => "EUR",
            3 => "GBP",
            _ => "???"
        };
    }
}
