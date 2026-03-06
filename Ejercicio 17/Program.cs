using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> inventario = new Dictionary<int, string>();
        string opcion = "";

        while (opcion != "4")
        {
            Console.WriteLine("\n1. Agregar 2. Eliminar 3. Mostrar 4. Salir");
            opcion = Console.ReadLine();

            if (opcion == "1")
            {
                Console.Write("ID: "); int id = int.Parse(Console.ReadLine());
                Console.Write("Producto: "); string p = Console.ReadLine();
                inventario[id] = p;
            }
            else if (opcion == "2")
            {
                Console.Write("ID a eliminar: "); int id = int.Parse(Console.ReadLine());
                inventario.Remove(id);
            }
            else if (opcion == "3")
            {
                foreach (var item in inventario) Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
