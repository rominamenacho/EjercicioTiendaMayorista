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
      
        public int CantidadUnidadesCotizadas { get => cantidadUnidadesCotizadas; }
        public decimal ValorCotizacion { get => valorCotizacion; }
        public Prenda Prenda { get => prenda; set => prenda = value; }

        public Cotizacion(int idCotizacion, DateTime fechaHora, int idVendedor, Prenda prenda, int cantidadUnidadesCotizadas, decimal valorCotizacion)
        {
            this.idCotizacion = idCotizacion;
            this.fechaHora = fechaHora;
            this.idVendedor = idVendedor;
            this.prenda = prenda;
            this.cantidadUnidadesCotizadas = cantidadUnidadesCotizadas;
            this.valorCotizacion = valorCotizacion;
        }

        public static Prenda MakeClothes(bool _pants, bool _short, bool _mao, bool _chupin, bool _qualityStandard, decimal _price, int _count)
        {
            if (_pants)
            {
               return makePants(_chupin, _qualityStandard, _price, _count);
            }
            else
            {
              return  makeShirt(_short, _mao, _qualityStandard, _price, _count);
            }
           
          
        }

        private static Prenda makeShirt(bool _short, bool _mao, bool _qualityStandard, decimal _price, int _count)
        {
            Premium qualityP = new Premium("Premium");
            Standard qualityS = new Standard("Standard");
            Corta mangaC = new Corta("Manga Corta");
            Larga mangal = new Larga("Manga Larga");
            Mao cuelloMao = new Mao("Cuello Mao");
            CuelloComun cuelloComun = new CuelloComun("Cuello Común");
            Prenda prendaTemp;
         
            return prendaTemp = new Camisa(_short? (ParManga)mangaC: (ParManga)mangal, _mao? (Cuello)cuelloMao : (Cuello)cuelloComun , _qualityStandard ? (Calidad)qualityS : (Calidad)qualityP, _price, _count);
        }

        private static Prenda  makePants(bool _chupin, bool _qualityStandard, decimal _price, int _count)
        {
            Premium qualityP = new Premium("Premium");
            Standard qualityS = new Standard("Standard");
            Prenda prendaTemp;

            if (_chupin)
            {
                return prendaTemp = new Chupin("Chupin", _qualityStandard ? (Calidad)qualityS : (Calidad)qualityP, _price, _count);
            }
            else
            {
                return prendaTemp = new Comun("Comun", _qualityStandard ? (Calidad)qualityS : (Calidad)qualityP, _price, _count);
            }
        }

       

        //    public void ImprimirCotizacionEn(Impresora i) { }

    }
}
