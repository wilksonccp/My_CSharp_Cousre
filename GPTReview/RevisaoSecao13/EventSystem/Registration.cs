namespace EventSystem;

public class Registration<T>
{
    internal HashSet<T> Values { get; } = new HashSet<T>();

    public void Insert(T item)
    {
        Values.Add(item);
    }
    public void Remove(T item)
    {
        Values.Remove(item);
    }
}
