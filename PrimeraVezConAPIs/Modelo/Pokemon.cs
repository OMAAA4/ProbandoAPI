using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraVezConAPIs.Modelo
{
    internal record class Pokemon
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string[] Habilidades { get; set; }
        public List<IndicePokemon> NumPokedex { get; set; }


    }
}
