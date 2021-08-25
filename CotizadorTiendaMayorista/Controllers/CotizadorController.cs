using CotizadorTiendaMayorista.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorTiendaMayorista.Controllers
{
    public class CotizadorController
    {
       
        InitController init;

        private int idVendedor;
        private bool camisa, mangaCorta, cuelloMao, pantalon, chupin, calidadStandard, calidadPremium;
        private  int precio, cantidad;

      
        public CotizadorController(InitController i, bool rbCamisa, bool cbMangaCorta, bool cbCuelloMao, bool rbPantalon,
            bool cbChupin, bool rbCalidadStandard, bool rbCalidadPremium, string txtPrecio, string txtCant)
        {
            this.idVendedor = int.Parse(i.Vendedor.IdVendedor.ToString());
            this.camisa = rbCamisa;
            this.mangaCorta = cbMangaCorta;
            this.cuelloMao = cbCuelloMao;
            this.pantalon = rbPantalon;
            this.chupin = cbChupin;
            this.calidadStandard = rbCalidadStandard;
            this.calidadPremium = rbCalidadPremium;
            this.precio = int.Parse(txtPrecio);
            this.cantidad = int.Parse(txtCant);
            this.init = i;
           
        }
               
             


        public decimal CrearCotizacion() {

          decimal resultadoCotizacion =  
                init.Vendedor.CreateCotizacion(pantalon, mangaCorta, cuelloMao, chupin, calidadStandard, precio, cantidad);

           return resultadoCotizacion;

        }

       
        
    }
}
