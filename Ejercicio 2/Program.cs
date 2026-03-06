using System;
using System.Collections.Generic;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> productos = new Dictionary<int, string>();
            productos.Add(1010, "Laptop");
            productos.Add(1020, "Mouse");
            productos.Add(1030, "Teclado");

            foreach (KeyValuePair<int, string> p in productos)
            {
                Console.WriteLine("Código: " + p.Key + " - Producto: " + p.Value);
            }
            Console.ReadKey();
        }
    }
}
