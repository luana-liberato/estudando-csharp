using System;

class Enumeradores
{
	// Por padr�o o �dice do tipo definido come�a com 0 e vai at� o (n�mero de possibilidades - 1)
	// Domingo = 0, Segunda = 1, Ter�a = 2, Quarta = 3, Quinta = 4, Sexta = 5, S�bado = 6
	enum DiaSemana { Domingo, Segunda, Ter�a, Quarta, Quinta, Sexta, S�bado };

	static void Main()
	{

		/*
         
         * Enumerador, enumeration ou enum � um recurso comum em algumas linguagens que basicamente cria um 
           tipo pr�prio com valores pr�-definidos que representam o �ndice de sua posi��o.
        
         */

		DiaSemana dia1 = DiaSemana.Segunda;
		Console.WriteLine("*** Dia 1 ***\n{0}", dia1);

		// Atribui��o pelo �ndice com aux�lio de casting
		// 3 = Quarta
		DiaSemana dia2 = (DiaSemana)3;
		Console.WriteLine("\n*** Dia 2 ***\n{0}", dia2);

		// Podemos atribuir o �ndice tamb�m atrav�s do casting
		// 0 = Domingo
		DiaSemana dia3 = DiaSemana.Domingo;
		int indiceDia = (int)dia3;
		Console.WriteLine("\n*** Dia 3 ***\n�ndice do {0}: {1}", (DiaSemana)indiceDia, indiceDia);
	}
}