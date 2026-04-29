using System;

public class Class1
{
	public Class1()
	{
        /*
		 *		Modificadores de Acceso
		 *	Palabras clave que controlan desde donde se puede acceder a algo.
		 *	modificadores = control de acceso en tiempo de compilación.
		 *	Si no se colocan modificadores de acceso, se asignan unos por defecto:
		 *		Miembros (campos, métodos, propiedades) -> Private por defecto.
		 *		Clases -> Internal por defecto.
		 *	
		 *	
		 *	Public
		 *		- accesible desde cualquier parte del programa.
		 *		- interfaz externa -> lo que se expone.
		 *	Private
		 *		- solo accesible dentro de la misma clase.
		 *		- Dato interno -> nadie debe tocarlo.
		 *	Protected
		 *		- accesible solo dentro de la clase y en clases que	heredan de ella.
		 *		- acceso por herencia. no es posible acceder desde inicialización de objeto de la clase heredada:
		 *			ejemplo:  Existiendo Clase A y Estando en Clase B, se inicializa un objeto de A: A a = new A(); <- es posible.
		 *					 luego se modifica el campo heredado a travez de ese objeto:  a.x = 10;  <-  no es posible.
		 *		- cuando se quiere que una clase hija pueda usarlo.
		 *	Internal
		 *		- accesible dentro del mismo proyecto (assembly).
		 *		- cuando se quiere limitar el uso al proyecto, no al mundo externo.
		 *		
		 *		
		 *	Usados en:
		 *		- campos
		 *		- propiedades
		 *		- métodos
		 *		- clases
		 */
    }
}
