namespace ExerciciodeFixacao.Entities;

public class Coustumer
{
    public string Name { get; set; }
    public string EMail { get; set; }
    public DateTime BirthDate { get; set; }

    public Coustumer()
    {
    }
    public Coustumer(string name, string eMail, DateTime birthDate)
    {
        Name = name;
        EMail = eMail;
        BirthDate = birthDate;
    }
    public override string ToString()
    {
        return Name + ", (" + BirthDate.ToString("dd/MM/yyyy") + ") - " + EMail;
    }
}
