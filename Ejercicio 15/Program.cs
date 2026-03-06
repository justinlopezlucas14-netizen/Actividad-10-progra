using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main()
    {
        Dictionary<int, string> empleados = new Dictionary<int, string>
        {
            { 101, "Carlos Pérez" },
            { 102, "Ana García" },
            { 103, "Roberto Gómez" },
            { 104, "Lucía Méndez" }
        };

        Console.WriteLine("Listado de Empleados con Formato");

        foreach (var emp in empleados)
        {
            Console.WriteLine($"ID: {emp.Key}  Nombre: {emp.Value}");
        }

        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
}