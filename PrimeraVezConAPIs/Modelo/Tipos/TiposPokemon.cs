using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraVezConAPIs.Modelo.Tipos
{
    internal class TiposPokemon
    {
        [JsonProperty("slot")]
        public int espacio {  get; set; }

        [JsonProperty("type")]
        public DetalleTiposPokemon tipo { get; set; }
    }
}
