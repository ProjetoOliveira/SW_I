namespace aula08;
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        //Console.ReadKey();

        //Instanciar um objeto a partir de uma classe
        Exemplo exe01 = new Exemplo();

        exe01.mostramsg();

        exe01.mostranome("Çabi");

        Console.WriteLine(exe01.msg());

        Console.WriteLine("A soma é: " + exe01.somar(10, 5));
    }
}
