using System;

class Typecast
{
    static void Main()
    {
        /*
          
         * Typecast também conhecido como cast é o processo de converter dados ou variáveis em tipos
           compátiveis. Neste sentido o C# tem a chamada conversão implícita e explicíta.
          
         */

        /*
         
         * A conversão implícita é um tipo de cast que o próprio compilador faz de forma automática quando 
           fazemos atribuição de um tipo para outro que não ocasiona em perda. A exemplo o tipo int para 
           float e um tipo derivado para o tipo base.
          
         */
        int num1 = 9;
        float num2 = num1;

        Console.WriteLine("*** CONVERSÃO IMPLÍCITA ***\n{0} do tipo int -> {1} do tipo float", num1, num2);

        /*
         
         * A conversão explícita é um tipo de cast em que forçamos a mudança de um tipo para outro que
           ocasiona na perda de dados. Quando fazemos esse tipo de operação precisamos deixar claro para
           o compilador que estamos um cas explicíto acrescentando o tipo em '( [tipo] )'.
         
         */
        double num3 = 10.5;
        int num4 = (int)num3;

        Console.WriteLine("\n*** CONVERSÃO EXPLÍCITA ***\n{0} do tipo double -> {1} do tipo int", num3, num4);

        // Um exemplo com o tipo ushort que recebe valores de 0 a 65,535 para byte que recebe de 0 a 255.
        ushort num5 = 65535;
        byte num6 = (byte)num5;

        Console.WriteLine("\n*** CONVERSÃO EXPLÍCITA DOIS ***\n{0} do tipo ushort -> {1} do tipo byte", num5, num6);
    }
}