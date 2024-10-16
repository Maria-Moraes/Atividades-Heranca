namespace Exercicio___07
{
    public abstract class ContaGenerica
    {
        public string Banco { get; set; }
        public string Agencia { get; set; }
        public string Conta { get; set; }
        public string Saldo { get; set; }

        public abstract void Depositar();
        public abstract void Sacar();
    }
    public class ContaCorrente1 : ContaGenerica
    {
        public override void Depositar()
        {
            Console.WriteLine("Você depositou 81000 reais.");
        }
        public override void Sacar()
        {
            Console.WriteLine("Você sacou 4000 reais.");
        }
    }
    public class ContaCorrente2 : ContaGenerica
    {
        public override void Depositar()
        {
            Console.WriteLine("Você depositou 55000 reais.");
        }
        public override void Sacar()
        {
            Console.WriteLine("Você sacou 16000 reais.");
        }
    }
    public class ContaCorrente3 : ContaGenerica
    {
        public override void Depositar()
        {
            Console.WriteLine("Você depositou 63000 reais.");
        }
        public override void Sacar()
        {
            Console.WriteLine("Você sacou 44000 reais.");
        }
    }

}
