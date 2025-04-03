using System;
using System.Globalization;
using FixingExercise.Entites;

namespace FixingExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Console.Write("Enter the number of products: ");
            int prodQtd = int.Parse(Console.ReadLine());

            for (int i = 1; i <= prodQtd; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Product #{i} data:");
                Console.ResetColor();
                Console.Write("Common, used or imported (c/u/i)?");
                char CUI = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (CUI == 'i')
                {
                    Console.Write("Customs fee: ");
                    double custFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    products.Add(new ImportedProduct(name, price, custFee));
                }
                else if (CUI == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    products.Add(new UsedProduct(name, price, date));
                }
                else
                {
                    products.Add(new Product(name, price));
                }
            }
            Console.WriteLine("PRICE TAGS:");
            foreach (Product p in products)
            {
                Console.WriteLine(p.PriceTag());
            }
        }
    }
}


