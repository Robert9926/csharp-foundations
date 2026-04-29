using System;

public class Class1
{
	public Class1()
	{
		/*
		 *		HashSet<T>
		 *	- Colección de elementos únicos (Sin duplicados)
		 *	- Almacena valores sin repetir.
		 *	Como funciona:  usa hashing (igual que Dictionary)
		 *		1-calcula un hash del valor
		 *		2-lo coloca en un bucket
		 *		3-permite acceso rápido
		 *	- Se usa cuando se evita duplicados.	
		 *	
		 *	
		 *	HashSet<int> numeros = new HashSet<int>();
		 *	numeros.Add(1);
		 *	numeros.Add(2);
		 *	numeros.Add(1);    <---  Se ignora ya que ya esta agregago.
		 *	
		 *	Verificar Existencia:
		 *	if (numeros.Contains(1))
		 *	{
		 *		Console.WriteLine("Existe");
		 *	}
		 *	
		 *	
		 *		Metodos Principales:
		 *	
		 *	Add:  agrega si no existe.
		 *	Contains:  verifica existencia
		 *	Remove:  elimina elemento
		 *	Count:  cantidad de elementos
		 */
	}
}
