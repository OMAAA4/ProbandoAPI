using Newtonsoft.Json;
using PrimeraVezConAPIs.Modelo.Estadisticas;
using PrimeraVezConAPIs.Modelo.Habilidades;
using PrimeraVezConAPIs.Modelo.IndicesEnJuegos;
using PrimeraVezConAPIs.Modelo.Sprites;
using PrimeraVezConAPIs.Modelo.Tipos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraVezConAPIs.Modelo
{
    internal record class Pokemon
    {
        [JsonProperty("name")]
        public string Nombre { get; set; }

        [JsonProperty("types")]
        public List<TiposPokemon> Tipo { get; set; }

        [JsonProperty("abilities")]
        public List<HabilidadesPokemon> Habilidades { get; set; }

        [JsonProperty("game_indices")]
        public List<IndicePokemon> pokedex { get; set; }

        [JsonProperty("sprites")]
        public SpritesPokemon sprites { get; set; }

        [JsonProperty("stats")]
        public List<EstadisticasPokemon> Estadisticas { get; set; }

    }
}
