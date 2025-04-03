using System;
using System.Globalization;

namespace Chll03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string vendas = @"C:/Temp/vendas.csv";
            string PathFl = @"C:/Temp";

            using (StreamReader sr = File.OpenText(vendas))
            using (StreamWriter sw = File.CreateText(PathFl + "/report.txt"))
            {
                sw.WriteLine("Produto,Total");
                string linha;
                while ((linha = sr.ReadLine()) != null)
                {
                    string[] dados = linha.Split(',');
                    if (dados.Length >= 3 && double.TryParse(dados[1], NumberStyles.Any, CultureInfo.InvariantCulture, out double preco))
                    {
                        int quantidade = int.Parse(dados[2]);
                        double total = preco * quantidade;
                        sw.WriteLine($"{dados[0]}, {total.ToString("F2", CultureInfo.InvariantCulture)}");
                    }

                }
                Console.WriteLine("Arquivo resumo.csv gerado com sucesso!");
            }
        }
    }
}


