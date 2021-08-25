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

        protected Pantalon(string descripcion, Calidad calidad, decimal precioUnitario, int cantidadStock) : base(calidad, precioUnitario, cantidadStock)
        {
            this.Descripcion = descripcion;
        }

       

        
    }
}
