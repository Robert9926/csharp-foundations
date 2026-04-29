using System;

public class Class1
{
	public Class1()
	{
        /*
		 *		List <T>
		 *	Es una colección dinamica de elementos del mismo tipo.
		 *	- almacena multiples valores.
		 *	- puede crecer y reducirse.
		 *	List tiene:
		 *		- Count = valores que tiene dentro.
		 *		- Capacity = Cantidad de valores que le caben sin crecer.
		 *	
		 *	Sitaxis:
		 *		- using System.Colletions.Generic;
		 *		- List<int> numeros = new List<int>();
		 *		
		 *	List<int> numeros = new List<int>();
		 *		- List<int>   ->  tipo de variable: Lista que solo acepta enteros.
		 *		- numeros    ->  nombre de la variable
		 *		- =   ->  asignación
		 *		- new    ->  operador de creación de objeto.
		 *					- reserva memoria en heap.
		 *					- crea el objeto.
		 *					- ejecuta el constructor.
		 *					- devuelve una referencia.
		 *		- List<int>()    -> llamada al constructor.
		 *					- La clase List<T> ya tiene constructores definidos internamente.
		 *					- se llama a un constructor que ya existe:
		 *					- List<int>()	<- Constructor vació.
		 *					- List<int>(int cap)  <- Con capacidad inicial.
		 *					- List<int>(IEnumerable<int>)  <- Con valores iniciales					
		 *	
		 *	
		 *	Crear List<T> con tamaño especificado:
		 *		- List<int> numeros = new List<int>(5);
		 *		- No se puede llenar de esta forma:  numeros[0] = 10;
		 *		- Solo de esta forma:  numeros.Add(10);
		 *	
		 *	Crear List<T> con valores desde inicio:
		 *		- List<int> numeros = new List<int> { 10, 20, 30 };
		 *	
		 *	
		 *	Agregar:
		 *		- numeros.Add(10);
		 *	Acceder:
		 *		- int x = numeros[0];
		 *	Modificar:
		 *		- numeros[1] = 50;
		 *	Eliminar:
		 *		- numeros.Remove(10);
		 *		
		 *		
		 *	- Al borrar un valor:  numeros.Remove(10);  - realiza una busqueda lineal, de inicio hasta encontrar el valor o hasta el final.
		 *		- Solo elimina la primera coincidencia si es que hay más de un valor igual
		 *		- encuentra el elemento, mueve todos los siguientes valores una posicion a la izquierda, reduce el tamaño lógico.
		 *		- Count se modifica, pero Capacity sigue igual.
		 *		
		 *	Memoria:
		 *	Variable -> variable local -> Stack
		 *	Objeto list "new List<int>()"  -> objeto -> Heap
		 *	
		 *	List<T> -> Heap
		 *	|--Array interno (T[])  <-  Elementos
		 *	|--Count
		 *	|--Capacity
		 *	
		 */
    }
}
