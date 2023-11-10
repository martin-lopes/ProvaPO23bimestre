using System;

public class Administrativo : Funcionario
{
    private string funcao;
    private double salariovale;

    public string Funcao { get { return funcao; } set { funcao = value; } }

    public double Salariovale { get { return salariovale; } set { salariovale = value; } }

    public Administrativo() { }

    public Administrativo(string funcao)
    {
        Funcao = funcao;
    }

    /*public double SalarioTransporte(double salario, double salariovale)
    {
        salariovale = salario + 150;
        return salariovale;
    }

    public double SalarioAlimentacao(double salario)
    {
        salario = salario + (salario * 0.15);
        return salario;
    }*/
}