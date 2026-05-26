// Console.WriteLine("Hello, World!");
// int a;
// int b;
// a=10;
// b=a;
// Console.WriteLine("valor de a:"+a);
// Console.WriteLine("valor de b:"+b);

using System;
//pongo using System para que no use System.DateTime y si use DateTime directamente
Console.WriteLine("Ingrese un texto: ");
string cadena = Console.ReadLine();
int num;
// 'num' recibe el valor numéricp y 'resultado' será verdadero.
bool resultado = int.TryParse(cadena,out num);

if (resultado && num > 0)
{
    Console.WriteLine("Valor de cadena pasado a númerico: " +num);
}
else
{
    Console.WriteLine("Es un string no un número");   
}
