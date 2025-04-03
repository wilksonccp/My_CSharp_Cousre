using System;
using System.Globalization;

namespace ExercicioDeFixacao03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Interactions userInteractions = new Interactions();
            userInteractions.start();
            Console.Write("Enter the number of lines: ");
            int lines = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of columns: ");
            int columns = int.Parse(Console.ReadLine());
            int[,] matExer03 = new int[lines,columns];

            Console.WriteLine("Thanks, now we need know a numbers to inserts");

            for (int i = 0; i < lines; i++)
            {
                Console.WriteLine($"Please enter the {columns} numbers to line {i+1} \nseparated by a blank space: ");
                string[] values = Console.ReadLine().Split(' ');
                for(int j = 0; j < values.Length; j++)
                {
                    matExer03[i,j] = int.Parse(values[j]);
                }
            }
            Console.WriteLine("Great, now let's find the location of a number ");
            Console.Write("Whats number do you want to find?");
            int findNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    if(matExer03[i,j]== findNumber)
                    {
                        Console.WriteLine($"I found this number in this position[{i}, {j}]");
                        if (i-1 >=0)
                        {
                            Console.WriteLine($"Above it is the number {matExer03[i-1,j]}");
                        }
                        if (i+2 <lines)
                        {
                            Console.WriteLine($"Below it is the number {matExer03[i+1,j]}");
                        }
                        if (j-1 >=0)
                        {
                            Console.WriteLine($"The left number is {matExer03[i,j-1]}");
                        }
                        if (j+2 <columns)
                        {
                            Console.WriteLine($"The right number is {matExer03[i,j+1]}");
                        }
                        Console.WriteLine($"");

                    } 
                }
            }
        }
    }
}
