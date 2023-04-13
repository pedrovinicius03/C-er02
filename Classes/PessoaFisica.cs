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
            if(rendimentos <= 1500)
            {
                return 0;
            }
            
            else if ( rendimentos > 1500 && rendimentos <= 3500)
            {
                float resultado = (rendimentos / 100) * 3.5f;
                return resultado;
            }
            
            else if ( rendimentos > 3500 && rendimentos <= 6000)
            {
                float resultado = (rendimentos / 100) * 3.5f;
                return resultado;
            }
            else 
            {
                float resultado = (rendimentos / 100) *5;
                return resultado;
            }
            
            
            
            
            
            
            
            
            throw new NotImplementedException();
        }

        public bool validarDataNasc(DateTime dataNasc)
        {
            throw new NotImplementedException();
        }
    }
}