using System;

public class Class1
{
	public Class1()
	{
        /*
		 *		Constructores
		 *	Es un método especial que se ejecuta automáticamente cuando creas un objeto con new.
		 *	Sirve para garantizar que el objeto nace en un estado válido. 
		 *	El Constructor define cómo nace el objeto.
		 *	
		 *	- Hay 2 tipos de Datos en un Objeto:
		 *		- Datos Obligatorios
		 *		- Datos Opcionales
		 *	El Constructor asegura los datos minimos necesarios, el resto puede asignarse después si no es esencial.
		 *		- Consecutivamente, ayuda a evitar errores futuros, si se llama a cierto dato del objeto y este esta vacio.
		 *	
		 *	El Objeto lo crea "New".
		 *	El Constructor lo inicializa con valores asignados desde un inicio.
		 *	
		 *	El constructor:
		 *		- Tiene el mismo nombre que la clase.
		 *		- No tiene tipo de retorno.
		 *		- Se ejecuta automáticamente con "new".
		 *+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++		
		 *	El constructor NO guarda el parámetro
		 *	Guarda el valor dentro del objeto
		 *	
		 *	Ejemplo de Constructor:
		 *		
		 *		public Person(string name)
				{
					Name = name;	-> Copia el valorde Stack a Heap
				}
		 *	- Siempre va dentro de la Clase que sera el objeto
		 *	- "name" es un parametro que se le pasa -> vive en el stack.
		 *	- El método(constructor) termina, "name" desaparece.
		 *	- "Name"(campo del objeto) -> vive en Heap.
		 *	- El valor ya fue guardado en el objeto.
		 *	+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++		
		 *	El Constructor Bloquea la creación de objetos inválidos.
		 *	Ejemplo:
		 *		
		 *		class CuentaBancaria	->  Clase
				{
					public double Saldo;	-> Dato que tendra el Objeto (Caracteristica)

					public CuentaBancaria(double saldo)		->  Método  (Constructor)
					{
						if (saldo < 0)			->  Comprobar que el saldo es valido al crear un nuevo objeto.
						throw new Exception();	
		
				        Saldo = saldo;		->  Asigna el valor mandado al valor en el objeto.
					}
				}	
		 *	
		 *	var cuenta = new CuentaBancaria(-100);		->   El objeto nunca llega a existir si es invalido.
		 *
		
		 */
    }
}
