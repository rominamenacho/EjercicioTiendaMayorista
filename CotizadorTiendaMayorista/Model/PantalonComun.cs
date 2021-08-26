using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorTiendaMayorista.Modelo
{
    public class PantalonComun : Pantalon
    {
        public PantalonComun(string descripcion, bool calidadStandard, decimal precioUnitario, int cantidadStock) : base(descripcion,  calidadStandard, precioUnitario, cantidadStock)
        {

            this.Descripcion = descripcion;
        }
    }
}
