using System;

// Console.WriteLine("Hello, World!");
// int a;
// int b;
// a=10;
// b=a;
// Console.WriteLine("valor de a:"+a);
// Console.WriteLine("valor de b:"+b);

//using System;
//pongo using System para que no use System.DateTime y si use DateTime directamente
// Console.WriteLine("Ingrese un texto: ");
// string cadena = Console.ReadLine();
// int num;
// // 'num' recibe el valor numérico y 'resultado' será verdadero.
// bool resultado = int.TryParse(cadena,out num);

// if (resultado && num > 0)
// {
//     Console.WriteLine("Valor de cadena pasado a númerico: " +num);
// }
// else
// {
//     Console.WriteLine("Es un string no un número");   
// }



//Ejercicio 4
Console.WriteLine("Ingrese una 1era cadena de texto:");
string linea1 = Console.ReadLine();
int longitud = linea1.Length;

Console.WriteLine($"La longitud de la cadena es: {longitud}");

Console.WriteLine("Ingrese una 2da cadena de texto:");
string linea2 = Console.ReadLine();

//solo para imprimir 
Console.WriteLine("Cadenas concatenadas: "+$@"{linea1} {linea2}");

//para concatenarla en una variable string
string concatenada = linea1 +" "+ linea2;
longitud = concatenada.Length;

// inicia la busqueda en posición 0 y toma 5 caracteres
string resultado = concatenada.Substring(0,5);
Console.Write("Subcadena: "+resultado);

