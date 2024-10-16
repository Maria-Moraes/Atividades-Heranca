using Exercicio___07;

ContaCorrente1 contaCorrente1 = new ContaCorrente1
{
    Banco = "Bradesco",
    Agencia = "002",
    Conta = "8104",
    Saldo = "R$50.000"
};

Console.WriteLine($"Seu banco é: {contaCorrente1.Banco}\nSua agência é: {contaCorrente1.Agencia}\nSua conta é de número: {contaCorrente1.Conta} \nSeu saldo é de: {contaCorrente1.Saldo}");
contaCorrente1.Sacar();
contaCorrente1.Depositar();


ContaCorrente2 contaCorrente2 = new ContaCorrente2
{
    Banco = "Itaú",
    Agencia = "099",
    Conta = "1655",
    Saldo = "R$10.000"
};

Console.WriteLine($"\nSeu banco é: {contaCorrente2.Banco}\nSua agência é: {contaCorrente2.Agencia}\nSua conta é de número: {contaCorrente2.Conta} \nSeu saldo é de: {contaCorrente2.Saldo}");
contaCorrente2.Sacar();
contaCorrente2.Depositar();

ContaCorrente3 contaCorrente3 = new ContaCorrente3
{
    Banco = "Santander",
    Agencia = "1665",
    Conta = "4463",
    Saldo = "R$8.000"
};

Console.WriteLine($"\nSeu banco é: {contaCorrente3.Banco}\nSua agência é: {contaCorrente3.Agencia}\nSua conta é de número: {contaCorrente3.Conta} \nSeu saldo é de: {contaCorrente3.Saldo}");
contaCorrente3.Sacar();
contaCorrente3.Depositar();

Console.ReadKey();