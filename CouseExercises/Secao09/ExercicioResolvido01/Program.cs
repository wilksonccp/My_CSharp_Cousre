using System;
using System.Globalization;
using System.Collections.Generic;
using ExercicioResolvido01.Entites;

namespace ExercicioResolvido01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1;i<=n;i++)
            {
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsourced (y/n)?");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double VPH = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'y')
                {
                    Console.Write("Additional charge: ");
                    double aditionalChange = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add( new OutsorcedEmployee (name, hours, VPH, aditionalChange));
                }
                else
                {
                    list.Add(new Employee (name, hours, VPH));
                }

                Console.WriteLine("PAYMENTS:");
                foreach(Employee e in list)
                {
                    Console.WriteLine(e.Name + " - $ " + e.Payment().ToString("f2", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}


