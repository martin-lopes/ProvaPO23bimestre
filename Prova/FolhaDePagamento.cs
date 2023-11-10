using System;

public class FolhaDePagamento
{
    private string mes;
    public Funcionario f2;
    private double valoriprf;
    private double horaextrastrab;
    private double pagamento;

    public string Mes { get { return mes; } set { mes = value; } }
    public double Valoriprf { get {  return valoriprf; } set {  valoriprf = value; } }
    public double Horaextrastrab { get {  return horaextrastrab; } set {  horaextrastrab = value; } }
    public double Pagamento { get { return pagamento; } set { pagamento = value; } }

    /*public double CalcPagamento(double pagamento, double salario)
    {
        
    }*/
}