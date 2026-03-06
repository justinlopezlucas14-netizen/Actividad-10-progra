using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> productos = new Dictionary<int, string>
        {
            { 501, "Laptop Dell" },
            { 502, "Mouse Inalámbrico" },
            { 503, "Teclado Mecánico" },
            { 504, "Monitor 27'" }
        };

        Console.WriteLine("Lista de Productos Almacenados");

        foreach (KeyValuePair<int, string> producto in productos)
        {
            Console.WriteLine($"Código: {producto.Key} Nombre: {producto.Value}");
        }

        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
}