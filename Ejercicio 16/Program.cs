using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> estudiantes = new Dictionary<int, string>();
        string opcion = "";

        while (opcion != "3")
        {
            Console.WriteLine("\nMENÚ DE ESTUDIANTES");
            Console.WriteLine("1. Agregar estudiante");
            Console.WriteLine("2. Mostrar todos los estudiantes");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Write("Ingrese el número de carné (ID): ");
                    if (int.TryParse(Console.ReadLine(), out int id))
                    {
                        if (!estudiantes.ContainsKey(id))
                        {
                            Console.Write("Ingrese el nombre completo: ");
                            string nombre = Console.ReadLine();
                            estudiantes.Add(id, nombre);
                            Console.WriteLine("¡Estudiante agregado con éxito!");
                        }
                        else
                        {
                            Console.WriteLine("Error: Ese número de carné ya existe.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error: El carné debe ser un número.");
                    }
                    break;

                case "2":
                    Console.WriteLine("\nLista de Estudiantes Registrados");
                    if (estudiantes.Count == 0)
                    {
                        Console.WriteLine("El diccionario está vacío.");
                    }
                    else
                    {
                        foreach (var est in estudiantes)
                        {
                            Console.WriteLine($"ID: {est.Key} Nombre: {est.Value}");
                        }
                    }
                    break;

                case "3":
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción no válida, intente de nuevo.");
                    break;
            }
        }
    }
}
