using System;

public class Class1
{
	public Class1()
	{
        /*
		 *		Tipos
		 *	Un tipo define:
		 *	- Que valores puede tener algo.
		 *	- Que operaciones se pueden hacer sobre esos valores.
		 *		Cada tipo define:
		 *		- Rango
		 *		- Precisión
		 *		- Operaciones Validas		
		 *	
		 *		Primitivos: 
		 *	En C#, "primitivo", se usa de forma práctica para referirse a tipos básicos del lenguaje, predefinidos,
		 *	que representan datos simples.
		 *	
		 *	Value Types:
		 *		- almacena el valor directamente
		 *		- normalmente viven en el stack
		 *		- al asignar -> se copia el valor.
		 *		- si se excede el tamaño de la capacidad de memoria(rango) hay overflow(desbordamiento).
		 *		- puede haber error de precisión en decimales.
		 *		- puede haber enormes cosumos de memoria innecesaria si no se asigna el tipo adecuado.
		 *	
		 *		Tipos Primitivos -> Value Types:
		 *	Enteros:
		 *		- int
		 *			tamaño: 4 bytes (32 bits)
		 *			rango: -2,147,483,648 a 2,147,483,647
		 *			uso: tipo por defecto para enteros.
		 *			
		 *		- long
		 *			tamaño: 8 bytes (64 bits)
		 *			rango: extremadamente grande (~9 quintillones)
		 *			uso: cuando "int" no alcanza.
		 *			
		 *		- short
		 *			tamaño: 2 bytes (16 bits)
		 *			rango: -32,768 a 32,767
		 *			
		 *		- byte
		 *			tamaño: 1 byte (8 bits)
		 *			rango: 0 a 255
		 *			uso: cuando se necesita ahorrar memoria o trabajar con datos binarios.
		 *			
		 *	Decimales:
		 *		- float
		 *			tamaño: 4 bytes
		 *			presición: ~7 dijitos, representación en binario.
		 *			uso: rapido, pero impreciso.
		 *			
		 *		- double
		 *			tamaño: 8 bytes
		 *			presición: ~15-16 dijitos, representación en binario.
		 *			uso: tipo por defecto para decimales, rapido pero impreciso.
		 *			
		 *		- decimal
		 *			tamaño: 16 bytes
		 *			precisión: muy alta (28-29 dijitos), representación en base 10.
		 *			uso: dinero/finanzas. preciso, pero más lento.
		 *			
		 *	Otros:
		 *		- bool
		 *			valores: true / false
		 *			uso: condiciones lógicas.
		 *			
		 *		- char
		 *			tamaño: 2 bytes
		 *			uso: representa un solo carácter.
		 *			
		 *		- string (NO es primitivo, es reference type)
		 *			No es value type, No es primitivo real.
		 *			Pero se usa como básico	
		 *	
		 *		
		 */
    }
}
