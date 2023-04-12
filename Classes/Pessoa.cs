using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace C__us13.Classes
{
    public abstract class Pessoa
    {
        public string? nome {get; set;}

        public float rendimentos {get; set;}

        public string? endereço {get; set;}

        public abstract float CalcularImposto (float rendimentos);

    }
}