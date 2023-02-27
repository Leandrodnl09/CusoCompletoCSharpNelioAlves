
using ExercicioAluno;

Aluno aluno = new Aluno();

Console.Write("Digite o nome do aluno: ");
aluno.Nome = Console.ReadLine();

Console.WriteLine("Digite as três notas do aluno: ");
aluno.Nota1 = double.Parse(Console.ReadLine());
aluno.Nota2 = double.Parse(Console.ReadLine());
aluno.Nota3 = double.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Nota Final: " + aluno.NotaFinal().ToString("F2"));

if (aluno.Aprovado()){
    Console.WriteLine("Aluno aprovado!");
}
else
{
    Console.WriteLine("Aluno Reprovado!");
    Console.WriteLine("Faltam " + aluno.NotaRestante() + " pontos!");
}