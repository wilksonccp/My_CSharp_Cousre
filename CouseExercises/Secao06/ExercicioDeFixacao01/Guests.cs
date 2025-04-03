namespace ExercicioDeFixacao01;

public class Guests
{
    public string Name
    {
        get => _name;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Nome não pode ser vazio.");
            _name = value;
        }
    }

    public string Email
    {
        get => _email;
        set
        {
            if (!value.Contains("@"))
                throw new ArgumentException("Email deve ser válido.");
            _email = value;
        }
    }

    public Guests(string name, string email)
    {
        Name = name;  // Isso chama o setter, que inclui a validação
        Email = email;  // Isso também chama o setter
    }

    private string _name;
    private string _email;
}
