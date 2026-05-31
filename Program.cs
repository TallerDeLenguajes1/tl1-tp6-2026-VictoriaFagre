using System;

// Console.WriteLine("Hello, World!");
// int a;
// int b;
// a=10;
// b=a;
// Console.WriteLine("valor de a:"+a);
// Console.WriteLine("valor de b:"+b);

//CalculadoraV1
int num1, num2, num;
string aux, pregu;

do
{
    Console.WriteLine("----------------MENÚ INTERACTIVO-----------------");
    Console.WriteLine("||ELEGIR UNA OPCIÓN|| 1: Suma| 2: Resta | 3: Multiplicación | 4: División:");
    aux = Console.ReadLine();
    int.TryParse(aux,out num);

    Console.WriteLine("Ingrese num1:");
    aux = Console.ReadLine();
    //a num1 le pongo el valor de aux
    int.TryParse(aux,out num1);

    Console.WriteLine("Ingrese num2:");
    aux = Console.ReadLine();

    int.TryParse(aux, out num2);

    switch (num){
        case 1: 
            num = num1 + num2;
        break;

        case 2: 
        num = num1 - num2; 
        break;

        case 3: 
            num = num1 * num2;
        break;

        case 4: 
            num = num1 / num2;
        break;
    }

    Console.WriteLine("La operación dió: "+num);

    Console.WriteLine("¿Quiere seguir haciendo operaciones?");
    pregu = Console.ReadLine();

}while(pregu == "si" || pregu == "Si");

//CalculadoraV2

double numAux = (double)num;
do
{
    Console.WriteLine("Ingrese un número:");
    string cadena = Console.ReadLine();
    double.TryParse(cadena, out numAux);
}while(num < 0);

double resultado;
resultado = Math.Abs(numAux);
Console.WriteLine("Valor Absoluto:"+resultado);
resultado = Math.Pow(numAux,2);
Console.WriteLine("Potencia doble:"+resultado);
resultado = Math.Sin(numAux);
Console.WriteLine("Seno del num:"+resultado);
resultado = Math.Cos(numAux);
Console.WriteLine("Coseno del num:"+resultado);
resultado = Math.Sqrt(numAux);
Console.WriteLine("Raíz cuadrada del num:"+resultado);
resultado = (int)numAux;
Console.WriteLine("Parte entera de un float:"+resultado);

// int num1, num2;
// string aux; ya que quedan redundantes por la inicialización en un ejercicio anterior


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