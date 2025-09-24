using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraVezConAPIs.Modelo.Habilidades
{
    internal class HabilidadBase
    {
        public string Nombre { get; set; }
        public string Url { get; set; }
        public bool Oculta { get; set; }
        public int Slot { get; set; }
    }
}
