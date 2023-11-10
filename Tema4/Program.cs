using System;
class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingresa 10 múltiplos de 2");
        int[] arr = new int[10];    

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("Ingresa el valor número " + (i+1) + ": ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
            if (arr[i]%2 != 0)
            {
                Console.WriteLine("El número que ingresaste no es par");
                i--;
             
            }
        }
        for (int i = 0;i < arr.Length; i++)
        {
            Console.Write(arr[i] + " | ");
        }
        Console.WriteLine("");
        Console.Write("Presiona una tecla para acceder al menú");
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("1.- Ingresar valor");
        Console.WriteLine("2.- Buscar");
        Console.WriteLine("3.- Modificar");
        Console.WriteLine("4.- Eliminar");
        Console.WriteLine("5.- Recorrer");
        Console.WriteLine("6.- Salir");
    }
}