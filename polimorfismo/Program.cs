using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Operacion objOp = new Operacion();
        Console.WriteLine($"5.2 x 9.1 = {objOp.multiplicacion(5.2, 9.1)}");

        Console.Write("Introduce el primer parametro: ");
        objOp.Parametro1 = Double.Parse(Console.ReadLine());
        Console.Write("Introduce el segundo parametro: ");
        objOp.Parametro2 = Double.Parse(Console.ReadLine());
        Console.WriteLine($"El resultado es: {objOp.multiplicacion()}");

        Console.ReadKey(true);
    }
}