using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraVezConAPIs.Modelo.Habilidades
{
    internal class HabilidadesPokemon
    {
        [JsonProperty("ability")]
        public DetalleHabilidadesPokemon habilidades {  get; set; }

        [JsonProperty("is_hidden")]
        public bool Oculta { get; set; }

        [JsonProperty("slot")]
        public  int espacio { get; set; }

    }
}
