#region OperacaoDeConjunto

//Distinct

using LINQT.Data;
using LINQT.Models;

int[] idades = new[] { 1, 2, 3, 4, 5, 12, 11, 5, 3, 2, 11, 4, 7, 9 };

IEnumerable<int> idadesDistintas = idades.Distinct().ToList();

//foreach (int idade in idadesDistintas)
//    Console.Write($"{idade}, ");

// Utilizando IEqualityComparer para String no método Distinct

string[] nomes = new[] { "Richard", "richard", "Ellen", "Ellen" };

var nomesDist = (from nome in nomes
                 select nome).Distinct(StringComparer.OrdinalIgnoreCase).ToList();

//foreach (string nome in nomesDist)
//    Console.Write($"{nome}, ");

// DistinctBy

IEnumerable<Aluno> alunos = FonteDados.GetAlunos().DistinctBy(aluno => aluno.Idade);

IEnumerable<Aluno> alunosIdadeDistintas = alunos.DistinctBy(aluno => aluno.Idade);

//foreach (Aluno aluno in alunosIdadeDistintas)
//    Console.WriteLine($"Nome: {aluno.Nome} | Idade: {aluno.Idade}");

//Except

int[] fonte1 = new int[] { 1, 2, 8, 4, 2, 3 };
int[] fonte2 = new int[] { 1, 3, 5, 4, 2, 7 };

IEnumerable<int> fontesDistinct = fonte1.Except(fonte2).ToList();

//foreach (int dadosFonte in fontesDistinct)
//    Console.Write($"{dadosFonte}, ");  8


//Except com String

string[] pais1 = new string[] { "Brasil", "argentina", "Russia", "Japão" };
string[] pais2 = new string[] { "Brasil", "Argentina", "Alemanha", "China", "russia" };

IEnumerable<string> paisDistintos = pais1.Except(pais2).ToList();
//foreach (string pais in paisDistintos)
//    Console.Write($"{pais} ");


//Except com Sobrecarga e utilizando IEqualityComparer

IEnumerable<string> paisDistintosIEquality = pais1.Except(pais2, StringComparer.OrdinalIgnoreCase);

//foreach (string pais in paisDistintosIEquality)
//    Console.Write($"{pais} ");


#endregion