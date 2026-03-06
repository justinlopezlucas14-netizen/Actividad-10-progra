using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> empleados = new Dictionary<int, string>
        {
            { 201, "Pedro Armas" },
            { 202, "Luisa Cano" },
            { 203, "Roberto Sosa" }
        };

        Console.WriteLine("Antes de la modificación");
        foreach (var emp in empleados) Console.WriteLine($"ID: {emp.Key} - Nombre: {emp.Value}");

        int idAModificar = 202;
        string nuevoNombre = "Luisa Cano de Pérez";


        empleados[idAModificar] = nuevoNombre;

        Console.WriteLine($"\nDespués de modificar al ID {idAModificar} ");
        foreach (var emp in empleados) Console.WriteLine($"ID: {emp.Key} - Nombre: {emp.Value}");

        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
}