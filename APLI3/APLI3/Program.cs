using System;

class VerificarPar
{
    static void Main()
    {
        Console.Write("Introduce un número: ");
        int num = int.Parse(Console.ReadLine());

        if (EsPar(num)) Console.WriteLine("El número es Par.");
        else Console.WriteLine("El número es Impar.");
    }

    static bool EsPar(int n) => n % 2 == 0;
}