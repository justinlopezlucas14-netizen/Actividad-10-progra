using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, double> notas = new Dictionary<string, double>
        {
            { "Juan", 85 },
            { "Maria", 92 },
            { "Pedro", 78 },
            { "Ana", 88},
            {"Luis",90},
        };

        double sumaTotal = 0;

        foreach (double nota in notas.Values)
        {
            sumaTotal += nota;
        }

        double promedio = sumaTotal / notas.Count;

        Console.WriteLine("Cálculo de Promedio");
        Console.WriteLine($"Total de estudiantes: {notas.Count}");
        Console.WriteLine($"Suma de notas: {sumaTotal}");
        Console.WriteLine($"El promedio general es: {promedio:F2}");

        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
}