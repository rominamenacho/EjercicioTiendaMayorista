using CotizadorTiendaMayorista.Controllers;
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
        InitController init;

        public string Nombre { get => nombre; }
        public string Direccion { get => direccion;  }
        internal List<Prenda> Prendas { get => prendas; set => prendas = value; }
        public InitController Init { get => init; set => init = value; }

        public Tienda(string nombre, string direccion)
        {
            this.nombre = nombre;
            this.direccion = direccion;
           
        }


        public bool CheckStock(List<Prenda> Prendas, Prenda prenda)
        {
            bool ret = false;

            List<Prenda> temp = Prendas.FindAll(x => ((x.GetType() == prenda.GetType())));


            foreach (Prenda p in temp)
            {
                if (p is Pantalon 
                    && StockEnough(p, prenda))
                {
                    init.LabelStock = p.CantidadStock.ToString();
                    ret = true;
                }
                else if (p is Camisa 
                        && Match(p, prenda)
                        && StockEnough(p, prenda))
                {
                    init.LabelStock = p.CantidadStock.ToString();
                    ret = true;
                }


            }
            return ret;
        }

        private bool Match(Prenda prendaLista, Prenda prendaCotizacion) {
            return (((Camisa)prendaLista).Cuello.GetType() == ((Camisa)prendaCotizacion).Cuello.GetType()
                && ((Camisa)prendaLista).Manga.GetType() == ((Camisa)prendaCotizacion).Manga.GetType());
        }
        private bool StockEnough(Prenda prendaLista, Prenda prendaCotizacion) {
            return prendaLista.CantidadStock >= prendaCotizacion.CantidadStock;
        }

    }
}
