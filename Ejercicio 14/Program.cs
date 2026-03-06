using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> ciudades = new Dictionary<string, string>
        {
            { "GUA", "Guatemala" },
            { "MEX", "México" },
            { "ESP", "España" },
            { "ARG", "Argentina" }
        };

        Console.WriteLine("Visualización de Datos Separados ");

        Console.Write("Claves del diccionario: ");
        foreach (string clave in ciudades.Keys)
        {
            Console.Write($"[{clave}] ");
        }

        Console.Write("Valores del diccionario: ");
        foreach (string valor in ciudades.Values)
        {
            Console.Write($"{valor}, ");
        }

        Console.WriteLine("\n\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
}