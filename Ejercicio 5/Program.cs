using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> cuentas = new Dictionary<string, string>
        {
            { "admin", "password123" },
            { "juan_perez", "guatemala2024" },
            { "maria_g", "flores99" },
            { "usuario_invitado", "invitado" }
        };

        Console.WriteLine("Buscador de Credenciales");
        Console.Write("Ingrese el nombre de usuario que desea buscar: ");
        string usuarioABuscar = Console.ReadLine();

        if (cuentas.ContainsKey(usuarioABuscar))
        {
            string pass = cuentas[usuarioABuscar];
            Console.WriteLine($"\nUsuario encontrado: {usuarioABuscar}");
            Console.WriteLine($"Contraseña: {pass}");
        }
        else
        {
            Console.WriteLine("\nError: El usuario ingresado no existe en el sistema.");
        }

        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
}
