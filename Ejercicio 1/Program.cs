using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> estudiantes = new Dictionary<int, string>();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("1. Registrar 3 Estudiantes");
            Console.WriteLine("2. Mostrar Nombre por ID");
            Console.WriteLine("3. Salir");
            Console.Write("\nSeleccione una opción: ");
            string op = Console.ReadLine();

            if (op == "3") break;

            if (op == "1")
            {
                for (int i = 1; i <= 3; i++)
                {
                    Console.WriteLine($"\nRegistro #{i}:");
                    Console.Write("Ingrese ID: ");
                    int id = int.Parse(Console.ReadLine());

                    Console.Write("Ingrese Nombre: ");
                    string nombre = Console.ReadLine();
                
                    estudiantes[id] = nombre;
                    Console.WriteLine("Guardado");
                }

                Console.WriteLine("\nSe han completado los 3 registros correctamente.");
                Console.WriteLine("Presione cualquier tecla para volver al menú...");
                Console.ReadKey();
            }
            else if (op == "2")
            {
                if (estudiantes.Count == 0)
                {
                    Console.WriteLine("\nEl registro está vacío. Primero use la opción 1.");
                }
                else
                {
                    Console.Write("\nIngrese ID a buscar: ");
                    int idB = int.Parse(Console.ReadLine());

                    if (estudiantes.ContainsKey(idB))
                    {
                        Console.WriteLine("Resultado Nombre: " + estudiantes[idB]);
                    }
                    else
                    {
                        Console.WriteLine("Error: El ID ingresado no existe.");
                    }
                }
                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}
