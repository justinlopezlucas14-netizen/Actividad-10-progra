using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, double> registroNotas = new Dictionary<string, double>
        {
            { "Carlos", 85 },
            { "Elena", 92 },
            { "Mario", 74 },
            { "Adriana", 100 }
        };

        Console.WriteLine("Sistema de Consulta de Notas");
        Console.Write("Ingrese el nombre del estudiante a consultar: ");
        string nombreInput = Console.ReadLine();

        if (registroNotas.ContainsKey(nombreInput))
        {
            double nota = registroNotas[nombreInput];
            Console.WriteLine($"\nLa nota de {nombreInput} es: {nota}");
        }
        else
        {
            Console.WriteLine($"\nError: El estudiante '{nombreInput}' no se encuentra registrado.");
        }

        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
}
