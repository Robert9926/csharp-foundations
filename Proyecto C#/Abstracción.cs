using System;

public class Class1
{
	public Class1()
	{
        /*
		 *		Abstracción
		 *	- Definir qué debe hacer algo, sin especificar cómo lo hace.
		 *	- Te enfocas en el comportamiento requerido, no en la implementación.
		 *	
		 *	Virtual tiene implementación base (opcional sobreescribir)
		 *	Abstract No tine implementación (Obligatorio sobreescribir)
		 *	
		 *	Sirve para que todas las clases hijas cumplan con ciertas reglas.
		 *	Garantizar que aldo puede hacerse.
		 *	NO permitir objetos "genericos" sin implementación
		 *	
		 * ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++		
		 * 
		 *		Ejemplo:
		 *	
		 *	abstract class Animal
		 *	{
		 *		public abstract void HacerSonido();
		 *	}
		 *		- Animal NO tiene implementación
		 *		- Obliga a las clases hijas a implementar el método
		 *		- Abstract en la clase significa:
		 *			--> no se puede instanciar
		 *			--> puede tener miembros incompletos
		 *		- Abstract en el método:
		 *			--> No tiene implementación
		 *			--> Obliga a las clases hijas a implementarlo
		 *		- Si un Método es Abstracto, la Clase debe ser Abstracta.
		 *	
		 *	Animal a = new Animal();	<--  ❌  No se puede crear instancias de clases abstractas.
		 *		
		 *	class Perro : Animal
		 *	{
		 *		public override void HacerSonido()
		 *		{
		 *			Console.WriteLine("Ladrar");
		 *		}
		 *	}
		 *	class Gato : Animal
		 *	{
		 *		public overrdie void HacerSonido()
		 *		{
		 *			Console.WriteLine("Maullar");
		 *		}
		 *	}
		 *		- Si una clase Hereda de una clase abstracta. Debe implementar sus métodos abstractos.
		 *		- Al tener la clase Padre un método Abstract, obliga a que todas las clases hijo
		 *		lo desarrollen. lo que garantiza que todas las clases cumplan el contrato de tener 
		 *		ese método.
		 *	
		 *	++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++		
		 *	
		 *	void HacerSonar(Animal a )
		 *	{
		 *		a.HacerSonido();
		 *	}
		 *		- Con un método asi, si una clase hijo no tiene el método, ocasiona un fallo.
		 *	
		 *	++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++		
		 *	
		 *	base:  acceder al comportamiento de la clase padre.
		 *		- llamar al método del padre.
		 *		- Permite extender en lugar de reemplazar.
		 *	
		 *		Ejemplo:
		 *		
		 *	class Animal	<--  Clase Padre
		 *	{
		 *		public virtual void HacerSonido()
		 *		{
		 *			Console.WriteLine("Generico");
		 *		}
		 *	}
		 *	class Perro : Animal	<-- Clase Hijo
		 *	{
		 *		public override void HacerSonido()
		 *		{
		 *			base.HacerSonido();				<-- Resultado:  Generico
		 *			Console.WriteLine("Ladrar");	<-- Resultado:  Ladrar
		 *		}
		 *	}
		 *	
		 *		Ejemplo:
		 *	
		 *	class Animal
		 *	{
		 *		public Animal(int edad)
		 *		{
		 *			Console.WriteLine("Animal creado");
		 *		}
		 *	}
		 *	class Perro : Animal
		 *	{
		 *		public Perro()	: base(5)		<-- Es un constructor hijo que llama al contructor Padre.
		 *		{
		 *			Console.WriteLine("Perro creado");
		 *		}
		 *	}
		 *		- Primero se llama al contructor Padre y luego se Ejecuta el constructor Hijo
		 *		- Se manda como parametro "5" al constructor.
		 *		
		 *	++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++		
		 *	
		 *	sealed:  evita que algo sea heredado o modificado
		 *		- evita cambios no deseados.
		 *	
		 *		Ejemplo:
		 *	
		 *	sealed class Perro {}
		 *		- Nadie puede heredar de Perro
		 *		
		 *	class Animal
		 *	{
		 *		public virtual void HacerSonido() { }
		 *	}
		 *	class Perro : Animal
		 *	{
		 *		public sealed override void HacerSonido() { }
		 *	}
		 *		- El método HacerSonido ya no puede ser sobreescrito otra vez por otra clase, 
		 *		ya que la clase perro utilizo "sealed" en el método.
		 *	
		 *	++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++		
		 */

    }
}
