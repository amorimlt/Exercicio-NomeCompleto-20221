string nome, sobrenome, sobrenomeMaisculo;

Console.Write("Digite seu primeiro nome: ");
nome = Console.ReadLine()!;

Console.Write("Digite seu segundo nome: ");
sobrenome = Console.ReadLine()!;

sobrenomeMaisculo = sobrenome.ToUpper();

Console.WriteLine($"\nNome Completo: {nome} {sobrenome}");

Console.WriteLine($"Nome de Catalogo: {sobrenomeMaisculo}, {nome}");