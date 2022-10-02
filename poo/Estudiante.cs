using System;

public class Estudiante : Persona
{
    private string matricula;
    private string grado;
    private string grupo;

    public Estudiante()
    {
        //Console.WriteLine("constructor");
    }

    public string Matricula { get => matricula; set => matricula = value; }
    public string Grado { get => grado; set => grado = value; }
    public string Grupo { get => grupo; set => grupo = value; }
}