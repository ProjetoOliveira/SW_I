namespace contratos;
class Program
{
    static void Main(string[] args)
    {
        ContratoPF n1 = new ContratoPF();
        ContratoPJ n2 = new ContratoPJ();

        n1.Email = "heloisa@gmail.com";
        n1.Nome = "Heloísa";
        n1.Telefone = "(11) 97349-0883";
        n1.cpf = "549.394.548-96";
        n1.Idade = 18;

        n2.Email = "luciana@gmail.com";
        n2.Nome = "Luciana";
        n2.Telefone = "(11) 94957-7145";
        n2.cnpj = "07.526.557/0001-00";
        n2.ie = "231.743.931.001";
        n2.NomeEmpresa = "Informatec";
        
        Console.WriteLine("Os dados da pessoa física são: " + n1.MostraDados());
        Console.WriteLine("Os dados da pessoa jurídica são: " + n2.MostraDados());
    }
}