namespace RepositoryProject;

public class Repositorio<T> where T : EntidadeBase, new()
{
    private List<T> _dados = new List<T>();
    private int _contadorId = 1;

    public T Criar()
    {
        T entidade = new T();
        entidade.Id = _contadorId++;
        _dados.Add(entidade);
        return entidade;
    }

    public void ListarTodos()
    {
        foreach (T item in _dados)
        {
            Console.WriteLine(item);
        }
    }
}
