using System;

namespace CoursesSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Portal portal = new Portal();
            portal.InsertCouse();

            int total = portal.GetTotalUniqueStudents();
            Console.WriteLine($"\nTotal number of unique students: {total}");
        }
    }
}
