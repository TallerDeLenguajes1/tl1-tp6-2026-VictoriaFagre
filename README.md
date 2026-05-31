# Anotaciones de Tp 6  ejercicio 4
**Responder las siguientes preguntas en el archivo readme.md:**
## ¿String es una tipo por valor o un tipo por referencia?

*String es un tipo de dato por referencia*
_Una variable de tipo de referencia no contiene la instancia directamente, sino una referencia a la ubicación en memoria donde se encuentra la instancia del tipo. Por defecto, al asignar una variable de tipo referencia a otra, al pasarla como argumento a un método o al devolverla como resultado, lo que se copia es la referencia a la instancia, no la instancia en sí misma._

¿Qué secuencias de escape tiene el tipo string?
*Una secuencia de escape en C# sirve para insertar caracteres especiales que no se pueden escribir directamente en el código fuente.Las secuencias de escape que tiene el tipo string son las siguientes:*

*Secuencia de escape	Nombre de carácter	Codificación Unicode*
*\'	                      Comilla simple	        0x0027*
*\"	                       Comilla doble	        0x0022*
*\\	                      Barra invertida	        0x005C*
*\0	                            Nulo	            0x0000*
*\a	                           Alerta	            0x0007*
*\b	                          Retroceso	            0x0008*
*\e	                           Escapar	            0x001B*
*\f	                        Avance de página	    0x000C*
*\n	                        Nueva línea	            0x000A*
*\r                      	Retorno de carro	    0x000D*
*\t	                    Tabulación horizontal	    0x0009*
*\v	                    Tabulación vertical	        0x000B*
*\u	Secuencia de escape Unicode (UTF-16)	        \uHHHH (intervalo: 0000 - FFFF; ejemplo: \u00E7 = "ç")*
*\U	Secuencia de escape Unicode (UTF-32)	        \U00HHHHHH (intervalo: 000000 - 10FFFF; ejemplo: \U0001F47D = *"👽")*
*\x	Secuencia de escape Unicode similar a "\u" excepto con longitud variable	\xH[H][H][H] (intervalo: 0 - FFFF; ejemplo: \x00E7 or \x0E7 or \xE7 = "ç")*

## ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?
*Ocurre la interpolación de cadenas textuales mediante la sintaxis de @$ o $@:*

*var jh = (firstName: "Jupiter", lastName: "Hammon", born: 1711, published: 1761);*
*Console.WriteLine($@"{jh.firstName} {jh.lastName}*
    *was an African American poet born in {jh.born}.");*
*Console.WriteLine(@$"He was first published in {jh.published}*
*at the age of {jh.published - jh.born}.");*

*// Output:*
*// Jupiter Hammon*
*//     was an African American poet born in 1711.*
*// He was first published in 1761*
*// at the age of 50.*

**IMPORTANTE: abrir siempre un folder para abrir program.cs o cualquier "cosa".cs**
**Si no me sale un error al no posicionarme bien en las carpetas para depurar/correr**

### Formas de usar .Substring():
_Ej 1:_
_string texto = "Hola Mundo";_
_// Corta desde la posición 5 hasta el final_
_string resultado = texto.Substring(5);_ 

_Console.WriteLine(resultado); // Resultado: "Mundo"_

_Ej 2:_
_string texto = "Hola Mundo";_
_// Inicia en la posición 0 y toma 4 caracteres_
_string resultado = texto.Substring(0, 4);_

_Console.WriteLine(resultado); // Resultado: "Hola"_


