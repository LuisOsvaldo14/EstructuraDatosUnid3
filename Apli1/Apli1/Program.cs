using System;

class Suma
{
    static void Main()
    {
        Console.Write("Introduce el primer número: ");
        int n1 = int.Parse(Console.ReadLine());
        Console.Write("Introduce el segundo número: ");
        int n2 = int.Parse(Console.ReadLine());

        Console.WriteLine($"Resultado de la suma: {Sumar(n1, n2)}");
    }

    static int Sumar(int a, int b) => a + b;
}