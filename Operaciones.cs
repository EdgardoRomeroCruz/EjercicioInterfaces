public class Operaciones : IOperaciones
{
    public double CalcularArea(double baseValue, double altura) => baseValue * altura / 2;

    public double CalcularLongitud(double radio) => 2 * 3.1416 * radio;

    public double CalcularVolumen(double largo, double ancho, double alto) => largo * ancho * alto;

    public double CalcularPerimetro(double lado) => 4 * lado;

    public double CalcularDiagonal(double lado1, double lado2) => Math.Sqrt(lado1 * lado1 + lado2 * lado2);

    public void Imprimir()
    {
        Console.WriteLine("Resultados de las operaciones:");
    }
}
