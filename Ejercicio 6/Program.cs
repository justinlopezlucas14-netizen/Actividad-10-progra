using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> estudiantes = new Dictionary<int, string>();
        estudiantes.Add(101, "Ana Martinez");
        estudiantes.Add(102, "Luis Garcia");
        estudiantes.Add(103, "Sofia Mendez");

        Console.WriteLine("Lista Inicial de Estudiantes");
        foreach (var est in estudiantes)
        {
            Console.WriteLine($"ID: {est.Key} | Nombre: {est.Value}");
        }

        int idAEliminar = 102;
        Console.WriteLine($"\nEliminando al estudiante con ID: {idAEliminar}...");

        if (estudiantes.Remove(idAEliminar))
        {
            Console.WriteLine("Registro eliminado con éxito.");
        }
        else
        {
            Console.WriteLine("El ID no fue encontrado.");
        }
        Console.WriteLine("\nLista Final de Estudiantes");
        foreach (var est in estudiantes)
        {
            Console.WriteLine($"ID: {est.Key} | Nombre: {est.Value}");
        }

        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
}
