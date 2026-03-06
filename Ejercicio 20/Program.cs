using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, (string Nombre, int Edad, string Carrera)> registroAlumnos =
            new Dictionary<int, (string Nombre, int Edad, string Carrera)>();

        Console.WriteLine("Registro de 3 Estudiantes");

        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine($"\nDatos del estudiante #{i}:");

            Console.Write("Ingrese número de carné: ");
            int carne = int.Parse(Console.ReadLine());

            Console.Write("Ingrese nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese edad: ");
            int edad = int.Parse(Console.ReadLine());

            Console.Write("Ingrese carrera: ");
            string carrera = Console.ReadLine();

            registroAlumnos.Add(carne, (nombre, edad, carrera));
        }

        Console.WriteLine("Mostrando toda la información");

        foreach (var item in registroAlumnos)
        {
            Console.WriteLine($"Carné: {item.Key}");
            Console.WriteLine($"Nombre: {item.Value.Nombre}");
            Console.WriteLine($"Edad: {item.Value.Edad} años");
            Console.WriteLine($"Carrera: {item.Value.Carrera}");
        }

        Console.WriteLine("\nPresione cualquier tecla para finalizar...");
        Console.ReadKey();
    }
}