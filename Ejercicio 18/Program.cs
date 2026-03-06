using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Diccionario de usuarios (Usuario - Correo)
        Dictionary<string, string> usuarios = new Dictionary<string, string>();
        string opcion = "";

        while (opcion != "3")
        {
            Console.WriteLine("SISTEMA DE REGISTRO");
            Console.WriteLine("1. Registrar nuevo usuario");
            Console.WriteLine("2. Ver usuarios registrados");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = Console.ReadLine();

            if (opcion == "1")
            {
                Console.Write("Ingrese nombre de usuario: ");
                string user = Console.ReadLine().ToLower();

                if (usuarios.ContainsKey(user))
                {
                    Console.WriteLine("Error: El nombre de usuario ya existe. Elija otro.");
                }
                else
                {
                    Console.Write("Ingrese correo electrónico: ");
                    string correo = Console.ReadLine();
                    usuarios.Add(user, correo);
                    Console.WriteLine("¡Usuario registrado exitosamente!");
                }
            }
            else if (opcion == "2")
            {
                Console.WriteLine("Lista de Usuarios");
                foreach (var u in usuarios) Console.WriteLine($"User: {u.Key} Email: {u.Value}");
            }
        }
    }
}