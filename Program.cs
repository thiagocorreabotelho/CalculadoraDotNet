using System;

namespace CalculadoraDotNetCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            int operacao = 0;

            Console.Clear();
            Console.WriteLine("------ SEJA BEM VINDA A NOSSA CALCULADORA, DIGITE ABAIXO A OPÇÃO PARA CALCULO!------");

            Console.WriteLine();

            Console.WriteLine("01 - SOMA");
            Console.WriteLine("02 - SUBTRAÇÃO");
            Console.WriteLine("03 - MULTIPLICAÇÃO");
            Console.WriteLine("04 - DIVISÃO");

            Console.WriteLine();
            operacao = int.Parse(Console.ReadLine());

            Calculo(operacao);
            Console.ReadKey();
            
        }

        static void Calculo(int operacao)
        {
            float primeiroValor = 0;
            float segundoValor = 0;

            Console.WriteLine("LEMBRANDO QUE NÃO PODEMOS DEIXAR DE DIGITAR NOSSOS VALORES!");
            Console.WriteLine("");

            Console.WriteLine("AGORA NOS INFORME O PRIMEIRO VALOR: ");
            primeiroValor = float.Parse(Console.ReadLine());

            Console.WriteLine("AGORA NOS INFORME O SEGUNDO VALOR: ");
            segundoValor = float.Parse(Console.ReadLine());

            if (operacao == 1)
                Soma(primeiroValor, segundoValor);

            if (operacao == 2)
                Subtracao(primeiroValor, segundoValor);

            if (operacao == 3)
                Multiplicacao(primeiroValor, segundoValor);

            if (operacao == 4)
                Divisao(primeiroValor, segundoValor);


        }

        static void Soma(float primeiroValor, float segundoValor)
        {
            Console.WriteLine("");
            Console.WriteLine($"O RESULTADO DA SOMA DO {primeiroValor} + {segundoValor} É DE {primeiroValor + segundoValor}");
            VoltarMenu();
            
        }

        static void Subtracao(float primeiroValor, float segundoValor)
        {
            Console.WriteLine("");
            Console.WriteLine($"O RESULTADO DA SUBTRAÇÃO DO {primeiroValor} - {segundoValor} É DE {primeiroValor - segundoValor}");
            VoltarMenu();

        }

        static void Multiplicacao(float primeiroValor, float segundoValor)
        {
            Console.WriteLine("");
            Console.WriteLine($"O RESULTADO DA MULTIPLICAÇÃO DO {primeiroValor} x {segundoValor} É DE {primeiroValor * segundoValor}");
            VoltarMenu();

        }

        static void Divisao(float primeiroValor, float segundoValor)
        {
            Console.WriteLine("");
            Console.WriteLine($"O RESULTADO DA DIVISÃO DO {primeiroValor} / {segundoValor} É DE {primeiroValor / segundoValor}");
            VoltarMenu();

        }

        static void VoltarMenu()
        {
            int voltarMenu = 0;
            

            Console.WriteLine("DESEJA VOLTAR AO MENU? ");
            Console.WriteLine("DIGITE 1 PARA VOLTAR OU 0 PARA ENCERRAR! ");
            voltarMenu = int.Parse(Console.ReadLine());

            if (voltarMenu == 1)
                Menu();

            if (voltarMenu == 0)
                Environment.Exit(0);

            if (voltarMenu > 1)
            {
                Console.WriteLine($"COMANDO NÃO DETECTADO, POR ISSO ESTAMOS ENCERRANDO A APLICAÇÃO");
                Environment.Exit(0);
            }

        }
    }
}
