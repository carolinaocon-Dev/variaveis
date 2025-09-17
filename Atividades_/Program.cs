using System;

class Program
{
    static void Main(string[] args)
    {
        // ------------------ EXERCÍCIO 1 ------------------
        // Entrada em evento
        Console.WriteLine("=== Entrada em Evento ===");
        Console.Write("Digite sua idade: ");
        int idade = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite seu sexo (M/F): ");
        string sexo = Console.ReadLine().ToUpper();

        Console.Write("Possui ingresso? (true/false): ");
        bool ingresso = Convert.ToBoolean(Console.ReadLine());

        if ((ingresso && idade >= 18) || (sexo == "F" && idade >= 18))
        {
            Console.WriteLine("Pode entrar!");
        }
        else
        {
            Console.WriteLine("Não pode entrar!");
        }

        Console.WriteLine();

        // ------------------ EXERCÍCIO 2 ------------------
        // Desconto no cinema
        Console.WriteLine("=== Desconto no Cinema ===");
        Console.Write("Digite sua idade: ");
        int idadeCinema = Convert.ToInt32(Console.ReadLine());

        Console.Write("É estudante? (true/false): ");
        bool estudante = Convert.ToBoolean(Console.ReadLine());

        if (idadeCinema < 12 || estudante || idadeCinema > 60)
        {
            Console.WriteLine("Paga meia entrada.");
        }
        else
        {
            Console.WriteLine("Paga inteira.");
        }

        Console.WriteLine();

        // ------------------ EXERCÍCIO 3 ------------------
        // Acesso ao jogo online
        Console.WriteLine("=== Acesso ao Jogo Online ===");
        Console.Write("Digite sua idade: ");
        int idadeJogo = Convert.ToInt32(Console.ReadLine());

        Console.Write("Possui assinatura? (true/false): ");
        bool assinatura = Convert.ToBoolean(Console.ReadLine());

        if ((assinatura && idadeJogo > 16) || (!assinatura && idadeJogo > 18))
        {
            Console.WriteLine("Pode jogar!");
        }
        else
        {
            Console.WriteLine("Acesso negado!");
        }

        Console.WriteLine();

        // ------------------ EXERCÍCIO 4 ------------------
        // Média do aluno
        Console.WriteLine("=== Média Final do Aluno ===");
        Console.Write("Digite a primeira nota: ");
        double nota1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a segunda nota: ");
        double nota2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a terceira nota: ");
        double nota3 = Convert.ToDouble(Console.ReadLine());

        double media = (nota1 + nota2 + nota3) / 3;

        if (media >= 7)
        {
            Console.WriteLine("Aluno aprovado!");
        }
        else if (media >= 5 && media < 7)
        {
            Console.WriteLine("Aluno em recuperação!");
        }
        else
        {
            Console.WriteLine("Aluno reprovado!");
        }

        Console.WriteLine("\nFim do programa.");
    }
}