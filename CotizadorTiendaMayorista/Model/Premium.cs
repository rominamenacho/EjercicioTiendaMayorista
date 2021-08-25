using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorTiendaMayorista.Modelo
{
    public class Premium : Calidad
    {
        public Premium(string descripcion) : base(descripcion)
        {
            descripcion = "Premium";
        }
    }
}
