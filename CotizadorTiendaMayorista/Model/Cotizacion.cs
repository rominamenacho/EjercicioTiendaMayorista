using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorTiendaMayorista.Modelo
{
  public  class Cotizacion
    {
        private int idCotizacion;
        private DateTime fechaHora;
        private int idVendedor;
        private Prenda prenda;
        private int cantidadUnidadesCotizadas;
        private decimal valorCotizacion;

        public int IdCotizacion { get => idCotizacion; }
        public DateTime FechaHora { get => fechaHora; }
        public int IdVendedor { get => idVendedor;  }
        public Prenda Prenda { get => prenda;}
        public int CantidadUnidadesCotizadas { get => cantidadUnidadesCotizadas; }
        public decimal ValorCotizacion { get => valorCotizacion; }

        public Cotizacion(int idCotizacion, DateTime fechaHora, int idVendedor, Prenda prenda, int cantidadUnidadesCotizadas, decimal valorCotizacion)
        {
            this.idCotizacion = idCotizacion;
            this.fechaHora = fechaHora;
            this.idVendedor = idVendedor;
            this.prenda = prenda;
            this.cantidadUnidadesCotizadas = cantidadUnidadesCotizadas;
            this.valorCotizacion = valorCotizacion;
        }

    //    public void ImprimirCotizacionEn(Impresora i) { }
    
    }
}
