using System;

public class Class1
{
	public Class1()
	{
        /*
		 *		Excepción
		 *	Es un mecanismo para manejar errores en tiempo de ejecución que interrumpen el flujo normal del programa.
		 *	- Es un objeto que representa una condición anormal durante la ejecución.
		 *	
		 *	(Try) -> Se coloca código con posibilidad de causar error. 
		 *	(Catch) -> En caso de dar error, se detiene la lectura del codigo y salta a Catch.
		 *	        -> Los tipos de excepsiones son clases ya establecidas en .Net, al dar el error,
		 *	           se crea un objeto de el tipo de clase de error, este objeto se crea para 
		 *	           transportar información y contiene:
		 *	           - ex.Messaje  -> mensaje    
		 *	           - ex.StackTrace -> Tipo de error
		 *	           - ex.GetType  -> Stack trace (Dónde ocurrió)
		 *	(Finally) ->  Siempre se ejecuta al final del bloque Incluso si hay error o Crash.
		 *	              - se usa para liberar recursos o ejecutar código obligatorio.
		 *	              - No es para manejar erorres. Es para garantizar ejecución de codigo.
		 *	
		 *	Cuando ocurre una excepción:
		 *	1- Se crea un objeto de excepción:	FormatException (objeto en Heap)
		 *	2- Se interrumpe el flujo normal:  El programa no continua linea por linea.
		 *	3- El runtime busca un catch:  Va subiendo  por la pila de llamadas (stack)
		 *	4- Si encuentra un cath compatible, ejecuta ese bloque.
		 *	5- Si no encuentra. el programa se termina (crash)	
		*/
        try     //  Código
        {
            Console.WriteLine("Inicio");
            int x = int.Parse("abc");
            Console.WriteLine("Nunca se ejecuta");
        }
        catch      //  Manejo de error (Si llega a ocurrir)
        {
            Console.WriteLine("Error");
        }
        finally     //  Siempre se ejecuta
        {
            Console.WriteLine("Fin");
        }
        /*	Flujo Real:
         *	- try →        
         *	- ocurre excepción →
         *	- se detiene ejecución →- entra a catch →
         *	-ejecuta código
         *	++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
         *      Estructura de manejo:
         *  Try
         *  - contiene código que puede fallar.
         *  Cath
         *  - maneja la excepción.
         *  Finally
         *  - Se ejecuta Siempre, haya excepción o no, incluso si hay return.
         *  - Aunque no haya catch en caso de error, Finally se ejecuta antes del crash.
         *  - Si surge Crash o Error. se ejecuta aun así.
         *  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
         *      Tipos de Excepciones 
         *  Son Clases:
         *  - Exception (base)
         *  - FormatException   ->  Formato invalido.
         *  - NullReferenceException    -> Se usa algo es es null.
         *  - InvalidOperationException     -> Operación no valida en ese estado.
         *  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++  
		*/
            catch (FormatException)     // -> Solo detecta el tipo de Error
            catch (FormatException ex)     //  ->  Da acceso al objeto creado
         //  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            try
        {
            int.Parse("abc");
        }
        /*  Error de compilación.
         *  En C#, un "try" debe de tener un "catch" o un "finally" forzosamente.
         *  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++*/
        try
        {
            int.Parse("abc");
        }
        catch   //  ->  Forma validas:  catch  |   catch(Exception)  |  catch(Exception ex)  |  catch()  <-  Error, no es valido.
        {
        }
        /*  Resultado:  
         *  - Compila
         *  - Ejecuta
         *  - No muestra error
         *  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++*/
        try
        {
            int.Parse("abc");
        }
        catch (NullReferenceException)
        {
            Console.WriteLine("Error");
        }
        /*  Si se coloca un tipo incorrecto del error que surge.
         *  - Al ocurrir el error, NO se entra al catch y el programa se cae (Crash)
         *  - El catch solo captura ese tipo especifico.
         *  - Se debe de colocar en "catch" el tipo especifico de error que surja o dejarlo en blanco.
            ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++*/        
        try
        {
            return 1;
        }
        finally
        {
            return 2;
        }
        /*  Finally sobreescribe el "return"
         *  Regresa 2, no 1.

    }   
}
