using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorTiendaMayorista.Modelo
{
  abstract class Pantalon:Prenda
    {
        private string descripcion;

        

        protected Pantalon(string descripcion, Calidad calidad, decimal precioUnitario, int cantidadStock) : base(calidad, precioUnitario, cantidadStock)
        {
        }

        public string Descripcion { get => descripcion; set => descripcion = value; }

        
    }
}
