// 
 
using System;

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
