using System;

public class Administrativo : Funcionario
{
    private string funcao;

    public string Funcao { get { return funcao; } set { funcao = value; } }

    public Administrativo() { }

    public Administrativo(string funcao)
    {
        Funcao = funcao;
    }
}