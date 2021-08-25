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
        Random idRandom = new Random();
        Prenda prenda;
        InitController init;

        private int idVendedor;
        private bool camisa, mangaCorta, cuelloMao, pantalon, chupin, calidadStandard, calidadPremium;
        private  int precio, cantidad;
        private List<Cotizacion> historialC = new List<Cotizacion>() ;

        public List<Cotizacion> HistorialC { get => historialC; set => historialC = value; }

        public CotizadorController(InitController i, bool rbCamisa, bool cbMangaCorta, bool cbCuelloMao, bool rbPantalon,
            bool cbChupin, bool rbCalidadStandard, bool rbCalidadPremium, string txtPrecio, string txtCant)
        {
            this.idVendedor = int.Parse(i.VendedorId());
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


        private void CrearPrenda()
        {
      
            if (isPantalon())
            { 
                CrearPantalon();
            }
            else
            {
                CrearCamisa();
            }
        
           
        }

        private int CreateIdCotizacion() {           
            return idRandom.Next(1, 2147483647);        
        }

        private bool RecorrerStock(List<Prenda> listaStockTienda, Prenda prenda)
        {
           bool ret = false;
       
         List <Prenda> temp =listaStockTienda.FindAll(x => ( (x.GetType() == prenda.GetType())));



            foreach (Prenda p in temp)
            {
                if (p is Pantalon &&  p.CantidadStock >= prenda.CantidadStock)
                {
                    init.LabelStock = p.CantidadStock.ToString();
                    ret = true;
                }
                else  if (p is Camisa &&
                       ((Camisa)p).Cuello.GetType() == ((Camisa)prenda).Cuello.GetType()
                       && ((Camisa)p).Manga.GetType() == ((Camisa)prenda).Manga.GetType()
                       && p.CantidadStock >= prenda.CantidadStock)
                    {
                    init.LabelStock = p.CantidadStock.ToString();
                    ret = true;
                    }
                

            }
            return ret;
        }


        public decimal CrearCotizacion() {

           
            CrearPrenda();

           if( RecorrerStock(init.Tienda.Prendas, prenda) )
            {
                DateTime actual = DateTime.Now;
                decimal resultadoCotizacion = Calcular();
               
                Cotizacion nuevaCotizacion = new Cotizacion(CreateIdCotizacion(), actual, idVendedor, prenda, cantidad, resultadoCotizacion);
                historialC.Add(nuevaCotizacion);

                return resultadoCotizacion;
            }
            else
            {
                return -1;
            }
           
          
        }

        private decimal Calcular() {
          return  prenda.CalcularPrecio() * cantidad;
        }

        private void CrearCamisa() {
            Premium calidadP = new Premium("Premium");
            Standard calidadS = new Standard("Standard");
            Corta mangaC = new Corta("Manga Corta");
            Larga mangal = new Larga("Manga Larga");
            Mao cuelloMao = new Mao("Cuello Mao");
            CuelloComun cuelloComun = new CuelloComun("Cuello Común");

            if (isStandard() && isMangaCorta() && isCuelloMao()) {
                prenda = new Camisa(mangaC, cuelloMao, calidadS, precio, cantidad);
            }

            if (isStandard() && isMangaCorta() && !isCuelloMao())
            {
                prenda = new Camisa(mangaC, cuelloComun, calidadS, precio, cantidad);
            }

            if (isStandard() && !isMangaCorta() && isCuelloMao())
            {
                prenda = new Camisa(mangal, cuelloMao, calidadS, precio, cantidad);
            }
           
            if (isStandard() && !isMangaCorta() && !isCuelloMao())
            {
                prenda = new Camisa(mangal, cuelloComun, calidadS, precio, cantidad);
            }

            if (!isStandard() && isMangaCorta() && isCuelloMao())
            {
                prenda = new Camisa(mangaC, cuelloMao, calidadP, precio, cantidad);
            }

            if (!isStandard() && isMangaCorta() && !isCuelloMao())
            {
                prenda = new Camisa(mangaC, cuelloComun, calidadP, precio, cantidad);
            }

            if (!isStandard() && !isMangaCorta() && isCuelloMao())
            {
                prenda = new Camisa(mangal, cuelloMao, calidadP, precio, cantidad);
            }

            if (!isStandard() && !isMangaCorta() && !isCuelloMao())
            {
                prenda = new Camisa(mangal, cuelloComun, calidadP, precio, cantidad);
            }

        }

        private void CrearPantalon() {
            Premium calidadP = new Premium("Premium");
            Standard calidadS = new Standard("Standard");

            if (isStandard() &&  isPantalonChupin()) {             
              prenda = new Chupin("Chupin", calidadS, precio, cantidad);
            }
          
            if(isStandard() && !isPantalonChupin())
            {
                prenda = new Comun("Común", calidadS, precio, cantidad);
            }

            if(!isStandard() && isPantalonChupin()) {
                prenda = new Chupin("Chupin", calidadP, precio, cantidad);
            }

            if(!isStandard() && !isPantalonChupin())
            {
                prenda = new Comun("Común", calidadP, precio, cantidad);
            }
              //  prenda = new Chupin("Chupin", isStandard() ? calidadS : calidadP , precio, cantidad);
              //  prenda = new Comun("Comun", isStandard() ? calidadS : calidadP, precio, cantidad);
        }

        private bool isPantalonChupin()
        {
            return (pantalon && chupin);
        }

        private bool isStandard()
        {
            return calidadStandard;
        }

        private bool isPantalon()
        {
            return pantalon;
        }

        private bool isMangaCorta() {
            return mangaCorta;
        }

        private bool isCuelloMao()
        {
            return cuelloMao;
        }

        
    }
}
