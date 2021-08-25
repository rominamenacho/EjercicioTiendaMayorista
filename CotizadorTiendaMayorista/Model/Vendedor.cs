using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorTiendaMayorista.Modelo
{
   public class Vendedor
    {
        private int idVendedor;
        private string nombre;
        private string apellido;
        private Cotizacion cotizacionActual;
        private Tienda tienda;
        private  List<Cotizacion> historial= new List<Cotizacion>();
             


        public int IdVendedor { get => idVendedor; }
        public string Nombre { get => nombre;  }
        public string Apellido { get => apellido;  }
        internal Cotizacion CotizacionActual { get => cotizacionActual; set => cotizacionActual = value; }
        public Tienda Tienda { get => tienda; set => tienda = value; }
        public List<Cotizacion> Historial { get => historial; }

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

        public decimal CreateCotizacion(bool pantalon, bool mangaCorta, bool cuelloMao, bool chupin, bool calidadStandard, int precio, int cantidad)
        {
            DateTime now = DateTime.Now;
            Prenda temp = Cotizacion.MakeClothes(pantalon, mangaCorta, cuelloMao, chupin, calidadStandard, precio, cantidad);
            decimal val = Calculate(temp, cantidad);

            
            if (Tienda.CheckStock(Tienda.Prendas, temp))
            {
                CotizacionActual = new Cotizacion(CreateIdCotizacion(), now, IdVendedor, temp, cantidad, val);

                Historial.Add(CotizacionActual);
                
                return CotizacionActual.ValorCotizacion;
            }
            else
            {
                return -1;
            }
        }

    
        private static int CreateIdCotizacion()
        {
            Random idRandom = new Random();
            return idRandom.Next(1, 2147483647);
        }

        private static decimal Calculate(Prenda p, int _count)
        {
            return p.CalculatePrice() * _count;
        }

    }
}
