using ExercicioResolvido02.Entities;
namespace ExercicioResolvido02
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Heve a nice trip!");
            Comment c2 = new Comment("Wow thats awesome!");

            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Travelig to New Zeland",
                "I'm going to visit this wondeful country",
                12);
            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the Force be with you");

            Post p2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good night guys",
                "See you tomorrow",
                12);
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);

        }

    }
}