using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using PrimeraVezConAPIs.Modelo;

namespace PrimeraVezConAPIs.Servicios
{
    internal class ObtenerPokemon
    {
        public async Task<Pokemon> GetPokemon(string nombre)
        {
            var Cliente = new HttpClient();
            var url = $"https://pokeapi.co/api/v2/pokemon/{nombre.ToLower()}";
            var respuesta = await Cliente.GetStringAsync(url);

            var pokemon = JsonConvert.DeserializeObject<Pokemon>(respuesta) ;
            return pokemon;
        }
    }
}
