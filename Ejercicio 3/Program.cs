using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, double> notas = new Dictionary<string, double>();
        notas.Add("Ana", 9.5);
        notas.Add("Luis", 8.2);

        string buscar = "Ana";
        Console.WriteLine($"La nota de {buscar} es: {notas[buscar]}");
    }
}
