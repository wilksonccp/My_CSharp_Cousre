public static class ConsoleHelper
{
    public static void EscreverTitulo(string texto)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(texto);
        Console.ResetColor();
    }

    public static void EscreverItem(string texto)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(texto);
        Console.ResetColor();
    }

    public static void EscreverErro(string texto)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"[ERRO] {texto}");
        Console.ResetColor();
    }

    public static void EscreverAlerta(string texto)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"⚠️ {texto}");
        Console.ResetColor();
    }
}
