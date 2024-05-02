using System;

class Operadores
{
    static void Main()
    {
        /*
         
         * C# assim como diversas outras linguagens de programação tem vários tipos de operadores. Nesta seção
           incluo alguns e ao longo de outras seções espero incluir os que faltaram, mas, no geral os operadores 
           são divididos entre:
                - Aritméticos
                - Comparação
                - Lógicos
                - Atribuição
                - Bitwise
                - Ternário
                - Concatenação
                - De referência e de tipo (Não tratado neste código)

         */
        
        Console.WriteLine("Vamos estudar sobre operadores! Para isso, me informe alguns valores de variáveis!");

        Console.Write("Informe um primeiro número do tipo double: ");
        double n1 = double.Parse(Console.ReadLine());
        Console.Write("Informe um segundo número do tipo double: ");
        double n2 = double.Parse(Console.ReadLine());

        Console.Write("Informe um valor do tipo booleano para variável A [True/False]: ");
        bool a = bool.Parse(Console.ReadLine());
        Console.Write("Informe um valor do tipo booleano para variável B [True/False]: ");
        bool b = bool.Parse(Console.ReadLine());

        Console.Write("Informe um primeiro valor do tipo string: ");
        string s1 = Console.ReadLine();
        Console.Write("Informe um segundo valor do tipo string: ");
        string s2 = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("=-=-=-=-=-=-= OPERADORES ARITMÉTICOS =-=-=-=-=-=-=");
        Console.WriteLine("'{0} + {1}' -> {2}", n1, n2, (n1 + n2));
        Console.WriteLine("'{0} - {1}' -> {2}", n1, n2, (n1 - n2));
        Console.WriteLine("'{0} * {1}' -> {2}", n1, n2, (n1 * n2));
        Console.WriteLine("'{0} / {1}' -> {2}", n1, n2, Math.Round((n1 / n2), 1));
        Console.WriteLine("'{0} % {1}' -> {2}", n1, n2, (n1 % n2));
        double aux = n1;
        aux++;
        Console.WriteLine("'{0}++' -> {1}", n1, aux);
        aux = n1;
        aux--;
        Console.WriteLine("'{0}--' -> {1}", n1, aux);

        Console.WriteLine();
        Console.WriteLine("=-=-=-=-=-= OPERADORES DE COMPARAÇÃO =-=-=-=-=-=");
        Console.WriteLine("'{0} == {1}' -> {2}", n1, n2, (n1 == n2));
        Console.WriteLine("'{0} != {1}' -> {2}", n1, n2, (n1 != n2));
        Console.WriteLine("'{0} >= {1}' -> {2}", n1, n2, (n1 >= n2));
        Console.WriteLine("'{0} <= {1}' -> {2}", n1, n2, (n1 <= n2));
        Console.WriteLine("'{0} > {1}' -> {2}", n1, n2, (n1 > n2));
        Console.WriteLine("'{0} < {1}' -> {2}", n1, n2, (n1 < n2));

        Console.WriteLine();
        Console.WriteLine("=-=-=-=-=-=-=-= OPERADORES LÓGICOS =-=-=-=-=-=-=-=");
        Console.WriteLine("'A:{0} &&(AND) B:{1}' -> {2}", a, b, (a && b));
        Console.WriteLine("'A:{0} ||(OR) B:{1}' -> {2}", a, b, (a || b));
        Console.WriteLine("'!A:!{0} (! = NOT) -> {1}", a, (!a));

        /*
         
         * A atribuição que fazemos quando usamos o '=' é claramente uma operação de atribuição, mas temos outros
           tipos conhecidos como atribuição composta.
         
         */

        Console.WriteLine();
        Console.WriteLine("=-=-=-=-=-= OPERADORES DE ATRIBUIÇÃO =-=-=-=-=-=");
        aux = n1;
        aux += 2;
        Console.WriteLine("'{0} += 2' -> {1}", n1, aux);
        aux = n1;
        aux -= 2;
        Console.WriteLine("'{0} -= 2' -> {1}", n1, aux);
        aux = n1;
        aux *= 2;
        Console.WriteLine("'{0} *= 2' -> {1}", n1, aux);
        aux = n1;
        aux /= 2;
        Console.WriteLine("'{0} /= 2' -> {1}", n1, Math.Round(aux, 1));

        Console.WriteLine();
        Console.WriteLine("=-=-=-=-=-=-=-= OPERADORES BITWISE =-=-=-=-=-=-=-=");

        /*
         
         * Nos operadores ternários temos a seguinte sintaxe: (condição) ? valor_se_verdadeiro : valor_se_falso 
         
         */

        Console.WriteLine();
        Console.WriteLine("=-=-=-=-=-=-=-= OPERADOR TERNÁRIO =-=-=-=-=-=-=-=");
        Console.WriteLine("'({0} > {1}) ? \"É maior\" : \"É menor\"' -> {2}", n1, n2, ((n1 > n2) ? "É maior" : "É menor"));

        Console.WriteLine();
        Console.WriteLine("=-=-=-=-=-=-= CONCATENAÇÃO DE STRINGS =-=-=-=-=-=-=");
        string auxS = s1 + " " + s2;
        Console.WriteLine("'{0} + \" \" + {1}' -> {2}", s1, s2, auxS);
    }
}
