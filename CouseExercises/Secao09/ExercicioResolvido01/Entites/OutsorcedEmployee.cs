namespace ExercicioResolvido01.Entites;

public class OutsorcedEmployee : Employee
{
    public double AditionaCharge { get; set; }

    public OutsorcedEmployee()
    {
    }
    public OutsorcedEmployee(string name, int hours, double valuePerHour, double aditionaCharge)
        : base(name, hours, valuePerHour)
    {
        AditionaCharge = aditionaCharge;
    }

    public override double Payment()
    {
        return base.Payment() + 1.1 * AditionaCharge;
    }
}
