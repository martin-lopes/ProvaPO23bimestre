using System;

public class Medico : Funcionario
{
    private string crm;
    private double horaextra;
    private string especialidade;

    public string Crm { get { return crm; } set {  crm = value; } }

    public double Horaextra { get {  return horaextra; } set {  horaextra = value; } }

    public string Especialidade { get {  return especialidade; } set {  especialidade = value; } }

    public Medico() { }

    public Medico(string crm, double horaextra, string especialidade)
    {
        Crm = crm;
        Horaextra = horaextra;
        Especialidade = especialidade;
    }

    /*public double AuxilioPericulosidade(double salario)
    {
        double auxilio = 0.20;
        salario = salario + (salario * auxilio);
        return salario;
    }*/
}