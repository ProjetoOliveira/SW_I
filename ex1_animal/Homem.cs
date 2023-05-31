namespace ex1_animal;
class Homem:Animal

{
    public string Nome = "";

     public override string Fala(){
        return base.Fala() + " Olá";
    }
}