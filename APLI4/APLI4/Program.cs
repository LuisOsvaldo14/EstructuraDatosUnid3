using System;

class NumeroMayor
{
    static void Main()
    {
        Console.Write("Primer número: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Segundo número: ");
        int y = int.Parse(Console.ReadLine());

        Console.WriteLine($"El mayor es: {ObtenerMayor(x, y)}");
    }

    static int ObtenerMayor(int a, int b) => (a > b) ? a : b;
}