using System;
using System.Collections.Generic;

namespace PrintGenericService
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer<object> printer = new Printer<object>();
            Type tipoPermitido = null;

            while (true)
            {
                Console.Write("Insert the value (or 'exit' to quit): ");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit") break;

                object ConvertedValue;

                // Try to convert in int, double or saty with string
                if (int.TryParse(input, out int i))
                {
                    ConvertedValue = i;
                }
                else if (double.TryParse(input, out double d))
                {
                    ConvertedValue = d;
                }
                else
                {
                    ConvertedValue = input;
                }

                //If the frist the type is defined
                if (tipoPermitido == null)
                {
                    tipoPermitido = ConvertedValue.GetType();
                    Console.WriteLine($"Type defined: {tipoPermitido}");
                    Console.WriteLine("Now you can put onsly this type.");
                }

                //Check if the type is permitted
                if (ConvertedValue.GetType() != tipoPermitido)
                {
                    Console.WriteLine("Invalid Type");
                    Console.WriteLine($"Please insert only the type: {tipoPermitido}");
                    continue;
                }

                printer.AddItem(ConvertedValue);
                Console.WriteLine($"Item added: {ConvertedValue}");


            }

            printer.PrintItems();

        }
    }
}
