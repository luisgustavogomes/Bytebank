using Bytebank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario
            {
                Nome = "Carlos",
                Cpf = "999.999.999-99",
                Salario = 2000
            };

            gerenciador.Registrar(carlos);

            Diretor roberta = new Diretor
            {
                Nome = "Roberta",
                Cpf = "999.999.999-99",
                Salario = 5000
            };

            gerenciador.Registrar(roberta);

            Console.WriteLine("Nome: " + carlos.Nome);
            Console.WriteLine("Bonificação: " + carlos.GetBonificacao());

            Console.WriteLine("Nome: " + roberta.Nome);
            Console.WriteLine("Bonificação: " + roberta.GetBonificacao());

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Total bonificação: " + gerenciador.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}
