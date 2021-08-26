using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorTiendaMayorista.Modelo
{
  public class Cotizacion
    {
        private int idCotizacion;
        private DateTime fechaHora;
        private int idVendedor;
        private Prenda prenda;
        private int unidadesCotizadas;
        private decimal valorCotizacion;


        public int IdCotizacion { get => idCotizacion; }
        public DateTime FechaHora { get => fechaHora; }
        public int IdVendedor { get => idVendedor;  }
      
        public int UnidadesCotizadas { get => unidadesCotizadas; }
        public decimal ValorCotizacion { get => valorCotizacion; }
        public Prenda Prenda { get => prenda; set => prenda = value; }

        public Cotizacion(int idCotizacion, DateTime fechaHora, int idVendedor, Prenda prenda, int cantidadUnidadesCotizadas, decimal valorCotizacion)
        {
            this.idCotizacion = idCotizacion;
            this.fechaHora = fechaHora;
            this.idVendedor = idVendedor;
            this.unidadesCotizadas = cantidadUnidadesCotizadas;
            this.valorCotizacion = valorCotizacion;
           
            this.prenda = prenda;

           
        }

        public static Prenda MakeClothes(bool _pants, bool _short, bool _mao, bool _chupin, bool _qualityStandard, decimal _price, int _count)
        {
            if (_pants)
            {
               return MakePants(_chupin, _qualityStandard, _price, _count);
            }
            else
            {
              return  MakeShirt(_short, _mao, _qualityStandard, _price, _count);
            }
           
          
        }

        private static Prenda MakeShirt(bool _short, bool _mao, bool _qualityStandard, decimal _price, int _count)
        {
                      
            Prenda prendaTemp;
         
            return prendaTemp = new Camisa(_short , _mao , _qualityStandard, _price, _count);
        }

        private static Prenda MakePants(bool _chupin, bool _qualityStandard, decimal _price, int _count)
        {
           
            Prenda prendaTemp;

            if (_chupin)
            {
                return prendaTemp = new Chupin("Chupin", _qualityStandard, _price, _count);
            }
            else
            {
                return prendaTemp = new PantalonComun("Comun", _qualityStandard, _price, _count);
            }
        }

       

    }
}
