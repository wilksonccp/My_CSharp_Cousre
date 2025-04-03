using System;

namespace VotesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            VotesBox votes = new VotesBox();

            Console.WriteLine("VOTES COUNTER - WELCOME");
            Console.WriteLine("=======================");
            Console.WriteLine();

            votes.AddVotes();
            votes.Totalvotes();

        }
    }
}
