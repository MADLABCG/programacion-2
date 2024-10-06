// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");


string[] jugadores =
{
    "Juan Perez",
    "Maria Altagracia",
    "Josefa Perez",
    "Mario Adames",
    "Ada Uribe"
};

ArrayList prueba = new ArrayList(jugadores);
prueba.RemoveAt(prueba.IndexOf("Juan Perez"));
foreach (var n in prueba)
{
    Console.WriteLine(n);
}
