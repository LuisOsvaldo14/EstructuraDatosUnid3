using System;

class Perro
{
    public string raza;

    public void ImprimirRaza()
    {
        Console.WriteLine($"La raza del perro es: {raza}");
    }

    static void Main()
    {
        Perro miPerro = new Perro();

        miPerro.raza = "Frenchie";
        miPerro.ImprimirRaza();
    }
}