using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorTiendaMayorista.Modelo
{
 public  abstract class Calidad
    {
        private string descripcion;

        protected Calidad(string descripcion)
        {
            this.descripcion = descripcion;
        }
    }
}
