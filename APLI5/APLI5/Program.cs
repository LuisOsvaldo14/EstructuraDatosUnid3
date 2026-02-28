using System;
using System.Linq;

class Vocales
{
    static void Main()
    {
        Console.Write("Escribe una frase: ");
        string texto = Console.ReadLine();
        Console.WriteLine($"Número de vocales: {ContarVocales(texto)}");
    }

    static int ContarVocales(string cadena)
    {
        string vocales = "aeiouAEIOUáéíóúÁÉÍÓÚ";
        return cadena.Count(c => vocales.Contains(c));
    }
}