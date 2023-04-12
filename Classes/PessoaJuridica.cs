using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using C__us13.Interface;

namespace C__us13.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string? cnpj{get; set;}

        public string? razaoSocial {get; set;}

        public override float CalcularImposto(float rendimentos)
        {
            throw new NotImplementedException();
        }

        public bool validarCnpj(string cnpj)
        {
            throw new NotImplementedException();
        }
    }

}