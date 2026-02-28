using System.Collections.Generic;

var ciudades = ("Santo Domingo", "Madrid", "París", "Tokio", "Roma");
var listaCiudades = new List<string> { ciudades.Item1, ciudades.Item2, ciudades.Item3, ciudades.Item4, ciudades.Item5 };
Console.WriteLine($"Primer ciudad de la lista: {listaCiudades[0]}");
