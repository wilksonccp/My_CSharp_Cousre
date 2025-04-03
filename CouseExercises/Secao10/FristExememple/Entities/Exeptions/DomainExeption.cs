namespace FristExememple.Entities.Exeptions;

public class DomainExeption : ApplicationException
{
    public DomainExeption(string message) : base(message)
    {
    }
}
