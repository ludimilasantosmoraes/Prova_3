public class Administrador : Funcionario
{
    public string Funcao { get; set; }

    public Administrador()
    { }
    public Administrador(string funcao)
    {
        Funcao = funcao;
    }
    public double Acressimo()
    {
        double acressimo = (Salario * 17) / 100;
        double acressimo2 = acressimo + Salario + 250;
        return acressimo2;
    }

}