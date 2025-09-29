using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraVezConAPIs.Modelo.Sonido
{
    internal class SonidoPokemon
    {
        [JsonProperty("latest")]
        public string SonidoNuevo { get; set; }

        [JsonProperty("legacy")]
        public string SonidoAntiguo { get; set; }
    }
}
