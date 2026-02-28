using System;

class Libro
{
    public string titulo;

    public void ImprimirTitulo()
    {
        Console.WriteLine($"Título del libro: {titulo}");
    }

    static void Main()
    {
        Libro miLibro = new Libro();
        miLibro.titulo = "Cien años de soledad";
        miLibro.ImprimirTitulo();
    }
}
