using System;
internal class Program
{
    private static void Main(string[] args)
    {
        int valor1 = 0, valor2 = 0, resultado;
        try{
            Console.Write("Numero 1:");
            valor1 = Int32.Parse(Console.ReadLine());
            Console.Write("Numero 2:");
            valor2 = Int32.Parse(Console.ReadLine());
            resultado = valor1 / valor2;
            Console.WriteLine(resultado);
        } catch (Exception ex){
            Console.WriteLine(ex.Message);
        }
        /* byte numeroChico = byte.MaxValue;
        try
        {
            checked{
                ++numeroChico;
            }
            Console.WriteLine(numeroChico);
        }
        catch (System.Exception ofex)
        {
            Console.WriteLine(ofex.Message);
        }finally{
            Console.WriteLine(numeroChico);
        } */

        /* int[] numeros = new int[3];
        for (int i = 0; i < 5; i++)
        {   
            try
            {
                numeros[i] = i * 3;
                Console.WriteLine(numeros[i]);
            }
            catch (IndexOutOfRangeException iore)
            {
                Console.WriteLine(iore.Message);
            }
        } */

        Console.WriteLine("FINAL");
        Console.ReadKey(true);

    }
}