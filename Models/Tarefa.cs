namespace TodoBlazor.Models;

public class Tarefa
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Titulo { get; set; } = string.Empty;
    public bool Concluida { get; set; } = false;
}