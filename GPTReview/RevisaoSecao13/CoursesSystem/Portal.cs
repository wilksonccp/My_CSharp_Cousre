namespace CoursesSystem;

public class Portal
{
    private Dictionary<string, Course> _portal = new Dictionary<string, Course>();

    public void InsertCouse()
    {
        Console.Write("How many courses do you what insert?");
        int qtdCou;
        while (!int.TryParse(Console.ReadLine(), out qtdCou) || qtdCou < 0)
        {
            Console.Write("Invalid input. Please enter a valid positive number: ");
        }

        for (int i = 0; i < qtdCou; i++)
        {
            string nameCourse;

            // Loop até o usuário digitar algo válido
            do
            {
                Console.Write($"Insert the name of course #{i + 1}: ");
                nameCourse = Console.ReadLine() ?? string.Empty;

                if (string.IsNullOrWhiteSpace(nameCourse))
                {
                    Console.WriteLine("Course name cannot be empty. Please try again.");
                }

            } while (string.IsNullOrWhiteSpace(nameCourse));

            Course newCourse = new Course(); // Não esquece de instanciar aqui
            newCourse.InsertStudent();

            _portal[nameCourse] = newCourse;
        }

    }
    public int GetTotalUniqueStudents()
    {
        HashSet<int> allStudents = new HashSet<int>();

        foreach (var course in _portal.Values)
        {
            allStudents.UnionWith(course.students);
        }

        return allStudents.Count;
    }
}
