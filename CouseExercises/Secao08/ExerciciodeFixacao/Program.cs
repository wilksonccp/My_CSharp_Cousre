using System;
using System.Globalization;
using System.Net.Mail;
using ExerciciodeFixacao.Entities;

namespace ExerciciodeFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter cliente data: ");
            Console.ResetColor();
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("E-mail: ");
            string eMail = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birth = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Enter ordder data: ");
            Console.ResetColor();
            Console.WriteLine("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            int qtd = int.Parse(Console.ReadLine());

            Coustumer coustumer = new Coustumer(name, eMail, birth);
            Order order = new Order(DateTime.Now, status, coustumer);

            for (int i = 1; i <= qtd; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string pName = Console.ReadLine();
                Console.Write("Product price: ");
                double pPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantuty: ");
                int pQtd = int.Parse(Console.ReadLine());

                Product product = new Product(pName, pPrice);
                OrderItem orderItem = new OrderItem(pQtd, pPrice, product);
                order.addItem(orderItem);
            }
            Console.WriteLine();
            Console.WriteLine("ORDER SUMARY: ");
            Console.WriteLine(order);
        }
    }
}