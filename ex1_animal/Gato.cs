namespace ex1_animal;
class Gato:Animal
{
    public string Nome = "";
      public override string Fala(){
        return base.Fala() + " Miau";
    }
}