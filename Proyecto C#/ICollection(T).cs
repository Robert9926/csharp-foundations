using System;

public class Class1
{
	public Class1()
	{
        /*
		 *		ICollection<T>
		 *	- Contrato para colecciones que pueden modificarse.
		 *	- ICollection Hereda de IEnumerable.
		 *	
		 *	IEnumerable<T>  ->  solo recorrer.
		 *	ICollection<T>  ->  Recorrer y modificar.
		 *	
		 *	- Ademas de Iterar, permite:
		 *		- Agregar
		 *		- Eliminar
		 *		- Cosultar tamaño
		 *		
		 *	Metodos Principales:
		 *	- Add (T item)	<-  Añadir dato nuevo
		 *	- Remove (T item)  <-  Eliminar Dato
		 *	- Clear()  <-  Elimina todos los elementos de la colección
		 *	- Contains (T item)  <-  Verifica si un elemento existe en la colección.
		 *	
		 *	Ejemplo:
		 *		ICollection<int> datos = new List<int>();
		 *		datos.Add(1);
				datos.Add(2);
				datos.Remove(1);
				datos.Clear();	
				bool existe = datos.Contains(20);	<-  True/False  |  False, no existe 20 en la colección.

				foreach (var d in datos)
				{
					Console.WriteLine(d);
				}
		 * 
		 */
    }
}
