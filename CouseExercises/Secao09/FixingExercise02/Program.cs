using System.Collections.Generic;
using System.Globalization;
using FixingExercise02.Entites;

namespace FixingExercise02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Payer> payers = new List<Payer>();
            Console.WriteLine("Enter the number of tax payers: ");
            int NPayers = int.Parse(Console.ReadLine());

            for (int i = 1; i <= NPayers; i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Tax payer #{i} data:");
                Console.ResetColor();
                Console.Write("Individual or company (i/c)?");
                char IoC = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double AnInc = double.Parse(Console.ReadLine());
                if (IoC == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double HElExp = double.Parse(Console.ReadLine());

                    payers.Add(new PersonalPayer(name, AnInc, HElExp));

                }
                else
                {
                    Console.Write("Number of employees: ");
                    int NumEmp = int.Parse(Console.ReadLine());

                    payers.Add(new CompanyPayer(name, AnInc, NumEmp));
                }

            }
            Console.WriteLine("TAXES PAID:");
            double TaxTotal = 0;
            foreach (Payer payer in payers)
            {
                Console.WriteLine(payer.ToString());
                TaxTotal += payer.Tax();
            }
            Console.WriteLine("TOTAL TAXES: $ " + TaxTotal.ToString("f2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}


