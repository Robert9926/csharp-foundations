using System;

public class Class1
{
	public Class1()
	{
		/*
		 *		Clase
		 *	Es una definición de un tipo de dato complejo.
		 *	Define que datos tendra y comó se comportará un objeto.
		 *	- Sirve para agrupar datos relacionados bajo una misma identidad en memoria.
		 *		Clase = Definición de estructura (datos, variables) + comportamiento (Métodos = acciones).
		 *		Objeto = Instancia real en memoria.
		 *	- La Clase define los datos que tendrá el objeto y las operaciones que pueden actuar sobre esos datos.
		 *		Metodos:
		 *		- Están atados a un objeto, usan su estado, requieren una instancia.
		 */
			Class Person
			{
				public string Name;
				public int Age;
			}
		/*	Define:  
		 *		- Un tipo llamado Person
		 *		- 2 campos: Name y Age.
		 *		
		 *	Una Clase No ocupa memoria, No es un objeto.
		 *	+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
		 *		New
		 *	1- Se reserva memoria en Heap.
		 *	2- Se crea el objeto.
		 *	3- Se inicializa valores por defecto.
		 *	4- Se devuelve una referencia
		 */
			Person p = new Person();
/*	      - "p" es una variable que guarda una referencia al objeto.
 *+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
 *		Objeto
 *	 Es una instancia de una clase en memoria (Heap)
 *	 
 *	 De la clase "Person" 
 *		- El objeto seria:  
 *			[Name] [Age]
 *	
 *	 Para acceder al objeto: 
 *		- p.Name = "Max";
 *	 El Runtime:
 *	 - Usa la referencia de "p".
 *	 - Accede al objeto en heap
 *	 - Modifica el campo
 *	 
 *	 Las variables de tipo Clase No contienen el objeto, contienen una referencia.
 *	 ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
 *		Copia de variables
 */
Person a = new Person();
Person b = a;
/*	No se copia el objeto,  Se copia la referencia al objeto:
 *	a ──┐
		├──▶ [Person object]
	b ──┘
 *	
 *	b.Name = "Juan";	->  cambia el objeto.
 *	b = new Person();	-> cambia la referencia a un nuevo objeto.
 *
	}

}
