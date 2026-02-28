using System;

class Longitud
{
    static void Main()
    {
        Console.Write("Escribe algo: ");
        string entrada = Console.ReadLine();
        Console.WriteLine($"La longitud es de {CalcularLargo(entrada)} caracteres.");
    }

    static int CalcularLargo(string texto) => texto.Length;
}
