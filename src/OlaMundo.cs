using System;

class OlaMundo
{
    static void Main()
    {
        Console.WriteLine("Olá mundo!");

        /*
         
         * O código que temos aqui é o primeiro print do programa com quebra de linha, ou seja, faz o print
           e "pula" uma linha.
           Esse print só é possível porque estamos utilizando um método da classe Console do namespace System.
         
         * Partindo do pressuposto que já sabemos o que é classe e método vamos somente determinar namespace:
                -> Esse recurso se refere a forma de organizar bibliotecas e programas em C#. No caso, ela vai
                   fazer referência a tipos e outros namespaces fornecendo um meio hierárquico de organizá-las.
                   
                   No exemplo do código em questão, a classe Console é um tipo do namespace System.
                   
                   Vale ressaltar que além de tipos o namespace System também tem outros namespaces com IO e
                   Collections em sua hierárquia.
                 
         * Dito isso vamos determinar o que é o using:
                -> É uma diretiva que permite o uso não qualificado dos tipos que são membros do namespace.
                   
                   Isso ajuda no sentido de reduzir a quantidade de código necessário para se escrever por cada
                   linha que você precise acessar um tipo toda vez que for o usar. Por exemplo:
                   Vamos supor que tenhamos uma classe 'Cliente' no namespace 'MeuApp.Clientes'. Toda vez que for
                   necessário usá-lá não precisamos digitar 'MeuApp.Clientes.Cliente', basta usarmos o using e
                   acessar a classe somente com 'Cliente'. No caso, seria 'using MeuApp.Clientes;'.

         */
    }
}
