using System;

public class Class1
{
	public Class1()
	{
        /*	+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
         *		Stack
         *	Es una región de memoria que funciona como una estructura LIFO (Last In, First Out) para almacenar:
         *	- variables locales
         *	- Parámetros de métodos
         *	- datos temporales de ejecución
         *	
         *	Caracteristicas:
         *	- tamaño limitado
         *	- acceso extremadamente rápido
         *	- gestión automática (no hay garbage collector aquí)
         *	- orden estricto de entrada/salida
         *	- también guarda referencias de memoria
         *	
         *	- Cada vez que se llama un metodo, se crea un stack frame, ahi se guardan sus variables, cuando el metodo termina,
         *	ese bloque se elimina automaticamente.
         *	- Optimizado para:
         *		* rapidez
         *		* datos pequeños
         *		* vida corta
         *		* estructura simple
         *		
         *	+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
         *		Heap
         *	Es una región de memoria usada para almacenar objetos dinámicos
         *	
         *	Caracteristicas:
         *	- tamaño mucho mayor
         *	- acceso más lento que el stack
         *	- memoria no se libera automáticamente al salir de un método
         *	- se limpia mediante el Garbage collector (GC)
         *	- el heap contiene objetos, esos objetos pueden contener value types
         *	
         *	- Necesario para:
         *		* objetos complejos
         *		* tamaño variable
         *		* vida independiente
         *		* compartir datos entre partes del programa
         *		
         *	+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
         *	    Garballe Collector
         *	Gestiona automáticamente la memoria del heap, identificando objetos que ya no son alcanzables y
         *	recuperando ese espacio.
         *	Función: detectar objetos sin referencias, liberar memoria.
         *	Se ejecuta cuando falta memoria, presión de memoria alta, el runtime lo decide.
         *	No libera memoria inmediatamente, NO funciona en el stack, No elimina objetos en uso
         *	
         *	- Alcanzable: no existe ninguna ruta desde el programa activo que permita acceder a ese objeto.
         *	
         *	El Garballe Collector (GC) tambien:
         *	- compacta memoria
         *	- reduce fragmentación
         *	- mejora localidad de acceso
         *	- optimiza futuras asignaciones
         *	
         *	    Función en fases del GC:
         *	
         *	        Identificación(Mark):
         *	Parte desde raices (roots):
         *	    - variables en el stack
         *	    - registros en el cpu
         *	    - referencias estaticas
         *	Y recorre todos los objetos que se pueden alcanzar desde ahí.
         *	
         *	        Marcado:
         *	- Los objetos alcanzables -> se marcan como "vivos"
         *	- Los objetos No alcanzables -> quedan sin marcar
         *	
         *	        Recolección:
         *  - Los no marcados ->  se eliminan
         *  - Su memoria queda disponible
         *  
         *          
         *	+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++	
         *		Value Type
         *	- acceso rapido
         *	- sin indirección
         *	- más rapido
         *	- vida controlada por el scope
         *	
         *	+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
         *	Reference Type
         *	- acceso indirecto (puntero -> objeto)
         *	- más flexible
         *	- permite compartir estado
         *	- requiere Garballe Collector
         *	
         *	+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
         *	
         *	La Variable contiene el valor o contiene una dirección de memoria??
         *	    - si contiene el valor -> value type
         *	    - si contiene dirección -> reference type
         *  El Stack/Heap es solo donde termina viviendo eso en memoria.
        */
    }
}
