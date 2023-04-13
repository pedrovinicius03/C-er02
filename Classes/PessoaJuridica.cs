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
            if(rendimentos <= 3000)
            {
                return 0;
            }
            else if (rendimentos > 3000 && rendimentos <= 6000)
            {
                float resultado = (rendimentos / 100) *5;
            }
             else if ( rendimentos > 6000 && rendimentos <= 10000)
            {
                float resultado = (rendimentos / 100) * 7;
                return resultado;
            }
            else 
            {
                float resultado = (rendimentos / 100) *9;
                return resultado;
            }





            throw new NotImplementedException();
        }

        public bool validarCnpj(string cnpj)
        {
            throw new NotImplementedException();
        }
    }

}

// Para Rendimentos até 3000, 3%
// Para rendimentos entre 3000 e 6000, 5%
// Para rendimentos entre 6000 e 10000, 7%
// Para rendimentos acima de 10000, 9%