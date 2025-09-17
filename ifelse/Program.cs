int idade;
Console.Write("Digite sua idade: ");
int.TryParse(Console.ReadLine(), out idade);

char sexo;
char.TryParse(Console.ReadLine().ToUpper(), out sexo);

Console.WriteLine("\n Verificação com if-else:");

// Exemplo 1: Verificação de maioridade 
if (idade >= 18 || sexo == 'F')
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Olá, você pode entrar na festa!");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Desculpe, você não pode entrar na festa.");
}

bool temIngresso = true;
// Exemplo 2
if (temIngresso && idade >= 18 || sexo == 'F' && idade >= 18)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Ola,você pode entrar na festa!");
}else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Desculpe, você não pode entrar na festa.");
}

Console
