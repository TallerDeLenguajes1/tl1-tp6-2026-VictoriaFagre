# Anotaciones de Tp 6 CalculadoraV2

_Otra forma de truncar un número con float y no necesariamente con (int)num_
**float miFloat = 7.89f;**
**float truncado = MathF.Truncate(miFloat); // Resultado: 7.0f**

# Anotaciones de Tp 6 CalculadoraV1
_La única forma de poder usar números como enteros en C# es haciendo un parseo:_

**int num;**
**string cadena = Console.ReadLine();**
**int.TryParse(cadena, out num);**

*Lo que hace es asignar el numero que escribí en la cadena al tipo de dato entero definido para num*