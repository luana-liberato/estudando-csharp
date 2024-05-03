using System;

class Constante
{
    // Constante sintaxe: [modificador] const [tipo] [nome da constante] = [valor da constante];
    const double pi = 3.14159;

    static void Main()
    {
        // Constante é uma variável que seu valor não pode ser alterado em tempo de execução. Nesta seção será
        // a variável pi.

        Console.Write("Vamos calcular a área de um círculo!\nInforme o raio: ");
        double raio = Convert.ToDouble(Console.ReadLine());

        double area = calcularArea(raio);
        Console.WriteLine("A área do círculo é igual a: {0}", Math.Round(area, 2));
    }


    static double calcularArea(double r)
    {
        return Math.Pow(r, 2) * pi;
    }
}