namespace EventSystem;

public class Event
{
    public string Name { get; set; }

    public Registration<int> Users { get; } = new();
    public Dictionary<string, int> Votes { get; } = new();

    public Event(string name)
    {
        Name = name;
    }

    public void ShowResumen()
    {
        Console.WriteLine($"\nEvento: {Name}");
        Console.WriteLine($"Usuários unicos: {Users.Values.Count}");

        Console.WriteLine("Votos");
        foreach (var (candidato, total) in Votes)
        {
            Console.WriteLine($"- {candidato}: {total} voto(s)");
        }
    }
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
                if (Votes.TryGetValue(name, out int currentTotal))
                {
                    Votes[name] = currentTotal + votes;
                }
                else
                {
                    Votes[name] = votes;
                }
            }
            else
            {
                Console.WriteLine("Invalid number of votes. Please try again.");
            }
            Console.Clear();
        }
    }
}
