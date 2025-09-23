using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PrimeraVezConAPIs.Modelo.IndicesEnJuegos
{
    internal class IndicePokemon
    {
        [JsonPropertyName("game_index")]
        public int indice { get; set; }

        [JsonPropertyName("version")]
        public DetalleIndicesPokemon juego { get; set; }

    }
}
