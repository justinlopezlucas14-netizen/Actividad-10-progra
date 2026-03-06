using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, double> curso = new Dictionary<string, double>();
        string opcion = "";

        while (opcion != "4")
        {
            Console.WriteLine("SISTEMA DE CONTROL DE NOTAS");
            Console.WriteLine("1. Ingresar estudiante y nota");
            Console.WriteLine("2. Modificar nota existente");
            Console.WriteLine("3. Mostrar listado de notas");
            Console.WriteLine("4. Salir");
            Console.Write("Opción: ");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Write("Nombre del estudiante: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Nota: ");
                    if (double.TryParse(Console.ReadLine(), out double nota))
                    {
                        curso[nombre] = nota; 
                        Console.WriteLine("Datos guardados.");
                    }
                    break;

                case "2":
                    Console.Write("Nombre del estudiante a modificar: ");
                    string nomMod = Console.ReadLine();
                    if (curso.ContainsKey(nomMod))
                    {
                        Console.Write($"Nueva nota para {nomMod}: ");
                        curso[nomMod] = double.Parse(Console.ReadLine());
                        Console.WriteLine("Nota actualizada correctamente.");
                    }
                    else
                    {
                        Console.WriteLine("Error: El estudiante no existe.");
                    }
                    break;

                case "3":
                    Console.WriteLine("Registro de Notas");
                    foreach (var est in curso) Console.WriteLine($"{est.Key}: {est.Value}");
                    break;
            }
        }
    }
}