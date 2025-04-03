using System;
using System.Globalization;
using System.Collections.Generic;

namespace ExercicioDeFixacao02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many employees will be registred?");
            int qtdReg = int.Parse(Console.ReadLine());
            int reg = 1;
            List<Employee> registred = new List<Employee>();

            for (int i = 0; i < qtdReg; i++)
            {
                Console.WriteLine($"Employee #{reg}:");
                Console.Write("Id: ");
                int emplId = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string emplName = Console.ReadLine();

                Console.Write("Salary: ");
                double emplSal = double.Parse(Console.ReadLine());

                bool idExists = registred.Exists(e => e.Id == emplId);
                if (!idExists)
                {
                    registred.Add(new Employee(emplId, emplName, emplSal));
                    reg++;
                }
                else
                {
                    Console.WriteLine("ID already exists. Try again.");
                    i--; // Decrementa o índice para repetir a inserção do funcionário
                }
            }
            Console.Write("Enter the employee id that will have salary incresse: ");
            int idIncre = int.Parse(Console.ReadLine());
            Employee employee = registred.Find(e => e.Id == idIncre);
            if (employee != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine());
                employee.IncreasseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }
            Console.WriteLine("Updated list of employees:");
            foreach (Employee emp in registred)
            {
                Console.WriteLine(emp); // Certifique-se de que a classe Employees tenha um método ToString adequado
            }

        }
    }
}


