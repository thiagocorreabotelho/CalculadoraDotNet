
Console.Clear();

float primeiroValor;
float segundoValor;
int operacao = 0;
string operacaoEscrita = string.Empty;

Console.WriteLine("------BEM VINDO A NOSSA CALCULADORA!------");

Console.WriteLine();

Console.WriteLine("QUAL OPERAÇÃO VOCÊ DESEJA EFETUAR? INFORME ABAIXO POR FAVOR.");
Console.WriteLine("01 - SOMA");
Console.WriteLine("02 - SUBTRAÇÃO");
Console.WriteLine("03 - MULTIPLICAÇÃO");
Console.WriteLine("04 - DIVIÃO");
operacao = int.Parse(Console.ReadLine());

if (operacao == 1)
    operacaoEscrita = "SOMA";

if (operacao == 2)
    operacaoEscrita = "SUBTRAÇÃO";

if (operacao == 3)
    operacaoEscrita = "MULTIPLICAÇÃO";

if (operacao == 4)
    operacaoEscrita = "DIVIÃO";

Console.WriteLine();
Console.WriteLine($"Certo você escolheu a operação: {operacaoEscrita}, informe agora abaixo os dois valores para o calculo.");

Console.WriteLine();
Console.WriteLine("Informe o seu primeiro valor: ");
primeiroValor = float.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Informe o seu segundo valor: ");
segundoValor = float.Parse(Console.ReadLine());

if (operacao == 1)
{
    Console.WriteLine($"A soma do {primeiroValor} + {segundoValor} é: {primeiroValor + segundoValor}");
}
else if (operacao == 2)
{
    Console.WriteLine($"A subtração do {primeiroValor} - {segundoValor} é: {primeiroValor - segundoValor}");
}
else if (operacao == 3)
{
    Console.WriteLine($"A multiplicação do {primeiroValor} X {segundoValor} é: {primeiroValor * segundoValor}");
}
else if (operacao == 4)
{
    Console.WriteLine($"A divisão do {primeiroValor} / {segundoValor} é: {primeiroValor / segundoValor}");
}

Console.ReadKey();