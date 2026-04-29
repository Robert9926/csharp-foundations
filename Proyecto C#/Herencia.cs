using System;

public class Class1
{
	public Class1()
	{
        /*
		 *		Herencia
		 *	- Relación entre tipos donde uno reutiliza/extiende a otro.
		 *	- Utiliza para no repetir codigo
		 *	
		 *		Extensión
		 *	- Agregar comportamiento nuevo (métodos, variables
		 *	
		 *		Tipos
		 *	- Clase -->  Clase  (class Perro : Animal)
		 *	- Interfaz  -->  Interfaz  (Ilist<T> : ICollection<T>)
		 *	- Clase  -->  Interfaz  (class List<T> : Ilist<T>)
		 *	
		 *		Regla
		 *	- Si B hereda de A --> B es A
		 *	++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
		 *		
		 *		Ejemplo:
		 *	
		 *	class Hijo : Padre		<--  ":" indica que hijo hereda de padre.
		 *	{	}
		 *	
		 *	- El Hijo obtiene del Padre:
		 *		- Métodos
		 *		- Variables
		 *		- Propiedades (Ejemp:  Get y Set).
		 *		- Comportamiento (Métodos "Funciones que ejecutan logica").
		 *	++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
		 *		
		 *		Ejemplo:
		 *	
		 *	class Animal
		 *	{ 
		 *		public void Comer()
		 *		{
		 *			-Console.WriteLine("Comiendo");
		 *		}
		 *	}
		 *	
		 *	class Perro : Animal	<--  Perro(HIJO)  hereda de Animal(PADRE).
		 *	{  
		 *		public void Ladrar()  {}	<-- Propio
		 *	}
		 *	
		 *	Perro p = new Perro();
		 *	p.Comer();		<--   Método "comer" fue heredado.
		 *	+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
		 *	
		 *		Ejemplo:
		 *	IEnumerable<int> datos = new List<int>();
		 *	Animal a = new Perro();
		 *	
		 *		variable  -->  tipo:  Animal/IEnumerable<T>
		 *		objeto  -->  tipo:  Perro/List<T>
		 *		
		 *		- Siempre se crea el objeto
		 *		- Se crea un objeto en Heap de tipo:  Perro/List<T>
		 *		- Se ejecuta constructor de:  Perro/List<T>
		 *		- la variable "a/datos" solo puede usar lo que Animal/IEnumerable<T> define
		 *		
		 *		a.Comer();   // ✔ (Animal)
		 *		a.Ladrar();  // ❌ (Perro)
		 *		- Aunque el objeto si tenga Ladrar o variables, La variable no puede accederlas.
		 *		- Por lo que la variable limita el acceso.
		 *	++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
		 *	
		 *		Ejemplo:
		 *	
		 *	class Animal	<-- Clase Padre.
			{
				public void Comer()
				{	
					Console.WriteLine("Comiendo");
				}
			}

			class Perro : Animal	<-- Clase Hijo.
			{
				public void Ladrar()
				{
					Console.WriteLine("Ladrando");
				}
			}

			class Gato : Animal		<-- Clase Hijo.
			{
				public void Maullar()
				{
					Console.WriteLine("Maullando");
				}
			}

			void Alimentar(Animal a)	<-- Método que recibe como parametros a Clase Padre.
			{
				a.Comer();
			}
			
			Perro p = new Perro();
			Gato g = new Gato();
	
			Alimentar(p);
			Alimentar(g);	<-- Es posible, porque ambos son heredados de Animal.

				- NO se duplica Logica ni Métodos:
				void AlimentarPerro(Perro p) { }
				void AlimentarGato(Gato g) { }
				- Es un método para todos


		 */
    }
}
