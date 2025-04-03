using System;
using static System.Console;

namespace DC01
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hi, I'll check if if you're realy drunk. (press enter)");
            ReadLine();
            Clear();
            WriteLine("Please Hou many drinks did you have?");
            int drinks = int.Parse(ReadLine());

            if (drinks < 3)
            {
                WriteLine("You're fine, continue drinking");
            }
            else if (drinks < 6)
            {
                WriteLine("Looks, do you see the code in 4D?");
            }
            else
            {
                WriteLine("MAN, come on, you're drunk, go home!");
            }
        }
    }
}