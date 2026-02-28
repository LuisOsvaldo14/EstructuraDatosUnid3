using System.Linq;

var numsRepetidos = new int[] { 1, 2, 2, 3, 2, 4 }; 
int buscar = 2;
int conteo = numsRepetidos.Count(x => x == buscar);
Console.WriteLine($"El número {buscar} aparece {conteo} veces.");
