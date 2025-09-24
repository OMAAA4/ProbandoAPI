using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using PrimeraVezConAPIs.Modelo;
using PrimeraVezConAPIs.Properties;

namespace PrimeraVezConAPIs.Servicios
{
    internal class ObtenerPokemon
    {
        public async Task<Pokemon> DatosPokemon(string nombre)
        {
            using var Cliente = new HttpClient();
            var url = $"https://pokeapi.co/api/v2/pokemon/{nombre.ToLower()}";
            var respuesta = await Cliente.GetStringAsync(url);

            var pokemon = JsonConvert.DeserializeObject<Pokemon>(respuesta) ;
            return pokemon;
        }

        public static async Task<Image> DescargarImagen(string url)
        {
            if (url != "")
            {
                using var Cliente = new HttpClient();
                var bytes = await Cliente.GetByteArrayAsync(url);
                using var ms = new MemoryStream(bytes);
                return Image.FromStream(ms);
            }
            else
            {
                return Resources.no_image;
            }
        }
    }
}
