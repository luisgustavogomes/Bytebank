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
        public static void Main(string[] args)
        {
            Separador();
            CalcularBonificacao();
            Separador();

            Console.ReadLine();
        }

        public static void Separador()
        {
            Console.WriteLine("-------------------------------------------------");
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
            Designer pedro = new Designer("999.999.999-99") { Nome = "Pedro" };
            gerenciador.Registrar(pedro);
            Diretor roberta = new Diretor("999.999.999-99") { Nome = "Roberta" };
            gerenciador.Registrar(roberta);
            Auxiliar igor = new Auxiliar("999.999.999-99") { Nome = "Igor" };
            gerenciador.Registrar(igor);
            GerenteDeConta camila = new GerenteDeConta("999.999.999-99") { Nome = "Camila" };
            gerenciador.Registrar(camila);

            Console.WriteLine("Total de bonificação do mês: " + gerenciador.GetTotalBonificacao());
        }
    }
}
