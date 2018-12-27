﻿using Bytebank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public FuncionarioAutenticavel(double salario, string cpf) : base(salario, cpf)
        {
        }

        public string Senha { get ; set; }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
