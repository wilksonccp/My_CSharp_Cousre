namespace RepositoryProject;

public class Usuario : EntidadeBase
{
    public string Nome { get; set; }
    public string Email { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}, Nome: {Nome}, Email: {Email}";
    }
}
