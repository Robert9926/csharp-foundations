using System;

public class Class1
{
	public Class1()
	{
        /*
		 *		IDictionary<They, TValue>
		 *	- Contrato para almacenar y acceder a datos mediante una clave.
		 *	
		 *	Solo es posible aplicarlo a:
		 *		- Dictionary<They, TValue>
		 *	
		 *	- Cada clave es unica
		 *	- se puede acceder rapido por clave
		 *	- se puede agreagar, modificar, eliminar.
		 *		
		 *	Uso:
		 *		IDictionary<string, int> datos = new Dictionary<string, int>();   <-  Declaración e Inicialización.
		 *		datos.Add("edad", 1);	<-  Agregar valor y dato Nuevo.  Error si la clave ya existe.
		 *		datos.Add("nivel", 2);
		 *		datos["a"] = 3;		<-  Agrega si no existe, Modifica si existe.
		 *		datos.ContainsKey("a");		<-  Verifica si la clave existe.
		 *		datos.Remove("a");		<-  Elimina por clave.
		 *		int edad = datos["edad"];	<- obtener dato a travez de valor.
		 */

    }
}
