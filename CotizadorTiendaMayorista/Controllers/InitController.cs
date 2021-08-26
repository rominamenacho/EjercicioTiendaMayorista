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
        private string labelStock;

        public Tienda Tienda { get => tienda; set => tienda = value; }
        internal Vendedor Vendedor { get => vendedor; set => vendedor = value; }
        public string LabelStock { get => labelStock; set => labelStock = value; }
       
        public InitController()
        {
           Vendedor = new Vendedor(356, "Juan ", "Topo ");
           Tienda= new Tienda("Falabella", "Avenida Siempreviva 742");
           Vendedor.Tienda = Tienda;
           Tienda.Init = this; 

           

            Camisa camisaMCCMS = new Camisa(true, true, true, 0, 100);
            Tienda.Prendas.Add(camisaMCCMS);
            Camisa camisaMCCMP = new Camisa(true, true, false, 0, 100);
            Tienda.Prendas.Add(camisaMCCMP);
            Camisa camisaMCCCS = new Camisa(true, false, true, 0, 150);
            Tienda.Prendas.Add(camisaMCCCS);
            Camisa camisaMCCCP = new Camisa(true, false, false, 0, 150);
            Tienda.Prendas.Add(camisaMCCCP);


            Camisa camisaMLCMS = new Camisa(false, true, true, 0, 75);
            Tienda.Prendas.Add(camisaMLCMS);
            Camisa camisaMLCMP = new Camisa(false, true, false, 0, 75);
            Tienda.Prendas.Add(camisaMLCMP);
            Camisa camisaMLCCS = new Camisa(false, false, true, 0, 175);
            Tienda.Prendas.Add(camisaMLCCS);
            Camisa camisaMLCCP = new Camisa(false, false, false, 0, 175);
            Tienda.Prendas.Add(camisaMLCCP);


            Chupin prendaChupinStandard = new Chupin("Chupín Standard", true, 0,750);
            Tienda.Prendas.Add(prendaChupinStandard);
            Chupin prendaChupinPremium = new Chupin("Chupín Premium", false, 0, 750);
            Tienda.Prendas.Add(prendaChupinPremium);

            PantalonComun pantalonComunStandard = new PantalonComun("Pantalon Común", true, 0, 250);
            Tienda.Prendas.Add(pantalonComunStandard);
            PantalonComun pantalonComunPremium = new PantalonComun("Pantalon Común", false, 0, 250);
            Tienda.Prendas.Add(pantalonComunPremium);


        }


    }
}
