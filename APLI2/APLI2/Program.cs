using System;

class AreaCirculo
{
    static void Main()
    {
        Console.Write("Introduce el radio del círculo: ");
        double r = double.Parse(Console.ReadLine());
        Console.WriteLine($"El área es: {CalcularArea(r):F2}");
    }

    static double CalcularArea(double radio) => Math.PI * Math.Pow(radio, 2);
}