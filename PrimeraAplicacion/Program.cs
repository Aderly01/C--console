// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        //codigo de prueba
        /* Console.WriteLine("What is your name?");
        var name = Console.ReadLine();
        var currentDate = DateTime.Now;
        Console.WriteLine($"\n Hello, {name}, on {currentDate:d} at {currentDate:t}!");
        Console.Write("\nPress any key to exit...");
        Console.ReadKey(true); */

        /* byte num = 255;
        Console.Write($"Un byte equivale a : {num}");
        Console.Read(); */

        //Sentencias de control if, else, switch
        /* int a = 15, b = 10, c = 9;

        if (a > b ){
            if (a > c){
            Console.WriteLine("A es mayor");
            } else {
            Console.WriteLine("C es mayor");
            }
        } else {
            if (b > c){
            Console.WriteLine("B es mayor");
            } else {
            Console.WriteLine("C es mayor");
            }
        } */

        /* int option = 6;
        switch ( option ){
            case 1:
                Console.WriteLine("Opcion 1");
                break;
            case 2:
                Console.WriteLine("Opcion 2");
                break;
            case 3:
                Console.WriteLine("Opcion 3");
                break;
            default :
                Console.WriteLine("Opcion invalida");
                break;
        } */

        //while, do while, for

        /* int numero = 1, limite = 10;
        while (numero <= limite)
        {
            if (numero % 2 == 0){
                Console.WriteLine($"{numero} Es par");
            } else {
                Console.WriteLine($"{numero} Es impar");
            }
            numero++;
        }
        Console.Read(); */

        /* int valor = 10;
        do {
            Console.WriteLine(valor);
            valor++;
        } while (valor <10 );
        Console.Read(); */
        
        /* Console.WriteLine("Introdusca el numero de la tabla que desea aprender: ");
        var input = Console.ReadLine();
        int  tabla = Int32.Parse(input);
        int limite= 10;
        for (int num = 1; num <= limite; num++){
            Console.WriteLine($"{tabla} x {num} = {tabla * num}");
        } */

        // Arreglos y matrices
        //int[] numeros = new int[10];
        /* int[] numeros = {4,8,7,2,1};
        int resultado = 0;
        for (int i = 0; i < numeros.Length; i++)
        {
            resultado += numeros[i];
        }
        Console.WriteLine(resultado); */

        //matrices
        /* int[,] numeros = new int[10,8];
        Random r = new Random();
        for (int x = 0; x < 10; x++)
        {
            for (int y = 0; y < 8; y++)
            {
                numeros[x,y] = r.Next(0,9);
                Console.Write(numeros[x,y] + "  ");
            }
            Console.WriteLine();
        }
            Console.Write("-----------------------\n");
        //suma de columnas
        int[] resultado = new int[10];
        for (int a = 0; a < 8; a++)
        {
            resultado[a] = 0;
            for (int b = 0; b < 10; b++)
            {
                resultado[a] += numeros[b, a];
            }
            //Console.Write("___");
            Console.Write(resultado[a] + " ");
        } */

        //entrada y salida de datos
        string archivo = "archivo.txt";

        // StreamWriter file = new StreamWriter(@archivo);
        // file.WriteLine("Esto es una linea de prueba");
        // file.WriteLine();
        // file.WriteLine("ultimo texto");
        // file.Close();
        
        // FileStream fs = new FileStream(archivo, FileMode.Append);
        // byte[] data = Encoding.Default.GetBytes("Este es un renglon editando el archivo");
        // fs.Write(data, 0, data.Length);
        // fs.Close();

        string contenido;
        FileStream fsSource = new FileStream(archivo, FileMode.Open, FileAccess.Read);
        using (StreamReader sr = new StreamReader(fsSource))
        {
            contenido = sr.ReadToEnd();
        }
        Console.WriteLine(contenido);
    }
}