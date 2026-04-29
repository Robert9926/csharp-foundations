using System;

public class Class1
{
	public Class1()
	{
        /*
		 *		Interfaz
		 *	- Define que debe hacerse, sin implementación ni estado.
		 *	- Una clase puede implementar múltiples interfaces.
		 *	
		 *		Ejemplo:
		 *		class Perro : Animal, IMascota  { }
		 *	
		 *	+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
		 *	
		 *		Diferencia:
		 *	Abstract
		 *		- puede tener implementación
		 *		- puede tener estado (variables)
		 *		- Es un contrato Parcial
		 *	Interface
		 *		- No tiene implementación
		 *		- No tiene estado (variables)
		 *		- solo define contrato (Que las clases hijas cumplan con tener eso)
		 *		- Es un contrato Puro/Total
		 *	
		 *	+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
		 *	
		 *		Ejemplo:
		 *	
		 *	interface IAnimal
		 *	{
		 *		void HacerSonido();
		 *	}
		 *		- no hay codigo dentro
		 *		- no hay variables
		 *		- solo define métodos
		 *		
		 *	class Perro : IAnimal
		 *	{
		 *		public void HacerSonido()
		 *		{
		 *			Console.WriteLine("Ladrar");
		 *		}
		 *	}
		 *		- Si una clase implementa una interfaz -->  Debe implementar todo
		 *		
		 *	+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
		 *	
		 *	IAnimal a = new Perro();
		 *		- solo se puede usar lo que esta en IAnimal, no en Perro.
		 */
    }
}
