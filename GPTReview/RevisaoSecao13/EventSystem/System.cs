namespace EventSystem;


public class EventSystem
{

    private Dictionary<string, Event> _events = new();
    public void Run()
    {
        Console.WriteLine("How many events do you want to register?");
        int.TryParse(Console.ReadLine(), out int qtd);

        for (int i = 0; i < qtd; i++)
        {
            Console.WriteLine($"Enter the name of event #{i + 1}:");
            string name = Console.ReadLine() ?? string.Empty;

            Event ev = new(name);

            Console.WriteLine($"Insert user IDs for event '{name}' (type 0 to finish):");
            while (true)
            {

                if (int.TryParse(Console.ReadLine(), out int userId) && userId != 0)
                {
                    ev.Users.Insert(userId);
                }
                else if (userId == 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid ID. Try again.");
                }
            }

            ev.AddVotes();

            _events[name] = ev;

        }

        foreach (var ev in _events.Values)
        {
            ev.ShowResumen();
        }

    }
}
