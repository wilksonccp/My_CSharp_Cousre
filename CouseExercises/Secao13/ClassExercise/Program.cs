namespace ClassExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService<int> ps = new PrintService<int> ();

            Console.WriteLine("How many values?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                ps.AddValue(int.Parse(Console.ReadLine()));
            }

            ps.Print();

            Console.WriteLine("First: " + ps.First());
        }
    }
}