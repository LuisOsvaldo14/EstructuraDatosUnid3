using System;

class Conversor
{
    static void Main()
    {
        Console.Write("Grados Celsius: ");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine($"{c}°C equivalen a {ConvertirAFahrenheit(c)}°F");
    }

    static double ConvertirAFahrenheit(double celsius) => (celsius * 1.8) + 32;
}