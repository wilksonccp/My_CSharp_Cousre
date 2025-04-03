using ExercicioResolvido02.Entites.Enums;
namespace ExercicioResolvido02.Entites;

class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius, Color color) : base(color)
    {
        Radius = radius;
    }

    public override double Area()
    {
        return Math.PI * Radius * Radius;
    }
}
