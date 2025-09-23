using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraVezConAPIs.Servicios
{
    internal class BaseModelado
    {
        public string Nombre { get; set; }
        public List<string> Tipos { get; set; }
        public List<string> Habilidades { get; set; }

        public List<string> Pokedex {  get; set; }
    }
}
