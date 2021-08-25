using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorTiendaMayorista.Modelo
{
    class Camisa:Prenda
    {
        private ParManga manga;
        private Cuello cuello;
       
        internal Cuello Cuello { get => cuello; set => cuello = value; }
        internal ParManga Manga { get => manga; set => manga = value; }

     
        public Camisa(ParManga manga, Cuello cuello,Calidad calidad, decimal precioUnitario, int cantidadStock) 
            : base(calidad, precioUnitario, cantidadStock)
        {
            this.Manga = manga;
            this.Cuello = cuello;
        }

        public override decimal CalcularPrecio()
        {
            decimal retorno = base.CalcularPrecio();
            if (Manga is Corta ) {
                if(Cuello is Mao)
                {
                    retorno = retorno - System.Math.Round(System.Convert.ToDecimal(retorno * 0.10M), 2);// rn1

                    retorno = retorno + System.Math.Round(System.Convert.ToDecimal(retorno * 0.03M), 2); ; //rn2

                 
                }
                else
                {
                    retorno = retorno - System.Math.Round(System.Convert.ToDecimal(retorno * 0.10M), 2);// rn1


                }

            }
            else
            {
                if(Cuello is Mao)
                {
                    retorno = retorno + System.Math.Round(System.Convert.ToDecimal(retorno * 0.03M), 2); ; //rn2
                }
            }
           

            return retorno;
        }
    }
    
}
