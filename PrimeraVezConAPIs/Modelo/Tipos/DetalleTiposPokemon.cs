using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PrimeraVezConAPIs.Modelo.Tipos
{
    internal class DetalleTiposPokemon
    {
        [JsonProperty("name")]
        public string nombre { get; set; }

        [JsonProperty("url")]
        public string urlType { get; set; }
    }
}
