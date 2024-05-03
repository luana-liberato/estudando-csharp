using System;

class EntradaSaidaNoConsole
{
    static void Main()
    {
        Console.WriteLine("Olá! Gostaria de lhe conhecer um pouco!");

        /*
          
         * Como já foi explicado no código OlaMundo, o C# trabalha com bibliotecas e tipos organizados de forma
           hierárquica. Neste sentido, o conceito de namespace vem a tona, ele representa uma hierarquia para
           bibliotecas e programas C#.
           
         * Dito isto, a classe Console do namespace System é uma classe que possui vários métodos de entrada e
           saída no console ou terminal. O WriteLine() e o ReadLine() são um dos métodos da classe Console.
           
         */

        // Declaração de variáveis do tipo simples seguem a mesma lógica de boa parte das linguagens:
        // [tipo] identificador; 
        // [tipo] identificador = valorInicial;
        string nome;
        byte idade = 0;
        float altura = 0;
 
        // Agora começamos a lidar com entrada de dados com o método ReadLine() da classe Console do namespace 
        // System. O ponto em questão é que ele retorna uma string, então, para variáveis de tipos primitivos 
        // diferentes é preciso fazer conversão como no exemplo abaixo para a variável idade e altura.
         
        Console.WriteLine();
        Console.WriteLine("Digite seu nome: ");
        nome = Console.ReadLine(); // Esse método vai ser chamado para a leitura de dados e retorna uma string

        Console.WriteLine("Digite sua idade: ");
        idade = Convert.ToByte(Console.ReadLine()); // Como o método retorna string ele precisa ser convertido

        Console.WriteLine("Digite seu peso: ");
        altura = float.Parse(Console.ReadLine()); // Outra forma de converter de string para o dado específico

        // De extra... Alguns elementos para deixar nossa saída no Console mais organizada

        Console.WriteLine();
        Console.WriteLine("Legal!\nPrazer em conhecer você, " + nome); // '\n' é quebra de linha 
         
        // Essa forma de juntar as informações de saída com variáveis é boa quando temos poucos elementos, mas 
        // temos outras alternativas com uma grande listagem de valores como agora.

        Console.WriteLine("Vou listar seus dados!");

        Console.WriteLine();
        Console.WriteLine("DADOS\nNome: {0}\nIdade: {1}\nAltura: {2}", nome, idade, altura);
        /*
           
         * Essa forma é uma maneira de listar nossos dados sem precisar fazer várias concatenações. Nesse caso
           as {} representam que naquela posição da mensagem vai estar uma variável. Os números dentro {} 
           representam a variável sendo 0 -> nome, 1 -> idade, 2 -> altura.
           
         * Esses números são determinados pela ordem que os valores foram alocados, por exemplo, se o nosso print
           fosse assim:
           Console.WriteLine("DADOS\nIdade: {0}\nAltura: {1}\nNome: {2}\n", idade, altura, nome);
         
         * Então no caso 0 -> idade, 1 -> altura, 2 -> nome
         
         */
    }
}