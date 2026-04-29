using System;

public class Class1
{
	public Class1()
	{
        /*
		 *		Array (T[])
		 *	Es un bloque contiguo de memoria que almacena elementos del mismo tipo.
		 *	Es un Reference type, vive en heap, lo maneja el Garballe Collector.
		 *	- El array esta en Memoria Heap, Los elementos del array (int[]) también están en Heap.
		 *	- Cada valor del array están separados dentro de un bloque continuo de memoria, no están dispersos por la memoria.
		 *	- Un array no son muchas referencias, Es una sola referencia a un bloque continuo de memoria.
		 *	
		 *	int[]  var = new int[3];
		 *		arr(variable) -> Referencia
		 *		El array (int[]) -> Objeto en Heap
		 *		
		 *		- arr es una referencia que apunta al inicio de un bloque contiguo en heap, 
		 *		y el runtime calcula las posiciones internas de forma segura
		 *		
		 *		Memoria:
		 *		Stack:
		 *			- variable "var"  -> referencia
		 *		Heap:
		 *			- objeto array:
		 *				- longitud: 3
		 *				- elementos: [0,0,0]
		 *				
		 *	La variable "var" tiene como valor la referencia de memoria del objeto.
		 *	+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
		 *	El tamaño del array es inmutable.
		 *	No se puede hacer después: 
		 *		var[3] = 5;  <-  Esto es un error.
		 *	Para crecer el array, se debe crear uno nuevo de mayor tamaño, copiar los datos a este y descartar el anterior.
		 *	
		 *	int[] var = new int[3];
		 *		- Guarda valores directamente (Reference Type): [1][2][3]
		 *		
		 *	Persona[] var = new Persona[3];
		 *		- Guarda Referencias de memoria.
		 *	+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
		 *	var a = new int[] {1,2,3};
		 *	var b = a;
		 *		- No copia el array, solo copia la referencia.
		 *	Osea:
		 *	a ──┐
				├──▶ [1][2][3]
			b ──┘
		 *		
		 *		Para copiar un array de forma correcta:
		 *	var b = new int[a.Length];
			Array.Copy(a, b, a.Length);
		 *	
		 */
    }
}
