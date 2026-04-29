using System;

public class Class1
{
	public Class1()
	{
		/*
		 *		Stack Trace
		 *	Es un registro de las funciones(Método) que estaban en ejecución cuando ocurrió una excepción.
		 *	Se puede interpretar como:  Cómo llego el programa hasta el error.
		 *	- Cada método crea un Frame en el Stack, Cuando se llaman métodos, se van apilando.
		 *	- Cuando ocurre un Error en un Método, ese estado se guarda. -> Eso es el Stack Trace.
		 *	Sirve para saber dónde ocurrió el error  ->  Debugging.
		 *	
		 *	Contiene lista ordenada de llamada.
		 *	Ejemplo:
		 *	- Metodo3()
		 *	- Metodo2()
		 *	- Metodo1()
		 *	- Main()
		 *	
		 *	+++++++++++++++++++++++++++++++++++++++++++++++++++
		 *	
		 *		Stack Unwinding
		 *	Es el proceso del Runtime de "Desenrrollar" el stack cuando ocurre una excepción.
		 *	Desenrrollar:  Eliminar Frames hasta encontrar un catch.
		 *	
		 *	Ejemplo:
		 *	- Metodo C()
		 *	- Metodo B()
		 *	- Metodo A()
		 *	- Metodo Main
		 *	
		 *	El Runtime hace:
		 *	- Error en Método C
		 *	- No hay catch en C  ->  Elimina C
		 *	- Va a Método B
		 *	- No hay catch en Método B -> Elimina B
		 *	- Va a Método A 
		 *	- Encuentra catch -> Se detiene
		 *	
		 *	->  Eso es Stack unwinding
		 *
	}
}
