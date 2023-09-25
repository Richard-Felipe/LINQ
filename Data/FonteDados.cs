using LINQT.Models;

namespace LINQT.Data;

public class FonteDados
{
    public static List<Funcionario> GetFuncionarios()
    {
        List<Funcionario> funcionarios = new()
        {
            new Funcionario { Nome = "Teste1", Setor = Setores.Programador, Salario = 4898.58m },
            new Funcionario { Nome = "Teste2", Setor = Setores.Administrativo, Salario = 2476m },
            new Funcionario { Nome = "Teste3", Setor = Setores.Tester, Salario = 2608m },
        };

        return funcionarios;
    }

    public static List<Usuario> GetUsuarios()
    {
        List<Usuario> usuarios = new()
        {
            new Usuario { Id = 1, Nome = "Dev" , Idade = 18, Cursos = new List<string> {"C#", "Asp.Net" } },
            new Usuario { Id = 2, Nome = "Teste", Idade = 19, Cursos = new List<string> {"JavaScript", "PHP" } }
        };

        return usuarios;
    }
}