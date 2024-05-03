using System;

class Constante
{
    // Constante sintaxe: [modificador] const [tipo] [nome da constante] = [valor da constante];
    const double pi = 3.14159;

    static void Main()
    {
        // Constante � uma vari�vel que seu valor n�o pode ser alterado em tempo de execu��o. Nesta se��o ser�
        // a vari�vel pi.

        Console.Write("Vamos calcular a �rea de um c�rculo!\nInforme o raio: ");
        double raio = Convert.ToDouble(Console.ReadLine());

        double area = calcularArea(raio);
        Console.WriteLine("A �rea do c�rculo � igual a: {0}", Math.Round(area, 2));
    }


    static double calcularArea(double r)
    {
        return Math.Pow(r, 2) * pi;
    }
}