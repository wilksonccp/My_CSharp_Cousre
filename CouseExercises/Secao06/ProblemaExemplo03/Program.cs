using System;
using System.Globalization;

namespace ProblemaExemplo03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert a number: ");
            int number = int.Parse(Console.ReadLine());

            int[,] matnumber = new int[number, number];

            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    Console.WriteLine($"Insert the number in line: {i} column: {j}");
                    matnumber[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.Write("The main diagonal is: ");
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    if (i==j)
                    {
                    int showNumber = matnumber[i, j];
                    Console.Write($" {showNumber}");
                    }
                }
            }
            Console.WriteLine();
            Console.Write("The negatives number is: ");
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    if (matnumber[i, j] <0)
                    {
                    int showNumber = matnumber[i, j];
                    Console.Write($" {showNumber}");
                    }
                }
            }

        }
    }
}
