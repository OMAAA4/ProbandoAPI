using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraVezConAPIs.Modelo.ListaGeneral
{
    internal class DetalleListaGeneral
    {
        [JsonProperty("name")]
        public string nombre { get; set; }
    }
}
