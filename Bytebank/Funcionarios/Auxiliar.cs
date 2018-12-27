﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank.Funcionarios
{
    class Auxiliar : Funcionario
    {
        public Auxiliar( string cpf) : base(2000, cpf)
        {
        }

        public override void AumentarSalario()
        {
            Salario *= 1.01;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.2;
        }
    }
}
