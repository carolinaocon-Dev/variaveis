string nome;
int idade;
char sexo;
double salario;

Console.WriteLine("Digite seu nome:");
nome = Console.ReadLine();

Console.WriteLine("digite sua idade:");
idade = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Qual é o seu sexo: M ou F");
sexo = Convert.ToChar(Console.ReadLine().ToUpper());

 Console.WriteLine("Digite seu salário");
salario = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"O seu nome é {nome}, você tem {idade} anos, seu sexo é: R${salario},00");




