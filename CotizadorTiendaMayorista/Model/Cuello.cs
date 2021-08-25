using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorTiendaMayorista.Modelo
{
   public abstract class Cuello
    {
        private string descripcion;

        public string Descripcion { get => descripcion; set => descripcion = value; }

        protected Cuello(string descripcion)
        {
            this.Descripcion = descripcion;
        }
    }
}
