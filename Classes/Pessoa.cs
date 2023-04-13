using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using C__us13.Interface;

namespace C__us13.Classes
{
    public abstract class Pessoa : IPessoa
    {
        public string? nome {get; set;}

        public float rendimentos {get; set;}

        public Endereco? endereço {get; set;}

        public abstract float CalcularImposto (float rendimentos);

    }
}