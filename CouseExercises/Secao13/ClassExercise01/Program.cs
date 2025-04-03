using System.IO;

class ClassExercise01
{
    static void Main(string [] args)
    {
        HashSet<int> codAlunos = new HashSet<int>();
        string[] Courses = new string[3] { "A", "B", "C" };

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"How many students for course {Courses[i]}? ");
            int n = int.Parse(Console.ReadLine());

            for (int j = 0; j < n; j++)
            {
                Console.Write($"Enter the student {j + 1} ID: ");
                int id = int.Parse(Console.ReadLine());
                codAlunos.Add(id);
            }
        }
        Console.WriteLine("Total students: " + codAlunos.Count);
    }
}