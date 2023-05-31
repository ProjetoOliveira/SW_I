namespace ex1_animal;
class Cao:Animal
{
    public string Nome = "";
    public override string Fala(){
        return base.Fala() + " Au Au";
    }
}