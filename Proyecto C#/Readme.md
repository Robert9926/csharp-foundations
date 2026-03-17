# Explicación Simple "hola mundo" en C#

## Proposito

Un programa que muestra un "hola mundo" simple en C#, con las descripciones y comportamientos de cada función y linea.

## Alcance

Muestra en pantalla el texto "hola mundo", explica a detalle la función de cada estructura del programa y sintaxis.

## Estructura del Programa

Se usan los siguientes componentes:
|Componente| función | Relación |
|----------|---------|----------|
|`Using`|agrega namespaces para que el compilador busque| Se usan namespace como `System`|
|`System`|Un namespace que contiene clases,structs, etc.|Contiene la clase `Console`|
|`namespace`|agrupa tipos bajo un nombre para evitar colisiones de nombres|Sin relación explicita en este contexto|
|`class`|agrupar datos y comportamientos|contiene al metodo `main`|
|`static`|metodo que pertenece a la clase para no inicilizar un objeto previamente|aplicado en metodo `main`|
|`void`|Metodo que no retorna un valor|aplicado en metodo `main`|
|`string[] args`|parametros que recibe el metodo `main`|usados por el `runtime`|
|`Console`|Una clase que contiene metodos `static`|contiene el metodo `WriteLine`|
|`WriteLine`|Un metodo que tipo `static` para escribir texto en la salida estándar|Muestra el texto `Hola mundo`|

## Flujo de Ejecución

Inicia en el metodo `main`, despúes busca la clase `Console` en el namespace `System` y ejecuta el metodo `WriteLine` para pasar los parametros "hola mundo" y que el runtime los muestre en la consola de comandos.

## Entrada

El programa no recibe datos o parametros, solo muestra los parametros que ya tiene por defecto al momento de ejecutarse.

## Salida

Imprime un dato de tipo string[] y los muestra en la Terminal.

## Dependencias

Utiliza el `namespace`: `System`.

## Análisis Técnico

El compilador resuelve `Console` dentro del `namespace` llamado `System` para usar el metodo `WriteLine` despúes el runtime ejecuta el programa ya compilado.

## Conceptos Clave

- Compilador
- Runtime
- Namespace
- Clase
- Metodo
- Parametro

## Casos Limite

- Al eliminar `Using System`, el compilador marcara error ya que no podra encontrar la clase `Console` y no podra resolver el nombre completo.
- Al no volver `Static` al metodo `main` el runtime no puede usar un metodo de instancia como punto de entrada.
- Al cambiarle el nombre al metodo `main` el programa no sabra por donde debe de inicializar y marcara error el compilador.

## Variaciones

- Se puede colocar el nombre completo del namespace: `System`:
  `System.Console.WriteLine();`.
- Se puede cambiar el nombre de la variable del parametro del metodo `main` a igual que cambiar el tipo de variable por un `string`:
  `static void Main(string args) {}`.

## Conclusiones

- Aprendi sobre los `namespace`, como interactua el `using` con el compilador, todo debe de ir dentro de una clase, al igual que dentro o relacionado con un metodo llamado `main` para que pueda inicializar y funcionar.
- Aún no comprendo del todo como funciona el compilador, el runtime y el entorno de C#.
