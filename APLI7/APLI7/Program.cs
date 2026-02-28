using System;
using System.Linq;

class BuscarLista
{
    static void Main()
    {
        int[] numeros = { 10, 25, 30, 45, 50 };
        Console.WriteLine("Lista disponible: " + string.Join(", ", numeros));
        Console.Write("¿Qué número buscas?: ");
        int buscar = int.Parse(Console.ReadLine());

        if (Existe(buscar, numeros)) Console.WriteLine("¡Encontrado!");
        else Console.WriteLine("No está en la lista.");
    }

    static bool Existe(int n, int[] lista) => lista.Contains(n);
}
