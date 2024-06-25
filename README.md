En C#, string es un tipo por referencia. Esto significa que cuando asignas una cadena a una variable string, estás manejando una referencia a la ubicación en memoria donde se almacena la cadena, en lugar de una copia directa de los datos de la cadena.

Las secuencias de escape que tiene el tipo string en C# son las siguientes:

\' - Comilla simple (apóstrofe)
\" - Comilla doble
\\ - Barra invertida
\0 - Carácter nulo
\a - Timbre (alerta)
\b - Retroceso
\f - Avance de página
\n - Nueva línea
\r - Retorno de carro
\t - Tabulación horizontal
\v - Tabulación vertical

Cuando utilizas el carácter @ antes de una cadena de texto (@"..."), estás creando una cadena verbatim. En una cadena verbatim, los caracteres de escape no tienen ningún significado especial, lo que significa que puedes incluir caracteres como \ sin necesidad de escaparlos. Por ejemplo:

string path = @"C:\Directorio\Archivo.txt";

El carácter $ se utiliza para definir una cadena interpolada ($"..."). Una cadena interpolada permite incrustar expresiones dentro de la cadena, precediendo la cadena con el carácter $ y colocando las expresiones dentro de llaves {}. Por ejemplo:

string nombre = "Juan";
string mensaje = $"Hola, {nombre}!";