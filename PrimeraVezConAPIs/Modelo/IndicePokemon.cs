using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PrimeraVezConAPIs.Modelo
{
    internal class IndicePokemon
    {
        [JsonPropertyName("game_index")]
        public int indice { get; set; }
        [JsonPropertyName("")]
        public string juego { get; set; }

    }
}
