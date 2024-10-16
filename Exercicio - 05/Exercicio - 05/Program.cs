using Exercicio___05;

//Instancionando a classe Funcionario
Funcionario func1 = new Funcionario { Nome = "Kimi", Idade = 18 };
Funcionario func2 = new Funcionario { Nome = "Kimi", Idade = 18 };

Funcionario func3 = new Funcionario { Nome = "Lando", Idade = 24 };
Funcionario func4 = new Funcionario { Nome = "Lando", Idade = 24 };

Funcionario func5 = new Funcionario { Nome = "Lewis", Idade = 39 };
Funcionario func6 = new Funcionario { Nome = "Lewis", Idade = 39 };


//Chamando o método envelhecer
func1.Envelhecer(10); //Somar a idade que você passou para a variável func1 mais 10
func2.Rejuvenescer(10);

func3.Envelhecer(10);
func4.Rejuvenescer(10);


func5.Envelhecer(10);
func6.Rejuvenescer(10);



//Exibindo as informações dos funcionários
Console.WriteLine($"Nome: {func1.Nome}, Idade: {func1.Idade}");
Console.WriteLine($"Nome: {func2.Nome}, Idade: {func2.Idade}");

Console.WriteLine($"Nome: {func3.Nome}, Idade: {func3.Idade}");
Console.WriteLine($"Nome: {func4.Nome}, Idade: {func4.Idade}");

Console.WriteLine($"Nome: {func5.Nome}, Idade: {func5.Idade}");
Console.WriteLine($"Nome: {func6.Nome}, Idade: {func6.Idade}");



//Encerra o programa
Console.WriteLine("Pressione qualquer tecla para sair");
Console.ReadKey();