namespace VotesCounter;

public class VotesBox
{
    private Dictionary<string, int> _votes = new Dictionary<string, int>();

    public void AddVotes()
    {
        while (true)
        {
            Console.Write("Insert the candidate name (or type 'exit' to finish): ");
            string name = Console.ReadLine();
            if (name.ToLower() == "exit")
                break;

            Console.Write($"Enter the number of votes for candidate {name}: ");
            if (int.TryParse(Console.ReadLine(), out int votes))
            {
                if (_votes.TryGetValue(name, out int currentTotal))
                {
                    _votes[name] = currentTotal + votes;
                }
                else
                {
                    _votes[name] = votes;
                }
            }
            else
            {
                Console.WriteLine("Invalid number of votes. Please try again.");
            }
            Console.Clear();
        }
    }
    public void Totalvotes()
    {
        foreach(var (name, votes) in _votes)
        {
            Console.WriteLine($"{name} : {votes}");
        }
    }
}
