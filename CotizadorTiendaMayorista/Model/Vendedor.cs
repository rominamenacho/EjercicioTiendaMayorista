using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorTiendaMayorista.Modelo
{
    class Vendedor
    {
        private int idVendedor;
        private string nombre;
        private string apellido;
        private Cotizacion cotizacionActual;

        public List<Cotizacion> historialCotizaciones;

        public int IdVendedor { get => idVendedor; }
        public string Nombre { get => nombre;  }
        public string Apellido { get => apellido;  }
        internal Cotizacion CotizacionActual { get => cotizacionActual; }
       // -----el set seria el add de la clase list----- internal List<Cotizacion> HistorialCotizaciones { set => historialCotizaciones = value; }

        
        public Vendedor(int idVendedor, string nombre, string apellido)
        {
            this.idVendedor = idVendedor;
            this.nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            this.apellido = apellido ?? throw new ArgumentNullException(nameof(apellido));
          
        }
        public Vendedor(int idVendedor, string nombre, string apellido, Cotizacion cotizacionActual)
        {
            this.idVendedor = idVendedor;
            this.nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            this.apellido = apellido ?? throw new ArgumentNullException(nameof(apellido));
            this.cotizacionActual = cotizacionActual ?? throw new ArgumentNullException(nameof(cotizacionActual));
        }

        public void ImprimirHistorial(List<Cotizacion>  _historialCotizaciones) {
        foreach( Cotizacion c in _historialCotizaciones)
            {
                
            }
        
        }

        public void RealizarCotizacion() { }
    }
}
