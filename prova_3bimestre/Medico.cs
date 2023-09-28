public class Medico : Funcionario
{
    public string Crm { get; set; }

    public double HoraE { get; set; }

    public string Especialidade { get; set; }

    public Medico()
    { }
   
    public Medico(string crm, double horaE, string especialidade)
    { 
        HoraE = horaE;
        Especialidade = especialidade;
        
    }

    public double Beneficio()
    {
        double beneficio = (Salario * 22) / 100;
        Salario = Salario + beneficio;
        return Salario;
    }
}
