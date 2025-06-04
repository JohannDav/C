// See https://aka.ms/new-console-template for more information

using System.Diagnostics.CodeAnalysis;
using System.Transactions;
/*
    Crea un programa que registre una cantidad de n calificaciones (no debe pedir el numero) 
    y que despliegue el promedio una vez se le solicite terminar el proceso
    sol propuesta por Quirino
        *Falta validar los datos :,(
*/
int cal = 0;
int prom = 0;
int suma = 0;
int aux = 0;
bool salir = false;
int ingresar = 0;

do
{
    do
    {
        Console.WriteLine("Ingrese una calificacion entre 0 y 10");
        cal = Convert.ToInt32(Console.ReadLine());


    }
    while (cal <= 0 && cal >= 10);
    suma = cal + suma;
    aux = aux + 1;
    Console.Clear();
    Console.WriteLine("Ingresar otra calificacion?");
    Console.WriteLine("1 Si");
    Console.WriteLine("2 No");
    ingresar = Convert.ToInt32(Console.ReadLine());

    if (ingresar == 2)
    {
        prom = suma / aux;
        salir = true;
    }
    
}
while (salir == false);

Console.Clear();
Console.WriteLine("Con un total de: " + aux + " calificaciones, el promedio obtenido fue de: " + prom);