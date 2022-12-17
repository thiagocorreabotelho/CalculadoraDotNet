# Calculadora em ASP.NET CORE 7 CONSOLE

> **Requisito**: Preciso que seja desenvolvida uma calculadora no console com as seguintes regras: 👇🏻

### Regras:
- Preciso exibir para o usuário um menu contendo as 4 operações básica de matemática _soma, subtração, multiplicação e divisão_.
- Após escolher a operação, o usuário deverá informar 2 valores de sua preferência para o cálculo.
- Agora a aplicação deverá retornar o valor para o usuário e perguntar se ele quer voltar para o menu principal ou sair do mesmo. A regra para essa opção é 1 para voltar o menu e 0 para sair. Caso seja maior que 1 devemos retornar uma mensagem para o usuário dizendo que vamos encerrar o mesmo.

-------------------------------
Aplicação desenvolvida.

1- Primeira coisa que devemos fazer é criar uma aplicação do tipo console .NET 7 conforme a imagem abaixo 👇🏻

![image](https://user-images.githubusercontent.com/99252640/208267459-f1969a80-2c2b-4f74-96af-2098965c8b29.png)

![image](https://user-images.githubusercontent.com/99252640/208267479-525a66b3-83d1-4421-a0c8-c6e5d5548ff1.png)

![image](https://user-images.githubusercontent.com/99252640/208267495-ea73c12e-e8c7-4b2d-9ebb-5ec65c5803f9.png)

2- Após ter criado, teremos a seguinte estrutura. 👇🏻

![image](https://user-images.githubusercontent.com/99252640/208267561-4c91fb0f-b474-4199-a800-d68ecb679288.png)

2- Agora devemos criar um método chamado _Menu_, nele vamos exibir para os nossos usuários a descrição de todo menu para o mesmo selecionar.

```csharp
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
```

> Observação: repare que em nossa penultima linha, temos uma chamada para um método chamado **Calculo** passando a operação que o nosso usuário escolheu.

3- Agora vamos criar nosso método **Calculo** a ideia desse método é receber via assinatura a operação que o usuário escolheu e pedir para o mesmo nos informar 2 valores de sua preferência para cálculo.

```csharp
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
```

> Observação: Repare bem que dependendo da operação que nosso usuário escolheu ele vai cair em nossa condição para efetuar o cálculo e retornar a resposta.
Lembrando também conforme abaixo é que todas as operações abaixo além de receber os devidos valores por assinatura vamos criar uma lógica simples para o usuário voltar ao menu ou simplesmente sair da aplicação.

4- Métodos de operações

```csharp
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
```

> Observação: Agora podemos reparar que em cada operação acima, temos um método chamado VoltarMenu() a ideia é fazer com que, ou usuário volte para o menu ou saia da aplicação conforme vemos abaixo.

5- Criando método para voltar ao menu principal.

```csharp
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
```

6- Agora que temos a nossa estrutura criada basta apenas chamar nosso método Menu() no método principal conforme abaixo:

![image](https://user-images.githubusercontent.com/99252640/208268010-356df514-18e4-4d45-a893-df8422d072e8.png)
