using System;

public class Class1
{
	public Class1()
	{
        /*
		 *		Variables 
		 *	Una variable es un identificador que referencia un valor o un objeto.
		 *	Su alcance (scope) define dónde puede ser accedida en el código.
		 *	
		 *		Scope (alcance)
		 *	Regla Base: Una variable solo existe dentro del bloque {} donde fue declarada.
		 *	- Dónde puedes usar la Variable
		 *	
		 *		Lifetime
		 *	- Cúanto tiempo existe en memoria.
		 *	
		 *	++++++++++++++++++++++++++++++++++++++++++++++++++++
		 *		Scope de Bloque
		 *	if (true)
		 *	{
		 *		int x = 0;
		 *	}
		 *		x solo existe dentro de if. 
		 *		fuera -> error de compilación.
		 *	-----------------------------------------------------	
         *		Scope de Metodo (Local)
         *	void Metodo ()
         *	{
         *		int a = 10;
         *		if (true)
         *		{
         *			int b = 20;
         *		}
         *	}
         *		b no se puede usar fuera de if.
         *		a puede usarse dentro de if.
         *	-----------------------------------------------------	
         *		Scope de Clase (campos)
         *	class Persona
         *	{
         *		int edad;
         *	}
         *		"edad" es accesible dentro de la clase.
         *		su vida depende del objeto.
         *  -----------------------------------------------------	
         *		Scope estático
         *	class Test
         *	{
         *	    static int contador;
         *	}
         *	    "contador" es accesible sin instancia.
         *	    vive durante toda la ejecución.
		 *	++++++++++++++++++++++++++++++++++++++++++++++++++++
		 *	    Lifetime (Tiempo de Vida)
		 *	Scope =/= Lifetime
		 *	
		 *	void Metodo ()
		 *	{
		 *	    int a = 10;
		 *	}
		 *		"a" vive  mientras el método se ejecuta.
		 *		luego desaparece (se almacena en stack).
		 *	-----------------------------------------------------		
		 *	Persona Crear ()
		 *	{
		 *		Persona p = new Persona;
		 *		return p;
		 *  }
		 *		"p" muere al salir del método.
		 *		el objeto "Persona" sigue vivo si alguien lo referencia.
		 *	-----------------------------------------------------	
		 *	static int contador;
		 *		"contador" vive durante todo el programa al "static".
		 *	-----------------------------------------------------	
		 *		Variables locales
		 *	- Viven normalmente en Stack.
		 *	- Tienen vida corta.
		 *	- Son de acceso rápido.
		 *		
		 *		Reference types
		 *	Persona p = new Persona();
		 *	- "p" vive en Stack(Referencia).
		 *	- El objeto "Persona" vive en Heap.
		 *	++++++++++++++++++++++++++++++++++++++++++++++++++++
		 *		Reglas Operativas
		 *	No se puede usar variables fuera de su Scope:
		 *		if (true)
		 *		{
		 *			int x = 10;
		 *		}
		 *		Console.WriteLine(x);   <-  Error.
		 *		
		 *	Scope Interno puede ver el Externo:
		 *		int a = 10;
		 *		if (true)
		 *		{
		 *			Console.WriteLine(a);   <-  Valido.
		 *		}
		 *		
		 *	Scope Externo No puede ver Interno:
		 *		if (true)
		 *		{
		 *			int b = 20;
		 *		}
		 *		Console.WriteLine(b);	<- Error.
		 *	
		 *	Shadowing:
		 *		int x = 10;
		 *		if (true)
		 *		{
		 *			int x = 20;		<- Error  en C#.
		 *		}
		 *			C# no permite declarar en el mismo contexto accesible.
		 * 
		*/
    }
}
