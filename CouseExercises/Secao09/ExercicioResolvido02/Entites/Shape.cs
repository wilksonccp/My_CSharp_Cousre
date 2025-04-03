using ExercicioResolvido02.Entites.Enums;
namespace ExercicioResolvido02.Entites;

abstract class Shape
{
    public Color Color { get; set; }

    public Shape(Color color)
    {
        Color = color;
    }

    public abstract double Area();
}
