using System;

public class Persona
{
    private string nombre;
    private int edad;
    private string fechaNac;

    public Persona()
    {
        //Console.WriteLine("constructor");
    }

    public string Nombre { get => nombre; set => nombre = value; }
    public int Edad { get => edad; set => edad = value; }
    public string FechaNac { get => fechaNac; set => fechaNac = value; }

    public void crearPersona(string _nombre, int _edad, string _fechaNac){
        nombre = _nombre;
        edad = _edad;
        fechaNac = _fechaNac; 
    }

    /* public string crearPersona(){
        
        return $"Nombre: {nombre} Edad: {edad} Fecha nacimiento: {fechaNac}"; 
    } */

}