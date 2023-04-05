namespace metodos_construtores;
class Program
{
    static void Main(string[] args)
    {
        //Pessoa p1 = new Pessoa();
        Pessoa p1 = new Pessoa("Heloísa",16);
        //p1.insereNome("Heloísa");
        //p1.insereSobreNome("Oliveira");
        //p1.insereIdade(16);
        p1.mostraDados();
    }
}
