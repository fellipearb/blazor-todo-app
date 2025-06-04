using TodoBlazor.Models;

namespace TodoBlazor.Services;

public class TodoService
{
    private readonly List<Tarefa> _tarefas = new();

    public IEnumerable<Tarefa> GetAllItems() => _tarefas;

    public void AddNewItem(string titulo)
    {
        if (!string.IsNullOrWhiteSpace(titulo))
        {
            _tarefas.Add(new Tarefa { Titulo = titulo });
        }
    }

    public void SetAsDone(Guid id)
    {
        var tarefa = _tarefas.FirstOrDefault(t => t.Id == id);
        if (tarefa != null)
        {
            tarefa.Concluida = true;
        }
    }

    public void RemoveItem(Guid id)
    {
        var tarefa = _tarefas.FirstOrDefault(t => t.Id == id);
        if (tarefa != null)
        {
            _tarefas.Remove(tarefa);
        }
    }
}
