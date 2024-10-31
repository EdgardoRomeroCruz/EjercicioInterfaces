// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

class Program
{
    static void Main(string[] args)
    {
        Operaciones operaciones = new Operaciones();

        Console.WriteLine("Ingrese la base y altura para calcular el área de un triangulo: ");
        double baseValor = double.Parse(Console.ReadLine());
        double altura = double.Parse(Console.ReadLine());
        Console.WriteLine("Área del triángulo: " + operaciones.CalcularArea(baseValor, altura));

        Console.WriteLine("Ingrese el radio para calcular la longitud de una circunferencia: ");
        double radio = double.Parse(Console.ReadLine());
        Console.WriteLine("Longitud de la circunferencia: " + operaciones.CalcularLongitud(radio));

        Console.WriteLine("Ingrese largo, ancho y alto para calcular el volumen de una pila:");
        double largo = double.Parse(Console.ReadLine());
        double ancho = double.Parse(Console.ReadLine());
        double alto = double.Parse(Console.ReadLine());
        Console.WriteLine("Volumen del prisma rectangular: " + operaciones.CalcularVolumen(largo, ancho, alto));

        Console.WriteLine("Ingrese el lado para calcular el perimetro de un cuadrado:");
        double lado = double.Parse(Console.ReadLine());
        Console.WriteLine("Perímetro del cuadrado: " + operaciones.CalcularPerimetro(lado));

        Console.WriteLine("Ingrese dos lados para calcular la diagonal de un rectangulo:");
        double lado1 = double.Parse(Console.ReadLine());
        double lado2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Diagonal del rectangulo: " + operaciones.CalcularDiagonal(lado1, lado2));

        operaciones.Imprimir();
    }
}
