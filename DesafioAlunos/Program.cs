namespace DesafioAlunos;
class Program
{
    static void Main(string[] args)
    {
        Alunos aluno1 = new Alunos();

        Console.Write("Nome do aluno(a): ");
        string? nome = Console.ReadLine();
        Console.Write("Digite a nota: ");
        double nota1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("A nota digitada foi: "+ nota1);
        Console.Write("Digite a segunda nota: ");
        double nota2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("A nota digitada foi: "+ nota2);
        aluno1.nome = nome;
        aluno1.nota1 = nota1;
        aluno1.nota2 = nota2;

        aluno1.mensagem();
    }
}
