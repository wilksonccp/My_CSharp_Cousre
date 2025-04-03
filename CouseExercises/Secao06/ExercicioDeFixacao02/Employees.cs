namespace ExercicioDeFixacao02;

public class Employee
{
    public int Id { get; private set; }
    public string Name { get; set; }
    private double Salary;

    public Employee(int id, string name, double salary)
    {
        Id = id;
        Name = name;
        Salary = salary;
    }

    public void IncreasseSalary(double por)
    {
        Salary += this.Salary*(por/100);
    }
    public override string ToString()
    {
        return $"{Id}, {Name}, R$ {Salary}";
    }
}
