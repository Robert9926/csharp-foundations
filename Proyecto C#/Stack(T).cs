using System;

public class Class1
{
	public Class1()
	{
        /*	Necesario Comprender:
         *	
         *		Índice:
         *		- Posición lógica dentro de una estructura 
         *		- Ejemplo:  posición númeo 3 dentro de un array.
         *		
         *		Puntero
         *		- Dirección Fisica real en memoria
         *		- Ejemplo: Dirección exacta en memoria donde está un dato.
         *	+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
         *	
		 *		stack<T>
		 *	LIFO  ->  Last In, First Out.
		 *		- Ultimo en Entrar, Primero en Salir.
		 *	Es un Array Dinamico (similar a List<T>)
		 *	
		 *	Operaciones:
		 *		- Push <- Agrega arriba
		 *		- Pop	<- Elimina y devuelve arriba
		 *		- Peek	<- Solo consulta arriba
		 *		
		 *	Declaración e Inicialización
		 *		- Stack<int> stack = new Stack<int>();
		 *	
		 *	Insertar (Push)
		 *	- stack.Push(1);
		 *	- stack.Push(2);
		 *		
		 *		Estado Interno:
		 *			- 2
		 *			- 1
		 *	
		 *	Sacar (Pop)		<-  Elimina el estado (top) 
		 *	- var x = stack.Pop();		<-  "var" el Compilador interpreta aumaticamente que tipo de variable	
		 *									se va a declarar, en este caso el tipo de dato que contenga: "stack.Pop"
		 *		Valor de x:
		 *			- x = 2
		 *		
		 *		Estado Interno despues del Pop:
		 *			- 1
		 *			
		 *	Ver sin eliminar (Peek)		<-  Devuelve el elemente superior, No lo elimina.
		 *	- var x = stack.Peek();
		 *	
		 *	Contar 
		 *	- stack.Count
		 *	
		 *	++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
		 *	
		 *	Si "Stack" esta vacio, y se realiza un "Pop"
		 *		- Se Genera una Excepción
		 *	Forma Segura:
		 *		if (stack.count > 0)
		 *		{ 
		 *			stack.Pop();
		 *		}
		 *	+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
		 *	
		 *	Push:
		 *		- coloca elemento en siguiente posición.
		 *		- incrementa índice 
		 *	
		 *	Pop:
		 *		- Devuelve elemento en top
		 *		- reduce índice
		 *		
		 *	Top
		 *		- Indica posición dentro del array, no dirección de memoria.
		 *		- Apunta a donde se insertara el siguiente valor
		 *
		 *+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
		 *
		 *		Memoria
		 *	var stack = new Stack<int>();
		 *	- Variable "stack"  ->  Se almacena en memoria stack, es una referencia de memoria al objeto que esta en Heap.
		 *	- Objeto Stack  ->  Se almacena en Heap
		 *	- Array interno  ->  Se alamacena en Heap
		 *	
		 *	
		 */
    }
}
