﻿using System;
using System.ComponentModel.Design;
using System.Numerics;

class program
{
    static void Main(string[] args)
    {
        Menu:
        Console.Write("-------Elige una opción (1-6): -------");
        Console.WriteLine("");
        Console.WriteLine("1.- Ingresar valor");
        Console.WriteLine("2.- Buscar");
        Console.WriteLine("3.- Modificar");
        Console.WriteLine("4.- Eliminar");
        Console.WriteLine("5.- Recorrer");
        Console.WriteLine("6.- Salir");

        int[] arr = new int[10];
        int opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:

                int tam=arr.Count();
                //variable aux i++ if i == 10 break cwl
                Console.WriteLine(tam);
                bool vectorLleno = false;
                if (tam ==10){ 
                    vectorLleno=true;
                }

                // Mostrar mensaje si el vector está lleno
                if (vectorLleno)
                {
                    Console.WriteLine("Vector lleno. No es posible ingresar más valores.");
                    goto Menu;
                    
                }

                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine("Ingresa el valor número " + (i + 1) + ": ");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                    if (arr[i] % 2 != 0 && arr[i] != 0)
                    {
                        Console.WriteLine("El número que ingresaste no es par");
                        i--;

                    }
                    foreach (var item in arr)
                    {
                        Console.Write(item + " | ");
                      
                    }
                    Console.WriteLine("");
                }
                    
               

            break;
            case 2:
                // Agrega aquí la lógica para la opción 2 (Buscar)
                break;
            case 3:
                // Agrega aquí la lógica para la opción 3 (Modificar)
                break;
            case 4:
                // Agrega aquí la lógica para la opción 4 (Eliminar)
                break;
            case 5:

                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " | ");
                }
                break;
            case 6:
                Console.WriteLine("Saliendo del programa...");
                break;
            default:
                Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                break;
        }
    }
}
  