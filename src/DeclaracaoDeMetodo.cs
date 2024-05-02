using System;

class Metodos
{
    public static int num1;
    public static int num2;

    static void Main()
    {
        // Métodos em C# são simples. A sintaxe é: [modificador] [tipo de retorno] [nome do método]([parâmetros]).

        apresentar();
        obterDados();
        somar();
    }

    // Como estamos chamando métodos que não estão relacionados a criação de objetos precisamos do 'static'
    public static void apresentar()
    {
        Console.WriteLine("Vamos trabalhar com operações de soma e subtração!");
    }

    public static void obterDados()
    {
        Console.Write("Digite um primeiro valor inteiro: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite um primeiro valor inteiro: ");
        num2 = Convert.ToInt32(Console.ReadLine());
    }

    public static void somar()
    {
        Console.WriteLine("O resultado da soma entre {0} e {1} é: {2}", num1, num2, (num1 + num2));
    }
}
