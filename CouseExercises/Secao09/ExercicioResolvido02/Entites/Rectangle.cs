using ExercicioResolvido02.Entites.Enums;
namespace ExercicioResolvido02.Entites;

class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double Width, double Height, Color color) : base(color)
    {
        Width = Width;
        Height = Height;
    }
    
    public override double Area()
    {
        return Width * Height;
        {
            
        }
    }
}
