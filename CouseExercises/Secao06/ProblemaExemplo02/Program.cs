using System;
using System.Globalization;

namespace ProbelmaExemplo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos produtos serão inseridos: ");
            int qtdPrd = int.Parse(Console.ReadLine());
            Product[] all = new Product[qtdPrd];

            for (int i = 0; i < qtdPrd; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                all[i] = new Product() { Name = name, Price = price };
            }
            double sumAll = 0;
            for (int i = 0; i < qtdPrd; i++)
            {
                sumAll += all[i].Price;
            }
            double avg = sumAll / qtdPrd;
            Console.WriteLine("AVERAGE PRICE :" + avg.ToString("f2", CultureInfo.InvariantCulture));


        }
    }
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
}


