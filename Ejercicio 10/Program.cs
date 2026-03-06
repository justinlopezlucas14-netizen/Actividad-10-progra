using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> inventario = new Dictionary<int, string>
        {
            { 1001, "Monitor 24 pulg" },
            { 1002, "Teclado Mecánico" },
            { 1003, "Mouse Gamer" },
            { 1004, "Auriculares Pro" }
        };

        Console.WriteLine("Inventario Actual");
        foreach (var item in inventario)
        {
            Console.WriteLine($"Código: {item.Key} | Producto: {item.Value}");
        }

        Console.Write("Ingrese el código del producto que desea eliminar: ");

        if (int.TryParse(Console.ReadLine(), out int codigoAEliminar))
        {
           
            if (inventario.Remove(codigoAEliminar))
            {
                Console.WriteLine($"\nÉxito: El producto con código {codigoAEliminar} ha sido eliminado.");
            }
            else
            {
                Console.WriteLine($"\nError: No se encontró ningún producto con el código {codigoAEliminar}.");
            }
        }
        else
        {
            Console.WriteLine("\nError: Debe ingresar un código numérico válido.");
        }
   
        Console.WriteLine("\nInventario Final");
        foreach (var item in inventario)
        {
            Console.WriteLine($"Código: {item.Key} | Producto: {item.Value}");
        }

        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
}
