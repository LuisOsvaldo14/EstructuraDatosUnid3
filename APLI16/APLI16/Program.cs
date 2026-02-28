using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main()
    {
        var miTupla = (10, "Hola", true, 5.5);

        ITuple t = miTupla;

        Console.WriteLine($"La tupla tiene {t.Length} elementos.");
    }
}
