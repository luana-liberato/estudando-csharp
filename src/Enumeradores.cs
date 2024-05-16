using System;

class Enumeradores
{
	// Por padrão o ídice do tipo definido começa com 0 e vai até o (número de possibilidades - 1)
	// Domingo = 0, Segunda = 1, Terça = 2, Quarta = 3, Quinta = 4, Sexta = 5, Sábado = 6
	enum DiaSemana { Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado };

	static void Main()
	{

		/*
         
         * Enumerador, enumeration ou enum é um recurso comum em algumas linguagens que basicamente cria um 
           tipo próprio com valores pré-definidos que representam o índice de sua posição.
        
         */

		DiaSemana dia1 = DiaSemana.Segunda;
		Console.WriteLine("*** Dia 1 ***\n{0}", dia1);

		// Atribuição pelo índice com auxílio de casting
		// 3 = Quarta
		DiaSemana dia2 = (DiaSemana)3;
		Console.WriteLine("\n*** Dia 2 ***\n{0}", dia2);

		// Podemos atribuir o índice também através do casting
		// 0 = Domingo
		DiaSemana dia3 = DiaSemana.Domingo;
		int indiceDia = (int)dia3;
		Console.WriteLine("\n*** Dia 3 ***\nÍndice do {0}: {1}", (DiaSemana)indiceDia, indiceDia);
	}
}