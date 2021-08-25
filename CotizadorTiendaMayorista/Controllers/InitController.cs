using CotizadorTiendaMayorista.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorTiendaMayorista.Controllers
{
  public  class InitController
    {
        private Tienda tienda;
        private Vendedor vendedor;

        public Tienda Tienda { get => tienda; set => tienda = value; }
        internal Vendedor Vendedor { get => vendedor; set => vendedor = value; }


        private string labelStock;
        public string LabelStock { get => labelStock; set => labelStock = value; }
       

      

        public InitController()
        {
           Vendedor = new Vendedor(356, "Juan ", "Topo ");
           Tienda= new Tienda("Falabella", "Avenida Siempreviva 742");


            Premium premium = new Premium("Premium");
            Standard standard = new Standard("Standard");

            Corta mangaCorta = new Corta("Manga corta");
            Larga mangaLarga = new Larga("Manga larga");

            Mao cuelloMao = new Mao("Cuello Mao");
            CuelloComun cuelloComun = new CuelloComun("Cuello común");

            Camisa camisaMCCMS = new Camisa(mangaCorta, cuelloMao, standard, 0, 100);
            Tienda.Prendas.Add(camisaMCCMS);
            Camisa camisaMCCMP = new Camisa(mangaCorta, cuelloMao, premium, 0, 100);
            Tienda.Prendas.Add(camisaMCCMP);
            Camisa camisaMCCCS = new Camisa(mangaCorta, cuelloComun, standard, 0, 150);
            Tienda.Prendas.Add(camisaMCCCS);
            Camisa camisaMCCCP = new Camisa(mangaCorta, cuelloComun, premium, 0, 150);
            Tienda.Prendas.Add(camisaMCCCP);


            Camisa camisaMLCMS = new Camisa(mangaLarga, cuelloMao, standard, 0, 75);
            Tienda.Prendas.Add(camisaMLCMS);
            Camisa camisaMLCMP = new Camisa(mangaLarga, cuelloMao, premium, 0, 75);
            Tienda.Prendas.Add(camisaMLCMP);
            Camisa camisaMLCCS = new Camisa(mangaLarga, cuelloComun, standard, 0, 175);
            Tienda.Prendas.Add(camisaMLCCS);
            Camisa camisaMLCCP = new Camisa(mangaLarga, cuelloComun, premium, 0, 175);
            Tienda.Prendas.Add(camisaMLCCP);


            Chupin prendaChupinStandard = new Chupin("Chupín Standard", standard,0,750);
            Tienda.Prendas.Add(prendaChupinStandard);
            Chupin prendaChupinPremium = new Chupin("Chupín Premium", premium, 0, 750);
            Tienda.Prendas.Add(prendaChupinPremium);

            Comun pantalonComunStandard = new Comun("Pantalon Común Standard", standard, 0, 250);
            Tienda.Prendas.Add(pantalonComunStandard);
            Comun pantalonComunPremium = new Comun("Pantalon Común Premium", premium, 0, 250);
            Tienda.Prendas.Add(pantalonComunPremium);


        }


        public string NombreTienda()
        {
            return Tienda.Nombre;
        }
        public string DireccionTienda()
        {
            return Tienda.Direccion;
        }
        public string VendedorId()
        {
            return Vendedor.IdVendedor.ToString();
        }
        public string VendedorNombreApellido()
        {
            return (Vendedor.Nombre + Vendedor.Apellido);
        }

        //se podria agregar una funcion que actualice el lbStock segun las prendas que se carguen

       
    }
}
