using Bytebank.Funcionarios;
using Bytebank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank
{
    class Program
    {
        public static void Main(string[] args)
        {
            Separador();
            //CalcularBonificacao();
            UsarSistemaInterno();
            Separador();

            Console.ReadLine();
        }

        public static void Separador()
        {
            Console.WriteLine("-------------------------------------------------");
        }

        public static void ExtratoFuncionario(Funcionario funcionario)
        {
            Console.WriteLine("Nome: " + funcionario.Nome +
                "\nSalário: " + funcionario.Salario +
                "\nBonificação: " + funcionario.GetBonificacao());
            Separador();
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Designer pedro = new Designer("999.999.999-99") { Nome = "Pedro" };
            gerenciador.Registrar(pedro);
            ExtratoFuncionario(pedro);

            Diretor roberta = new Diretor("999.999.999-99") { Nome = "Roberta" };
            gerenciador.Registrar(roberta);
            ExtratoFuncionario(roberta);

            Auxiliar igor = new Auxiliar("999.999.999-99") { Nome = "Igor" };
            gerenciador.Registrar(igor);
            ExtratoFuncionario(igor);

            GerenteDeConta camila = new GerenteDeConta("999.999.999-99") { Nome = "Camila" };
            gerenciador.Registrar(camila);
            ExtratoFuncionario(camila);

            Desenvolvedor luis = new Desenvolvedor("999.999.999-99") { Nome = "Luis" };
            gerenciador.Registrar(luis);
            ExtratoFuncionario(luis);

            Console.WriteLine("Total de bonificação do mês: " + gerenciador.GetTotalBonificacao());
        }

        public static void UsarSistemaInterno()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();


            Diretor roberta = new Diretor("999.999.999-99") { Nome = "Roberta", Senha = "123" };
            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(roberta, "abc");

            Separador();

            GerenteDeConta camila = new GerenteDeConta("999.999.999-99") { Nome = "Camila", Senha = "abc" };
            sistemaInterno.Logar(camila, "123");
            sistemaInterno.Logar(camila, "abc");

        }
    }
}
