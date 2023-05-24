namespace contratos;
class ContratoPF:Contrato
{
    public string? cpf {get;set;}
    public int? Idade {get;set;}

    public override string MostraDados(){
        return base.MostraDados() + "  CPF:" + this.cpf + "  Idade:" + this.Idade;

    }
}