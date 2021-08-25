using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorTiendaMayorista.Modelo
{
    class Comun : Pantalon
    {
        public Comun(string descripcion, Calidad calidad, decimal precioUnitario, int cantidadStock) : base(descripcion, calidad, precioUnitario, cantidadStock)
        {
        }
    }
}
