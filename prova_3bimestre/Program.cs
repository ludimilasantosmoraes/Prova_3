using System;

class Programa
{
    static void Main(string[] args)
    {
        List<Administrador> listaA = new List<Administrador>();
        List<Medico> listaM = new List<Medico>();

        while (true)
        {
            try
            {
                Funcionario f = new Funcionario();
                Medico m = new Medico();
                Administrador a = new Administrador();

                Console.WriteLine("Informe as seguintes informações para cadastrar funcionários:");
                Console.WriteLine("Nome:");
                f.Nome = Convert.ToString(Console.ReadLine());
                Console.WriteLine("CPF:");
                f.Cpf = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Matricula:");
                f.Matricula = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Data de Nascimento: yyyy,mm,dd");
                f.DataNascimento = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Sexo:");
                f.Sexo = Convert.ToString(Console.ReadLine());
                

                

                Console.WriteLine("Tipo de funcionário:\n1 - Médico\n2 - Administrador\n 0 - Sair do Cadastro ");
                int tipo = Convert.ToInt32(Console.ReadLine());
                if(tipo == 1)
                {
                    Console.WriteLine("Salário:");
                    m.Salario = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Informe o CRM:");
                    m.Crm = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Informe a especialidade:");
                    m.Especialidade = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Informe o valor da hora extra:");
                    m.HoraE = Convert.ToDouble(Console.ReadLine());
                    listaM.Add(m);                  
                  foreach(Medico med in listaM)
                    {
                        Console.WriteLine($"Nome: {med.Nome} Salário: R${med.Beneficio().ToString("00.00")} CPF:{med.Cpf} Data de Nascimento: {med.DataNascimento} Sexo: {med.Sexo} Especialidade: {med.Especialidade} CRM: {med.Crm} Valor Hora Extra: {med.HoraE}");     
                    }
                    
                }
                else if(tipo == 2)
                {
                    Console.WriteLine("Salário:");
                    a.Salario = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Informe a função do funcionário:");
                    a.Funcao = Convert.ToString(Console.ReadLine());
                    listaA.Add(a);
                    foreach(Administrador adm in listaA )
                    {
                        Console.WriteLine($"Nome: {adm.Nome} Salário: R${adm.Acressimo().ToString("00.00")} CPF: {adm.Cpf} Data de Nascimento: {adm.DataNascimento} Sexo: {adm.Sexo} Função: {adm.Funcao} Matricula:{adm.Matricula}");
                    }
                }
                if(tipo == 0)
                {
                    break;
                }

               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }   
        }
    }
}