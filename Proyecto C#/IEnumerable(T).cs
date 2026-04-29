using System;

public class Class1
{
	public Class1()
	{
        /*
		 *		IEnumerable<T>
		 *	- Contrato que permite recorrer una colección
		 *	- No permite o hace: acceso por indice, modificar directamente.
		 *	- solo recorre, permite recorrer elementos.
		 *	
		 *	Contrato:  Define qué se puede hacer, No como se hace.
		 *	
		 *	Al ser algo IEnumerable, se puede iterar (Recorrerlo elemento por elemento).
		 *	
		 *	Sintaxis:
		 *	- IEnumerable<int> numeros = new List<int> {1, 2, 3};
		 *		- Es una Declaración e Inicialización al mismo tiempo.
		 *		- Declaración por Separado:
		 *			- IEnumerable<int> numeros;
		 *		- Inicialización por Separado:
		 *			- numeros = new List<int> {1, 2, 3};
		 *		- "numeros"  ->  Variable (Vive en Stack y su valor es una referencia de memoria)
		 *		- "List<int>"  ->  Es el objeto (Vive en Heap)
		 *	
		 *	Todos los siguientes son IEnumerables:
		 *	- List<T>
		 *	- Stack<T>
		 *	- Queue<T>
		 *	- Array
		 *	
		 *		- Se puede usar Foreach en estas sin necesidad de declararlas como "IEnumerable"
		 *		porque ya implementan internamente IEnumerable.
		 *	+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
		 *	Ejemplo de como se puede usar:
		 *	
		 *	void Procesar(IEnumerable<int> datos)
			{
				foreach (var d in datos)
				{
					Console.WriteLine(d);
				}
			}
				- Un metodo que se le puede pasar cualquier Lista o Array que sea de tipo "int", 
				  ya que es el parametro que tiene.
				- Funciona para hacer codigo más General y flexible.


			void Procesar(List<int> datos)
				- Un método que solo se le puede listas
		++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
		 *	Ejemplo de usar Foreach en una lista:
		 *	
		 *		var lista = new List<int> { 1, 2, 3 };
				foreach (var x in lista)
				{
					Console.WriteLine(x);
				}
		++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++		
		 *	IEnumerable<T>	<-  Define que puedes Iterar
		 *		- Trabaja con:  
		 *			- IEnumerator<T>   <-  Define cómo Iterar.
		 *			- Foreach   <-  Usa ambos sin importar la estructura.
		 *			
		 *	IEnumerable → contrato (puedo iterar)
			IEnumerator → mecanismo (cómo iterar)
			foreach → usa eso automáticamente
				1. GetEnumerator()
				2. MoveNext()
				3. Current
				4. repetir
		 *
		 *
		 */
    }
}
