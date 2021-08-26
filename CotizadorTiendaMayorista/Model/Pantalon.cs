using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorTiendaMayorista.Modelo
{
    public abstract class Pantalon:Prenda
    {
        private string descripcion;

         public string Descripcion { get => descripcion; set => descripcion = value; }

        protected Pantalon(string descripcion, bool standard, decimal precioUnitario, int cantidadStock) : base(standard, precioUnitario, cantidadStock)
        {
            this.Descripcion = descripcion;
        }

       

        
    }
}
