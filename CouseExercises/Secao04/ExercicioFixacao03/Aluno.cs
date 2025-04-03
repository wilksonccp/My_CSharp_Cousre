namespace ExercicioFixacao03;

public class Aluno
{
    public string Nome;
    public double Nota01, Nota02, Nota03;

    public double NotaFinal()
    {
        return Nota01+Nota02+Nota03;
    }
    public bool Aprovado()
    {
        if (NotaFinal() >= 60.00)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public double NotaRestante()
    {
        if(Aprovado())
        {
            return 0.0;
        }
        else
        {
            return 60.0 - NotaFinal();
        }
    }
}
