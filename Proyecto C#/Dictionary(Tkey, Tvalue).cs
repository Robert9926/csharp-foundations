using System;

public class Class1
{
	public Class1()
	{
        /*
		 *		Dictionary<They, TValue>
		 *	Es un tipo generico, representa una estructura de datos que almacena pares.
		 *		- Es una colección
		 *		- Es una estructura basada en hashing
		 *		- Es de Reference type (Almacenado en Heap)
		 *		
		 *	TKey ->  tipo de la clave.
		 *			- No puede ser null
		 *			- tipos validos: (string, int, long)
		 *			
		 *	TValue -> Tipo del valor
		 *			- Puede ser Null
		 *			- Puede ser cualquier tipo (int,string,bool,objetos,listas, otro dictionary).
		 *			- Puede ser cualquier tamaño (string largos, objetos grandes,structs)
		 *	
		 *	Permitir acceder a un valor usando una clave
		 *	- Para acceder a un valor, siempre se usa la Key.
		 *	- Siempre debe de haber una Key, pero una Key puede no tener o apuntar a un valor (null).
		 *	
		 *	No es necesario definir valor, crece dinamicamente.
		 *	Al definir valor inicial:  
		 *		- var dict = new Dictionary<string, int>(100);  <-  espacio para 100 elementos.
		 *		- cuando se llena, crea estructura más grande, reubica elementos(rehashing).
		 *	
		 *	+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
		 *		Declaración
		 *	- En General, es definir una variable (nombre + tipo) en el programa.
		 *	- Le dice el compilador, existe una variable llamada: "x" de tipo: "x".
		 *	
		 *	- Dictionary<string, int> dict;
		 *		-> Variable llamada:  dict.
		 *		-> de tipo:  Dictionary.
		 *		-> usa: String y int.
		 *		
		 *		
		 *		Inicialización
		 *	- En General, es asignarle un valor inicial a la variable.
		 *	
		 *	- dict = new Dictionary<string, int>();
		 *		-> con "new":
		 *			- se crea objeto en heap.
		 *			- se ejecuta constructor.
		 *			- se devuelve referencia.
		 *			
		 *	++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++		
		 *	
		 *		dict.Add()
		 *	- Es un método, significa añadir un par clave al valor.
		 *		- dict.Add("a", 1);
		 *			- "a" = clave(Tkey)
		 *			- 1 = valor(TValue)
		 *	- No permite duplicados:
		 *		dict.Add("a", 1);
				dict.Add("a", 2); // ❌ lanza excepción
			- Se usa cuando no debe existir previamente.
		 *			
		 *			
		 *		dict["a"] = 1
		 *	- Es un indexador, no es un método		 
		 *	- significa: asignar valor a la clave.
		 *		- si la clave no existe, la crea.
		 *		- si la clave existe, reemplaza valor.
		 *	- Permite Sobreescribir:
		 *		dict["a"] = 1;
		 *		dict["a"] = 2; // ✔ reemplaza
		 *	- Se usa cuando no importa si existe o no o se sobreescriba.
		 *	- Al usarlo, compara claves, las ubica en mémoria eficientemente.
		 *		- Equals() -> comparar igualdad.
		 *		- HetHashCode() ->  Ubicar en estructura interna.
		 *		
		 *	+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
		 *		Equals
		 *	- Un método que compara si 2 objetos son iguales.
		 *	
		 *		GetHashCode
		 *	- Un método para convertir un objeto a número(int), un identificador númerico.
		 *	
		 *		Bucket
		 *	- posición en un array interno donde se agrupan elementos.
		 *		[0] [1] [2] [3] [4]  <-  Array.
		 *		- Cada posición es un Bucket.
		 *	- Solo existe en Dictionary o estructuras basadas en hashing no en List<> ni Arrays.
		 *	- Dictionary utiliza buckets porque la clave no es un posición. 
		 *		- primero convierte a número
		 *		- segundo ubica
		 *		- tercero confirma
		 *		
		 *		Entries
		 *	- Datos Reales 
		 *	- Solo existe en Dictionary o estructuras basadas en hashing no en List<> ni Arrays.
		 *	+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
		 *	
		 *	class Persona
			{
				public string Nombre;
			}

			var p1 = new Persona { Nombre = "Juan" };
			var p2 = new Persona { Nombre = "Juan" };
	
			p1.Equals(p2); //   <-  Compara, Resulta:  ❌ false
		 *		
		 *		- Los objetos se comparan por referencia (dirección de memoria)
		 *		- p1 =/= p2 porque son instancias distintas.
		 *		- Igualdad por referencia es distinto a igualdad por contenido.
		 */
    }
}
