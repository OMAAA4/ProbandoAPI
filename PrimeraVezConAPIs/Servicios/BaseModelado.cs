using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimeraVezConAPIs.Modelo.Habilidades;
using PrimeraVezConAPIs.Modelo.IndicesEnJuegos;
using PrimeraVezConAPIs.Modelo.Tipos;

namespace PrimeraVezConAPIs.Servicios
{
    internal class BaseModelado
    {
        public string Nombre { get; set; }
        public List<TiposBase> Tipos { get; set; }
        public List<HabilidadBase> Habilidades { get; set; }
        public List<IndiceBase> Pokedex {  get; set; }
    }
}
