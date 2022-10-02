using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Persona objPerson = new Persona();
        /* Console.WriteLine("ingresa un nombre:");
        var a = Console.ReadLine();
        Console.WriteLine("ingresa una edad:");
        var b = Console.ReadLine();
        Console.WriteLine("ingresa fecha de nacimiento ejmp 01-01-2000 :");
        var c = Console.ReadLine();
        int d = Int32.Parse(b);
        objPerson.crearPersona(a, d, c); */
        /* objPerson.crearPersona("Aderly", 25, "17-11-1995");

        Console.WriteLine($"Nombre: {objPerson.Nombre} \nEdad: {objPerson.Edad} \nFecha de naciemiento: {objPerson.FechaNac}");

        Console.WriteLine($"sobrecarga de metodo - {objPerson.crearPersona()}"); */

        Estudiante objEst = new Estudiante();
            objEst.Nombre = "Rumario D.";
            objEst.Edad = 18;
            objEst.Matricula = "20152500158";
            objEst.Grado = "Tercero";
            objEst.Grupo = "A";
            Console.WriteLine($"*****ESTUDIANTE*****\nNombre: {objEst.Nombre} \nEdad: {objEst.Edad} \nMatricula: {objEst.Matricula} \nGrado: {objEst.Grado} \nGrupo: {objEst.Grupo}");
        Console.WriteLine("-------------");
        Profesor objProf = new Profesor();
            objProf.crearPersona("Aderly P.",25,"11-17-1995");
            objProf.NoEmpleado = "0704199600128";
            objProf.Sueldo = 18400;
            Console.WriteLine($"*****PROFESOR*****\nNombre: {objProf.Nombre} \nEdad: {objProf.Edad} \nMatricula: {objProf.NoEmpleado} \nGrado: {objProf.Sueldo}");
        Console.ReadKey(true);
    }
}