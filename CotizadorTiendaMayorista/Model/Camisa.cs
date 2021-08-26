using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorTiendaMayorista.Modelo
{
  public class Camisa:Prenda
    {
        private ParManga manga;
        private Cuello cuello;
       
        internal Cuello Cuello { get => cuello; set => cuello = value; }
        internal ParManga Manga { get => manga; set => manga = value; }

     
        public Camisa(bool mangaCorta, bool cuelloMao ,bool standard, decimal precioUnitario, int cantidadStock) 
            : base(standard, precioUnitario, cantidadStock)
        {
            if (mangaCorta)
            {
                this.Manga = new Corta("Manga corta");
            }
            else
            {
                this.Manga = new Larga("Manga larga");
            }

            if (cuelloMao)
            {
                this.Cuello = new Mao("Cuello Mao");
            }
            else
            {
                this.Cuello = new CuelloComun("Cuello común");
            }
        }

        public override decimal CalculatePrice()
        {
            decimal retorno = base.CalculatePrice();
            if (Manga is Corta ) {

                retorno = retorno - System.Math.Round(System.Convert.ToDecimal(retorno * 0.10M), 2);// rn1
               
                if (Cuello is Mao)
                {
                    retorno = retorno + System.Math.Round(System.Convert.ToDecimal(retorno * 0.03M), 2); ; //rn2
                }
                
            }
           

            return retorno;
        }
    }
    
}
