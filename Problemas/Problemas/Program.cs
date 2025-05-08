using System.Diagnostics.Tracing;
using System.Timers;

internal class Problemas
{
    private static void Main(string[] args)
    {
        /* 
        Problema 1: Verificar si un numero es positivo
        Problema 2: Mostrar el día de la semana segun el numero del 1 al 7
        Problema 3: Imprimir los numeros del 1 al 1,000,000
        Problema 4: Leer numeros hasta que el usuario escriba 0. Al final mostrar "Adios"
        * Debemos utilizar un menú para que el usuario escoja cual programa ejecutar
        */

        bool salir = false;

        while(!salir)
        {
            Console.WriteLine("");
            Console.WriteLine("Escoge una opción");
            Console.WriteLine("1 Verificar si un numero es positivo");
            Console.WriteLine("2 Mostrar el día de la semana segun el numero del 1 al 7");
            Console.WriteLine("3 Imprimir los numeros del 1 al 1,000,000");
            Console.WriteLine("4 Leer numeros hasta que el usuario escriba 0. Al final mostrar Adios");
            Console.WriteLine("5 Salir");
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                //Este switch nos comienza las opciones donde cada caso es una opcion
                case 1: //Mostrar si un numero es positivo o negativo (mencionar si es el cero)
                    Console.Clear();
                    Console.WriteLine("Escogiste la opcion 1");
                    Console.WriteLine("");
                    Console.WriteLine("Teclea un número para saber si es positivo o negativo");
                    int num = Convert.ToInt32(Console.ReadLine());


                    if(num < 0)
                    {
                        Console.WriteLine("El numero es negativo");

                    }
                    else if (num == 0)
                    {
                        Console.WriteLine("Ese numero es el cero");
                    }
                    else
                    {
                        Console.WriteLine("Es positivo");
                    }
                    break;

                case 2: //Mostrar el dia segun el numero
                    Console.Clear();
                    Console.WriteLine("Escogiste la opcion 2");
                    Console.WriteLine("Escoje un numero del 1 al 7 para saber que día de la semana es");

                    int dia = Convert.ToInt32(Console.ReadLine());

                    switch (dia)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Lunes");
                            break;

                        case 2:
                            Console.Clear();
                            Console.WriteLine("Martes");
                            break;

                        case 3:
                            Console.Clear();
                            Console.WriteLine("Miercoles");
                            break;

                        case 4:
                            Console.Clear();
                            Console.WriteLine("Juebebes");
                            break;

                        case 5:
                            Console.Clear();
                            Console.WriteLine("Viernes de alcohol");
                            break;

                        case 6:
                            Console.Clear();
                            Console.WriteLine("Sábado de cruda");
                            break;

                        case 7:
                            Console.Clear();
                            Console.WriteLine("Domingo de limpieza");
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine("Solo hay 7 días en la semana w");
                            break;
                    }

                    break;

                case 3: //Mostrar los numeros hasta el 1,000,000
                    Console.Clear();
                    Console.WriteLine("Escogiste la opcion 3");

                    for(int  i = 0; i <= 1000000; i++)
                    {
                        Console.WriteLine("" + i);
                    }


                    break;

                case 4://Leer numeros hasta que el usuario escriba el 0
                    Console.Clear();
                    Console.WriteLine("Elegiste la opcion 4");
                    Console.WriteLine("Escoje un numero para saber si es la clave");

                    int propuesta = Convert.ToInt32(Console.ReadLine());

                    while(propuesta != 0)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("El numero " + propuesta + " no es la clave" );
                        Console.WriteLine("Escoje otro numero");
                        propuesta = Convert.ToInt32(Console.ReadLine());
                        
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Felicidades el numero " + propuesta + " era la clave");
                    Console.WriteLine("Adiós");

                    break;

                case 5:
                    Console.Clear();
                    Console.WriteLine("Adiós");
                    salir = true;
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Aprende a leer w");
                    break;
            }
        }
    }
}