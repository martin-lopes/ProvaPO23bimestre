using System;
using System.Collections.Generic;

public class FolhaDePagamento
{
    public List<FolhaDePagamento> FolhaDePagamentoList; 
    private string mes;
    public Funcionario f2;
    private double valoriprf;
    private double horaextrastrab;
    private static double pagamento;
    private double beneficios;

    public string Mes { get { return mes; } set { mes = value; } }
    public double Valoriprf { get {  return valoriprf; } set {  valoriprf = value; } }
    public double Horaextrastrab { get {  return horaextrastrab; } set {  horaextrastrab = value; } }
    public static double Pagamento { get { return pagamento; } set { pagamento = value; } }
    public double Beneficios { get { return beneficios; } set { beneficios = value; } }

    public double CalcPagamento(double pagamento, double salario)
    {
        salario = salario + beneficios;//teoria apenas
        return salario;
    }

    public double iprf(double salario, double valoriprf)
    {
        if (salario > 5000) { valoriprf = salario - (salario * 0.17); }  else { } return valoriprf;
    }

    public static double ValorGastoPag(string mes, List<FolhaDePagamento> FolhaDePagamentoList)
    {
        double valorgastopag = 0.0;
        return valorgastopag;
    }

    public double AuxilioPericulosidade(double salario)
    {
        double auxilio = 0.20;
        salario = salario + (salario * auxilio);
        return salario;
    }
    public double SalarioTransporte(double salario, double salariovale)
    {
        salariovale = salario + 150;
        return salariovale;
    }

    public double SalarioAlimentacao(double salario)
    {
        salario = salario + (salario * 0.15);
        return salario;
    }
}