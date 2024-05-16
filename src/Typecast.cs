using System;

class Typecast
{
    static void Main()
    {
        /*
          
         * Typecast tamb�m conhecido como cast � o processo de converter dados ou vari�veis em tipos
           comp�tiveis. Neste sentido o C# tem a chamada convers�o impl�cita e explic�ta.
          
         */

        /*
         
         * A convers�o impl�cita � um tipo de cast que o pr�prio compilador faz de forma autom�tica quando 
           fazemos atribui��o de um tipo para outro que n�o ocasiona em perda. A exemplo o tipo int para 
           float e um tipo derivado para o tipo base.
          
         */
        int num1 = 9;
        float num2 = num1;

        Console.WriteLine("*** CONVERS�O IMPL�CITA ***\n{0} do tipo int -> {1} do tipo float", num1, num2);

        /*
         
         * A convers�o expl�cita � um tipo de cast em que for�amos a mudan�a de um tipo para outro que
           ocasiona na perda de dados. Quando fazemos esse tipo de opera��o precisamos deixar claro para
           o compilador que estamos um cas explic�to acrescentando o tipo em '( [tipo] )'.
         
         */
        double num3 = 10.5;
        int num4 = (int)num3;

        Console.WriteLine("\n*** CONVERS�O EXPL�CITA ***\n{0} do tipo double -> {1} do tipo int", num3, num4);

        // Um exemplo com o tipo ushort que recebe valores de 0 a 65,535 para byte que recebe de 0 a 255.
        ushort num5 = 65535;
        byte num6 = (byte)num5;

        Console.WriteLine("\n*** CONVERS�O EXPL�CITA DOIS ***\n{0} do tipo ushort -> {1} do tipo byte", num5, num6);
    }
}