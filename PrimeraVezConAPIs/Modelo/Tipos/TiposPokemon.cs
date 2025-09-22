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
        public int slot {  get; set; }

        [JsonProperty("type")]
        public List<DetalleTiposPokemon> tipo { get; set; }
    }
}
