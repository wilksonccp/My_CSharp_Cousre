using System;
using System.Globalization;

namespace SelesReport
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string SalesPath = @"C:\Temp\pedidos.csv";
            Dictionary<string, double> salesByCoustumer = new Dictionary<string, double>();
            try
            {
                using (StreamReader sr = new StreamReader(SalesPath))
                {
                    string line;
                    bool isFirstLine = true;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (isFirstLine) // Ignora o cabeçalho
                        {
                            isFirstLine = false;
                            continue;
                        }
                        string[] dados = line.Split(',');
                        if (salesByCoustumer.ContainsKey(dados[1]))
                        {
                            salesByCoustumer[dados[1]] += double.Parse(dados[3], CultureInfo.InvariantCulture) * int.Parse(dados[4]);
                        }
                        else
                        {
                            salesByCoustumer[dados[1]] = double.Parse(dados[3], CultureInfo.InvariantCulture) * int.Parse(dados[4]);
                        }
                    }
                }
                using (StreamWriter sw = new StreamWriter(@"C:\Temp\relatorio_clientes.txt"))
                {
                    sw.WriteLine("Vendedor,Total Gasto");
                    foreach (var sale in salesByCoustumer)
                    {
                        sw.WriteLine($"{sale.Key},{sale.Value.ToString("F2", CultureInfo.InvariantCulture)}");
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred while reading the file: " + e.Message);
            }
        }
    }
}


