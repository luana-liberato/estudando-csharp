using System;

public class DeclaracaoDeMetodo {
    public static void Main() {

        /***/

        apresentar();
        int soma = somar();
        formatarResultado(soma);
    }

    public static void apresentar() {
        Console.WriteLine("Seja bem-vindo ao programa somar!");
    }

    public static int somar() {
        Console.Write("Informe o primeiro valor inteiro: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Informe o primeiro valor inteiro: ");
        int num2 = int.Parse(Console.ReadLine());

        return num1 + num2;
    }

    public static void formatarResultado(int resultado) {
        Console.WriteLine("Resultado da nossa soma: " + resultado);
    }
}