using System;
/* 
 *      using: 
 * agrega un namespace a la lista de lugares donde el compilador buscará 
 * nombres no completamente calificados  
 * El compilador ve: Console y piensa: ¿Console está en el namespace actual? 
 * si no → ¿Console está en System?  Encuentra: System.Console y resuelve el nombre.
 * 
 *      System:
 * Es un namespace, estos contienen tipos: (principalmente clases, structs, interfaces, etc).
 * No contiene directamente metodos ni datos.
 * dentro tiene la clase llamada "console" y esta clase tiene el metodo "WriteLine".
 * 
 */

namespace MiPrimerPrograma
/* 
 * No es necesario u obligatorio tener o crear un namespace para crear clases.
 * Aunque se utiliza para evitar colisiones de nombres por ejemplo:
 * System.Console  ->  MiProyecto.Console
 * Usados para organizar al momento de tener muchas clases o clases con
 * nombres iguales o similares. la función es para tener mayor organización.
 * 
*/
{
    class Program
/*
 *      Class
 * Una clase llamada "Program", es una estructura que agrupa datos y comportamientos.
 * Define que puede hacer algo y que informacíón tiene.
*/
    {
        static void Main(string[] args)
        /*
         *          Static
         *      Cuando un metodo es "static", significa que el metodo pertenece a la clase y no a una instancia (objeto) de la clase.
         *      Para usar un metodo que no es "static", es necesario primero inicializar el objeto y luego su(s) metodo(s). Aqui "main" es static,
         *      porque cuando el programa inicia no existe ningún objeto aún.
         *      
         *          Void   
         *      Es un tipo de metodo, significa o se usa que ese metodo no devuelve ningún valor, es un metodo
         *      que ejecuta una acción, pero no devuelve un valor.
         *      
         *          Main
         *      Es el nombre del metodo, pero tambien es la FIRMA del método, es el metodo de entrada del programa. 
         *      el runtime de C#, busca un metodo de entrada llamado "main" que es por donde iniciara la ejecución del programa.
         *      Por ejemplo: 
         *      -> static void Main() 
         *      -> static void Main(string[] args)
         *      -> static int Main()
         *      
         *          String []
         *      Es un "array" de tipo "string", es un tipo de referencia, una estructura que almacena múltiples valores del mismo tipo. 
         *      Un arreglo de Strings. Una colección de cadenas de texto. 
         *      Puede haber varios tipos de array, como  de int, double, caracter, etc.
         *      
         *          Args
         *      Es el nombre de la varible que tiene como parametro el metodo "main". y esta variable es de tipo "array".
         *      osea "string[]". Esta variable llamada "args" no es una palabra reservada, es solo por convención. podria 
         *      llamarse de otro tipo y funcionaria igual.
         *      
         *          ( String[] args ) 
         *      Es un parametro del metodo "main", un parametro es una variable(s) que recibe datos cuando el método es llamado.
         *      En este caso el runtime de C# que es Common Languaje Runtime (CLR) ejecuta el programa y luego llama al 
         *      metodo "Main", despues aquello que se escribio en la Terminal/linea de comandos se pasa como argumento en la variable "args".
         *      Compilador =/= Runtime
         *          compilador:
         *      traduce código y resuelve nombres (using, types, etc.)
         *           runtime (CLR):
         *      ejecuta el programa ya compilado
         * 
        */
        {
            Console.WriteLine("Hola mundo");
/*            
             *      Console 
             * Es una clase que pertenece al namespace "system", el nombre completo es: System.Console.
             * 
             *      WriteLine
             * Es un metodo de tipo "static" de la clase "console", por eso se puede llamar sin necesidad de crear un objeto antes.
             * Este metodo en especifico, escribe testo en la salida estándar "console ouput" y añade un salto de linea al final.
             * por eso se llama (writeline -> escribe la linea).
             * 
             *      ("hola mundo")
             * Esto es un parametro que se le pasa al método, es un parametro de tipo "string", entonces WriteLine recibe un parametro 
             * de tipo String.
             * 
             *      ;
             * Indica el fin de una instrucción, en C# cada statement termina con ";".
             * 
*/            
        }
    }
}