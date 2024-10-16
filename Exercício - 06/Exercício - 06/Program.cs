using Exercício___06;

Gato gato1 = new Gato
{
    Especie = "Mamífero"
};

Porco porco1 = new Porco
{
    Especie = "Mamífero"
};

Capivara capivara1 = new Capivara
{
    Especie = "Mamífero"
};

Console.WriteLine($" O Gato é um {gato1.Especie}");
gato1.EmitirSom();
Console.WriteLine($" O Porco é um {porco1.Especie}");
porco1.EmitirSom();
Console.WriteLine($" A Capivara é um {capivara1.Especie}");
capivara1.EmitirSom();

Console.ReadKey();