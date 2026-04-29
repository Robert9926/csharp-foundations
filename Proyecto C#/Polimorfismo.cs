using System;

public class Class1
{
	public Class1()
	{
		/*
		 *		Polimorfismo
		 *	- Mismo tipo Variable, Diferentes comportamientos según el objeto.
		 *	Ejemplo:  Se usa Animal, pero el comportamiento depende de si es Perro o Gato.
		 *	- El método ejecutado depende del objeto Real.
		 *	- Antes la variable limitaba que se hacia.
		 *	- Ahora el comportamiento depende del tipo real del objeto.
		 *	
		 *	virtual:  Siempre en la Clase Base (Padre)
		 *		- permite que un método pueda ser redefinido en una clase hijo.
		 *	override:  Siempre en la Clase Hijo.
		 *		- realiza el reemplazo
		 *		- si hay override, Gana el Hijo.
		 *		- si NO hay override, Gana la variable.
		 *	
		 *	Funcionan en métodos y propiedades
		 *	Sin virtual/override:  decisión en compilación (estatico)
		 *	Con virtual/override:  decisión en ejecución (dinamico)
		 *	- El Runtime decide que método ejecutar según el tipo real del objeto.
		 *	
		 *	+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
		 *	
		 *		Ejemplo:
		 *	class Animal	<--  Clase Padre.
		 *	{
		 *		public virtual void HacerSonido()
		 *		{ 
		 *			Console.WriteLine("Sonido Genérico");
		 *		}
		 *	}
		 *	
		 *	class Perro : Animal  <--  Clase Hijo.
		 *	{
		 *		public override void HacerSonido()
		 *		{ 
		 *			Console.WriteLine("Ladrar");
		 *		}
		 *	}
		 *	
		 *	class Gato : Animal  <-- Clase Hijo.
		 *	{
		 *		public override void HacerSonido()
		 *		{
		 *			Console.WriteLine("Maullar");
		 *		}
		 *	}
		 *	
		 *	Animal a1 = new Perro();
		 *	Animal a2 = new Gato();
		 *	
		 *	a1.HacerSonido();
		 *	a2.HacerSonido();
		 *		
		 *		Resultado:
		 *		- Ladrar
		 *		- Maullar
		 *	+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
		 *	
		 *		Ejemplo: 
		 *	Mismo método  --> diferentes implementaciones.
		 *	
		 *	void HacerSonar(Animal a)
		 *	{
		 *		a.HacerSonido();
		 *	}
		 *	
		 *	HacerSonar(new Perro());
		 *	HacerSonar(new Hato());
		 *	
		 *		- mismo codigo
		 *		- distinto comportamiento
		 *		- Se elige el método correcto en tiempo de ejecución.
		 *		- Se evita usar: if/else, Ejemplo:
		 *			if (tipo == "perro") {}
		 *			else if (tipo == "gato") {}
		 *
		 */
	}
}
