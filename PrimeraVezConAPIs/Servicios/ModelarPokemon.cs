using PrimeraVezConAPIs.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraVezConAPIs.Servicios
{
    internal static class ModelarPokemon
    {

        public static BaseModelado DatosPokemon(Pokemon p) => new BaseModelado
        {
            Nombre = p.Nombre,
            Tipos = p.Tipo?.Select(t => t.tipo.nombre).ToList() ?? [],
            Habilidades = p.Habilidades?.Select(h => h.habilidades?.nombre ?? "").ToList() ?? [],
            Pokedex = p.pokedex?.Select(p => p.juego?.nombre ?? "").ToList() ?? [],
        };

    }
}
