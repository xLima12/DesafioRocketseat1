using System.Globalization;

Console.WriteLine("########################################");
Console.WriteLine("Desafio prático - Fundamentos de C-Sharp");
Console.WriteLine("########################################");

Console.WriteLine("Exercício 1");
Console.Write("\nInforme o seu nome: ");
var nome = Console.ReadLine();
Console.WriteLine($"\nOlá, {nome}! Seja muito bem-vindo!");

Console.WriteLine();
Console.WriteLine("Exercício 2");
Console.Write("\nInforme o seu nome: ");
var nome2 = Console.ReadLine();
Console.Write("Informe o seu sobrenome: ");
var sobrenome = Console.ReadLine();
Console.WriteLine($"\nObrigado pelas informações, {nome} {sobrenome}.");

Console.WriteLine();
Console.WriteLine("Exercício 3");
double numero1 = 5.0;
double numero2 = 10.0;
Console.WriteLine($"Números escolhidos {numero1} e {numero2}");

void Soma(double numero1, double numero2)
{
    var resultado = numero1 + numero2;
    Console.WriteLine($"Adição {resultado}");
}
Soma(numero1: numero1, numero2: numero2);

void Subtrair(double numero1, double numero2)
{
    var resultado = numero1 - numero2;
    Console.WriteLine($"Subtração {resultado}");
}
Subtrair(numero1: numero1, numero2: numero2);

void Dividir(double numero1, double numero2)
{
    if (numero1 is 0 || numero2 is 0)
    {
        Console.WriteLine("Não existe divisão por 0.");
    }
    var resultado = numero1 / numero2;
    Console.WriteLine($"Divisão {resultado}");
}
Dividir(numero1: numero1, numero2: numero2);

void Multiplicar(double numero1, double numero2)
{
    var resultado = numero1 * numero2;
    Console.WriteLine($"Multiplicação {resultado}");
}
Multiplicar(numero1: numero1, numero2: numero2);

void Media(double numero1, double numero2)
{
    var resultado = (numero1 + numero2) / 2;
    Console.WriteLine($"Média {resultado}");
}
Media(numero1: numero1, numero2: numero2);

Console.WriteLine();
Console.WriteLine("Exercício 4");
Console.WriteLine("\nDigite uma ou mais palavras:");
var palavrasDigitada = Console.ReadLine();
var quantidadeCaracteres = palavrasDigitada.Length;
Console.WriteLine($"Você digitou um total de {quantidadeCaracteres} caracteres.");

Console.WriteLine();
Console.WriteLine("Exercício 5");
Console.Write("Informe a placa do veículo: ");
var placa = Console.ReadLine();

int letras = 0;
int numeros = 0;

if (placa?.Length is 7)
{
    for (int i = 0; i < placa.Length; i++)
    {
        var validaPlaca = Char.IsLetter(placa[i]) ? letras++ : numeros++;
    }

    if (letras is 3 && numeros is 4)
    {
        Console.WriteLine("Verdadeiro");
    }
    else
    {
        Console.WriteLine("Falso");
    }
}

Console.WriteLine();
Console.WriteLine("Exercício 6");
Console.WriteLine("Digite 1 para exibir a data atual");
var opcaoDigitada = Console.ReadLine();
int opcaoDigitadaNumerico = int.Parse(opcaoDigitada);
Console.WriteLine();
switch (opcaoDigitadaNumerico)
{
    case 1:
        ExibirData();
        break;
    default:
        Console.WriteLine("Opção inválida");
        break;
}

void ExibirData()
{
    DateTime dataCompleta = DateTime.Now;
    Console.WriteLine(dataCompleta.ToString("F", CultureInfo.CreateSpecificCulture("pt-BR")));
    DateTime dataAbreviada = DateTime.Now;
    Console.WriteLine(dataAbreviada.ToString("d", CultureInfo.CreateSpecificCulture("pt-BR")));
    DateTime dataVinteQuatroHoras = DateTime.Now;
    Console.WriteLine(dataVinteQuatroHoras.ToString("t", CultureInfo.CreateSpecificCulture("pt-BR")));
    DateTime dataEMesPorExtenso = DateTime.Now;
    Console.WriteLine(dataEMesPorExtenso.ToString("m", CultureInfo.CreateSpecificCulture("pt-BR")));
}