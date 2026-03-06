using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> productos = new Dictionary<string, string>();
        string clave = "P001";
        string nombre = "Laptop";

        if (productos.ContainsKey(clave))
        {
            productos.Add(clave, nombre);
            Console.WriteLine("Producto agregado con éxito.");
        }
        else
        {
            Console.WriteLine("Error: La clave ya existe.");
        }
    }
}