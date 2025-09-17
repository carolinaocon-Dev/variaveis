// 1. Soma de 3 notas e mostre a média deles.
double nota1, nota2, nota3, media;

Console.WriteLine("Digite a primeira nota: ");
nota1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a segunda nota: ");
nota2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a terceira nota: ");
nota3 = Convert.ToDouble(Console.ReadLine());

media = (nota1 + nota2 + nota3) / 3;
Console.WriteLine($"A média das notas é: {media}");

// 2. Temperatura: Celsius para Fahrenheit
double celsius, fahrenheit;

Console.WriteLine("\nDigite a temperatura em Celsius: ");
celsius = Convert.ToDouble(Console.ReadLine());

fahrenheit = (celsius * 9 / 5) + 32;
Console.WriteLine($"A temperatura em Fahrenheit é: {fahrenheit}");

// 3. Área de um quadrado
double lado, areaQuadrado;

Console.WriteLine("\nDigite o lado do quadrado: ");
lado = Convert.ToDouble(Console.ReadLine());

areaQuadrado = lado * lado;
Console.WriteLine($"A área do quadrado é: {areaQuadrado}");

// 4. Área de um triângulo
double basetri, altura, areaTriangulo;

Console.WriteLine("\nDigite a base do triângulo: ");
basetri = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a altura do triângulo: ");
altura = Convert.ToDouble(Console.ReadLine());

areaTriangulo = (basetri * altura) / 2;
Console.WriteLine($"A área do triângulo é: {areaTriangulo}");

// 5. Área do círculo (constante PI)
const double PI = 3.14159;
double raio, areaCirculo;

Console.WriteLine("\nDigite o raio do círculo: ");
raio = Convert.ToDouble(Console.ReadLine());

areaCirculo = PI * raio * raio;
Console.WriteLine($"A área do círculo é: {areaCirculo}");

// 6. Perímetro do retângulo
double largura, alturaRet, perimetro;

Console.WriteLine("\nDigite a largura do retângulo: ");
largura = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a altura do retângulo: ");
alturaRet = Convert.ToDouble(Console.ReadLine());

perimetro = 2 * (largura + alturaRet);
Console.WriteLine($"O perímetro do retângulo é: {perimetro}");
