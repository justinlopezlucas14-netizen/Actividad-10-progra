using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> ciudades = new Dictionary<int, string> {
            {502, "Guatemala"},
            {34, "España"},
            {57, "Colombia"},
            {52, "México"},
            {51, "Perú"}
        };

        Console.WriteLine("Buscador de Ciudades por Código");
        Console.Write("Por favor, ingrese el código de área: ");

        if (int.TryParse(Console.ReadLine(), out int codigo))
        {
            if (ciudades.ContainsKey(codigo))
            {
                string pais = ciudades[codigo];
                Console.WriteLine($"\nResultado: El código {codigo} pertenece a {pais}.");
            }
            else
            {
                Console.WriteLine($"\nLo sentimos, el código {codigo} no se encuentra en nuestra base de datos.");
            }
        }
        else
        {
            Console.WriteLine("\nError: Debe ingresar un número válido.");
        }

        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
}