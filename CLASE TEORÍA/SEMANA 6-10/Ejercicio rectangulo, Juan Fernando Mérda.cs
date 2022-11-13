// See https://aka.ms/new-console-template for more information
using System.Runtime;

Console.WriteLine("Perimetro y Area de un Rectangulo");

int ancho, largo;
int area, perimetro;

Console.WriteLine("Ingrese un valor para el ancho del Rectangulo: ");
ancho = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese un valor para el largo del Rectangulo: ");
largo = Convert.ToInt32(Console.ReadLine());

area = ancho * largo;
perimetro = ancho + largo + ancho + largo;

Console.WriteLine("El perimetro es: " + perimetro);
Console.WriteLine("El area es: " + area);








