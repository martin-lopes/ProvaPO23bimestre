using System;

public class Funcionario
{
    private string nome;
    private string cpf;
    private string matricula;
    private DateTime datanasc;
    private string sexo;
    private double salario;

    public string Nome { set { nome = value; } get { return nome; } }

    public string Cpf { get { return cpf; } set { cpf = value; } }

    public string Matricula { get { return matricula; } set { matricula = value; } }

    public DateTime Datanasc { get { return datanasc; } set { datanasc = value; } }

    public string Sexo { get { return sexo; } set {  sexo = value; } }

    public double Salario { get {  return salario; } set {  salario = value; } }

    public Funcionario() { }

    public Funcionario(string nome, string cpf, string matricula, DateTime datanasc, string sexo, double salario)
    {
        Nome = nome;
        Cpf = cpf;
        Matricula = matricula;
        Datanasc = datanasc;
        Sexo = sexo;
        Salario = salario;
    }
}