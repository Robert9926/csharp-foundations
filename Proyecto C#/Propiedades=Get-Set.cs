using System;

public class Class1
{
	public Class1()
	{
        /*
		 *		Propiedad
		 *	Es un miembro de una clase que permite leer y/o escribir un valor
		 *	
		 *	Diferencias entre métodos y Propiedades.
		 *	1- Con propiedad se puede:
		 *		- cuenta.Saldo += 100;
		 *		- cuenta.Saldo++;
		 *	Con Métodos no se puede.
		 *	
		 *	2- Propiedad:  int x = cuenta.Saldo;
		 *		- El lenguaje lo ve como lectura de valor.
		 *	   Método:  int x = cuenta.ObtenerSaldo();
		 *	   - El Lenguaje lo ve como Ejecutar algo.
		 *	   
		 *	 Propiedad:
		 *		- Member Access Expresion
		 *		- Produce valor directamente.
		 *		- No requiere:  ().
		 *		- permite operaciones directas.
		 *		
		 *	Método:
		 *		- Invocation Expression
		 *		- Ejecuta codigo
		 *		- Luego produce valor (si retorna)
		 *		- se invoca con:  ().
		 *		- Es ejecución
		 *		- no es valor directo hasta que retorna (si es que lo hace).
		 *	
		 *		Get
		 *	Permite leer el valor
		 *	
		 *		Set
		 *	Permite asignar un valor
		 *	
		 *	
		 *	Lectura de Valor:  El compilador trata la expresión como un valor directamente usable
		 *	
		 *	Ejecutar algo:  El compilador trata la expresión como una llamada que debe ejecutarse primero.
		 *	
		 *	+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
		 *		Ejemplos:
		 *		
		 *		class Ejemplo
				{
				private int _valor;

					public int Valor	<-  Propiedad
					{
					get { return _valor; }		<-  Obtener/Leer Valor
					set { _valor = value; }		<-  Asignar/Cambiar Valor  - Set reconoce el valor entrante como: "value" -> Siempre.
					}
				}	
			+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
				class Ejemplo
				{
					private int _edad;
					private string _nombre;

					public int Edad { get; set; }	  <- Se utilizan modificadores de acceso para get y set:  public, private, protected, etc.
					public string Nombre { get; set; }
				}
		 *	+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
		 *		Ejemplo con Constructor:
		 *		
		 *		class Persona
				{
					private int _edad;		<-  Atributo del objeto
				
					public int Edad		<-  Propiedad Get/Set
					{
						get { return _edad; }
						set
						{
							if (value >= 0)
							_edad = value;
						}
				    }

					public Persona(int edad)	<-  Constructor
					{
						Edad = edad; // usa el set
					}
				}
		 * +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
		 *		Constructor -> Valida estado inicial del valor para el objeto.
		 *		Propiedad ->  Valida cualquier cambio en cualquier momento.
		 *		
		 *		Regla:
		 *		- siempre que se asigne un valor (constructor o fuera) → usar la propiedad.
		 */

    }
}
	