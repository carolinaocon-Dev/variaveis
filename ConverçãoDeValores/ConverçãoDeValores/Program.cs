//Atividade 01 - Conversão de Valores e Variáveis em C#
//1
string nome;
int idade;
string cidade;
string area;
string hobbies;

Console.WriteLine("Digite seu nome: ");
nome = Console.ReadLine();

Console.WriteLine("Digite sua idade: ");
idade = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Digite sua cidade: ");
cidade = Console.ReadLine();

Console.WriteLine("Digite a área da programação que mais gosta: ");
area = Console.ReadLine();

Console.WriteLine("Digite seu hobbie: ");
hobbies = Console.ReadLine();


Console.WriteLine($"Olá, eu sou {nome}, tenho {idade} anos, moro em {cidade}, e tenho hobbies de: {hobbies} , {area}");


//2 
char letra;

Console.WriteLine("Digite uma letra: ");
letra = Convert.ToChar(Console.ReadLine().ToUpper());
//
Console.WriteLine($"Você digitou a letra: {letra}");

        int num1, num2, soma;

        Console.WriteLine("Digite o primeiro número inteiro:");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o segundo número inteiro:");
        num2 = Convert.ToInt32(Console.ReadLine());

        soma = num1 + num2;

        Console.WriteLine($"A soma dos dois números é: {soma}");
    