using System;

public class Class1
{
	public Class1()
	{
        /*
		 *		IList<T>
		 *	- Contrato para colecciones ordenadas con acceso por índice y modificación.
		 *	- Se usa cuando se necesita acceder o modificar por posición.
		 *	- Añade control por posición sobre los elementos
		 *	
		 *	Al ser algo de tipo List<T>, se puede:
		 *	- recorrer (foreach)
		 *	- agregar/quitar
		 *	- acceder por indice
		 *	- modificar por posición
		 *	- mantener orden
		 *	
		 *	Se puede aplicar a:
		 *		- List<T>
		 *		- T[]  Array
		 *	No se puede aplicar a:
		 *		- Stack<T>
		 *		- Queue<T>
		 *		- Dictionary<They, TValue>
		 *		- HashSet<T>
		 *	
		 *	Elementos:
		 *	
		 *	variable[0]  <- acceso por posición
		 *	
		 *	Métodos:
		 *	- IndexOf(T item)  <-  Posición de un elemento
		 *	- Insert(int i, T x)  <- Insertar en posición
		 *	- RemoveAt(int i)  <-  eliminar en posición
		 *	+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
		 *	Ejemplo:
		 *	
		 *	IList<int> datos = new List<int>();

			datos.Add(10);
			datos.Add(20);
			datos.Add(30);		  // Agregar	
			datos[1] = 99;        // modificar
			datos.Insert(1, 50);  // insertar
			datos.RemoveAt(0);    // eliminar
		 */
    }
}
