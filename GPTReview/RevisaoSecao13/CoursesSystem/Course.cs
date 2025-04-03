namespace CoursesSystem;

public class Course
{
    public HashSet<int> students { get; } = new HashSet<int>();

    public void InsertStudent()
    {
        Console.Write("How many students do you want to insert? ");
        int qtdStd;
        while (!int.TryParse(Console.ReadLine(), out qtdStd) || qtdStd < 0)
        {
            Console.Write("Invalid input. Please enter a valid positive number: ");
        }


        for (int i = 0; i < qtdStd; i++)
        {
            Console.Write($"Insert the ID of student #{i + 1}: ");
            int idStd;
            while (!int.TryParse(Console.ReadLine(), out idStd))
            {
                Console.Write("Invalid ID. Please enter a valid number: ");
            }


            students.Add(idStd);
        }
    }
}
