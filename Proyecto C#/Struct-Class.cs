using System;

public class Class1
{
	public Class1()
	{
        /*
		 *		Struct
		 *	Tipo de valor (value type) que almacena sus datos directamente.
		 *	- hereda implicícitamente de System.ValueType
		 *	- se copia por valor.
		 *	- no requiere "new" (aunque puede usarse).
		 *	Representa Valor. Importa el Contenido.
		 *		
		 *		Memoria:
		 *		Puede estar en:
		 *		- stack (Variable local)
		 *		- dentro de objetos (heap)
		 *		
		 *		Struct  es Value Type
		 *		
		 *		Se Utiliza Struct:
		  		- Es pequeño (<16 bytes)
		  		- representa un valor (no identidad)
		  		- es inmutable idealmente
		  		- no se necesita compartir estado
		 */
            struct Punto
		 	{
		 		public int x;
		 		public int y;
		 	}
		 	Punto a = new Punto();
		 	Punto b = a;
		 /*	Memoria Stack:
		 *		a: X, Y.
		 *		b: X, Y.
		 *		- copia completa.
		 *		- independientes.
		 *		
		 *		Comportamiento:
		 *	Punto a = new Punto {X = 1};
		 *	Punto b = a;
		 *	
		 *		Resultado:
		 *		a.X = 1.
		 *		b.X = 5.
		 */		
		 //		Metodos:
		 	void Cambiar (Punto p)
		 	{
		 		p.X = 10;
		 	}
		 //		- no afecta el original.		  				  				 
		 /*	++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
		 *		Class 
		 *	Tipo de referencia (reference type) cuyo objeto vive en el heap y se accede mediante referencia.
		 *	- se instancia con "new".
		 *	- se maneja mediante referencias.
		 *	- permite identidad (misma instancia compartida).
		 *	Representa Identidad. Importa la Identidad.
		 *	
		 *		Memoria:
		 *		- Si es Objeto -> está en Heap.
		 *		- Si es variable -> es Referencia (Stack o Campo).
		 *		
		 *		Class es Reference Type.
		 *		
		 *		Se Utiliza Class:
		 *		- Se necesita identidad
		 *		- el objeto es grando o complejo
		 *		- Se necesita mutabilidad compartida
		 *		- Hay relaciones entre objetos
		 */	
		 	class Punto
		 	{
		 		public int x;
		 		public int y;
		 	}
		 	Punto a = new Punto();
		 	Punto b = a; 
		 /*		Memoria Stack:
		 *			a: ref 0x1000
		 *			b: ref 0x1000
		 *		Memoria Heap:
		 *		Objeto Punto
		 *		- Misma instancia.
		 *		- Estado compartido.
		 *		
		 */		Comportamiento:
		 	Punto a = new Punto {X = 1};
		 	Punto b = a;
		 	b.X = 5
		 		
		 /*		Resultado
		 *		a.X = 5
		 *		b.X = 5		  
		*/
		 //		Metodos:
			void Cambiar (Punto p)
			{
				p.X = 10;
			}
			// Si afecta al Original.
	}
}
