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
                if (p is Pantalon && p.CantidadStock >= prenda.CantidadStock)
                {
                    init.LabelStock = p.CantidadStock.ToString();
                    ret = true;
                }
                else if (p is Camisa &&
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


    }
}
