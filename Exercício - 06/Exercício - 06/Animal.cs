namespace Exercício___06
{
    public abstract class Animal
    {
        public string Especie { get; set; }

        public abstract void EmitirSom();
    }
    public class Gato : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Miau Miau");
        }
    }
    public class Porco : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Oinc Oinc");
        }
    }
    public class Capivara  : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Snif Snif");
        }
    }
}
