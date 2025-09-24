using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraVezConAPIs.Modelo.Sprites
{
    internal class SpritesPokemon
    {
        [JsonProperty("front_default")]
        public string spriteFrontal {  get; set; }

        [JsonProperty("back_default")]
        public string spriteEspalda { get; set; }
    }
}
