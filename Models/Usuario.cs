namespace LINQT.Models;

public class Usuario
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public int Idade { get; set; }
    public List<string>? Cursos { get; set; }

    public override string ToString() => $"Id: {Id}, Nome: {Nome}, Idade: {Idade}";
}
