using System.Reflection.Metadata;

namespace ExercicioFixacao04;

public class Calculadora
{

    public static double Iof = 6.0;
    public static double ConvUSDBLR(double Qtd, double Cot)
    {
        double total = Qtd * Cot;
        return total + total * Iof / 100.0;
    }
}
