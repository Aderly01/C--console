using System;

public class Profesor : Persona
{
    private string noEmpleado;
    private double sueldo;
    public Profesor()
    {
        //Console.WriteLine("constructor");
    }

    public string NoEmpleado { get => noEmpleado; set => noEmpleado = value; }
    public double Sueldo { get => sueldo; set => sueldo = value; }
}