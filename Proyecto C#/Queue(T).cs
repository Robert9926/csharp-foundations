using System;

public class Class1
{
	public Class1()
	{
        /*
		 *		Queue<T>
		 *	FIFO  ->  First In, Firts Out.
		 *	- El primero que entra, el primero que sale.
		 *	
		 *	Declaración e Inicialización
		 *		- var queue = new Queue<int>();
		 *		
		 *	Insertar (Enqueue)
		 *		- queue.Enqueue(1);
		 *		- queue.Enqueue(2);
		 *		- queue.Enqueue(3);
		 *		Estado:
		 *			En Salir  -> [1] [2] [3]
		 *		
		 *	Sacar (Dequeue)
		 *		- var x = queue.Dequeue();
		 *		Resultado:
		 *		x = 1.
		 *		Estado:
		 *			En Salir  -> [2] [3]
		 *			
		 *	Ver sin Eliminar (Peek)
		 *		- var x = queue.Peek();
		 *		- devuelve el primero
		 *		- No lo Elimina
		 *		
		 *	Cantidad
		 *		- queue.Count
		 *	+++++++++++++++++++++++++++++++++++++++++++++++++++++++++
		 *	
		 *	Si el Queue esta vacio:
		 *	- queue.Dequeue();   <-  Genera Excepción
		 *	
		 *	Forma Segura:
		 *	if (queue.Count > 0)
		 *	{ 
		 *		queue.Dequeue();
		 *	}
		 *	+++++++++++++++++++++++++++++++++++++++++++++++++++++++++
		 *	
		 *		Memoria
		 *	var queue = new Queue<int>();
		 *	- variable "queue" ->  vive en stack, su valor es una referencia al objeto en Heap.
		 *	- Objeto "new Queue"  ->  vive en Heap
		 *	- Array "Queue<int>"  ->  vive en heap
		 *	
		 *		
		 */
    }
}
