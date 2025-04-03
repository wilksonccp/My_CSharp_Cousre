using System;
using System.Globalization;

namespace DateTime1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);
            Console.WriteLine(dt.Ticks);
            DateTime dt2 = new DateTime();
        }
    }
}


