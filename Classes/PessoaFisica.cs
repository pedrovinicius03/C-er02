using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using C__us13.Interface;

namespace C__us13.Classes
{
    public class PessoaFisica: Pessoa, IPessoaFisica
    {
        public string? cpf {get; set;}

        public DateTime dataNasc {get; set;}

        public override float CalcularImposto(float rendimentos)
        {
            throw new NotImplementedException();
        }

        public bool validarDataNasc(DateTime dataNasc)
        {
            throw new NotImplementedException();
        }
    }
}