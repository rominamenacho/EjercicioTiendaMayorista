using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorTiendaMayorista.Modelo
{
    class Standard : Calidad
    {
        public Standard(string descripcion) : base(descripcion)
        {
            descripcion = "Standard";
        }
    }
}
