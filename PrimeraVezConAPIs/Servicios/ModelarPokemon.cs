using PrimeraVezConAPIs.Modelo;
using PrimeraVezConAPIs.Modelo.Habilidades;
using PrimeraVezConAPIs.Modelo.IndicesEnJuegos;
using PrimeraVezConAPIs.Modelo.Tipos;
using PrimeraVezConAPIs.Modelo.Estadisticas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraVezConAPIs.Servicios
{
    internal static class ModelarPokemon
    {
        public static async Task<BaseModelado> DatosPokemon(Pokemon p) => new BaseModelado
        {
            Nombre = p.Nombre,
            Tipos = p.Tipo?.Select(t => new TiposBase
            {
                Slot = t.espacio,
                Nombre = t.tipo?.nombre ?? "",
                Url = t.tipo?.url ?? ""
            }).ToList() ?? [],
            Habilidades = p.Habilidades?.Select(h => new HabilidadBase
            {
                Nombre = h.habilidades?.nombre ?? "",
                Url = h.habilidades?.url ?? "",
                Oculta = h.Oculta,
                Slot = h.espacio
            }).ToList() ?? [],
            Pokedex = p.pokedex?.Select(px => new IndiceBase
            {
                GameIndex = px.indice,
                VersionNombre = px.juego?.nombre ?? "",
                VersionUrl = px.juego?.url ?? ""
            }).ToList() ?? [],
            spriteFrontal = await ObtenerPokemon.DescargarImagen(p.sprites?.spriteFrontal ?? ""),
            spriteEspalda = await ObtenerPokemon.DescargarImagen(p.sprites?.spriteEspalda ?? ""),
            estadisticas = p.Estadisticas?.Select(e => new EstadisticaBase
            {
                nombre = e.estadistica?.nombre ?? "",
                baseInicio = e?.baseInicio ?? 0,
                esfuerzo = e?.esfuerzo ?? 0
            }).ToList() ?? [],
        };

    }
}
