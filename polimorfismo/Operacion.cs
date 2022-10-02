public class Operacion
{  
    private double resultado, parametro1, parametro2;

    public double Resultado { get => resultado; set => resultado = value; }
    public double Parametro1 { get => parametro1; set => parametro1 = value; }
    public double Parametro2 { get => parametro2; set => parametro2 = value; }

    public double multiplicacion(double valor1, double valor2){

        resultado = valor1 * valor2;
        return resultado;

    }

    public double multiplicacion(){
        this.Resultado = this.Parametro1 * this.Parametro2;
        return this.Resultado;
    }

}