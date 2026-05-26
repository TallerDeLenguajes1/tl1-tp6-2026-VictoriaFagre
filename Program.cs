// Console.WriteLine("Hello, World!");
// int a;
// int b;
// a=10;
// b=a;
// Console.WriteLine("valor de a:"+a);
// Console.WriteLine("valor de b:"+b);

using System;

double num;
do
{
    Console.WriteLine("Ingrese un número:");
    string cadena = Console.ReadLine();
    double.TryParse(cadena, out num);
}while(num < 0);

double resultado;
resultado = Math.Abs(num);
Console.WriteLine("Valor Absoluto:"+resultado);
resultado = Math.Pow(num,2);
Console.WriteLine("Potencia doble:"+resultado);
resultado = Math.Sin(num);
Console.WriteLine("Seno del num:"+resultado);
resultado = Math.Cos(num);
Console.WriteLine("Coseno del num:"+resultado);
resultado = Math.Sqrt(num);
Console.WriteLine("Raíz cuadrada del num:"+resultado);
resultado = (int)num;
Console.WriteLine("Parte entera de un float:"+resultado);

int num1, num2;
string aux;

do
{
    Console.WriteLine("Ingrese un num1");
    aux = Console.ReadLine();
    int.TryParse(aux,out num1);

    Console.WriteLine("Ingrese un num2");
    aux = Console.ReadLine();
    int.TryParse(aux,out num2);
}while(num1 == num2);

if (num1 > num2){
    Console.WriteLine("El mayor de los números es:"+num1);
    Console.WriteLine("El menor de los números es:"+num2);
}
else
{
    Console.WriteLine("El mayor de los números es:"+num2);
    Console.WriteLine("El menor de los números es:"+num1);
}