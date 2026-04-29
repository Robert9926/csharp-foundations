using System;

public class Class1
{
	public Class1()
	{
        /*
		 *		Parámetro
		 *	Es una variable definida en la Firma de un método que recibe un valor o referencia desde el exterior.
		 *	En C#, todo se pasa por valor.
		 *	
		 *	Al llamar un método, siempre se copia algo, y es con lo que el método trabaja:
		 *	value type -> valor
		 *	reference type -> referencia de memoria
		 *	
		 *	El metodo trabaja con una copia del valor de la variable, o valor pero es una referencia.
		 *	Sin ref/out/in:
		 *	El método nunca puede modificar la variable externa
		 *	Pero: puede modificar el objeto si es reference type
		 *	
		 *		Ejemplo con Value Type:
		 */
        void Cambiar(int x)
			{
	            x = 10;
			}

			int	a = 5;
			Cambiar(a);
        /*		Resultado Final:
		 *		a = 5.
		 *		
		 *		Qué pasó realmente:
		 *		- a tiene valor 5
		 *		- se copia a x
		 *		- x cambia a 10
		 *		- el método termina → x desaparece
		 *		- a → 5      (original)
		 *		- x → 10     (copia)
		 *		- Nunca se toco "a".
		 *		
		 *		Ejemplo con Reference Type:
		 */
			void Cambiar(Persona p)
			{
	            p.Nombre = "Juan";
			}
	        Persona persona = new Persona();
			persona.Nombre = "Pedro";
			Cambiar(persona);
        /*		Resultado Final:
		 *		persona.Nombre = "Juan"
		 *		
		 *		No se esta cambiando la variable, Se cambia el objeto.
		 *		Se copia la referencia, no el objeto
		 *	++++++++++++++++++++++++++++++++++++++++++++++++++
		 *		REF
		 *	No hay copia, se trabaja sobre la misma variable.	
		 *	Debe estar inicializada (con valor) antes de llamar al método.
		 *	- modificar algo existente
		 *	- ya tiene valor
		 *	- puedes leer y modificar
		 */
        void Cambiar(ref int x)
			{
				x = 10;
			}
			int a = 5;
			Cambiar(ref a);
        /*		Resultado:
		 *			a = 10.
		 *	++++++++++++++++++++++++++++++++++++++++++++++++++
		 *		OUT	 ->  Parametro de salida obligatoria.
		 *	No se necesita valor previo.
		 *	Trabaja con la variable original.
		 *	Es obligatorio asignar/modificar el valor de la variable dentro del método.
		 *	- crear / asignar un valor
		 *	- no necesitas valor previo
		 *	- debes asignar
		 */
        void Obtener(out int x)
			{
	            x = 20;
			}
			int a;
			Obtener(out a);
        //		out se usa cuando el método debe producir un valor y asignarlo obligatoriamente
        /* ++++++++++++++++++++++++++++++++++++++++++++++++++
		 *		IN  ->  Parametro de solo lectura sin copia.
		 *	No trabaja con copia. trabaja con original.
		 *	Pero no permite asignar/modificar el valor de la variable dentro del método.
		 *	- leer sin modificar.
		 */
        void Mostrar(in int x)
			{
	            // x = 10; ❌ no permitido
			}
        //		in se usa para pasar por referencia sin copia y garantizar que no se modifique
        // ++++++++++++++++++++++++++++++++++++++++++++++++++
    }
}
