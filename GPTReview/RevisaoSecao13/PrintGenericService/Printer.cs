namespace PrintGenericService;

public class Printer<T>
{
    private List<T> _items = new List<T>();
    public void AddItem(T item)
    {
        _items.Add(item);
    }
    public void PrintItems()
    {
        for (int i = 0; i < _items.Count; i++)
        {
            Console.Write(_items[i]);
            if (i < _items.Count - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }

    public void PrintFrist()
    {
        if (_items.Count > 0)
        {
            Console.WriteLine(_items[0]);
        }
        else
        {
            Console.WriteLine("No items to print.");
        }
    }
}