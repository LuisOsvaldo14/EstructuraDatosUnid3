using System;

class Persona
{
    public string nombre; 

    public void Saludar()
    { 
        Console.WriteLine($"Hola, soy {nombre}");
    }

    static void Main()
    {
        Persona p = new Persona();
        Console.Write("Ingresa tu nombre: ");
        p.nombre = "Rodorfo";
        p.Saludar();
    }
}