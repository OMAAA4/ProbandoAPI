using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraVezConAPIs.Modelo.Estadisticas
{
    internal class EstadisticasPokemon
    {
        [JsonProperty("base_stat")]
        public int baseInicio { get; set; }

        [JsonProperty("effort")]
        public int esfuerzo { get; set; }

        [JsonProperty("stat")]
        public DetalleEstadisticasPokemon estadistica { get; set; }
    }
}
