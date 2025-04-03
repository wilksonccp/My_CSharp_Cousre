using System;
using DC02;
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
            
            int drinks;
            while (true)
            {
                string input = ReadLine();
                if(int.TryParse(input, out drinks) && drinks >= 0)
                {
                    break;
                }
                else
                {
                    WriteLine("Please enter a valid number of drinks");
                }
            }

            if (drinks < 3)
            {
                WriteLine("You're still sharp! Keep going!");
            }
            else if (drinks < 6)
            {
                WriteLine("You're still sharp! Keep going!");
            }
            else
            {
                RealyDrunk.ChoiceSenteces(drinks);
            }
        }
    }
}