using System;

public class Class1
{
	public Class1()
	{
		/*
		 *		Método
		 *	Es una unidad de ejecución que define:
		 *	- un punto de entrada de lógica.
		 *	- un conjunto de instrucciones.
		 *	- una interfaz (parámetros + retorno)
		 *	Pocas Palabras:  Es ejecución Temporal
		 *	- las variables mueren al terminar el método (porque usan memoria de Stack)
		 *	- al retornar un objeto se retorna la referencia.
		 *	Un método es un mecanismo de control de ejecución más aislamiento temporal de memoria (Stack Frame)
		 *	
		 *	Al llamar un método:
		 *	1- se crea un stack frame, este contiene:
		 *		- parámetros
		 *		- variables locales
		 *		- dirección de retorno
		 *	2- se copian o pasan los parametros (dependiendo)
		 *	3- se ejecuta el código
		 *	4- se retorna el valor (si aplica)
		 *	5- se destruye el frame
		 */
			int Sumar (int a, int b)	//  <-  Firma del Método
		/*		Componentes:
		 *		- tipo de retorno: int
		 *		- nombre: Sumar 
		 *		- parametros: (int a, int b)
		 *	La firma define cómo se invoca el método, no cómo funciona internamente.
		 *	
		 *		
		 *		Retorno
		 *	- devuelve un valor
		 *	- ese valor se copia (si es value type)
		 *	- o se devuelve referencia (si es reference type)
		 *	- "return" -> Termina el método inmediatamente
		 */
			int Doble (int x)
			{
				return x * 2;	//  <-  Se termina el método
			}
		 /*	
		 *		
		 *		No Retorno
		 *	- no devuelve nada
		 *	- solo ejecuta efectos	
		*/
			void Imprimir ()
			{
			Console.WriteLine("hola");
			}
		/*	
		 *		Retornar Objetos
		 *	- Es posible porque el objeto está en Heap.
		 *	- No depende del Stack frame.
		 */
			Persona Crear ()
			{
			return new Persona();
			}
		/*	++++++++++++++++++++++++++++++++++++++++++++++++++++++++
		 *		Variables Locales
		 *	- viven en el Stack Frame
		 *	- mueren al terminar el método
		 */
			void Metodo()
			{
			int a = 10;		//  <-  Variable local, tipo:  Value type.  ubicación: stack.
			}
		/*
		 *		Objetos Creados Dentro
		 *	- El objeto puede morir (si no hay referencias a él)
		 *	- El objeto puede sobrevivir si se retorna o guarda
		 *	- Las variables mueren al terminar el método.
		 */
			void Metodo ()
			{
			Persona p = new Persona();	//  "p"  muere al terminar el método.
			}
        /*  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++
         *  
         *		Sobrecarga (Overloading)
         *	Múltiples métodos con mismo nombre pero distinta firma
         *		Resolución
         *	El compilador decide cuál usar en base a:
         *	- número de parámetros
         *	- tipos de parámetros
		 */
			int Sumar (int a, int b)
			double Sumar (double a, double b)

        //	No es valido si solo cambia el retorno, el retorno no forma parte de la firma para sobrecarga.
            int Test(int x)
			void Test(int x) // ❌ solo cambia retorno
        //  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        //		Paso de ejecución Encadenado
            int A()
        {
            return B();
        }

        int B()
        {
            return 5;
        }
        /*		Memoria: 
        *	[A frame]:
        *		→ llama B
        *	[B frame]:
        *		return 5
        *	→ vuelve a A
        *	→ A retorna 5
        *	++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        *		Método Estático
        *	- no requiere objeto
        *	- pertenece  a la clase.
        */
			static int Sumar (int a, int b)

        /*		Método Instancia
		 *	- Requiere un objeto
		 *	- Tiene acceso a estado del objeto
		 */
            class Calculadora
			{
			public int Sumar(int a, int b)
			}
}
}
