using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraVezConAPIs.Modelo.Estadisticas
{
    internal class EstadisticaBase
    {
        public string nombre { set; get; }
        public int baseInicio { get; set; }
        public int esfuerzo { get; set; }
    }
}
