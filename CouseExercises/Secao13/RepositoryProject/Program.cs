using RepositoryProject;

class Program
{
    static void Main(string[] args)
    {
        var repositorio = new Repositorio<Usuario>();

        Usuario u1 = repositorio.Criar();
        u1.Nome = "Maria";
        u1.Email = "maria@gmail.com";

        Usuario u2 = repositorio.Criar();
        u2.Nome = "João";
        u2.Email = "joao@gmail.com";

        Console.WriteLine("Listando todos os usuários:");
        repositorio.ListarTodos();
    }
}