using System.Globalization;
using ExercicioResolvido02.Entites;
using ExercicioResolvido02.Entites.Enums;

namespace ExercicioResolvido02
{
    class program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();


            Console.WriteLine("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                char RC = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (RC == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(width, height, color));

                }
                else
                {
                    Console.Write("Radium: ");
                    double radium = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(radium, color));
                }

            }
            Console.WriteLine("SHAPE EREAS;");
            foreach (Shape s in list)
            {
                Console.WriteLine(s.Area().ToString("f2", CultureInfo.InvariantCulture));
            }

        }
    }
}