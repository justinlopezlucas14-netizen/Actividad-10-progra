using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> estudiantes = new Dictionary<string, int> {
            {"Juan", 20}, {"Maria", 22}, {"Pedro", 19}, {"Lucia", 21}, {"Elena", 23}
        };

        foreach (var item in estudiantes)
        {
            Console.WriteLine($"Nombre: {item.Key} - Edad: {item.Value}");
        }
    }
}