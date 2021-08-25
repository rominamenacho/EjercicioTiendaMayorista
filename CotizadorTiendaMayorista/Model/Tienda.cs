using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorTiendaMayorista.Modelo
{
  public class Tienda
    {
        private string nombre;
        private string direccion;
        private List<Prenda> prendas = new List<Prenda>();

        public string Nombre { get => nombre; }
        public string Direccion { get => direccion;  }
        internal List<Prenda> Prendas { get => prendas; set => prendas = value; }

       
        public Tienda(string nombre, string direccion)
        {
            this.nombre = nombre;
            this.direccion = direccion;
           
        }

     
    }
}
