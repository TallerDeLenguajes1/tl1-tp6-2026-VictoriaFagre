using System;
using System.Collections;
using System.Runtime.InteropServices.Marshalling;

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

//CalculadoraV1
int num1, num2, num;
string aux, pregu;

Console.Write("\n");
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
            Console.WriteLine($@"La suma de {num1} y de {num2} es igual a: {num}");
        break;

        case 2: 
            num = num1 - num2; 
            Console.WriteLine($@"La diferencia de {num1} y de {num2} es igual a: {num}");
        break;

        case 3: 
            num = num1 * num2;
            Console.WriteLine($@"El producto de {num1} y de {num2} es igual a: {num}");
        break;

        case 4: 
            num = num1 / num2;
            Console.WriteLine($@"La división de {num1} y de {num2} es igual a: {num}");
        break;
    }

    Console.WriteLine("¿Quiere seguir haciendo operaciones?");
    pregu = Console.ReadLine();

}while(pregu == "si" || pregu == "Si");


//uso de toString();
Console.WriteLine("Letra por letra de las cadenas concatenadas:");
foreach (var letra in concatenada)
{
    Console.WriteLine(letra);
}

Console.WriteLine("Ingrese la palabra a buscar en cadena:");
string palabra = Console.ReadLine().ToLower();

//con comillas simples porque se habla de char
string[] separada = concatenada.Split(' ', '.');
int cont = 0;
for (int i = 0; i < separada.Length; i++)
{
    if (string.Compare(separada[i].ToLower(), palabra)== 0)
    {
        cont++;
    }
}

Console.WriteLine(@$"Se repite/ocurre {cont} veces esa palabra en: {concatenada}");

string cadAux = concatenada.ToLower();
Console.Write("Cadena en minúsculas:"+cadAux +"\n");
cadAux = concatenada.ToUpper();
Console.Write("Cadena en mayúsculas:"+cadAux);


Console.WriteLine("\nIngrese una cadena: ");

string cadena = Console.ReadLine();

string[] arreglo = cadena.Split(' ', '.');
for (int i = 0; i < arreglo.Length; i++)
{
    Console.WriteLine(arreglo[i]);
}



Console.WriteLine("Ingrese una operacion con 2 numeros asi se resuelve:");
string operacion = Console.ReadLine();
string[] nums = operacion.Split('+','-','*','/');
char[] caracteresOperadores = { '+', '-', '*', '/' };
int posicionOperador = operacion.IndexOfAny(caracteresOperadores);

// Extraigo el operador usando esa posición exacta, con numeros cuenta cada num como posición
//no toma al numero completo como string por mas que este guardado así

string operador = operacion.Substring(posicionOperador, 1);

num1 = int.Parse(nums[0]);
num2 = int.Parse(nums[1]);

switch (operador)
{
    case "+":
        num = num1 + num2;
    break;
    
    case "-":
        num = num1 - num2;
    break;

    case "*":
        num = num1 * num2;
    break;

    case "/":
        num = num1 / num2;
    break;
}

Console.WriteLine(@$"La siguiente operación queda: {num1} {operador} {num2} = {num}");
