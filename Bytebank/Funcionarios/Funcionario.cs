using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank.Funcionarios
{
    public class Funcionario
    {   
        public static int TotalDeFuncionarios { get; private set; }
        
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario(double salario , string cpf)
        {
            Salario = salario;
            Cpf = cpf;
            TotalDeFuncionarios++;
        }
        
        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        }

        public virtual void AumentarSalario()
        {
            Salario *= 1.1;
        }

    }
}
